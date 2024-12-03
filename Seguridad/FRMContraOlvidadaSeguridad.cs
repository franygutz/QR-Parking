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
    public partial class FRMContraOlvidadaSeguridad : Form
    {
        private static FRMContraOlvidadaSeguridad instancia;
        private TRegistroSeguridad tablaContraOlvSeguridad = TRegistroSeguridad.getInstancia();

        
        public FRMContraOlvidadaSeguridad()
        {
            InitializeComponent();
        }

        public static FRMContraOlvidadaSeguridad getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FRMContraOlvidadaSeguridad();
            }
            return instancia;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string correoElec = this.tbUsuarioCO.Text;

            if (tablaContraOlvSeguridad.autenticarUsuarioRecuperarContrasena(correoElec, out string userId))
            {
                MessageBox.Show("Se ha enviado un email con tu nueva contraseña.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsuarioCO.Clear();
            }
            else
            {
                MessageBox.Show("Correo no encontrado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bIrGmail_Click(object sender, EventArgs e)
        {
            string url;
            url = "https://workspace.google.com/intl/es/gmail/";
            System.Diagnostics.Process.Start(url);
        }
    }
}
