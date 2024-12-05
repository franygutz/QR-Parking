
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Admin;
using Proyecto_Final___QR_Parking.Clases.Tablas;
using Proyecto_Final___QR_Parking.Seguridad;
using Proyecto_Final___QR_Parking.PersonalReg;

namespace Proyecto_Final___QR_Parking
{
	public partial class FRMBienvenidos : Form
	{
		public FRMBienvenidos()
		{
			InitializeComponent();
		}

		private void FRMBienvenidos_Load(object sender, EventArgs e)
		{
			TablaPersonalSeguridad.GetInstancia().CargarPersonal();
		}

		private void tsmiSeguridadUamSignIn_Click(object sender, EventArgs e)
		{
			FRMRegistroSeguridad frmSeguridad = FRMRegistroSeguridad.GetInstancia();
			frmSeguridad.MdiParent = this;
			frmSeguridad.Show();
		}

		private void tsmiSeguridadUamLogIn_Click(object sender, EventArgs e)
		{
			FRMLogInSeguridad frmInicioSesionSeguridad = FRMLogInSeguridad.GetInstancia();
			frmInicioSesionSeguridad.MdiParent = this;
			frmInicioSesionSeguridad.Show();
		}

		private void tsmiPersonalRegistroSignIn_Click(object sender, EventArgs e)
		{
			FRMRegistroPersonalReg frmRegistroPersonal = FRMRegistroPersonalReg.GetInstancia();   
			frmRegistroPersonal.MdiParent = this;
			frmRegistroPersonal.Show();
		}

		private void tsmiPersonalRegistroLogI_Click(object sender, EventArgs e)
		{
			FRMLogInPersonalReg frmLogInPerReg = FRMLogInPersonalReg.GetInstancia();
			frmLogInPerReg.MdiParent = this;
			frmLogInPerReg.Show();
		}

		private void FRMBienvenidos_EscapeKeyClose(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				DialogResult result = MessageBox.Show(
					"¿Deseas cerrar la aplicación?",
					"Confirmación",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (result == DialogResult.Yes)
				{
					Close();
				}
			}
		}

		private void tsmiMenuAdmin_Click(object sender, EventArgs e)
		{
			FRMAdministrador frmAdmin = FRMAdministrador.getInstancia();
			frmAdmin.MdiParent = this;
			frmAdmin.Show();
		}
	}
}
