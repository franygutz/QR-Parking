
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.PersonalReg;


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

        public static FRMAdministrador getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FRMAdministrador();
            
            return instancia;
        }

        private void bIniciarSesionPerReg_Click(object sender, EventArgs e)
        {
            if (tbCorreoAdmin.Text != "soyeladmin123@uam.edu.ni" || mtbContraAdmin.Text != "holamundoQR")
            {
                MessageBox.Show("Correo o contraseña incorrectos. Por favor, intente de nuevo.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (tbCorreoAdmin.Text == "soyeladmin123@uam.edu.ni" && mtbContraAdmin.Text == "holamundoQR")
            {
                FRMAdminHub adminHub = FRMAdminHub.getInstancia();
                adminHub.Show();
                this.Close();
            }
        }

        private void bVolverLogInPerReg_Click(object sender, EventArgs e)
        {
            this.Close();
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
