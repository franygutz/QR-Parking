using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Seguridad;

namespace Proyecto_Final___QR_Parking
{
    public partial class FRMLogInSeguridad : Form
    {
        private static FRMLogInSeguridad instancia;
        private TRegistroSeguridad tablaRegistroSeguridad = TRegistroSeguridad.getInstancia();


        public FRMLogInSeguridad()
        {
            InitializeComponent();
        }

        public static FRMLogInSeguridad getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FRMLogInSeguridad();
            }
            return instancia;
        }

        private void linklRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMRegistroSeguridad frmSeguridad = FRMRegistroSeguridad.getInstancia();
            frmSeguridad.Show();
        }

        private void bIniciarSesionSeguridad_Click(object sender, EventArgs e)
        {
            string correoElec = this.tbCorreoLogInSeg.Text;
            string contra= this.mtbContraLogInSeg.Text;

            if (tablaRegistroSeguridad.autenticarUsuario(correoElec, contra, out string userId))
            {
                MessageBox.Show("Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbContraLogInSeg.Clear();
                tbCorreoLogInSeg.Clear();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bVolverLogInSeg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMContraOlvidadaSeguridad frmContraOlvidad = FRMContraOlvidadaSeguridad.getInstancia();
            frmContraOlvidad.Show();
        }

        private void cbVerOcultarLogInSeg_CheckedChanged(object sender, EventArgs e)
        {
            mtbContraLogInSeg.PasswordChar = cbVerOcultarLogInSeg.Checked ? '\0' : '*';
            mtbContraLogInSeg.Text = cbVerOcultarLogInSeg.Checked ? "Ocultar" : "Ver";
        }

        private void FRMLogInSeguridad_Load(object sender, EventArgs e)
        {
            mtbContraLogInSeg.PasswordChar = '*';
        }
    }
}
