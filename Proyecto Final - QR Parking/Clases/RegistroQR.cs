
using System;


namespace Proyecto_Final___QR_Parking.Clases
{
	internal class RegistroQR
	{
		private string tipoQR;
		private string nombresQR;
		private string apellidosQR;
		private string cedulaQR;
		private string placaQR;
		private DateTime fecha;

		public string TipoQR { get => tipoQR; set => tipoQR = value; }

		public string NombresQR { get => nombresQR; set => nombresQR = value; }

		public string ApellidosQR { get => apellidosQR; set => apellidosQR = value; }


		public string CedulaQR
		{
			get => cedulaQR;
			set
			{
				if (value.Length > 17)
					throw new ArgumentException(
						"¡Una cédula debe tener exactamente 17 caracteres!"
					);

				cedulaQR = value;
			}
		}

		public string PlacaQR 
		{ 
			get => placaQR; 
			set
			{
				if (value.Length > 8)
					throw new ArgumentException(
						"¡Una placa debe tener un máximo de 8 caracteres!"
					);

				placaQR = value;
			}
		}

		public DateTime Fecha { get => fecha; set => fecha = value; }
	}
}
