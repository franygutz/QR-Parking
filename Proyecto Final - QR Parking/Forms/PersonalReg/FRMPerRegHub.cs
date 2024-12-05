
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

		//no borrar porque se crashea
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FRMPerRegHub_Load(object sender, EventArgs e)
		{
			this.dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
		}

		private void tsmicerrarSesion_Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				FRMLogInPersonalReg frmLogIn = FRMLogInPersonalReg.GetInstancia();
				frmLogIn.Show();
				this.Close();
			}
			else return;
		}

		private void bAgregar_Click(object sender, EventArgs e)
		{
			FRMAgregarRegistroQR agregarRegistro = FRMAgregarRegistroQR.GetInstancia();

			agregarRegistro.RegistroGuardado += () =>
			{
				this.dgvRegistros.DataSource = null;
				this.dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
			};

			agregarRegistro.Show();
		}

		private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				// Validar que se haya hecho clic en una celda válida
				if (e.RowIndex < 0 || e.RowIndex >= dgvRegistros.Rows.Count) return;

				DataGridViewRow filaSeleccionada = dgvRegistros.Rows[e.RowIndex];

				if (e.ColumnIndex == dgvRegistros.Columns["Ver"].Index)
				{
					string nombres = filaSeleccionada.Cells["NombresQR"]?.Value?.ToString() ?? "Sin nombre";
					string apellidos = filaSeleccionada.Cells["ApellidosQR"]?.Value?.ToString() ?? "Sin apellidos";
					string cedula = filaSeleccionada.Cells["CedulaQR"]?.Value?.ToString() ?? "Sin cédula";
					string placa = filaSeleccionada.Cells["PlacaQR"]?.Value?.ToString() ?? "Sin placa";
					string tipo = filaSeleccionada.Cells["TipoQR"]?.Value?.ToString() ?? "Sin tipo";
					string fecha = filaSeleccionada.Cells["Fecha"]?.Value?.ToString() ?? DateTime.Now.ToString();

					FRMMostrarRegistroQR detallesForm = new FRMMostrarRegistroQR(nombres, apellidos, cedula, placa, tipo, fecha);
					detallesForm.ShowDialog();
				}

				if (e.ColumnIndex == dgvRegistros.Columns["Editar"].Index)
				{
					string nombres = filaSeleccionada.Cells["NombresQR"]?.Value?.ToString() ?? "Sin nombre";
					string apellidos = filaSeleccionada.Cells["ApellidosQR"]?.Value?.ToString() ?? "Sin apellidos";
					string cedula = filaSeleccionada.Cells["CedulaQR"]?.Value?.ToString() ?? "Sin cédula";
					string placa = filaSeleccionada.Cells["PlacaQR"]?.Value?.ToString() ?? "Sin placa";
					string tipo = filaSeleccionada.Cells["TipoQR"]?.Value?.ToString() ?? "Sin tipo";
					string fecha = filaSeleccionada.Cells["Fecha"]?.Value?.ToString() ?? DateTime.Now.ToString();

					FRMEditarRegistroQR editarForm = new FRMEditarRegistroQR(nombres, apellidos, cedula, placa, tipo, fecha);

					editarForm.RegistroEditado += () =>
					{
						dgvRegistros.DataSource = null;
						dgvRegistros.DataSource = TablaRegistrosQR.GetInstancia().GetTabla();
					};

					editarForm.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al procesar acción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}