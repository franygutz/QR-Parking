
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;


namespace Proyecto_Final___QR_Parking.PersonalReg
{
	public partial class FRMMostrarRegistroQR : Form
	{
		private static FRMMostrarRegistroQR instancia;

		public FRMMostrarRegistroQR(
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

		public static FRMMostrarRegistroQR GetInstancia(
			string nombres,
			string apellidos,
			string cedula,
			string placa,
			string tipo,
			string fecha
		) {

			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMMostrarRegistroQR(
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

		private void FRMMostrarRegistroQR_Load(object sender, EventArgs e)
		{
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

			// Mostrar QR en pictureBox
			Bitmap qrCodeImage = escritorQR.Write(contenidoQR);
			pbCodigoQR.Image = qrCodeImage;
		}

		private void bExportar_Click(object sender, EventArgs e)
		{
			if (pbCodigoQR.Image == null)
			{
				MessageBox.Show(
					"No hay ningún QR generado para exportar.",
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
	}
}
