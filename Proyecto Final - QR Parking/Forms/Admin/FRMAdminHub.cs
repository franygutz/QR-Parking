
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

        public static FRMAdminHub getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FRMAdminHub();

            return instancia;
        }

        private void FRMAdminHub_Load(object sender, EventArgs e)
        {
            this.dgvPersonalRegistro.DataSource = TablaPersonalRegistro.GetInstancia().GetTabla();
            this.dgvSeguridad.DataSource = TablaPersonalSeguridad.GetInstancia().GetTabla();
        }

        private void tsmicerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                FRMAdministrador inicioSesionAdmin = FRMAdministrador.getInstancia();
                inicioSesionAdmin.Show();
            }
            else return;
        }
    }
}
