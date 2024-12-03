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

namespace Proyecto_Final___QR_Parking
{
    public partial class FRMRegistroSeguridad : Form
    {
        private static FRMRegistroSeguridad instancia;
        private TRegistroSeguridad tablaRegistroSeguridad = TRegistroSeguridad.getInstancia();
        
        public FRMRegistroSeguridad()
        {
            InitializeComponent();
        }

        public static FRMRegistroSeguridad getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FRMRegistroSeguridad();
            }
            return instancia;
        }

        private void bRegistrarseSignInSeg_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos tengan texto
            if (string.IsNullOrWhiteSpace(this.tbNombresSignInSeg.Text) ||
                string.IsNullOrWhiteSpace(this.tbApellidosSignInSeg.Text) ||
                string.IsNullOrWhiteSpace(this.mtbCedulaSignInSeg.Text) ||
                string.IsNullOrWhiteSpace(this.tbCorreoSignInSeg.Text) ||
                string.IsNullOrWhiteSpace(this.mtbContraSignInSeg.Text) ||
                string.IsNullOrWhiteSpace(this.mtbConfirmarContraSignInSeg.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Solamente correo UAM
            string correo = this.tbCorreoSignInSeg.Text;
            if (!correo.EndsWith("@uamv.edu.ni") && !correo.EndsWith("@uam.edu.ni"))
            {
                MessageBox.Show("El correo debe ser de la UAM (uamv.edu.ni o uam.edu.ni)", "Error de Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Las contraseñas tienen que coincidir
            string contrasena = this.mtbContraSignInSeg.Text;
            string confirmarContrasena = this.mtbConfirmarContraSignInSeg.Text;
            if (contrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // No debe de haber dos usuarios con el mismo correo
            if (!tablaRegistroSeguridad.verificarExistenciaSeguridad(this.tbCorreoSignInSeg.Text))
            {
                DialogResult resp = MessageBox.Show("¿Está seguro de guardar los datos?", "Registro de Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes) 
                {
                    RegistroSeguridad nuevoUsuarioSeguridad = new RegistroSeguridad()
                    {
                        Nombres = this.tbNombresSignInSeg.Text,
                        Apellidos = this.tbApellidosSignInSeg.Text,
                        Cedula = this.mtbCedulaSignInSeg.Text,
                        Correo = this.tbCorreoSignInSeg.Text,
                        Contrasena = this.mtbContraSignInSeg.Text,
                        ConfirmarContrasena = this.mtbConfirmarContraSignInSeg.Text,
                    };

                    tablaRegistroSeguridad.agregarRegistro(nuevoUsuarioSeguridad);


                    int success = tablaRegistroSeguridad.guardar();
                    if (success == 0)
                    {
                        MessageBox.Show("¡Error al guardar los datos!", "Registro de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("¡Los datos se guardaron exitosamente!", "Registro de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar campos
                        this.tbNombresSignInSeg.Text = "";
                        this.tbApellidosSignInSeg.Text = "";
                        this.mtbCedulaSignInSeg.Text = "";
                        this.tbCorreoSignInSeg.Text = "";
                        this.mtbContraSignInSeg.Text = "";
                        this.mtbConfirmarContraSignInSeg.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Ya existe un Usuario de Seguridad con el Correo indicado", "Registro de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bVolverSignInSeg_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void cbVerOcultarSignInSeg_CheckedChanged(object sender, EventArgs e)
        {
            mtbContraSignInSeg.PasswordChar = cbVerOcultarSignInSeg.Checked ? '\0' : '*';
            cbVerOcultarSignInSeg.Text = cbVerOcultarSignInSeg.Checked ? "Ocultar" : "Ver";
        }

        private void cbVerOcultarConfirmarSignInSeg_CheckedChanged(object sender, EventArgs e)
        {
            mtbConfirmarContraSignInSeg.PasswordChar = cbVerOcultarConfirmarSignInSeg.Checked ? '\0' : '*';
            cbVerOcultarConfirmarSignInSeg.Text = cbVerOcultarConfirmarSignInSeg.Checked ? "Ocultar" : "Ver";
        }

        private void FRMRegistroSeguridad_Load(object sender, EventArgs e)
        {
            mtbContraSignInSeg.PasswordChar = '*';
            mtbConfirmarContraSignInSeg.PasswordChar = '*';
        }
    }
}
