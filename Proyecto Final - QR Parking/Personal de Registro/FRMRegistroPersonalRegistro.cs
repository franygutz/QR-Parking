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
using Proyecto_Final___QR_Parking.Clases.Seguridad;

namespace Proyecto_Final___QR_Parking
{
    public partial class FRMRegistroPersonalRegistro : Form
    {
        private static FRMRegistroPersonalRegistro instancia;
        private TRegistroPersonalRegistro tablaRegistroPersonal = TRegistroPersonalRegistro.getInstancia();

        public FRMRegistroPersonalRegistro()
        {
            InitializeComponent();
        }

        public static FRMRegistroPersonalRegistro getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FRMRegistroPersonalRegistro();
            }
            return instancia;
        }

        private void bRegistrarseSignInPerReg_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos tengan texto
            if (string.IsNullOrWhiteSpace(this.tbNombresSignInPerReg.Text) ||
                string.IsNullOrWhiteSpace(this.tbApellidosSignInPerReg.Text) ||
                string.IsNullOrWhiteSpace(this.mtbCedulaSignInPerReg.Text) ||
                string.IsNullOrWhiteSpace(this.tbCorreoSignInPerReg.Text) ||
                string.IsNullOrWhiteSpace(this.mtbContraSignInPerReg.Text) ||
                string.IsNullOrWhiteSpace(this.mtbConfirmarContraSignInPerReg.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Solamente correo UAM
            string correo = this.tbCorreoSignInPerReg.Text;
            if (!correo.EndsWith("@uamv.edu.ni") && !correo.EndsWith("@uam.edu.ni"))
            {
                MessageBox.Show("El correo debe ser de la UAM (uamv.edu.ni o uam.edu.ni)", "Error de Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Las contraseñas tienen que coincidir
            string contrasena = this.mtbContraSignInPerReg.Text;
            string confirmarContrasena = this.mtbConfirmarContraSignInPerReg.Text;
            if (contrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // No debe de haber dos usuarios con el mismo correo
            if (!tablaRegistroPersonal.verificarExistenciaPersonal(this.tbCorreoSignInPerReg.Text))
            {
                DialogResult resp = MessageBox.Show("¿Está seguro de guardar los datos?", "Registro de Personal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    RegistroPersonalRegistro nuevoRegistroPersonal= new RegistroPersonalRegistro()
                    {
                        NombresRegistro = this.tbNombresSignInPerReg.Text,
                        ApellidosRegistro = this.tbApellidosSignInPerReg.Text,
                        CedulaRegistro = this.mtbCedulaSignInPerReg.Text,
                        CorreoRegistro = this.tbCorreoSignInPerReg.Text,
                        ContrasenaRegistro = this.mtbContraSignInPerReg.Text,
                        ConfirmarContrasenaRegistro = this.mtbConfirmarContraSignInPerReg.Text,
                    };

                    tablaRegistroPersonal.agregarRegistroPersonal(nuevoRegistroPersonal);

                    int success = tablaRegistroPersonal.guardarPersonal();
                    if (success == 0)
                    {
                        MessageBox.Show("¡Error al guardar los datos!", "Registro de Personal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("¡Los datos se guardaron exitosamente!", "Registro de Personal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar campos
                        this.tbNombresSignInPerReg.Text = "";
                        this.tbApellidosSignInPerReg.Text = "";
                        this.mtbCedulaSignInPerReg.Text = "";
                        this.tbCorreoSignInPerReg.Text = "";
                        this.mtbContraSignInPerReg.Text = "";
                        this.mtbConfirmarContraSignInPerReg.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Ya existe un Usuario de Seguridad con el Correo indicado", "Registro de Personal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bVolverSignInPerReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbVerOcultarSignInPerReg_CheckedChanged(object sender, EventArgs e)
        {
            mtbContraSignInPerReg.PasswordChar = cbVerOcultarSignInPerReg.Checked ? '\0' : '*';
            cbVerOcultarSignInPerReg.Text = cbVerOcultarSignInPerReg.Checked ? "Ocultar" : "Ver";
        }

        private void cbVerOcultarConfirmarSignInPerReg_CheckedChanged(object sender, EventArgs e)
        {
            mtbConfirmarContraSignInPerReg.PasswordChar = cbVerOcultarConfirmarSignInPerReg.Checked ? '\0' : '*';
            cbVerOcultarConfirmarSignInPerReg.Text = cbVerOcultarConfirmarSignInPerReg.Checked ? "Ocultar" : "Ver";
        }

        private void FRMRegistroPersonalRegistro_Load(object sender, EventArgs e)
        {
            mtbContraSignInPerReg.PasswordChar = '*';
            mtbConfirmarContraSignInPerReg.PasswordChar = '*';
        }
    }
}
