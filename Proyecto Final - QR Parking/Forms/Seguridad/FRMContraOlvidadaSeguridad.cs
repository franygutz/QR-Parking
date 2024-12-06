
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.Seguridad
{
	public partial class FRMContraOlvidadaSeguridad : Form
	{
		private static FRMContraOlvidadaSeguridad instancia;
		private TablaPersonalSeguridad tabla_RSeguridad = TablaPersonalSeguridad.GetInstancia();
		
		public FRMContraOlvidadaSeguridad()
		{
			InitializeComponent();
		}

		public static FRMContraOlvidadaSeguridad GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMContraOlvidadaSeguridad();

			return instancia;
		}

		private void bIrGmail_Click(object sender, EventArgs e)
		{
			string url = "https://mail.google.com/mail/";
			System.Diagnostics.Process.Start(url);
		}

		private void bVolver_Click(object sender, EventArgs e)
		{
			Close();
			FRMLogInSeguridad frmInicioSesionSeguridad = FRMLogInSeguridad.GetInstancia();
			frmInicioSesionSeguridad.Show();
		}

		private void bAceptar_Click(object sender, EventArgs e)
		{
			string correoElec = tbUsuarioCO.Text;

			if (tabla_RSeguridad.VerificarExistenciaCorreo(correoElec))
			{
				MessageBox.Show(
					$"Se ha enviado un correo a {correoElec} con tu nueva contraseña.",
					"Recuperación de Contraseña",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);

				tbUsuarioCO.Clear();
			}

			else
			{
				MessageBox.Show(
					"¡No hay una cuenta de Seguridad registrada con el correo ingresado!",
					"Error de Correo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}
	}
}
