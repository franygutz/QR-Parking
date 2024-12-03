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
using Proyecto_Final___QR_Parking.Clases.Personal_de_Registro.Registros_del_Hub;

namespace Proyecto_Final___QR_Parking.Personal_de_Registro
{
    public partial class FRMPerRegHub : Form
    {
        private static FRMPerRegHub instancia;
        
        public FRMPerRegHub()
        {
            InitializeComponent();
        }
        public static FRMPerRegHub getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FRMPerRegHub();
            }
            return instancia;
        }

        //no borrar porque se crashea
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRMPerRegHub_Load(object sender, EventArgs e)
        {
            this.dgvRegistros.DataSource = TRegistrosQRParking.getInstancia().getTabla();
        }

        private void tsmicerrarSesion_Click(object sender, EventArgs e)
        {
            FRMLogInPersonalReg frmLogIn = FRMLogInPersonalReg.getInstancia();
            frmLogIn.Show();
            this.Close();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            FRMAgregarRegistroQR agregarRegistro = FRMAgregarRegistroQR.getInstancia();

            agregarRegistro.RegistroGuardado += () =>
            {
                this.dgvRegistros.DataSource = null;
                this.dgvRegistros.DataSource = TRegistrosQRParking.getInstancia().getTabla();
            };

            agregarRegistro.Show();
        }
    }
}
