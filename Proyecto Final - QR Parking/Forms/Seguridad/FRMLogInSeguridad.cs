
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.Seguridad
{
	public partial class FRMLogInSeguridad : Form
	{
		private static FRMLogInSeguridad instancia;
		private TablaPersonalSeguridad tabla_RSeguridad = TablaPersonalSeguridad.GetInstancia();

		public FRMLogInSeguridad()
		{
			InitializeComponent();
			AcceptButton = bIniciarSesionSeguridad; 
		}

		public static FRMLogInSeguridad GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMLogInSeguridad();

			return instancia;
		}

		private void linklRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FRMRegistroSeguridad frmSeguridad = FRMRegistroSeguridad.GetInstancia();
			frmSeguridad.Show();
			Close();
		}

		private void bIniciarSesionSeguridad_Click(object sender, EventArgs e)
		{
			string correo = tbCorreoLogInSeg.Text;
			string contra = mtbContraLogInSeg.Text;

			if (!tabla_RSeguridad.AutenticarUsuario(correo, contra))
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

			mtbContraLogInSeg.Clear();
			tbCorreoLogInSeg.Clear();
			FRMSeguridadHub hubSeguridad = FRMSeguridadHub.GetInstancia();
			hubSeguridad.Show();
			Close();
		}

		private void bVolverLogInSeg_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void linklRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FRMContraOlvidadaSeguridad frmContraOlvidad = FRMContraOlvidadaSeguridad.GetInstancia();
			frmContraOlvidad.Show();
			Close();
		}

		private void cbVerOcultarLogInSeg_CheckedChanged(object sender, EventArgs e)
		{
			mtbContraLogInSeg.PasswordChar = cbVerOcultarLogInSeg.Checked ? '\0' : '*';
			cbVerOcultarLogInSeg.Text = cbVerOcultarLogInSeg.Checked ? "Ocultar" : "Ver";
		}

		private void FRMLogInSeguridad_Load(object sender, EventArgs e)
		{
			mtbContraLogInSeg.PasswordChar = '*';
		}
	}
}
