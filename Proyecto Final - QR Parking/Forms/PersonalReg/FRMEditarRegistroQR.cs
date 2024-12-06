
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;
using Proyecto_Final___QR_Parking.Clases.Tablas;
using Proyecto_Final___QR_Parking.Clases;


namespace Proyecto_Final___QR_Parking.PersonalReg
{
	public partial class FRMEditarRegistroQR : Form
	{
		private static FRMEditarRegistroQR instancia;
		private TablaRegistrosQR tabla_RQR = TablaRegistrosQR.GetInstancia();
		public event Action RegistroEditado;

		public FRMEditarRegistroQR(
			string nombres,
			string apellidos,
			string cedula,
			string placa,
			string tipo,
			string fecha
		) {

			InitializeComponent();

			this.tbNombresAg.Text = nombres;
			this.tbApellidosAg.Text = apellidos;
			this.mtbCedulaAg.Text = cedula;
			this.tbPlacaAg.Text = placa;
			this.cbTipoAg.Text = tipo;
			this.dtpFechaAg.Value = Convert.ToDateTime(fecha);
		}

		public static FRMEditarRegistroQR GetInstancia(
			string nombres,
			string apellidos,
			string cedula,
			string placa,
			string tipo,
			string fecha
		) {

			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMEditarRegistroQR(
					nombres,
					apellidos,
					cedula,
					placa,
					tipo,
					fecha
				);

			return instancia;
		}

		private void bVolverSignInPerReg_Click(object sender, EventArgs e)
		{
			// Esto no hace nada, no esta asociado a ningun boton
		}

		private void FRMEditarRegistroQR_Load(object sender, EventArgs e)
		{
			lQRCode.Visible = true;
			lQrGenerado.Visible = false;
			bExportar.Visible = false;
			pbCodigoQR.Visible = false;
		}

		private void bExportar_Click(object sender, EventArgs e)
		{
			if (pbCodigoQR.Image == null)
			{
				MessageBox.Show(
					"¡No hay ningún QR generado para exportar!",
					"Advertencia",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CodigosQR_Mostrados");

			try
			{
				if (!Directory.Exists(carpetaDestino))
					Directory.CreateDirectory(carpetaDestino);

				string nombreArchivo = $"QR_{tbPlacaAg.Text}_{DateTime.Now:ddMMyyyy_HHmm}.png";
				string rutaArchivo = Path.Combine(carpetaDestino, nombreArchivo);
				pbCodigoQR.Image.Save(rutaArchivo);

				MessageBox.Show(
					$"¡Código QR guardado exitosamente!\n\nUbicación:\n{rutaArchivo}",
					"Éxito",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}

			catch (Exception ex)
			{
				MessageBox.Show(
					$"¡Error al guardar QR!\n{ex.Message}",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void bGuardar_Click(object sender, EventArgs e)
		{
			// Validar que todos los campos tengan texto
			if (string.IsNullOrWhiteSpace(this.tbNombresAg.Text) ||
				string.IsNullOrWhiteSpace(this.tbApellidosAg.Text) ||
				string.IsNullOrWhiteSpace(this.cbTipoAg.Text) ||
				string.IsNullOrWhiteSpace(this.mtbCedulaAg.Text) ||
				string.IsNullOrWhiteSpace(this.tbPlacaAg.Text))
			{
				MessageBox.Show(
					"¡Todos los campos son obligatorios! Por favor, complete todos los campos.",
					"Error de Validación",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			// Confirmar edición
			DialogResult resp = MessageBox.Show(
				"¿Está seguro que desea guardar estos cambios?",
				"Edición de QR Parking",
				MessageBoxButtons.YesNo, 
				MessageBoxIcon.Question
			);

			if (resp == DialogResult.Yes)
			{
				// Crear un nuevo objeto con los datos actualizados
				RegistroQR registroEditado = new RegistroQR()
				{
					NombresQR = this.tbNombresAg.Text,
					ApellidosQR = this.tbApellidosAg.Text,
					TipoQR = this.cbTipoAg.Text,
					CedulaQR = this.mtbCedulaAg.Text,
					PlacaQR = this.tbPlacaAg.Text,
					Fecha = this.dtpFechaAg.Value,
				};

				// Llamar al método de edición
				bool resultado = tabla_RQR.EditarRegistro(registroEditado);
				if (!resultado)
				{
					MessageBox.Show(
						"¡Error al actualizar los datos! Por favor, verifique sus cambios.",
						"Edición de QR Parking",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
				
				MessageBox.Show(
					"¡Los datos se actualizaron exitosamente!",
					"Edición de QR Parking",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);

				// Generar nuevo QR
				string contenidoQR = $"Nombre: {this.tbNombresAg.Text} {this.tbApellidosAg.Text}\n";
				contenidoQR += $"Placa: {this.tbPlacaAg.Text}";

				BarcodeWriter escritorQR = new BarcodeWriter
				{
					Format = BarcodeFormat.QR_CODE,
					Options = new ZXing.Common.EncodingOptions
					{
						Width = 200,
						Height = 200,
						Margin = 1
					}
				};

				// Mostrar el QR actualizado
				Bitmap qrCodeImage = escritorQR.Write(contenidoQR);
				pbCodigoQR.Image = qrCodeImage;

				lQRCode.Visible = false;
				lQrGenerado.Visible= true;
				bExportar.Visible= true;
				pbCodigoQR.Visible= true;

				// Disparar evento para actualizar el DataGridView
				RegistroEditado?.Invoke();
			}
		}

        private void bVolverSignInPerReg_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FRMPerRegHub frmPerRegHub = FRMPerRegHub.GetInstancia();
            frmPerRegHub.Show();
        }
    }
}
