
using System;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases;
using Proyecto_Final___QR_Parking.Clases.Tablas;


namespace Proyecto_Final___QR_Parking.PersonalReg
{
	public partial class FRMRegistroPersonalReg : Form
	{
		private static FRMRegistroPersonalReg instancia;
		private TablaPersonalRegistro tabla_RPersonalReg = TablaPersonalRegistro.GetInstancia();

		public FRMRegistroPersonalReg()
		{
			InitializeComponent();
			this.AcceptButton = bRegistrarseSignInPerReg;
		}

		public static FRMRegistroPersonalReg GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMRegistroPersonalReg();

			return instancia;
		}

		private void bRegistrarseSignInPerReg_Click(object sender, EventArgs e)
		{
			bool valido = Util.ValidarRegistroUsuario(
				"Personal de Registro",
				tbNombresSignInPerReg.Text,
				tbApellidosSignInPerReg.Text,
				mtbCedulaSignInPerReg.Text,
				tbCorreoSignInPerReg.Text,
				mtbContraSignInPerReg.Text,
				mtbConfirmarContraSignInPerReg.Text,
				tabla_RPersonalReg.VerificarExistenciaCorreo(tbCorreoSignInPerReg.Text)
			);

			if (!valido) return;

			Empleado nuevoRegistroPersonal = new Empleado()
			{
				Nombres = tbNombresSignInPerReg.Text,
				Apellidos = tbApellidosSignInPerReg.Text,
				Cedula = mtbCedulaSignInPerReg.Text,
				Correo = tbCorreoSignInPerReg.Text,
				Contra = mtbContraSignInPerReg.Text
			};

			tabla_RPersonalReg.AgregarPersonal(nuevoRegistroPersonal);
			bool success = tabla_RPersonalReg.GuardarPersonal();

			if (!success)
				return;

			MessageBox.Show(
				"¡Los datos se guardaron exitosamente!",
				"Registro de Personal",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);

			// Limpiar campos
			tbNombresSignInPerReg.Clear();
			tbApellidosSignInPerReg.Clear();
			mtbCedulaSignInPerReg.Clear();
			tbCorreoSignInPerReg.Clear();
			mtbContraSignInPerReg.Clear();
			mtbConfirmarContraSignInPerReg.Clear();
		}

		private void bVolverSignInPerReg_Click(object sender, EventArgs e)
		{
			Close();
			FRMLogInPersonalReg frmRegistroPer = FRMLogInPersonalReg.GetInstancia();
			frmRegistroPer.Show();
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
