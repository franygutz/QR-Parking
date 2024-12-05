
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.PersonalReg
{
	public partial class FRMPerRegHub : Form
	{
		private static FRMPerRegHub instancia;

		public FRMPerRegHub()
		{
			InitializeComponent();
		}

		public static FRMPerRegHub GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMPerRegHub();
			
			return instancia;
		}


		private void FRMPerRegHub_Load(object sender, EventArgs e)
		{
			this.dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
		}

		private void tsmicerrarSesion_Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show(
				"¿Desea cerrar sesión?",
				"Cerrar Sesión",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (respuesta == DialogResult.Yes)
			{
				FRMLogInPersonalReg frmLogIn = FRMLogInPersonalReg.GetInstancia();
				frmLogIn.Show();
				Close();
			}
		}

		private void bAgregar_Click(object sender, EventArgs e)
		{
			FRMAgregarRegistroQR agregarRegistro = FRMAgregarRegistroQR.GetInstancia();

			agregarRegistro.RegistroGuardado += () =>
			{
                this.dgvRegistros.DataSource = null;
                dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
			};

			agregarRegistro.Show();
		}

		private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
                // Desactiva el dgv para evitar interactuar con el DataGridView mientras se actualiza
                dgvRegistros.Enabled = false;

                // Validar que se haya hecho clic en una celda válida
                if (e.RowIndex < 0 || e.RowIndex >= dgvRegistros.Rows.Count)
					return;

				DataGridViewRow filaSeleccionada = dgvRegistros.Rows[e.RowIndex];

				string nombres = filaSeleccionada.Cells["NombresQR"]?.Value?.ToString() ?? "Sin nombres";
				string apellidos = filaSeleccionada.Cells["ApellidosQR"]?.Value?.ToString() ?? "Sin apellidos";
				string cedula = filaSeleccionada.Cells["CedulaQR"]?.Value?.ToString() ?? "Sin cédula";
				string placa = filaSeleccionada.Cells["PlacaQR"]?.Value?.ToString() ?? "Sin placa";
				string tipo = filaSeleccionada.Cells["TipoQR"]?.Value?.ToString() ?? "Sin tipo";
				string fecha = filaSeleccionada.Cells["Fecha"]?.Value?.ToString() ?? DateTime.Now.ToString();

				if (e.ColumnIndex == dgvRegistros.Columns["Ver"].Index)
				{
					FRMMostrarRegistroQR detallesForm = new FRMMostrarRegistroQR(
						nombres,
						apellidos,
						cedula,
						placa,
						tipo,
						fecha
					);

					detallesForm.ShowDialog();
				}

				else if (e.ColumnIndex == dgvRegistros.Columns["Editar"].Index)
				{
					FRMEditarRegistroQR editarForm = new FRMEditarRegistroQR(
						nombres,
						apellidos,
						cedula,
						placa,
						tipo,
						fecha
					);

					editarForm.RegistroEditado += () =>
					{
						dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
					};

					editarForm.ShowDialog();
				}

				else if (e.ColumnIndex == dgvRegistros.Columns["Eliminar"].Index)
				{
                    var placaQRCell = dgvRegistros.Rows[e.RowIndex].Cells["PlacaQR"];
                    if (placaQRCell.Value != null)
                    {
                        // Si obtenemos la placa, la hacemos string
                        string placaQR = placaQRCell.Value.ToString();

                        DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?",
                                                                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            // Eliminar el registro
                            bool eliminado = TablaRegistrosQR.GetInstancia().EliminarRegistro(placaQR);
                            if (eliminado)
                            {
                                // Mensaje de éxito
                                MessageBox.Show("Registro eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.dgvRegistros.DataSource = null;
                                this.dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo encontrar el registro a eliminar.", "Error",
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
                dgvRegistros.Enabled = true;
            }
        }
	}
}