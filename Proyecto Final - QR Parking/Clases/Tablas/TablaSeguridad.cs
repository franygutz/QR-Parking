
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Proyecto_Final___QR_Parking.Clases.Tablas
{
	internal class TablaPersonalSeguridad
	{
		const string nombre_fichero = "PersonalSeguridad.bin";

		private static TablaPersonalSeguridad instancia;
		private List<Empleado> tabla;

		private TablaPersonalSeguridad()
		{
			tabla = new List<Empleado>();
			CargarPersonal();
		}

		public static TablaPersonalSeguridad GetInstancia()
		{
			if (instancia == null)
				instancia = new TablaPersonalSeguridad();

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

					File.Delete(nombre_fichero);
					File.Move(temp, nombre_fichero);
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show(
					$"¡Error al guardar registros de Seguridad!\n{ex.Message}",
					"Error de Archivo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}

			return true;
		}

		public void CargarPersonal()
		{
			if (!File.Exists(nombre_fichero))
			{
				MessageBox.Show(
					"¡Aún no ha guardado ningún registro de Seguridad!",
					"Advertencia",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
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
						$"Error al cargar registros de Seguridad!\n{ex.Message}",
						"Error de Archivo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}
	}
}
