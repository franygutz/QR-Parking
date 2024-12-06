
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Tablas;
using Proyecto_Final___QR_Parking.Forms.Admin;
using Proyecto_Final___QR_Parking.PersonalReg;


namespace Proyecto_Final___QR_Parking.Admin
{
    public partial class FRMAdminHub : Form
    {
        private static FRMAdminHub instancia;

        public FRMAdminHub()
        {
            InitializeComponent();
        }

        public static FRMAdminHub getInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new FRMAdminHub();

            return instancia;
        }

        private void FRMAdminHub_Load(object sender, EventArgs e)
        {
            this.dgvPersonalRegistro.DataSource = TablaPersonalRegistro.GetInstancia().GetTabla();
            this.dgvSeguridad.DataSource = TablaPersonalSeguridad.GetInstancia().GetTabla();
        }

        private void tsmicerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                FRMAdministrador inicioSesionAdmin = FRMAdministrador.getInstancia();
                inicioSesionAdmin.Show();
            }
            else return;
        }

        private void dgvPersonalRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Desactiva el dgv para evitar interactuar con el DataGridView mientras se actualiza
                dgvPersonalRegistro.Enabled = false;

                // Validar que se haya hecho clic en una celda válida
                if (e.RowIndex < 0 || e.RowIndex >= dgvPersonalRegistro.Rows.Count)
                    return;

                DataGridViewRow filaSeleccionada = dgvPersonalRegistro.Rows[e.RowIndex];

                string nombres = filaSeleccionada.Cells["Nombres"]?.Value?.ToString() ?? "Sin nombres";
                string apellidos = filaSeleccionada.Cells["Apellidos"]?.Value?.ToString() ?? "Sin apellidos";
                string cedula = filaSeleccionada.Cells["Cedula"]?.Value?.ToString() ?? "Sin cédula";
                string correo = filaSeleccionada.Cells["Correo"]?.Value?.ToString() ?? "Sin correo";
                string contra = filaSeleccionada.Cells["Contra"]?.Value?.ToString() ?? "Sin contra";

                //if (e.ColumnIndex == dgvPersonalRegistro.Columns["Ver"].Index)
                //{
                    
                //}

                if (e.ColumnIndex == dgvPersonalRegistro.Columns["Editar"].Index)
                {
                    FRMEditarPersonalRegistro editarform = new FRMEditarPersonalRegistro(
                        nombres,
                        apellidos,
                        cedula,
                        correo,
                        contra
                    );

                    editarform.PersonalEditado += () =>
                    {
                        dgvPersonalRegistro.DataSource = TablaPersonalRegistro.GetInstancia().GetTabla();
                    };

                    editarform.ShowDialog();
                }

                else if (e.ColumnIndex == dgvPersonalRegistro.Columns["Eliminar"].Index)
                {
                    var cedulaPersonalRegCell = dgvPersonalRegistro.Rows[e.RowIndex].Cells["Cedula"];
                    if (cedulaPersonalRegCell.Value != null)
                    {
                        // Si obtenemos la cdeula, la hacemos string
                        string cedulaP = cedulaPersonalRegCell.Value.ToString();

                        DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?",
                                                                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            // Eliminar el personal
                            bool eliminado = TablaPersonalRegistro.GetInstancia().EliminarPersonal(cedulaP);
                            if (eliminado)
                            {
                                // Mensaje de éxito
                                MessageBox.Show("Persona de registro eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.dgvPersonalRegistro.DataSource = null;
                                this.dgvPersonalRegistro.DataSource = TablaPersonalRegistro.GetInstancia().GetTabla();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo encontrar el personal a eliminar.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al procesar acción: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // Vuelve a habilitar el DataGridView después de que se actualiza
                this.dgvPersonalRegistro.Enabled = true;
            }
        }

        private void dgvSeguridad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Desactiva el dgv para evitar interactuar con el DataGridView mientras se actualiza
                this.dgvSeguridad.Enabled = false;

                // Validar que se haya hecho clic en una celda válida
                if (e.RowIndex < 0 || e.RowIndex >= dgvSeguridad.Rows.Count)
                    return;

                DataGridViewRow filaSeleccionada = dgvSeguridad.Rows[e.RowIndex];

                string nombres = filaSeleccionada.Cells["Nombres"]?.Value?.ToString() ?? "Sin nombres";
                string apellidos = filaSeleccionada.Cells["Apellidos"]?.Value?.ToString() ?? "Sin apellidos";
                string cedula = filaSeleccionada.Cells["Cedula"]?.Value?.ToString() ?? "Sin cédula";
                string correo = filaSeleccionada.Cells["Correo"]?.Value?.ToString() ?? "Sin correo";
                string contra = filaSeleccionada.Cells["Contra"]?.Value?.ToString() ?? "Sin contra";

                //if (e.ColumnIndex == dgvPersonalRegistro.Columns["Ver"].Index)
                //{

                //}

                if (e.ColumnIndex == dgvSeguridad.Columns["EditarSeguridad"].Index)
                {
                    FRMEditarPersonalSeguridad editarform = new FRMEditarPersonalSeguridad(
                        nombres,
                        apellidos,
                        cedula,
                        correo,
                        contra
                    );

                    editarform.PersonalEditado += () =>
                    {
                        dgvSeguridad.DataSource = TablaPersonalSeguridad.GetInstancia().GetTabla();
                    };

                    editarform.ShowDialog();
                }

                else if (e.ColumnIndex == dgvSeguridad.Columns["EliminarSeguridad"].Index)
                {
                    var cedulaSeguridadCell = dgvSeguridad.Rows[e.RowIndex].Cells["Cedula"];
                    if (cedulaSeguridadCell.Value != null)
                    {
                        // Si obtenemos la cdeula, la hacemos string
                        string cedulaS = cedulaSeguridadCell.Value.ToString();

                        DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?",
                                                                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            // Eliminar el personal
                            bool eliminado = TablaPersonalSeguridad.GetInstancia().EliminarPersonal(cedulaS);
                            if (eliminado)
                            {
                                // Mensaje de éxito
                                MessageBox.Show("Persona de seguridad eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.dgvSeguridad.DataSource = null;
                                this.dgvSeguridad.DataSource = TablaPersonalSeguridad.GetInstancia().GetTabla();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo encontrar el personal a eliminar.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al procesar acción: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // Vuelve a habilitar el DataGridView después de que se actualiza
                this.dgvSeguridad.Enabled = true;
            }
        }
    }
}
