using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final___QR_Parking.Clases.Personal_de_Registro
{
    internal class RegistroPersonalRegistro
    {
        private string nombresRegistro;
        private string apellidosRegistro;
        private string cedulaRegistro;
        private string correoRegistro;
        private string contrasenaRegistro;
        private string confirmarContrasenaRegistro;

        public string NombresRegistro { get => nombresRegistro; set => nombresRegistro = value; }
        public string ApellidosRegistro { get => apellidosRegistro; set => apellidosRegistro = value; }
        public string CedulaRegistro
        {
            get => cedulaRegistro;
            set
            {
                if (value.Length > 17) throw new ArgumentException("La Cédula debe tener exactamente 17 caracteres");
                cedulaRegistro = value;
            }
        }
        public string CorreoRegistro
        {
            get => correoRegistro;
            set
            {
                if (!validarCorreoRegistro(value)) throw new ArgumentException("El correo debe tener la extensión 'uamv.edu.ni' o 'uam.edu.ni'.");
                correoRegistro = value;
            }
        }
        public string ContrasenaRegistro { get => contrasenaRegistro; set => contrasenaRegistro = value; }
        public string ConfirmarContrasenaRegistro
        {
            get => confirmarContrasenaRegistro;
            set
            {
                if (value != contrasenaRegistro) throw new ArgumentException("Las contraseñas no coinciden");
                confirmarContrasenaRegistro = value;
            }
        }

        private bool validarCorreoRegistro(string correo)
        {
            return correo.EndsWith("@uamv.edu.ni") || correo.EndsWith("@uam.edu.ni");
        }
    }
}
