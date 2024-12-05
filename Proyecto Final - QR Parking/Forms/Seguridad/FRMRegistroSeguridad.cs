
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.Seguridad
{
	public partial class FRMRegistroSeguridad : Form
	{
		private static FRMRegistroSeguridad instancia;
		private TablaPersonalSeguridad tabla_RSeguridad = TablaPersonalSeguridad.GetInstancia();
		
		public FRMRegistroSeguridad()
		{
			InitializeComponent();
			AcceptButton = bRegistrarseSignInSeg;
		}

		public static FRMRegistroSeguridad GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMRegistroSeguridad();

			return instancia;
		}

		private void bRegistrarseSignInSeg_Click(object sender, EventArgs e)
		{
			bool valido = Util.ValidarRegistroUsuario(
				"Seguridad",
				tbNombresSignInSeg.Text,
				tbApellidosSignInSeg.Text,
				mtbCedulaSignInSeg.Text,
				tbCorreoSignInSeg.Text,
				mtbContraSignInSeg.Text,
				mtbConfirmarContraSignInSeg.Text,
				tabla_RSeguridad.VerificarExistenciaCorreo(tbCorreoSignInSeg.Text)
			);

			// si hubo un input invalido, ValidarRegistroUsuario()
			// muestra el message box de error y retorna null
			if (!valido) return;

			Empleado nuevoUsuarioSeguridad = new Empleado()
			{
				Nombres = tbNombresSignInSeg.Text,
				Apellidos = tbApellidosSignInSeg.Text,
				Cedula = mtbCedulaSignInSeg.Text,
				Correo = tbCorreoSignInSeg.Text,
				Contra = mtbContraSignInSeg.Text
			};

			tabla_RSeguridad.AgregarPersonal(nuevoUsuarioSeguridad);
			bool success = tabla_RSeguridad.GuardarPersonal();

			if (success)
			{
				MessageBox.Show(
					"¡Error al guardar los datos!",
					"Registro de Seguridad",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return;
			}
						
			MessageBox.Show(
				"¡Los datos se guardaron exitosamente!",
				"Registro de Seguridad",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);

			// Limpiar campos
			tbNombresSignInSeg.Clear();
			tbApellidosSignInSeg.Clear();
			mtbCedulaSignInSeg.Clear();
			tbCorreoSignInSeg.Clear();
			mtbContraSignInSeg.Clear();
			mtbConfirmarContraSignInSeg.Clear();
		}

		private void bVolverSignInSeg_Click(object sender, EventArgs e)
		{ 
			Close();
			FRMLogInSeguridad frmSegu = FRMLogInSeguridad.GetInstancia();
			frmSegu.Show();
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
