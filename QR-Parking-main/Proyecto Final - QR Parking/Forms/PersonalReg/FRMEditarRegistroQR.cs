
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

			tbNombresAg.Text = nombres;
			tbApellidosAg.Text = apellidos;
			mtbCedulaAg.Text = cedula;
			tbPlacaAg.Text = placa;
			cbTipoAg.Text = tipo;
			dtpFechaAg.Value = Convert.ToDateTime(fecha);
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
			Close();
			FRMPerRegHub frmPerRegHub = FRMPerRegHub.GetInstancia();
			frmPerRegHub.Show();
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

				string nombreArchivo = $"QR_{tbPlacaAg.Text}.png";
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
			if (string.IsNullOrWhiteSpace(tbNombresAg.Text) ||
				string.IsNullOrWhiteSpace(tbApellidosAg.Text) ||
				string.IsNullOrWhiteSpace(cbTipoAg.Text) ||
				string.IsNullOrWhiteSpace(mtbCedulaAg.Text) ||
				string.IsNullOrWhiteSpace(tbPlacaAg.Text))
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
					NombresQR = tbNombresAg.Text,
					ApellidosQR = tbApellidosAg.Text,
					TipoQR = cbTipoAg.Text,
					CedulaQR = mtbCedulaAg.Text,
					PlacaQR = tbPlacaAg.Text,
					Fecha = dtpFechaAg.Value,
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

					return;
				}
				
				MessageBox.Show(
					"¡Los datos se actualizaron exitosamente!",
					"Edición de QR Parking",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);

				// Generar nuevo QR
				string contenidoQR = $"Nombre: {tbNombresAg.Text} {tbApellidosAg.Text}\n";
				contenidoQR += $"Placa: {tbPlacaAg.Text}";

				BarcodeWriter escritorQR = new BarcodeWriter
				{
					Format = BarcodeFormat.QR_CODE,
					Options = new ZXing.Common.EncodingOptions
					{
						Width = pbCodigoQR.Width,
						Height = pbCodigoQR.Height,
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
	}
}
