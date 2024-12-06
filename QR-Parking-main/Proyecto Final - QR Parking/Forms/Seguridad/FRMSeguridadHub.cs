
using System;
using System.Drawing;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;


namespace Proyecto_Final___QR_Parking.Seguridad
{
	public partial class FRMSeguridadHub : Form
	{
		private static FRMSeguridadHub instancia;
		private FilterInfoCollection camarasDisponibles;
		private VideoCaptureDevice camaraSeleccionada;

		public FRMSeguridadHub()
		{
			InitializeComponent();
		}

		public static FRMSeguridadHub GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMSeguridadHub();

			return instancia;
		}

		private void FRMSeguridadHub_Load(object sender, EventArgs e)
		{
			lCamara.Visible = false;
			pbCamara.Visible = false;
			bTerminar.Visible = false;
		}

		private void FRMSeguridadHub_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (camaraSeleccionada != null && camaraSeleccionada.IsRunning)
				camaraSeleccionada.Stop();
		}

		private void bEscanear_Click(object sender, EventArgs e)
		{
			try
			{
				camarasDisponibles = new FilterInfoCollection(FilterCategory.VideoInputDevice);

				if (camarasDisponibles.Count == 0)
				{
					MessageBox.Show(
						"¡No se detectaron cámaras disponibles!",
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);

					return;
				}

				camaraSeleccionada = new VideoCaptureDevice(camarasDisponibles[0].MonikerString);
				camaraSeleccionada.NewFrame += new NewFrameEventHandler(ActualizarPB);
				camaraSeleccionada.Start();

				lEscanea.Visible = false;
				lCamara.Visible = true;
				pbCamara.Visible = true;
				bTerminar.Visible = true;
			}

			catch (Exception ex)
			{
				MessageBox.Show(
					"Error al iniciar la cámara: " + ex.Message,
					"Error de Cámara",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void ActualizarPB(object sender, NewFrameEventArgs eventArgs)
		{
			// Mostrar el frame capturado en el PictureBox
			Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
			pbCamara.Image = frame;
		}

		private void bTerminar_Click(object sender, EventArgs e)
		{
			if (camaraSeleccionada != null && camaraSeleccionada.IsRunning)
				camaraSeleccionada.Stop();

			lCamara.Visible = false;
			pbCamara.Visible = false;
			lEscanea.Visible = true;
			bTerminar.Visible = false;
		}

		private void tsmiCerrarSesion_Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show(
				"¿Desea cerrar sesión?",
				"Cerrar Sesión",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (respuesta == DialogResult.Yes)
			{
				this.Close();
				FRMLogInSeguridad logInSegu = FRMLogInSeguridad.GetInstancia();
				logInSegu.Show();
			}
		}
	}
}
