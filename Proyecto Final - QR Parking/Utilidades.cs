
using System.Windows.Forms;


namespace Proyecto_Final___QR_Parking
{
	class Util
	{
		public static bool ValidarCorreoRegistro(string correo)
		{
			return correo.EndsWith("@uamv.edu.ni") || correo.EndsWith("@uam.edu.ni");
		}

		public static bool ValidarRegistroUsuario
		(
			string tipo_usuario,
			string nombres,
			string apellidos,
			string cedula,
			string correo,
			string contra,
			string confirmar_contra,
			bool existe_correo
		) {

			// Validar si alguno de los campos esta vacio
			if (string.IsNullOrWhiteSpace(nombres) ||
				string.IsNullOrWhiteSpace(apellidos) ||
				string.IsNullOrWhiteSpace(cedula) ||
				string.IsNullOrWhiteSpace(correo) ||
				string.IsNullOrWhiteSpace(contra) ||
				string.IsNullOrWhiteSpace(confirmar_contra))
			{
				MessageBox.Show(
					"¡Todos los campos son obligatorios! Por favor, complete todos los campos.",
					"Error de Validación",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return false;
			}

			// Solamente correo UAM
			if (!correo.EndsWith("@uamv.edu.ni") && !correo.EndsWith("@uam.edu.ni"))
			{
				MessageBox.Show(
					"¡El correo debe ser un correo institucional UAM! (@uamv.edu.ni, @uam.edu.ni)",
					"Error de Correo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}

			// Contraseña de al menos 8 caracteres
			if (contra.Length < 8)
			{
				MessageBox.Show(
					"¡La contraseña debe tener al menos 8 caracteres!",
					"Error de Contraseña",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}

			// Las contraseñas tienen que coincidir
			if (contra != confirmar_contra)
			{
				MessageBox.Show(
					"¡Las contraseñas no coinciden!",
					"Error de Contraseña",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}

			// No debe de haber dos usuarios con el mismo correo
			if (existe_correo)
			{
				MessageBox.Show(
					$"¡Ya existe un usuario de {tipo_usuario} con el correo indicado!",
					"Registro de Seguridad",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}

			DialogResult resp = MessageBox.Show(
					"¿Está seguro que desea guardar estos datos?",
					"Registro de Seguridad",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
			);

			if (resp == DialogResult.Yes)
				return true;
			
			return false;
		}
	}
}
