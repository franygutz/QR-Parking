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
    }
}
