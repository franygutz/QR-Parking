
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

			if (tbPlacaAg.Text.Length < 4)
			{
				MessageBox.Show(
					"¡La placa debe tener al menos 4 caracteres!", 
					"Error de Validación", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Warning
				);

				return;
			}

			if (tbPlacaAg.Text.Length > 8)
			{
				MessageBox.Show(
					"¡La placa debe tener como máximo 8 caracteres.!", 
					"Error de Validación", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Warning
				);

				return;
			}

			// Validar si es una placa repetida
			if (tabla_RQR.VerificarExistenciaPlaca(tbPlacaAg.Text))
			{
				MessageBox.Show(
					"¡Ya existe un usuario con la placa indicada!", 
					"Registro de QR Parking", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error
				);
								
				return;
			}

			DialogResult resp = MessageBox.Show(
				"¿Está seguro que desea guardar estos datos?", 
				"Registro de QR Parking", 
				MessageBoxButtons.YesNo, 
				MessageBoxIcon.Question
			);

			if (resp == DialogResult.Yes)
			{
				RegistroQR nuevoRegistroQR = new RegistroQR()
				{
					NombresQR = tbNombresAg.Text,
					ApellidosQR = tbApellidosAg.Text,
					TipoQR = cbTipoAg.Text,
					CedulaQR = mtbCedulaAg.Text,
					PlacaQR = tbPlacaAg.Text,
					Fecha = dtpFechaAg.Value,
				};

				tabla_RQR.AgregarRegistroPlaca(nuevoRegistroQR);

				bool success = tabla_RQR.GuardarRegistros();
				if (!success)
				{
					MessageBox.Show(
						"¡Error al guardar los datos!", 
						"Registro de QR Parking", 
						MessageBoxButtons.OK, 
						MessageBoxIcon.Error
					);

					return;
				}

				MessageBox.Show(
					"¡Los datos se guardaron exitosamente!", 
					"Registro de QR Parking", 
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);

				// se invoka el evento para actualizar el dgv
				RegistroGuardado?.Invoke();

				// Generación de QR
				string contenidoQR = $"Nombre: {this.tbNombresAg.Text} {this.tbApellidosAg.Text}\nPlaca: {this.tbPlacaAg.Text}";

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

				// Mostrar QR en pictureBox
				Bitmap qrCodeImage = escritorQR.Write(contenidoQR);
				pbCodigoQR.Image = qrCodeImage;
				
				lQrGenerado.Visible = true;
				pbCodigoQR.Visible = true;
				bExportar.Visible = true;
				lQRCode.Visible = false;
			}
		}

		private void bVolverSignInPerReg_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bExportar_Click(object sender, EventArgs e)
		{
			if(pbCodigoQR.Image == null)
			{
				MessageBox.Show(
					"¡No hay ningún QR generado para exportar!",
					"Advertencia",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CodigosQR");

			try
			{
				if (!Directory.Exists(carpetaDestino))
					Directory.CreateDirectory(carpetaDestino);

				string nombreArchivo = $"CodigoQR_{this.tbPlacaAg.Text}.png";
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
