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
using Proyecto_Final___QR_Parking.Personal_de_Registro;

namespace Proyecto_Final___QR_Parking
{
    public partial class FRMBienvenidos : Form
    {
        public FRMBienvenidos()
        {
            InitializeComponent();
        }

        private void tsmiSeguridadUamSignIn_Click(object sender, EventArgs e)
        {
            FRMRegistroSeguridad frmSeguridad = FRMRegistroSeguridad.getInstancia();
            frmSeguridad.MdiParent = this;
            frmSeguridad.Show();
        }

        private void FRMBienvenidos_Load(object sender, EventArgs e)
        {
            TRegistroSeguridad.getInstancia().cargar();
        }

        private void tsmiSeguridadUamLogIn_Click(object sender, EventArgs e)
        {
            FRMLogInSeguridad frmInicioSesionSeguridad = FRMLogInSeguridad.getInstancia();
            frmInicioSesionSeguridad.MdiParent = this;
            frmInicioSesionSeguridad.Show();
        }

        private void tsmiPersonalRegistroSignIn_Click(object sender, EventArgs e)
        {
            FRMRegistroPersonalRegistro frmRegistroPersonal = FRMRegistroPersonalRegistro.getInstancia();   
            frmRegistroPersonal.MdiParent = this;
            frmRegistroPersonal.Show();
        }

        private void tsmiPersonalRegistroLogI_Click(object sender, EventArgs e)
        {
            FRMLogInPersonalReg frmLogInPerReg = FRMLogInPersonalReg.getInstancia();
            frmLogInPerReg.MdiParent = this;
            frmLogInPerReg.Show();
        }
    }
}
