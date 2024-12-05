namespace Proyecto_Final___QR_Parking.PersonalReg
{
	partial class FRMMostrarRegistroQR
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMostrarRegistroQR));
			this.bExportar = new System.Windows.Forms.Button();
			this.lQrGenerado = new System.Windows.Forms.Label();
			this.pbCodigoQR = new System.Windows.Forms.PictureBox();
			this.panelSeparador = new System.Windows.Forms.Panel();
			this.bVolverSignInPerReg = new System.Windows.Forms.Button();
			this.lFechaAg = new System.Windows.Forms.Label();
			this.dtpFechaAg = new System.Windows.Forms.DateTimePicker();
			this.cbTipoAg = new System.Windows.Forms.ComboBox();
			this.lTipoAg = new System.Windows.Forms.Label();
			this.tbPlacaAg = new System.Windows.Forms.TextBox();
			this.mtbCedulaAg = new System.Windows.Forms.MaskedTextBox();
			this.tbApellidosAg = new System.Windows.Forms.TextBox();
			this.tbNombresAg = new System.Windows.Forms.TextBox();
			this.lPlaca = new System.Windows.Forms.Label();
			this.lCedulaAg = new System.Windows.Forms.Label();
			this.lApellidosAg = new System.Windows.Forms.Label();
			this.lNombresAg = new System.Windows.Forms.Label();
			this.panelArribaSignInPerReg = new System.Windows.Forms.Panel();
			this.pbLogoQRParking = new System.Windows.Forms.PictureBox();
			this.lAgregarRegistro = new System.Windows.Forms.Label();
			this.panelAbajoSignInPerReg = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbCodigoQR)).BeginInit();
			this.panelArribaSignInPerReg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRParking)).BeginInit();
			this.SuspendLayout();
			// 
			// bExportar
			// 
			this.bExportar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bExportar.Location = new System.Drawing.Point(524, 300);
			this.bExportar.Name = "bExportar";
			this.bExportar.Size = new System.Drawing.Size(124, 27);
			this.bExportar.TabIndex = 118;
			this.bExportar.Text = "Exportar";
			this.bExportar.UseVisualStyleBackColor = true;
			this.bExportar.Click += new System.EventHandler(this.bExportar_Click);
			// 
			// lQrGenerado
			// 
			this.lQrGenerado.AutoSize = true;
			this.lQrGenerado.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lQrGenerado.Location = new System.Drawing.Point(419, 41);
			this.lQrGenerado.Name = "lQrGenerado";
			this.lQrGenerado.Size = new System.Drawing.Size(180, 37);
			this.lQrGenerado.TabIndex = 116;
			this.lQrGenerado.Text = "QR Generado";
			// 
			// pbCodigoQR
			// 
			this.pbCodigoQR.Location = new System.Drawing.Point(426, 81);
			this.pbCodigoQR.Name = "pbCodigoQR";
			this.pbCodigoQR.Size = new System.Drawing.Size(222, 200);
			this.pbCodigoQR.TabIndex = 115;
			this.pbCodigoQR.TabStop = false;
			// 
			// panelSeparador
			// 
			this.panelSeparador.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelSeparador.Location = new System.Drawing.Point(368, 38);
			this.panelSeparador.Name = "panelSeparador";
			this.panelSeparador.Size = new System.Drawing.Size(10, 323);
			this.panelSeparador.TabIndex = 114;
			// 
			// bVolverSignInPerReg
			// 
			this.bVolverSignInPerReg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bVolverSignInPerReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bVolverSignInPerReg.Location = new System.Drawing.Point(29, 300);
			this.bVolverSignInPerReg.Name = "bVolverSignInPerReg";
			this.bVolverSignInPerReg.Size = new System.Drawing.Size(93, 27);
			this.bVolverSignInPerReg.TabIndex = 99;
			this.bVolverSignInPerReg.Text = "Volver";
			this.bVolverSignInPerReg.UseVisualStyleBackColor = true;
			this.bVolverSignInPerReg.Click += new System.EventHandler(this.bVolverSignInPerReg_Click);
			// 
			// lFechaAg
			// 
			this.lFechaAg.AutoSize = true;
			this.lFechaAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lFechaAg.Location = new System.Drawing.Point(26, 259);
			this.lFechaAg.Name = "lFechaAg";
			this.lFechaAg.Size = new System.Drawing.Size(46, 17);
			this.lFechaAg.TabIndex = 113;
			this.lFechaAg.Text = "Fecha:";
			// 
			// dtpFechaAg
			// 
			this.dtpFechaAg.Enabled = false;
			this.dtpFechaAg.Location = new System.Drawing.Point(151, 259);
			this.dtpFechaAg.MaxDate = new System.DateTime(2111, 1, 10, 0, 0, 0, 0);
			this.dtpFechaAg.MinDate = new System.DateTime(2024, 12, 1, 0, 0, 0, 0);
			this.dtpFechaAg.Name = "dtpFechaAg";
			this.dtpFechaAg.Size = new System.Drawing.Size(187, 20);
			this.dtpFechaAg.TabIndex = 112;
			this.dtpFechaAg.Value = new System.DateTime(2024, 12, 3, 20, 11, 30, 0);
			// 
			// cbTipoAg
			// 
			this.cbTipoAg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoAg.Enabled = false;
			this.cbTipoAg.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbTipoAg.FormattingEnabled = true;
			this.cbTipoAg.Items.AddRange(new object[] {
			"Visitante",
			"Colaborador",
			"Estudiante"});
			this.cbTipoAg.Location = new System.Drawing.Point(151, 219);
			this.cbTipoAg.Name = "cbTipoAg";
			this.cbTipoAg.Size = new System.Drawing.Size(187, 21);
			this.cbTipoAg.TabIndex = 111;
			// 
			// lTipoAg
			// 
			this.lTipoAg.AutoSize = true;
			this.lTipoAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lTipoAg.Location = new System.Drawing.Point(26, 219);
			this.lTipoAg.Name = "lTipoAg";
			this.lTipoAg.Size = new System.Drawing.Size(37, 17);
			this.lTipoAg.TabIndex = 110;
			this.lTipoAg.Text = "Tipo:";
			// 
			// tbPlacaAg
			// 
			this.tbPlacaAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPlacaAg.Enabled = false;
			this.tbPlacaAg.Location = new System.Drawing.Point(151, 182);
			this.tbPlacaAg.MaxLength = 8;
			this.tbPlacaAg.Name = "tbPlacaAg";
			this.tbPlacaAg.Size = new System.Drawing.Size(187, 20);
			this.tbPlacaAg.TabIndex = 105;
			// 
			// mtbCedulaAg
			// 
			this.mtbCedulaAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mtbCedulaAg.Enabled = false;
			this.mtbCedulaAg.Location = new System.Drawing.Point(151, 146);
			this.mtbCedulaAg.Mask = "000-000000-0000L";
			this.mtbCedulaAg.Name = "mtbCedulaAg";
			this.mtbCedulaAg.Size = new System.Drawing.Size(187, 20);
			this.mtbCedulaAg.TabIndex = 104;
			// 
			// tbApellidosAg
			// 
			this.tbApellidosAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbApellidosAg.Enabled = false;
			this.tbApellidosAg.Location = new System.Drawing.Point(151, 111);
			this.tbApellidosAg.Name = "tbApellidosAg";
			this.tbApellidosAg.Size = new System.Drawing.Size(187, 20);
			this.tbApellidosAg.TabIndex = 103;
			// 
			// tbNombresAg
			// 
			this.tbNombresAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbNombresAg.Enabled = false;
			this.tbNombresAg.Location = new System.Drawing.Point(151, 69);
			this.tbNombresAg.Name = "tbNombresAg";
			this.tbNombresAg.Size = new System.Drawing.Size(187, 20);
			this.tbNombresAg.TabIndex = 102;
			// 
			// lPlaca
			// 
			this.lPlaca.AutoSize = true;
			this.lPlaca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lPlaca.Location = new System.Drawing.Point(26, 182);
			this.lPlaca.Name = "lPlaca";
			this.lPlaca.Size = new System.Drawing.Size(42, 17);
			this.lPlaca.TabIndex = 109;
			this.lPlaca.Text = "Placa:";
			// 
			// lCedulaAg
			// 
			this.lCedulaAg.AutoSize = true;
			this.lCedulaAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lCedulaAg.Location = new System.Drawing.Point(26, 146);
			this.lCedulaAg.Name = "lCedulaAg";
			this.lCedulaAg.Size = new System.Drawing.Size(52, 17);
			this.lCedulaAg.TabIndex = 108;
			this.lCedulaAg.Text = "Cédula:";
			// 
			// lApellidosAg
			// 
			this.lApellidosAg.AutoSize = true;
			this.lApellidosAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lApellidosAg.Location = new System.Drawing.Point(26, 107);
			this.lApellidosAg.Name = "lApellidosAg";
			this.lApellidosAg.Size = new System.Drawing.Size(66, 17);
			this.lApellidosAg.TabIndex = 107;
			this.lApellidosAg.Text = "Apellidos:";
			// 
			// lNombresAg
			// 
			this.lNombresAg.AutoSize = true;
			this.lNombresAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lNombresAg.Location = new System.Drawing.Point(26, 69);
			this.lNombresAg.Name = "lNombresAg";
			this.lNombresAg.Size = new System.Drawing.Size(71, 17);
			this.lNombresAg.TabIndex = 106;
			this.lNombresAg.Text = "Nombres: ";
			// 
			// panelArribaSignInPerReg
			// 
			this.panelArribaSignInPerReg.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelArribaSignInPerReg.Controls.Add(this.pbLogoQRParking);
			this.panelArribaSignInPerReg.Controls.Add(this.lAgregarRegistro);
			this.panelArribaSignInPerReg.Location = new System.Drawing.Point(-8, -1);
			this.panelArribaSignInPerReg.Name = "panelArribaSignInPerReg";
			this.panelArribaSignInPerReg.Size = new System.Drawing.Size(708, 39);
			this.panelArribaSignInPerReg.TabIndex = 101;
			// 
			// pbLogoQRParking
			// 
			this.pbLogoQRParking.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRParking.Image")));
			this.pbLogoQRParking.Location = new System.Drawing.Point(12, -1);
			this.pbLogoQRParking.Name = "pbLogoQRParking";
			this.pbLogoQRParking.Size = new System.Drawing.Size(77, 38);
			this.pbLogoQRParking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogoQRParking.TabIndex = 7;
			this.pbLogoQRParking.TabStop = false;
			// 
			// lAgregarRegistro
			// 
			this.lAgregarRegistro.AutoSize = true;
			this.lAgregarRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lAgregarRegistro.Location = new System.Drawing.Point(86, -1);
			this.lAgregarRegistro.Name = "lAgregarRegistro";
			this.lAgregarRegistro.Size = new System.Drawing.Size(199, 37);
			this.lAgregarRegistro.TabIndex = 8;
			this.lAgregarRegistro.Text = "Registro de QR";
			// 
			// panelAbajoSignInPerReg
			// 
			this.panelAbajoSignInPerReg.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelAbajoSignInPerReg.Location = new System.Drawing.Point(-8, 346);
			this.panelAbajoSignInPerReg.Name = "panelAbajoSignInPerReg";
			this.panelAbajoSignInPerReg.Size = new System.Drawing.Size(708, 43);
			this.panelAbajoSignInPerReg.TabIndex = 100;
			// 
			// FRMMostrarRegistroQR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(692, 388);
			this.Controls.Add(this.bExportar);
			this.Controls.Add(this.lQrGenerado);
			this.Controls.Add(this.pbCodigoQR);
			this.Controls.Add(this.panelSeparador);
			this.Controls.Add(this.bVolverSignInPerReg);
			this.Controls.Add(this.lFechaAg);
			this.Controls.Add(this.dtpFechaAg);
			this.Controls.Add(this.cbTipoAg);
			this.Controls.Add(this.lTipoAg);
			this.Controls.Add(this.tbPlacaAg);
			this.Controls.Add(this.mtbCedulaAg);
			this.Controls.Add(this.tbApellidosAg);
			this.Controls.Add(this.tbNombresAg);
			this.Controls.Add(this.lPlaca);
			this.Controls.Add(this.lCedulaAg);
			this.Controls.Add(this.lApellidosAg);
			this.Controls.Add(this.lNombresAg);
			this.Controls.Add(this.panelArribaSignInPerReg);
			this.Controls.Add(this.panelAbajoSignInPerReg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FRMMostrarRegistroQR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FRMMostrarRegistroQR";
			this.Load += new System.EventHandler(this.FRMMostrarRegistroQR_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbCodigoQR)).EndInit();
			this.panelArribaSignInPerReg.ResumeLayout(false);
			this.panelArribaSignInPerReg.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRParking)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button bExportar;
		private System.Windows.Forms.Label lQrGenerado;
		private System.Windows.Forms.PictureBox pbCodigoQR;
		private System.Windows.Forms.Panel panelSeparador;
		private System.Windows.Forms.Button bVolverSignInPerReg;
		private System.Windows.Forms.Label lFechaAg;
		private System.Windows.Forms.DateTimePicker dtpFechaAg;
		private System.Windows.Forms.ComboBox cbTipoAg;
		private System.Windows.Forms.Label lTipoAg;
		private System.Windows.Forms.TextBox tbPlacaAg;
		private System.Windows.Forms.MaskedTextBox mtbCedulaAg;
		private System.Windows.Forms.TextBox tbApellidosAg;
		private System.Windows.Forms.TextBox tbNombresAg;
		private System.Windows.Forms.Label lPlaca;
		private System.Windows.Forms.Label lCedulaAg;
		private System.Windows.Forms.Label lApellidosAg;
		private System.Windows.Forms.Label lNombresAg;
		private System.Windows.Forms.Panel panelArribaSignInPerReg;
		private System.Windows.Forms.PictureBox pbLogoQRParking;
		private System.Windows.Forms.Label lAgregarRegistro;
		private System.Windows.Forms.Panel panelAbajoSignInPerReg;
	}
}