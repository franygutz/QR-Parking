using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final___QR_Parking.Clases.Personal_de_Registro.Registros_del_Hub
{
    internal class TRegistrosQRParking
    {
        private static TRegistrosQRParking instancia;
        private List<RegistrosQRParking> tabla;

        private TRegistrosQRParking()
        {
            tabla = new List<RegistrosQRParking>();
            cargar();
        }

        public static TRegistrosQRParking getInstancia()
        {
            if (instancia == null)
            {
                instancia = new TRegistrosQRParking();
            }
            return instancia;
        }

        public void agregarRegistroPlaca(RegistrosQRParking registro)
        {
            if (registro != null)
            {
                tabla.Add(registro);
            }
        }

        public bool verificarExistenciaQRParking(string placa)
        {
            foreach (RegistrosQRParking placaRegistrada in tabla)
            {
                if (placaRegistrada.PlacaQR.Equals(placa))
                    return true;
            }
            return false;
        }

        public int guardarRegistro()
        {
            try
            {
                string temporal = "Temp1.bin";
                string permanente = "RegistrosPlacas.bin";

                using (var stream = File.Open(temporal, FileMode.Create, FileAccess.Write))
                {
                    using (var write = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var registro in tabla)
                        {
                            write.Write(registro.NombresQR);
                            write.Write(registro.ApellidosQR);
                            write.Write(registro.TipoQR);
                            write.Write(registro.CedulaQR);
                            write.Write(registro.PlacaQR);
                            write.Write(registro.Fecha.ToString());
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
            string fileName = "RegistrosPlacas.bin";
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
                                RegistrosQRParking registro = new RegistrosQRParking();
                                registro.NombresQR = reader.ReadString();
                                registro.ApellidosQR= reader.ReadString();
                                registro.TipoQR= reader.ReadString();
                                registro.CedulaQR= reader.ReadString();
                                registro.PlacaQR= reader.ReadString();
                                registro.Fecha = DateTime.Parse(reader.ReadString());

                                this.agregarRegistroPlaca(registro);
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

        public List<RegistrosQRParking> getTabla()
        {
            return this.tabla;
        }


        public bool autenticarPlaca(string placa, out string idPlaca)
        {
            idPlaca = null;

            foreach (RegistrosQRParking registro in tabla)
            {
                if (registro.PlacaQR.Equals(placa))
                {
                    idPlaca= registro.CedulaQR;
                    return true;
                }
            }
            return false;
        }
    }
}
