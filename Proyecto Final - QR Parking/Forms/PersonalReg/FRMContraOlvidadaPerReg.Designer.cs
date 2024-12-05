namespace Proyecto_Final___QR_Parking.PersonalReg
{
	partial class FRMContraOlvidadaPerReg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMContraOlvidadaPerReg));
			this.panelContraolvidSeg = new System.Windows.Forms.Panel();
			this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
			this.bAceptar = new System.Windows.Forms.Button();
			this.bIrGmail = new System.Windows.Forms.Button();
			this.bVolver = new System.Windows.Forms.Button();
			this.lIndicacion = new System.Windows.Forms.Label();
			this.tbUsuarioCO = new System.Windows.Forms.TextBox();
			this.lCorreoCO = new System.Windows.Forms.Label();
			this.panelContraolvidSeg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
			this.SuspendLayout();
			// 
			// panelContraolvidSeg
			// 
			this.panelContraolvidSeg.BackColor = System.Drawing.Color.White;
			this.panelContraolvidSeg.Controls.Add(this.pbLogoQRLogInSeg);
			this.panelContraolvidSeg.Controls.Add(this.bAceptar);
			this.panelContraolvidSeg.Controls.Add(this.bIrGmail);
			this.panelContraolvidSeg.Controls.Add(this.bVolver);
			this.panelContraolvidSeg.Controls.Add(this.lIndicacion);
			this.panelContraolvidSeg.Controls.Add(this.tbUsuarioCO);
			this.panelContraolvidSeg.Controls.Add(this.lCorreoCO);
			this.panelContraolvidSeg.Location = new System.Drawing.Point(225, 85);
			this.panelContraolvidSeg.Name = "panelContraolvidSeg";
			this.panelContraolvidSeg.Size = new System.Drawing.Size(271, 256);
			this.panelContraolvidSeg.TabIndex = 20;
			// 
			// pbLogoQRLogInSeg
			// 
			this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
			this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(32, 10);
			this.pbLogoQRLogInSeg.Name = "pbLogoQRLogInSeg";
			this.pbLogoQRLogInSeg.Size = new System.Drawing.Size(206, 72);
			this.pbLogoQRLogInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogoQRLogInSeg.TabIndex = 59;
			this.pbLogoQRLogInSeg.TabStop = false;
			// 
			// bAceptar
			// 
			this.bAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bAceptar.Location = new System.Drawing.Point(105, 214);
			this.bAceptar.Name = "bAceptar";
			this.bAceptar.Size = new System.Drawing.Size(61, 23);
			this.bAceptar.TabIndex = 18;
			this.bAceptar.Text = "Aceptar";
			this.bAceptar.UseVisualStyleBackColor = true;
			this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
			// 
			// bIrGmail
			// 
			this.bIrGmail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bIrGmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bIrGmail.Location = new System.Drawing.Point(172, 214);
			this.bIrGmail.Name = "bIrGmail";
			this.bIrGmail.Size = new System.Drawing.Size(61, 23);
			this.bIrGmail.TabIndex = 17;
			this.bIrGmail.Text = "Ir a Gmail";
			this.bIrGmail.UseVisualStyleBackColor = true;
			this.bIrGmail.Click += new System.EventHandler(this.bIrGmail_Click);
			// 
			// bVolver
			// 
			this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bVolver.Location = new System.Drawing.Point(35, 214);
			this.bVolver.Name = "bVolver";
			this.bVolver.Size = new System.Drawing.Size(61, 23);
			this.bVolver.TabIndex = 16;
			this.bVolver.Text = "Volver";
			this.bVolver.UseVisualStyleBackColor = true;
			this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
			// 
			// lIndicacion
			// 
			this.lIndicacion.BackColor = System.Drawing.Color.White;
			this.lIndicacion.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.lIndicacion.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lIndicacion.Location = new System.Drawing.Point(30, 136);
			this.lIndicacion.Name = "lIndicacion";
			this.lIndicacion.Size = new System.Drawing.Size(216, 62);
			this.lIndicacion.TabIndex = 15;
			this.lIndicacion.Text = "Esta opción le permite recuperar su contraseña, enviando un código de acceso a la" +
	" dirección de correo electrónico asociada al usuario ingresado. Su contaseña es " +
	"el código enviado.";
			// 
			// tbUsuarioCO
			// 
			this.tbUsuarioCO.AcceptsTab = true;
			this.tbUsuarioCO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbUsuarioCO.Location = new System.Drawing.Point(35, 103);
			this.tbUsuarioCO.Name = "tbUsuarioCO";
			this.tbUsuarioCO.Size = new System.Drawing.Size(195, 20);
			this.tbUsuarioCO.TabIndex = 13;
			// 
			// lCorreoCO
			// 
			this.lCorreoCO.AutoSize = true;
			this.lCorreoCO.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lCorreoCO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lCorreoCO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lCorreoCO.Location = new System.Drawing.Point(32, 85);
			this.lCorreoCO.Name = "lCorreoCO";
			this.lCorreoCO.Size = new System.Drawing.Size(97, 15);
			this.lCorreoCO.TabIndex = 14;
			this.lCorreoCO.Text = "Digite su Correo";
			// 
			// FRMContraOlvidadaPerReg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(721, 427);
			this.Controls.Add(this.panelContraolvidSeg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FRMContraOlvidadaPerReg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QR Parking | Personal Registro | Contraseña Olvidada";
			this.panelContraolvidSeg.ResumeLayout(false);
			this.panelContraolvidSeg.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelContraolvidSeg;
		private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
		private System.Windows.Forms.Button bAceptar;
		private System.Windows.Forms.Button bIrGmail;
		private System.Windows.Forms.Button bVolver;
		private System.Windows.Forms.Label lIndicacion;
		private System.Windows.Forms.TextBox tbUsuarioCO;
		private System.Windows.Forms.Label lCorreoCO;
	}
}