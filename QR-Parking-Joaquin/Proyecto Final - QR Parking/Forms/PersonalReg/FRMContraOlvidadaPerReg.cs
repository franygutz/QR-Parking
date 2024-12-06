
using System;
using System.Net.Mail;
using System.Windows.Forms;
using Proyecto_Final___QR_Parking.Clases;
using Proyecto_Final___QR_Parking.Clases.Tablas;
using Proyecto_Final___QR_Parking.Seguridad;


namespace Proyecto_Final___QR_Parking.PersonalReg
{
	public partial class FRMContraOlvidadaPerReg : Form
	{
		private static FRMContraOlvidadaPerReg instancia;
		private TablaPersonalRegistro tabla_RPersonalReg = TablaPersonalRegistro.GetInstancia();

		public FRMContraOlvidadaPerReg()
		{
			InitializeComponent();
		}

		public static FRMContraOlvidadaPerReg GetInstancia()
		{
			if (instancia == null || instancia.IsDisposed)
				instancia = new FRMContraOlvidadaPerReg();

			return instancia;
		}

		private void bIrGmail_Click(object sender, EventArgs e)
		{
			string url = "https://mail.google.com/mail/";
			System.Diagnostics.Process.Start(url);
		}

		private void bVolver_Click(object sender, EventArgs e)
		{
		   Close();
			FRMLogInPersonalReg frmInicioSesionPerReg = FRMLogInPersonalReg.GetInstancia();
			frmInicioSesionPerReg.Show();
		}

		private void bAceptar_Click(object sender, EventArgs e)
		{
            // No borrar
        }

        private void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            // Configuración del cliente SMTP
            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            cliente.Credentials = new System.Net.NetworkCredential("qrparking.uam@gmail.com", "mqmt ejie dvew pcav");
            cliente.EnableSsl = true;

            // Crea el mensaje de correo
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("qrparking.uam@gmail.com");
            mensaje.To.Add(destinatario);
            mensaje.Subject = asunto;
            mensaje.Body = cuerpo;
            mensaje.IsBodyHtml = false;

            // Envia el correo
            cliente.Send(mensaje);
        }

        private void bAceptar_Click_1(object sender, EventArgs e)
        {
            string correoUsuario = tbUsuarioCO.Text;

            // Validar que el correo no esté vacío
            if (string.IsNullOrEmpty(correoUsuario))
            {
                MessageBox.Show(
                    "Por favor ingresa tu correo electrónico.",
                    "Correo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                // Buscar al usuario en la base de datos por correo
                Empleado usuario = tabla_RPersonalReg.buscarPersonal(correoUsuario);

                if (usuario != null)
                {
                    // Configuración del correo
                    string correoAdministrador = "qrparking.uam@gmail.com";
                    string asunto = "Solicitud de recuperación de contraseña";
                    string mensaje = $"El usuario con los siguientes datos ha solicitado recuperar su contraseña:\n\n" +
                                     $"Nombre: {usuario.Nombres} {usuario.Apellidos}\n" +
                                     $"Cédula: {usuario.Cedula}\n" +
                                     $"Correo: {usuario.Correo}\n\n" +
                                     $"Por favor, revisa la solicitud.";

                    // Enviar el correo
                    EnviarCorreo(correoAdministrador, asunto, mensaje);

                    MessageBox.Show(
                        "Tu solicitud ha sido enviada al administrador. Por favor, espera una respuesta.",
                        "Solicitud enviada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    tbUsuarioCO.Clear();
                }
                else
                {
                    MessageBox.Show(
                        "¡No se encontró un usuario con ese correo electrónico!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al enviar la solicitud: {ex.Message}",
                    "Error al enviar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void bIrGmail_Click_1(object sender, EventArgs e)
        {
            string url = "https://mail.google.com/mail/";
            System.Diagnostics.Process.Start(url);
        }

        private void bVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FRMLogInPersonalReg fRMLogInPersonalReg = new FRMLogInPersonalReg();
            fRMLogInPersonalReg.Show();
        }
    }
}
