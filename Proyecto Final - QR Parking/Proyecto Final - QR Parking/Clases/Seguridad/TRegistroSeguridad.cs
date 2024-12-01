using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final___QR_Parking.Clases.Seguridad
{
    internal class TRegistroSeguridad
    {
        private static TRegistroSeguridad instancia;
        private List<RegistroSeguridad> tabla;

        private TRegistroSeguridad()
        {
            tabla = new List<RegistroSeguridad>();
            cargar();
        }

        public static TRegistroSeguridad getInstancia()
        {
            if (instancia == null)
            {
                instancia = new TRegistroSeguridad();
            }
            return instancia;
        }

        public void agregarRegistro(RegistroSeguridad registro)
        {
            if (registro != null)
            {
                tabla.Add(registro);
            }
        }

        public bool verificarExistenciaSeguridad(string correo)
        {
            foreach (RegistroSeguridad seguridadRegistrada in tabla)
            {
                if (seguridadRegistrada.Correo.Equals(correo))
                    return true;
            }
            return false;
        }

        public int guardar()
        {
            try
            {
                string temporal = "Temp.bin";
                string permanente = "RegistrosSeguridad.bin";

                using (var stream = File.Open(temporal, FileMode.Create, FileAccess.Write))
                {
                    using (var write = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var registro in tabla)
                        {
                            write.Write(registro.Nombres);
                            write.Write(registro.Apellidos);
                            write.Write(registro.Cedula);
                            write.Write(registro.Correo);
                            write.Write(registro.Contrasena);
                        }
                    }

                    File.Delete(permanente);
                    File.Move(temporal, permanente);
                }
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al guardar: {e.Message}");
                return 0;
            }
        }

        public void cargar()
        {
            string fileName = "RegistrosSeguridad.bin";
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        try
                        {
                            while (stream.Position < stream.Length)
                            {
                                RegistroSeguridad registro = new RegistroSeguridad();
                                registro.Nombres = reader.ReadString();
                                registro.Apellidos = reader.ReadString();
                                registro.Cedula = reader.ReadString();
                                registro.Correo = reader.ReadString();
                                registro.Contrasena = reader.ReadString();

                                this.agregarRegistro(registro);
                            }
                        }
                        catch (EndOfStreamException)
                        {
                            MessageBox.Show("Se alcanzó el final del archivo antes de leer todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error al cargar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo de registros no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<RegistroSeguridad> getTabla()
        {
            return this.tabla;
        }

        public bool autenticarUsuario(string correo, string contrasena, out string idSeguridad)
        {
            idSeguridad = null;

            foreach (RegistroSeguridad registro in tabla)
            {
                if (registro.Correo.Equals(correo) && registro.Contrasena.Equals(contrasena))
                {
                    idSeguridad = registro.Cedula;
                    return true;
                }
            }
            return false;
        }

        public bool autenticarUsuarioRecuperarContrasena(string correo, out string idSeguridadCorreo)
        {
            idSeguridadCorreo = null;

            foreach (RegistroSeguridad registro in tabla)
            {
                if (registro.Correo.Equals(correo))
                {
                    idSeguridadCorreo = registro.Cedula;
                    return true;
                }
            }
            return false;
        }
    }
}
