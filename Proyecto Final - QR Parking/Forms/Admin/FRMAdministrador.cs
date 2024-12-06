
using System;
using System.Windows.Forms;


namespace Proyecto_Final___QR_Parking.Admin
{
	public partial class FRMAdministrador : Form
	{
		private static FRMAdministrador instancia;

		public FRMAdministrador()
		{
			InitializeComponent();
			this.AcceptButton = bIniciarSesionAdmin;
		}

		public static FRMAdministrador GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMAdministrador();
			
			return instancia;
		}

		private void bIniciarSesionPerReg_Click(object sender, EventArgs e)
		{
			if (tbCorreoAdmin.Text != "qrparking.uam@gmail.com" || mtbContraAdmin.Text != "holamundoQR123")
			{
				MessageBox.Show(
					"¡Correo o contraseña incorrect@!", 
					"Error de Inicio de Sesión", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Warning
				);
			}

			if (tbCorreoAdmin.Text == "qrparking.uam@gmail.com" && mtbContraAdmin.Text == "holamundoQR123")
			{
				FRMAdminHub adminHub = FRMAdminHub.GetInstancia();
				adminHub.Show();
				Close();
			}
		}

		private void bVolverLogInPerReg_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbVerOcultarLogInPerReg_CheckedChanged(object sender, EventArgs e)
		{
			mtbContraAdmin.PasswordChar = cbVerOcultarLogInAdmin.Checked ? '\0' : '*';
			cbVerOcultarLogInAdmin.Text = cbVerOcultarLogInAdmin.Checked ? "Ocultar" : "Ver";

		}

		private void FRMAdministrador_Load(object sender, EventArgs e)
		{
			mtbContraAdmin.PasswordChar = '*';
		}
	}
}
