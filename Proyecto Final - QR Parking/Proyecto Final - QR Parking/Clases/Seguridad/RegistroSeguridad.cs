using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final___QR_Parking.Clases.Seguridad
{
    internal class RegistroSeguridad
    {
        private string nombres;
        private string apellidos;
        private string cedula;
        private string correo;
        private string contrasena;
        private string confirmarContrasena;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula
        {
            get => cedula;
            set
            {
                if (value.Length > 17) throw new ArgumentException("La Cédula debe tener exactamente 17 caracteres");
                cedula = value;
            }
        }
        public string Correo
        {
            get => correo;
            set
            {
                if (!validarCorreo(value)) throw new ArgumentException("El correo debe tener la extensión 'uamv.edu.ni' o 'uam.edu.ni'.");
                correo = value;
            }
        }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string ConfirmarContrasena 
        { 
            get => confirmarContrasena;
            set
            {
                if (value != contrasena) throw new ArgumentException("Las contraseñas no coinciden");
                confirmarContrasena = value;
            }
        }

        private bool validarCorreo (string correo)
        {
            return correo.EndsWith("@uamv.edu.ni") || correo.EndsWith("@uam.edu.ni");
        }
    }
}
