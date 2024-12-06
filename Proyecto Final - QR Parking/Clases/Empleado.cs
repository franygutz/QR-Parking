
using System;


namespace Proyecto_Final___QR_Parking.Clases
{
	internal class Empleado
	{
		private string nombres;
		private string apellidos;
		private string cedula;
		private string correo;
		private string contra;

		public string Nombres { get => nombres; set => nombres = value; }

		public string Apellidos { get => apellidos; set => apellidos = value; }

		public string Cedula
		{
			get => cedula;
			set
			{
				if (value.Length > 17)
					throw new ArgumentException(
						"¡Una cédula debe tener exactamente 17 caracteres!"
					);

				cedula = value;
			}
		}

		public string Correo
		{
			get => correo;
			set
			{
				if (!Util.ValidarCorreoRegistro(value))
					throw new ArgumentException(
						"¡El correo debe tener la extensión '@uamv.edu.ni' o '@uam.edu.ni'!"
					);

				correo = value;
			}
		}

		public string Contra
		{
			get => contra; 
			set
			{
				if (value.Length < 8)
					throw new ArgumentException(
						"¡Una contraseña debe tener al menos 8 caracteres!"
					);

				contra= value;
			}
		}
	}
}
