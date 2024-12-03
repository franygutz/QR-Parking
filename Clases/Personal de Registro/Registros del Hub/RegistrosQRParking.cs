using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final___QR_Parking.Clases.Personal_de_Registro.Registros_del_Hub
{
    internal class RegistrosQRParking
    {
        private string nombresQR;
        private string apellidosQR;
        private string tipoQR;
        private string cedulaQR;
        private string placaQR;
        private DateTime fecha;

        public string NombresQR { get => nombresQR; set => nombresQR = value; }
        public string ApellidosQR { get => apellidosQR; set => apellidosQR = value; }
        public string TipoQR { get => tipoQR; set => tipoQR = value; }
        public string CedulaQR 
        {
            get => cedulaQR;
            set
            {
                if (value.Length > 17) throw new ArgumentException("La Cédula debe tener exactamente 17 caracteres");
                cedulaQR = value;
            }
        }
        public string PlacaQR { get => placaQR; set => placaQR = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
