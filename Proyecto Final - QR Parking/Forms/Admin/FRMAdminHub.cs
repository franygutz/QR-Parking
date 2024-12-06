
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.Admin
{
	public partial class FRMAdminHub : Form
	{
		private static FRMAdminHub instancia;

		public FRMAdminHub()
		{
			InitializeComponent();
		}

		public static FRMAdminHub GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMAdminHub();

			return instancia;
		}

		private void FRMAdminHub_Load(object sender, EventArgs e)
		{
			dgvPersonalRegistro.DataSource = TablaPersonalRegistro.GetInstancia().GetTabla();
			dgvSeguridad.DataSource = TablaPersonalSeguridad.GetInstancia().GetTabla();
		}

		private void tsmiCerrarSesion_Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show(
				"¿Desea cerrar sesión?",
				"Cerrar Sesión",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (respuesta == DialogResult.Yes)
			{
				Close();
				FRMAdministrador inicioSesionAdmin = FRMAdministrador.GetInstancia();
				inicioSesionAdmin.Show();
			}
		}

		private void dgvPersonalRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				// Desactiva el dgv para evitar interactuar
				// con el DataGridView mientras se actualiza
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
					if (cedulaPersonalRegCell.Value == null)
						return;

					// Si obtenemos la cedula, la hacemos string
					string cedulaP = cedulaPersonalRegCell.Value.ToString();

					DialogResult resultado = MessageBox.Show(
						"¿Está seguro que desea eliminar este registro?",
						"Confirmación",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
					);

					if (resultado == DialogResult.Yes)
					{
						bool eliminado = TablaPersonalRegistro.GetInstancia().EliminarPersonal(cedulaP);
						if (eliminado)
						{
							MessageBox.Show(
								"¡Personal de registro eliminado exitosamente!",
								"Éxito",
								MessageBoxButtons.OK,
								MessageBoxIcon.Information
							);

							dgvPersonalRegistro.DataSource = null;
							dgvPersonalRegistro.DataSource = TablaPersonalRegistro.GetInstancia().GetTabla();
						}

						else
						{
							MessageBox.Show(
								"¡No se pudo encontrar el personal a eliminar!",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error
							);
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
				dgvPersonalRegistro.Enabled = true;
			}
		}

		private void dgvSeguridad_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				// Desactiva el dgv para evitar interactuar
				// con el DataGridView mientras se actualiza
				dgvSeguridad.Enabled = false;

				// Validar que se haya hecho clic en una celda válida
				if (e.RowIndex < 0 || e.RowIndex >= dgvSeguridad.Rows.Count)
					return;

				DataGridViewRow filaSeleccionada = dgvSeguridad.Rows[e.RowIndex];
				string nombres = filaSeleccionada.Cells["Nombres"]?.Value?.ToString() ?? "Sin nombres";
				string apellidos = filaSeleccionada.Cells["Apellidos"]?.Value?.ToString() ?? "Sin apellidos";
				string cedula = filaSeleccionada.Cells["Cedula"]?.Value?.ToString() ?? "Sin cédula";
				string correo = filaSeleccionada.Cells["Correo"]?.Value?.ToString() ?? "Sin correo";
				string contra = filaSeleccionada.Cells["Contra"]?.Value?.ToString() ?? "Sin contra";
				
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
						// Si obtenemos la cedula, la hacemos string
						string cedulaS = cedulaSeguridadCell.Value.ToString();
						DialogResult resultado = MessageBox.Show(
							"¿Está seguro que desea eliminar este registro?",
							"Confirmación",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Question
						);

						if (resultado == DialogResult.Yes)
						{
							bool eliminado = TablaPersonalSeguridad.GetInstancia().EliminarPersonal(cedulaS);
							if (eliminado)
							{
								MessageBox.Show(
									"¡Personal de seguridad eliminado correctamente.",
									"Éxito",
									MessageBoxButtons.OK,
									MessageBoxIcon.Information
								);

								dgvSeguridad.DataSource = null;
								dgvSeguridad.DataSource = TablaPersonalSeguridad.GetInstancia().GetTabla();
							}

							else
							{
								MessageBox.Show(
									"¡No se pudo encontrar el personal a eliminar!",
									"Error",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error
								);
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
				dgvSeguridad.Enabled = true;
			}
		}
	}
}
