
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;
using Proyecto_Final___QR_Parking.Clases;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.PersonalReg
{
	public partial class FRMAgregarRegistroQR : Form
	{
		private static FRMAgregarRegistroQR instancia;
		private TablaRegistrosQR tabla_RQR = TablaRegistrosQR.GetInstancia();
		public event Action RegistroGuardado;

		public FRMAgregarRegistroQR()
		{
			InitializeComponent();
		}

		public static FRMAgregarRegistroQR GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMAgregarRegistroQR();

			return instancia;
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
				MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (tbPlacaAg.Text.Length < 4)
			{
				MessageBox.Show("La placa debe tener al menos 4 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (tbPlacaAg.Text.Length > 8)
			{
				MessageBox.Show("La placa debe tener como máximo 8 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Validar que no sea una placa repetida
			if (!tabla_RQR.VerificarExistenciaPlaca(this.tbPlacaAg.Text))
			{
				DialogResult resp = MessageBox.Show("¿Está seguro de guardar los datos?", "Registro de QR Parking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (resp == DialogResult.Yes)
				{
					RegistroQR nuevoRegistroQR = new RegistroQR()
					{
						NombresQR = this.tbNombresAg.Text,
						ApellidosQR = this.tbApellidosAg.Text,
						TipoQR = this.cbTipoAg.Text,
						CedulaQR = this.mtbCedulaAg.Text,
						PlacaQR = this.tbPlacaAg.Text,
						Fecha = this.dtpFechaAg.Value,
					};

					tabla_RQR.AgregarRegistroPlaca(nuevoRegistroQR);

					bool success = tabla_RQR.GuardarRegistros();
					if (success)
					{
						MessageBox.Show("¡Error al guardar los datos!", "Registro de QR Parking", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						MessageBox.Show("¡Los datos se guardaron exitosamente!", "Registro de QR Parking", MessageBoxButtons.OK, MessageBoxIcon.Information);
						// se dispara porque si no, no se actuliza el dgv
						RegistroGuardado?.Invoke();
					}

					// Generación de QR
					string contenidoQR = $"Nombre: {this.tbNombresAg.Text} {this.tbApellidosAg.Text}\nPlaca: {this.tbPlacaAg.Text}";

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

					// Mostrar QR en pictureBox
					Bitmap qrCodeImage = escritorQR.Write(contenidoQR);
					pbCodigoQR.Image = qrCodeImage;
				}
			}
			else
			{
				MessageBox.Show("Ya existe un Usuario con la Placa indicada", "Registro de QR Parking", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			lQrGenerado.Visible = true;
			pbCodigoQR.Visible = true;
			bExportar.Visible = true;
			lQRCode.Visible = false;

		}

		private void bVolverSignInPerReg_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bExportar_Click(object sender, EventArgs e)
		{
			if(pbCodigoQR.Image == null)
			{
				MessageBox.Show("No hay ningún QR generado para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CodigosQR");

			try
			{
				if (!Directory.Exists(carpetaDestino))
					Directory.CreateDirectory(carpetaDestino);

				string nombreArchivo = $"CodigoQR_{this.tbPlacaAg.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
				string rutaArchivo = Path.Combine(carpetaDestino, nombreArchivo);
				pbCodigoQR.Image.Save(rutaArchivo);

				MessageBox.Show(
					$"Código QR guardado exitosamente en:\n{rutaArchivo}",
					"Éxito",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}

			catch (Exception ex)
			{ 
				MessageBox.Show(
					$"Ocurrió un error al guardar el QR: {ex.Message}",
					"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
		}

		private void bLimpiar_Click(object sender, EventArgs e)
		{
			tbNombresAg.Clear();
			tbApellidosAg.Clear();
			cbTipoAg.SelectedIndex = -1;
			mtbCedulaAg.Clear();
			tbPlacaAg.Clear();
			pbCodigoQR.Image = null;
			lQrGenerado.Visible = false;
			pbCodigoQR.Visible = false;
			bExportar.Visible = false;
			lQRCode.Visible = true;
		}

		private void FRMAgregarRegistroQR_Load(object sender, EventArgs e)
		{
			dtpFechaAg.Value = DateTime.Now;
			lQrGenerado.Visible = false;
			pbCodigoQR.Visible = false;
			bExportar.Visible = false;
			lQRCode.Visible = true;
		}
	}
}
