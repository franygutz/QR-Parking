
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.PersonalReg
{
	public partial class FRMContraOlvidadaPerReg : Form
	{
		private static FRMContraOlvidadaPerReg instancia;
		private TablaPersonalRegistro tabla_RPersonalReg = TablaPersonalRegistro.GetInstancia();

		public FRMContraOlvidadaPerReg()
		{
			InitializeComponent();
		}

		public static FRMContraOlvidadaPerReg GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMContraOlvidadaPerReg();

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
			FRMLogInPersonalReg frmInicioSesionPerReg = FRMLogInPersonalReg.GetInstancia();
			frmInicioSesionPerReg.Show();
		}

		private void bAceptar_Click(object sender, EventArgs e)
		{
			if (!tabla_RPersonalReg.VerificarExistenciaCorreo(tbUsuarioCO.Text))
			{
				MessageBox.Show(
					"¡Correo no encontrado!",
					"Error de Autenticación",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return;
			}

			MessageBox.Show(
				"Se ha enviado un email con su nueva contraseña.",
				"Éxito",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);

			tbUsuarioCO.Clear();
		}
	}
}
