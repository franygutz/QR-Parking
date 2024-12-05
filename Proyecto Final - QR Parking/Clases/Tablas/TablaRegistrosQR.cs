
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Proyecto_Final___QR_Parking.Clases.Tablas
{
	internal class TablaRegistrosQR
	{
		const string nombre_fichero = "RegistrosPlacas.bin";

		private static TablaRegistrosQR instancia;
		private List<RegistroQR> tabla;

		private TablaRegistrosQR()
		{
			tabla = new List<RegistroQR>();
			CargarRegistros();
		}

		public static TablaRegistrosQR GetInstancia()
		{
			if (instancia == null)
				instancia = new TablaRegistrosQR();

			return instancia;
		}

		public List<RegistroQR> GetTabla()
		{
			return tabla;
		}

		public void AgregarRegistroPlaca(RegistroQR registro)
		{
			if (registro != null)
				tabla.Add(registro);
		}

		public bool VerificarExistenciaPlaca(string placa)
		{
			return tabla.Exists(reg => reg.PlacaQR == placa);
		}

		public bool EditarRegistro(RegistroQR registroEditado)
		{
			var registroOriginal = tabla.FirstOrDefault(
				reg => reg.PlacaQR == registroEditado.PlacaQR
			);

			if (registroOriginal != null)
			{
				registroOriginal.TipoQR = registroEditado.TipoQR;
				registroOriginal.NombresQR = registroEditado.NombresQR;
				registroOriginal.ApellidosQR = registroEditado.ApellidosQR;
				registroOriginal.CedulaQR = registroEditado.CedulaQR;
				registroOriginal.PlacaQR = registroEditado.PlacaQR;
				registroOriginal.Fecha = registroEditado.Fecha;

				GuardarRegistros();
				return true;
			}

			return false;
		}

		public bool EliminarRegistro(string placa)
		{
			var registroEliminar = tabla.FirstOrDefault(r => r.PlacaQR.Equals(placa));

			if (registroEliminar != null)
			{
				tabla.Remove(registroEliminar);
				GuardarRegistros();
				return true;
			}

			return false;
		}

		public bool GuardarRegistros()
		{
			try
			{
				string temp = "temp";
				using (var stream = File.Open(temp, FileMode.Create, FileAccess.Write))
				{
					var writer = new BinaryWriter(stream, Encoding.UTF8, false);

					foreach (var registro in tabla)
					{
						writer.Write(registro.TipoQR);
						writer.Write(registro.NombresQR);
						writer.Write(registro.ApellidosQR);
						writer.Write(registro.CedulaQR);
						writer.Write(registro.PlacaQR);
						writer.Write(registro.Fecha.ToString());
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
					$"¡Error al guardar registros de QR!\n{ex.Message}",
					"Error de Archivo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}
		}

		public void CargarRegistros()
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
						RegistroQR registro = new RegistroQR()
						{
							TipoQR = reader.ReadString(),
							NombresQR = reader.ReadString(),
							ApellidosQR = reader.ReadString(),
							CedulaQR = reader.ReadString(),
							PlacaQR = reader.ReadString(),
							Fecha = DateTime.Parse(reader.ReadString())
						};

						AgregarRegistroPlaca(registro);
					}
				}

				catch (Exception ex)
				{
					MessageBox.Show(
						$"¡Error al cargar registros de QR!\n{ex.Message}",
						"Error de ARchivo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}
	}
}
