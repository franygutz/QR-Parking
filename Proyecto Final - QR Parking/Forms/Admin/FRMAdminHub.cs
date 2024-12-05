
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.Admin
{
	public partial class FRMAdminHub : Form
	{
		private static FRMAdminHub instancia;

		public FRMAdminHub()
		{
			InitializeComponent();
		}

		public static FRMAdminHub GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMAdminHub();

			return instancia;
		}

		private void FRMAdminHub_Load(object sender, EventArgs e)
		{
			dgvPersonalRegistro.DataSource = TablaPersonalRegistro.GetInstancia().GetTabla();
			dgvSeguridad.DataSource = TablaPersonalSeguridad.GetInstancia().GetTabla();
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
				Close();
				FRMAdministrador inicioSesionAdmin = FRMAdministrador.GetInstancia();
				inicioSesionAdmin.Show();
			}
		}
	}
}
