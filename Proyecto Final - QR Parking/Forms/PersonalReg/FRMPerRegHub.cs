
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases;
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
			dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
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
				dgvRegistros.DataSource = null;
				dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
			};

			agregarRegistro.Show();
		}

		private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				// Desactiva el dgv para evitar interactuar
				// con el DataGridView mientras se actualiza
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
						dgvRegistros.DataSource = null;
						dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
					};

					editarForm.ShowDialog();
				}

				else if (e.ColumnIndex == dgvRegistros.Columns["Eliminar"].Index)
				{
					var placaQRCell = dgvRegistros.Rows[e.RowIndex].Cells["PlacaQR"];
					if (placaQRCell.Value == null)
					{
						MessageBox.Show(
							"¡No se encontró el registro a eliminar!",
							"Error de Registro",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error
						);

						return;
					}

					string placaQR = placaQRCell.Value.ToString();
					DialogResult resultado = MessageBox.Show(
						"¿Está seguro que desea eliminar este registro?",
						"Confirmación",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
					);

					if (resultado == DialogResult.Yes)
					{
						bool eliminado = TablaRegistrosQR.GetInstancia().EliminarRegistro(placaQR);

						if (!eliminado)
						{
							MessageBox.Show(
								"¡No se pudo encontrar el registro a eliminar!",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error
							);

							return;
						}
						
						dgvRegistros.DataSource = null;
						dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();

						MessageBox.Show(
							"¡Registro eliminado exitosamente!",
							"Éxito",
							MessageBoxButtons.OK,
							MessageBoxIcon.Information
						);
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
				dgvRegistros.Enabled = true;
			}
		}

		private void tbPlaca_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != (char) Keys.Enter)
				return;

			string placa = tbPlaca.Text;
			RegistroQR registro_encontrado = TablaRegistrosQR.GetInstancia().BuscarRegistroPlaca(placa);

			if (registro_encontrado == null)
			{
				MessageBox.Show(
					"¡No se encontró la placa ingresada!",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return;
			}

			foreach (DataGridViewRow row in dgvRegistros.Rows)
			{
				if (row.Cells["PlacaQR"].Value != null && row.Cells["PlacaQR"].Value.ToString() == placa)
				{
					row.Selected = true;
					dgvRegistros.FirstDisplayedScrollingRowIndex = row.Index;
					break;
				}
			}
		}
	}
}