namespace Proyecto_Final___QR_Parking.PersonalReg
{
	partial class FRMEditarRegistroQR
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
			this.bGuardar = new System.Windows.Forms.Button();
			this.panelArribaSignInPerReg = new System.Windows.Forms.Panel();
			this.lAgregarRegistro = new System.Windows.Forms.Label();
			this.panelAbajoSignInPerReg = new System.Windows.Forms.Panel();
			this.lQRCode = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
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
			this.pbCodigoQR = new System.Windows.Forms.PictureBox();
			this.bExportar = new System.Windows.Forms.Button();
			this.lQrGenerado = new System.Windows.Forms.Label();
			this.panelArribaSignInPerReg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCodigoQR)).BeginInit();
			this.SuspendLayout();
			// 
			// bGuardar
			// 
			this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.bGuardar.Location = new System.Drawing.Point(244, 409);
			this.bGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.bGuardar.Name = "bGuardar";
			this.bGuardar.Size = new System.Drawing.Size(108, 35);
			this.bGuardar.TabIndex = 96;
			this.bGuardar.Text = "Guardar";
			this.bGuardar.UseVisualStyleBackColor = true;
			this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
			// 
			// panelArribaSignInPerReg
			// 
			this.panelArribaSignInPerReg.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelArribaSignInPerReg.Controls.Add(this.lAgregarRegistro);
			this.panelArribaSignInPerReg.Location = new System.Drawing.Point(-9, -1);
			this.panelArribaSignInPerReg.Margin = new System.Windows.Forms.Padding(4);
			this.panelArribaSignInPerReg.Name = "panelArribaSignInPerReg";
			this.panelArribaSignInPerReg.Size = new System.Drawing.Size(826, 51);
			this.panelArribaSignInPerReg.TabIndex = 80;
			// 
			// lAgregarRegistro
			// 
			this.lAgregarRegistro.AutoSize = true;
			this.lAgregarRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
			this.lAgregarRegistro.Location = new System.Drawing.Point(59, 10);
			this.lAgregarRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lAgregarRegistro.Name = "lAgregarRegistro";
			this.lAgregarRegistro.Size = new System.Drawing.Size(177, 32);
			this.lAgregarRegistro.TabIndex = 8;
			this.lAgregarRegistro.Text = "Registro de QR";
			// 
			// panelAbajoSignInPerReg
			// 
			this.panelAbajoSignInPerReg.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelAbajoSignInPerReg.Location = new System.Drawing.Point(-9, 452);
			this.panelAbajoSignInPerReg.Margin = new System.Windows.Forms.Padding(4);
			this.panelAbajoSignInPerReg.Name = "panelAbajoSignInPerReg";
			this.panelAbajoSignInPerReg.Size = new System.Drawing.Size(826, 56);
			this.panelAbajoSignInPerReg.TabIndex = 79;
			// 
			// lQRCode
			// 
			this.lQRCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lQRCode.ForeColor = System.Drawing.Color.DarkCyan;
			this.lQRCode.Location = new System.Drawing.Point(462, 221);
			this.lQRCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lQRCode.Name = "lQRCode";
			this.lQRCode.Size = new System.Drawing.Size(286, 95);
			this.lQRCode.TabIndex = 98;
			this.lQRCode.Text = "Guarda la edición para mostrar el nuevo QR";
			this.lQRCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panel1.Location = new System.Drawing.Point(369, 37);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(16, 429);
			this.panel1.TabIndex = 128;
			// 
			// bVolverSignInPerReg
			// 
			this.bVolverSignInPerReg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bVolverSignInPerReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bVolverSignInPerReg.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.bVolverSignInPerReg.Location = new System.Drawing.Point(13, 409);
			this.bVolverSignInPerReg.Margin = new System.Windows.Forms.Padding(4);
			this.bVolverSignInPerReg.Name = "bVolverSignInPerReg";
			this.bVolverSignInPerReg.Size = new System.Drawing.Size(108, 35);
			this.bVolverSignInPerReg.TabIndex = 115;
			this.bVolverSignInPerReg.Text = "Volver";
			this.bVolverSignInPerReg.UseVisualStyleBackColor = true;
			// 
			// lFechaAg
			// 
			this.lFechaAg.AutoSize = true;
			this.lFechaAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lFechaAg.Location = new System.Drawing.Point(75, 349);
			this.lFechaAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lFechaAg.Name = "lFechaAg";
			this.lFechaAg.Size = new System.Drawing.Size(46, 17);
			this.lFechaAg.TabIndex = 127;
			this.lFechaAg.Text = "Fecha:";
			// 
			// dtpFechaAg
			// 
			this.dtpFechaAg.Enabled = false;
			this.dtpFechaAg.Location = new System.Drawing.Point(134, 349);
			this.dtpFechaAg.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFechaAg.MaxDate = new System.DateTime(2111, 1, 10, 0, 0, 0, 0);
			this.dtpFechaAg.MinDate = new System.DateTime(2024, 12, 1, 0, 0, 0, 0);
			this.dtpFechaAg.Name = "dtpFechaAg";
			this.dtpFechaAg.Size = new System.Drawing.Size(218, 25);
			this.dtpFechaAg.TabIndex = 126;
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
			this.cbTipoAg.Location = new System.Drawing.Point(134, 299);
			this.cbTipoAg.Margin = new System.Windows.Forms.Padding(4);
			this.cbTipoAg.Name = "cbTipoAg";
			this.cbTipoAg.Size = new System.Drawing.Size(218, 25);
			this.cbTipoAg.TabIndex = 125;
			// 
			// lTipoAg
			// 
			this.lTipoAg.AutoSize = true;
			this.lTipoAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lTipoAg.Location = new System.Drawing.Point(84, 299);
			this.lTipoAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lTipoAg.Name = "lTipoAg";
			this.lTipoAg.Size = new System.Drawing.Size(37, 17);
			this.lTipoAg.TabIndex = 124;
			this.lTipoAg.Text = "Tipo:";
			// 
			// tbPlacaAg
			// 
			this.tbPlacaAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPlacaAg.Enabled = false;
			this.tbPlacaAg.Location = new System.Drawing.Point(134, 251);
			this.tbPlacaAg.Margin = new System.Windows.Forms.Padding(4);
			this.tbPlacaAg.MaxLength = 8;
			this.tbPlacaAg.Name = "tbPlacaAg";
			this.tbPlacaAg.Size = new System.Drawing.Size(218, 25);
			this.tbPlacaAg.TabIndex = 119;
			this.tbPlacaAg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mtbCedulaAg
			// 
			this.mtbCedulaAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mtbCedulaAg.Enabled = false;
			this.mtbCedulaAg.Location = new System.Drawing.Point(134, 204);
			this.mtbCedulaAg.Margin = new System.Windows.Forms.Padding(4);
			this.mtbCedulaAg.Mask = "000-000000-0000L";
			this.mtbCedulaAg.Name = "mtbCedulaAg";
			this.mtbCedulaAg.Size = new System.Drawing.Size(218, 25);
			this.mtbCedulaAg.TabIndex = 118;
			this.mtbCedulaAg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbApellidosAg
			// 
			this.tbApellidosAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbApellidosAg.Enabled = false;
			this.tbApellidosAg.Location = new System.Drawing.Point(134, 158);
			this.tbApellidosAg.Margin = new System.Windows.Forms.Padding(4);
			this.tbApellidosAg.Name = "tbApellidosAg";
			this.tbApellidosAg.Size = new System.Drawing.Size(218, 25);
			this.tbApellidosAg.TabIndex = 117;
			this.tbApellidosAg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbNombresAg
			// 
			this.tbNombresAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbNombresAg.Enabled = false;
			this.tbNombresAg.Location = new System.Drawing.Point(134, 110);
			this.tbNombresAg.Margin = new System.Windows.Forms.Padding(4);
			this.tbNombresAg.Name = "tbNombresAg";
			this.tbNombresAg.Size = new System.Drawing.Size(218, 25);
			this.tbNombresAg.TabIndex = 116;
			this.tbNombresAg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lPlaca
			// 
			this.lPlaca.AutoSize = true;
			this.lPlaca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lPlaca.Location = new System.Drawing.Point(84, 251);
			this.lPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lPlaca.Name = "lPlaca";
			this.lPlaca.Size = new System.Drawing.Size(42, 17);
			this.lPlaca.TabIndex = 123;
			this.lPlaca.Text = "Placa:";
			// 
			// lCedulaAg
			// 
			this.lCedulaAg.AutoSize = true;
			this.lCedulaAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lCedulaAg.Location = new System.Drawing.Point(74, 204);
			this.lCedulaAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lCedulaAg.Name = "lCedulaAg";
			this.lCedulaAg.Size = new System.Drawing.Size(52, 17);
			this.lCedulaAg.TabIndex = 122;
			this.lCedulaAg.Text = "Cédula:";
			// 
			// lApellidosAg
			// 
			this.lApellidosAg.AutoSize = true;
			this.lApellidosAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lApellidosAg.Location = new System.Drawing.Point(60, 158);
			this.lApellidosAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lApellidosAg.Name = "lApellidosAg";
			this.lApellidosAg.Size = new System.Drawing.Size(66, 17);
			this.lApellidosAg.TabIndex = 121;
			this.lApellidosAg.Text = "Apellidos:";
			// 
			// lNombresAg
			// 
			this.lNombresAg.AutoSize = true;
			this.lNombresAg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lNombresAg.Location = new System.Drawing.Point(55, 110);
			this.lNombresAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lNombresAg.Name = "lNombresAg";
			this.lNombresAg.Size = new System.Drawing.Size(71, 17);
			this.lNombresAg.TabIndex = 120;
			this.lNombresAg.Text = "Nombres: ";
			// 
			// pbCodigoQR
			// 
			this.pbCodigoQR.Location = new System.Drawing.Point(403, 95);
			this.pbCodigoQR.Margin = new System.Windows.Forms.Padding(4);
			this.pbCodigoQR.Name = "pbCodigoQR";
			this.pbCodigoQR.Size = new System.Drawing.Size(391, 349);
			this.pbCodigoQR.TabIndex = 129;
			this.pbCodigoQR.TabStop = false;
			// 
			// bExportar
			// 
			this.bExportar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bExportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.bExportar.Location = new System.Drawing.Point(649, 58);
			this.bExportar.Margin = new System.Windows.Forms.Padding(4);
			this.bExportar.Name = "bExportar";
			this.bExportar.Size = new System.Drawing.Size(145, 35);
			this.bExportar.TabIndex = 131;
			this.bExportar.Text = "Exportar";
			this.bExportar.UseVisualStyleBackColor = true;
			// 
			// lQrGenerado
			// 
			this.lQrGenerado.AutoSize = true;
			this.lQrGenerado.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.lQrGenerado.Location = new System.Drawing.Point(398, 57);
			this.lQrGenerado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lQrGenerado.Name = "lQrGenerado";
			this.lQrGenerado.Size = new System.Drawing.Size(147, 30);
			this.lQrGenerado.TabIndex = 130;
			this.lQrGenerado.Text = "QR Generado";
			// 
			// FRMEditarRegistroQR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(807, 507);
			this.Controls.Add(this.pbCodigoQR);
			this.Controls.Add(this.bExportar);
			this.Controls.Add(this.lQrGenerado);
			this.Controls.Add(this.panel1);
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
			this.Controls.Add(this.lQRCode);
			this.Controls.Add(this.bGuardar);
			this.Controls.Add(this.panelArribaSignInPerReg);
			this.Controls.Add(this.panelAbajoSignInPerReg);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FRMEditarRegistroQR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FRMEditarRegistroQR";
			this.Load += new System.EventHandler(this.FRMEditarRegistroQR_Load);
			this.panelArribaSignInPerReg.ResumeLayout(false);
			this.panelArribaSignInPerReg.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCodigoQR)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button bGuardar;
		private System.Windows.Forms.Panel panelArribaSignInPerReg;
		private System.Windows.Forms.Label lAgregarRegistro;
		private System.Windows.Forms.Panel panelAbajoSignInPerReg;
		private System.Windows.Forms.Label lQRCode;
		private System.Windows.Forms.Panel panel1;
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
		private System.Windows.Forms.PictureBox pbCodigoQR;
		private System.Windows.Forms.Button bExportar;
		private System.Windows.Forms.Label lQrGenerado;
	}
}