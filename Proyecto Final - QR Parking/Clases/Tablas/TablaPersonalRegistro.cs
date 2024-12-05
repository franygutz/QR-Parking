
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Proyecto_Final___QR_Parking.Clases.Tablas
{
	internal class TablaPersonalRegistro
	{
		const string nombre_fichero = "PersonalRegistro.bin";

		private static TablaPersonalRegistro instancia;
		private List<Empleado> tabla;

		private TablaPersonalRegistro()
		{
			tabla = new List<Empleado>();
			CargarPersonal();
		}

		public static TablaPersonalRegistro GetInstancia()
		{
			if (instancia == null)
				instancia = new TablaPersonalRegistro();

			return instancia;
		}

		public List<Empleado> GetTabla()
		{
			return tabla;
		}

		public void AgregarPersonal(Empleado registro)
		{
			if (registro != null)
				tabla.Add(registro);
		}

		public bool VerificarExistenciaCorreo(string correo)
		{
			return tabla.Exists(emp => emp.Correo == correo);
		}

		public bool AutenticarUsuario(string correo, string contra)
		{
			return tabla.Exists(
				reg => reg.Correo == correo && reg.Contra == contra
			);
		}

		public bool GuardarPersonal()
		{
			try
			{
				string temp = "temp.bin";
				using (var stream = File.Open(temp, FileMode.Create, FileAccess.Write))
				{
					var writer = new BinaryWriter(stream, Encoding.UTF8, false);

					foreach (var registro in tabla)
					{
						writer.Write(registro.Nombres);
						writer.Write(registro.Apellidos);
						writer.Write(registro.Cedula);
						writer.Write(registro.Correo);
						writer.Write(registro.Contra);
					}

				}

				if (File.Exists(nombre_fichero))
					File.Delete(nombre_fichero);

				File.Move(temp, nombre_fichero);
				return true;
			}

			catch (Exception ex)
			{
				MessageBox.Show(
					$"¡Error al guardar registros de Personal de Registros!\n{ex.Message}",
					"Error de Archivo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}
		}

		public void CargarPersonal()
		{
			if (!File.Exists(nombre_fichero))
			{
				File.Create(nombre_fichero).Close();
			}

			using (var stream = File.Open(nombre_fichero, FileMode.Open, FileAccess.Read))
			{
				var reader = new BinaryReader(stream, Encoding.UTF8, false);

				try
				{
					while (stream.Position < stream.Length)
					{
						Empleado empleado = new Empleado()
						{
							Nombres = reader.ReadString(),
							Apellidos = reader.ReadString(),
							Cedula = reader.ReadString(),
							Correo = reader.ReadString(),
							Contra = reader.ReadString()
						};

						AgregarPersonal(empleado);
					}
				}					

				catch (Exception ex)
				{
					MessageBox.Show(
						$"¡Error al cargar registros de Personal de Registros!\n{ex.Message}",
						"Error de Archivo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}
	}
}
