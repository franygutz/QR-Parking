
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.PersonalReg
{
	public partial class FRMLogInPersonalReg : Form
	{
		private static FRMLogInPersonalReg instancia;
		private TablaPersonalRegistro tabla_RPersonalReg = TablaPersonalRegistro.GetInstancia();

		public FRMLogInPersonalReg()
		{
			InitializeComponent();
			AcceptButton = bIniciarSesionPerReg;
		}

		public static FRMLogInPersonalReg GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMLogInPersonalReg();

			return instancia;
		}

		private void linklRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FRMRegistroPersonalReg frmRegistro = FRMRegistroPersonalReg.GetInstancia();
			frmRegistro.Show();
			Close();
		}

		private void linklRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FRMContraOlvidadaPerReg frmContraOlvidadPerReg = FRMContraOlvidadaPerReg.GetInstancia();
			frmContraOlvidadPerReg.Show();
			Close();
		}

		private void bIniciarSesionPerReg_Click(object sender, EventArgs e)
		{
			string correo = tbCorreoLogInPerReg.Text;
			string contra = mtbContraLogInPerReg.Text;

			if (!tabla_RPersonalReg.AutenticarUsuario(correo, contra))
			{
				MessageBox.Show(
					"¡Correo o contraseña incorrect@!",
					"Error de Autenticación",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return;
			}
			
			MessageBox.Show(
				"¡Inicio de sesión exitoso!",
				"Éxito",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);

			mtbContraLogInPerReg.Clear();
			tbCorreoLogInPerReg.Clear();
			FRMPerRegHub frmPerRegHub = FRMPerRegHub.GetInstancia();
			frmPerRegHub.Show();
			Close();
		}

		private void bVolverLogInPerReg_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbVerOcultarLogInPerReg_CheckedChanged(object sender, EventArgs e)
		{
			mtbContraLogInPerReg.PasswordChar = cbVerOcultarLogInPerReg.Checked ? '\0' : '*';
			cbVerOcultarLogInPerReg.Text = cbVerOcultarLogInPerReg.Checked ? "Ocultar" : "Ver";
		}

		private void FRMLogInPersonalReg_Load(object sender, EventArgs e)
		{
			mtbContraLogInPerReg.PasswordChar = '*';
		}
	}
}
