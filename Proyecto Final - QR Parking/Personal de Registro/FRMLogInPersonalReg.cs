using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Personal_de_Registro;
using Proyecto_Final___QR_Parking.Clases.Seguridad;

namespace Proyecto_Final___QR_Parking.Personal_de_Registro
{
    public partial class FRMLogInPersonalReg : Form
    {
        private static FRMLogInPersonalReg instancia;
        private TRegistroPersonalRegistro tablaRegistroPersonal= TRegistroPersonalRegistro.getInstancia();

        public FRMLogInPersonalReg()
        {
            InitializeComponent();
        }

        public static FRMLogInPersonalReg getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FRMLogInPersonalReg();
            }
            return instancia;
        }

        private void linklRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMRegistroPersonalRegistro frmRegistro = FRMRegistroPersonalRegistro.getInstancia();
            frmRegistro.Show();
        }

        private void linklRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMContraOlvidadaPerReg frmContraOlvidadPerReg = FRMContraOlvidadaPerReg.getInstancia();
            frmContraOlvidadPerReg.Show();
        }

        private void bIniciarSesionPerReg_Click(object sender, EventArgs e)
        {
            string correoElec = this.tbCorreoLogInPerReg.Text;
            string contra = this.mtbContraLogInPerReg.Text;

            if (tablaRegistroPersonal.autenticarUsuarioRegistro(correoElec, contra, out string userId))
            {
                MessageBox.Show("Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbContraLogInPerReg.Clear();
                tbCorreoLogInPerReg.Clear();
                FRMPerRegHub frmPerRegHub = FRMPerRegHub.getInstancia();
                frmPerRegHub.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bVolverLogInPerReg_Click(object sender, EventArgs e)
        {
            this.Close();
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
