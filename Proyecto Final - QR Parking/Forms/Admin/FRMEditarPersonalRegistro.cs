
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.Admin
{
	public partial class FRMEditarPersonalRegistro : Form
	{
		private static FRMEditarPersonalRegistro instancia;
		private TablaPersonalRegistro tablaPersonal = TablaPersonalRegistro.GetInstancia();
		public event Action PersonalEditado;

		public FRMEditarPersonalRegistro(string nombres, string apellidos, string cedula, string correo, string contra)
		{
			InitializeComponent();
			tbNombres.Text = nombres;
			tbApellidos.Text = apellidos;
			mtbCedula.Text = cedula;
			tbCorreo.Text = correo;
			tbContra.Text = contra;
		}

		public static FRMEditarPersonalRegistro GetInstancia(string nombres, string apellidos, string cedula, string correo, string contra)
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
			Close();
			FRMAdminHub fRMAdminHub = FRMAdminHub.GetInstancia();
			fRMAdminHub.Show();
		}

		private void bGuardar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbNombres.Text) ||
				string.IsNullOrWhiteSpace(tbApellidos.Text) ||
				string.IsNullOrWhiteSpace(mtbCedula.Text) ||
				string.IsNullOrWhiteSpace(tbCorreo.Text) ||
				string.IsNullOrWhiteSpace(tbContra.Text))
			{

				MessageBox.Show(
					"¡Todos los campos son obligatorios! Por favor, complete todos los campos.",
					"Error de Validación",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (tbContra.Text.Length < 8)
			{
				MessageBox.Show(
					"¡La contraseña debe tener al menos 8 caracteres!",
					"Error de Contraseña",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
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
					Nombres = tbNombres.Text,
					Apellidos = tbApellidos.Text,
					Cedula = mtbCedula.Text,
					Correo = tbCorreo.Text,
					Contra = tbContra.Text
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
