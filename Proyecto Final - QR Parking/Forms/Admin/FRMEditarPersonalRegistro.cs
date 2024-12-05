using Proyecto_Final___QR_Parking.Admin;
using Proyecto_Final___QR_Parking.Clases;
using Proyecto_Final___QR_Parking.Clases.Tablas;
using Proyecto_Final___QR_Parking.PersonalReg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final___QR_Parking.Forms.Admin
{
    public partial class FRMEditarPersonalRegistro : Form
    {
        private static FRMEditarPersonalRegistro instancia;
        private TablaPersonalRegistro tablaPersonal = TablaPersonalRegistro.GetInstancia();
        public event Action PersonalEditado;

        public FRMEditarPersonalRegistro(string nombres, string apellidos, string cedula, string correo, string contra)
        {
            InitializeComponent();

            this.tbNombres.Text = nombres;
            this.tbApellidos.Text = apellidos;
            this.mtbCedula.Text = cedula;
            this.tbCorreo.Text = correo;
            this.tbContra.Text = contra;

        }

        public static FRMEditarPersonalRegistro GetInstancia(string nombres, string apellidos,
            string cedula, string correo, string contra)

        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FRMEditarPersonalRegistro(
                    nombres,
                    apellidos,
                    cedula,
                    correo,
                    contra
                );

            return instancia;
        }

        private void bVolverSignInPerReg_Click(object sender, EventArgs e)
        {
            this.Close();
            FRMAdminHub fRMAdminHub = new FRMAdminHub();
            fRMAdminHub.Show();
        }

        private void FRMEditarPersonalRegistro_Load(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.tbNombres.Text) ||
                string.IsNullOrWhiteSpace(this.tbApellidos.Text) ||
                string.IsNullOrWhiteSpace(this.mtbCedula.Text) ||
                string.IsNullOrWhiteSpace(this.tbCorreo.Text) ||
                string.IsNullOrWhiteSpace(this.tbContra.Text))
            {

                MessageBox.Show(
                    "¡Todos los campos son obligatorios! Por favor, complete todos los campos.",
                    "Error de Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Confirmar edición
            DialogResult resp = MessageBox.Show(
                "¿Está seguro que desea guardar estos cambios?",
                "Edición de QR Parking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resp == DialogResult.Yes)
            {
                // Crear un nuevo objeto con los datos actualizados
                Empleado empleadoEditado = new Empleado()
                {
                    Nombres = this.tbNombres.Text,
                    Apellidos = this.tbApellidos.Text,
                    Cedula = this.mtbCedula.Text,
                    Correo = this.tbCorreo.Text,
                    Contra = this.tbContra.Text,
                };

                // Llamar al método de edición
                bool resultado = tablaPersonal.EditarPersonal(empleadoEditado);
                if (!resultado)
                {
                    MessageBox.Show(
                        "¡Error al actualizar los datos! Por favor, verifique sus cambios.",
                        "Edición de QR Parking",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                MessageBox.Show(
                    "¡Los datos se actualizaron exitosamente!",
                    "Edición de QR Parking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }
    }
}
