using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Personal_de_Registro;
using Proyecto_Final___QR_Parking.Clases.Personal_de_Registro.Registros_del_Hub;
//
using ZXing;

namespace Proyecto_Final___QR_Parking.Personal_de_Registro
{
    public partial class FRMAgregarRegistroQR : Form
    {
        private static FRMAgregarRegistroQR instancia;
        private TRegistrosQRParking tablaRegistroQR = TRegistrosQRParking.getInstancia();
        public event Action RegistroGuardado;

        public FRMAgregarRegistroQR()
        {
            InitializeComponent();
        }
        public static FRMAgregarRegistroQR getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FRMAgregarRegistroQR();
            }
            return instancia;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos tengan texto
            if (string.IsNullOrWhiteSpace(this.tbNombresAg.Text) ||
                string.IsNullOrWhiteSpace(this.tbApellidosAg.Text) ||
                string.IsNullOrWhiteSpace(this.cbTipoAg.Text) ||
                string.IsNullOrWhiteSpace(this.mtbCedulaAg.Text) ||
                string.IsNullOrWhiteSpace(this.tbPlacaAg.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que no sea una placa repetida
            if (!tablaRegistroQR.verificarExistenciaQRParking(this.tbPlacaAg.Text))
            {
                DialogResult resp = MessageBox.Show("¿Está seguro de guardar los datos?", "Registro de QR Parking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    RegistrosQRParking nuevoRegistroQR = new RegistrosQRParking()
                    {
                        NombresQR = this.tbNombresAg.Text,
                        ApellidosQR = this.tbApellidosAg.Text,
                        TipoQR = this.cbTipoAg.Text,
                        CedulaQR = this.mtbCedulaAg.Text,
                        PlacaQR = this.tbPlacaAg.Text,
                        Fecha = this.dtpFechaAg.Value,
                    };

                    tablaRegistroQR.agregarRegistroPlaca(nuevoRegistroQR);

                    int success = tablaRegistroQR.guardarRegistro();
                    if (success == 0)
                    {
                        MessageBox.Show("¡Error al guardar los datos!", "Registro de QR Parking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("¡Los datos se guardaron exitosamente!", "Registro de QR Parking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // se dispara porque si no, no se actuliza el dgv
                        RegistroGuardado?.Invoke();
                    }

                    // Generación de QR
                    string contenidoQR = $"Nombre: {this.tbNombresAg.Text} {this.tbApellidosAg.Text}\nCédula: {this.mtbCedulaAg.Text}\nPlaca: {this.tbPlacaAg.Text}";

                    BarcodeWriter escritorQR = new BarcodeWriter
                    {
                        Format = BarcodeFormat.QR_CODE,
                        Options = new ZXing.Common.EncodingOptions
                        {
                            Width = 200,  
                            Height = 200, 
                            Margin = 1    
                        }
                    };

                    // Mostrar QR en pictureBox
                    Bitmap qrCodeImage = escritorQR.Write(contenidoQR);
                    pbCodigoQR.Image = qrCodeImage;
                }
            }
            else
            {
                MessageBox.Show("Ya existe un Usuario con la Placa indicada", "Registro de QR Parking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bVolverSignInPerReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bExportar_Click(object sender, EventArgs e)
        {
            if(pbCodigoQR.Image == null)
            {
                MessageBox.Show("No hay ningún QR generado para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CodigosQR");

            try
            {
                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                string nombreArchivo = $"CodigoQR_{this.tbPlacaAg.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.png";

                string rutaArchivo = Path.Combine(carpetaDestino, nombreArchivo);

                pbCodigoQR.Image.Save(rutaArchivo);

                MessageBox.Show($"Código QR guardado exitosamente en:\n{rutaArchivo}",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Ocurrió un error al guardar el QR: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            this.tbNombresAg.Clear();
            this.tbApellidosAg.Clear();
            this.cbTipoAg.SelectedIndex = -1;
            this.mtbCedulaAg.Clear();
            this.tbPlacaAg.Clear();
            this.pbCodigoQR.Image = null;
        }
    }
}
