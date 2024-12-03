using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final___QR_Parking.Clases.Seguridad;
using System.Windows.Forms;

namespace Proyecto_Final___QR_Parking.Clases.Personal_de_Registro
{
    internal class TRegistroPersonalRegistro
    {
        private static TRegistroPersonalRegistro instancia;
        private List<RegistroPersonalRegistro> tabla;

        private TRegistroPersonalRegistro()
        {
            tabla = new List<RegistroPersonalRegistro>();
            cargar();
        }

        public static TRegistroPersonalRegistro getInstancia()
        {
            if (instancia == null)
            {
                instancia = new TRegistroPersonalRegistro();
            }
            return instancia;
        }

        public void agregarRegistroPersonal(RegistroPersonalRegistro registro)
        {
            if (registro != null)
            {
                tabla.Add(registro);
            }
        }

        public bool verificarExistenciaPersonal(string correo)
        {
            foreach (RegistroPersonalRegistro personalRegistrado in tabla)
            {
                if (personalRegistrado.CorreoRegistro.Equals(correo))
                    return true;
            }
            return false;
        }

        public int guardarPersonal()
        {
            try
            {
                string temporal = "Temp1.bin";
                string permanente = "RegistrosPersonalRegistro.bin";

                using (var stream = File.Open(temporal, FileMode.Create, FileAccess.Write))
                {
                    using (var write = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var registro in tabla)
                        {
                            write.Write(registro.NombresRegistro);
                            write.Write(registro.ApellidosRegistro);
                            write.Write(registro.CedulaRegistro);
                            write.Write(registro.CorreoRegistro);
                            write.Write(registro.ContrasenaRegistro);
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
            string fileName = "RegistrosPersonalRegistro.bin";
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
                                RegistroPersonalRegistro registro = new RegistroPersonalRegistro();
                                registro.NombresRegistro = reader.ReadString();
                                registro.ApellidosRegistro = reader.ReadString();
                                registro.CedulaRegistro = reader.ReadString();
                                registro.CorreoRegistro = reader.ReadString();
                                registro.ContrasenaRegistro = reader.ReadString();

                                this.agregarRegistroPersonal(registro);
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

        public List<RegistroPersonalRegistro> getTabla()
        {
            return this.tabla;
        }

        public bool autenticarUsuarioRegistro(string correo, string contrasena, out string idPersonal)
        {
            idPersonal = null;

            foreach (RegistroPersonalRegistro registro in tabla)
            {
                if (registro.CorreoRegistro.Equals(correo) && registro.ContrasenaRegistro.Equals(contrasena))
                {
                    idPersonal = registro.CedulaRegistro;
                    return true;
                }
            }
            return false;
        }

        public bool autenticarUsuarioRecuperarContrasenaRegistro(string correo, out string idSeguridadCorreo)
        {
            idSeguridadCorreo = null;

            foreach (RegistroPersonalRegistro registro in tabla)
            {
                if (registro.CorreoRegistro.Equals(correo))
                {
                    idSeguridadCorreo = registro.CedulaRegistro;
                    return true;
                }
            }
            return false;
        }
    }
}
