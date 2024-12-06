namespace Proyecto_Final___QR_Parking.Seguridad
{
    partial class FRMSeguridadHub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSeguridadHub));
			this.panelAbajoSeguridad = new System.Windows.Forms.Panel();
			this.pbEscanea = new System.Windows.Forms.PictureBox();
			this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
			this.msSeguridadHub = new System.Windows.Forms.MenuStrip();
			this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
			this.bEscanear = new System.Windows.Forms.Button();
			this.panelSeparador = new System.Windows.Forms.Panel();
			this.lEscanea = new System.Windows.Forms.Label();
			this.lCamara = new System.Windows.Forms.Label();
			this.pbCamara = new System.Windows.Forms.PictureBox();
			this.bTerminar = new System.Windows.Forms.Button();
			this.lBienvenidoPerReg = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbEscanea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
			this.msSeguridadHub.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
			this.SuspendLayout();
			// 
			// panelAbajoSeguridad
			// 
			this.panelAbajoSeguridad.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelAbajoSeguridad.Location = new System.Drawing.Point(0, 370);
			this.panelAbajoSeguridad.Name = "panelAbajoSeguridad";
			this.panelAbajoSeguridad.Size = new System.Drawing.Size(721, 39);
			this.panelAbajoSeguridad.TabIndex = 25;
			// 
			// pbEscanea
			// 
			this.pbEscanea.Image = ((System.Drawing.Image)(resources.GetObject("pbEscanea.Image")));
			this.pbEscanea.Location = new System.Drawing.Point(29, 114);
			this.pbEscanea.Name = "pbEscanea";
			this.pbEscanea.Size = new System.Drawing.Size(217, 186);
			this.pbEscanea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbEscanea.TabIndex = 27;
			this.pbEscanea.TabStop = false;
			// 
			// pbLogoQRLogInSeg
			// 
			this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
			this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(515, 30);
			this.pbLogoQRLogInSeg.Name = "pbLogoQRLogInSeg";
			this.pbLogoQRLogInSeg.Size = new System.Drawing.Size(206, 72);
			this.pbLogoQRLogInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogoQRLogInSeg.TabIndex = 72;
			this.pbLogoQRLogInSeg.TabStop = false;
			// 
			// msSeguridadHub
			// 
			this.msSeguridadHub.BackColor = System.Drawing.Color.MediumTurquoise;
			this.msSeguridadHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion});
			this.msSeguridadHub.Location = new System.Drawing.Point(0, 0);
			this.msSeguridadHub.Name = "msSeguridadHub";
			this.msSeguridadHub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.msSeguridadHub.Size = new System.Drawing.Size(721, 29);
			this.msSeguridadHub.TabIndex = 73;
			this.msSeguridadHub.Text = "menuStrip1";
			// 
			// tsmiCerrarSesion
			// 
			this.tsmiCerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiCerrarSesion.ForeColor = System.Drawing.Color.Red;
			this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
			this.tsmiCerrarSesion.Size = new System.Drawing.Size(119, 25);
			this.tsmiCerrarSesion.Text = "Cerrar Sesión";
			this.tsmiCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
			// 
			// bEscanear
			// 
			this.bEscanear.BackColor = System.Drawing.Color.LightCyan;
			this.bEscanear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bEscanear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bEscanear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.bEscanear.Location = new System.Drawing.Point(29, 306);
			this.bEscanear.Name = "bEscanear";
			this.bEscanear.Size = new System.Drawing.Size(217, 51);
			this.bEscanear.TabIndex = 0;
			this.bEscanear.Text = "Escanea";
			this.bEscanear.UseVisualStyleBackColor = false;
			this.bEscanear.Click += new System.EventHandler(this.bEscanear_Click);
			// 
			// panelSeparador
			// 
			this.panelSeparador.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelSeparador.Location = new System.Drawing.Point(279, 121);
			this.panelSeparador.Name = "panelSeparador";
			this.panelSeparador.Size = new System.Drawing.Size(10, 230);
			this.panelSeparador.TabIndex = 75;
			// 
			// lEscanea
			// 
			this.lEscanea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lEscanea.ForeColor = System.Drawing.Color.DarkCyan;
			this.lEscanea.Location = new System.Drawing.Point(335, 194);
			this.lEscanea.Name = "lEscanea";
			this.lEscanea.Size = new System.Drawing.Size(350, 28);
			this.lEscanea.TabIndex = 76;
			this.lEscanea.Text = "Haga click en \"Escanea\" para abrir la cámara";
			this.lEscanea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lCamara
			// 
			this.lCamara.AutoSize = true;
			this.lCamara.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
			this.lCamara.Location = new System.Drawing.Point(387, 86);
			this.lCamara.Name = "lCamara";
			this.lCamara.Size = new System.Drawing.Size(78, 25);
			this.lCamara.TabIndex = 78;
			this.lCamara.Text = "Cámara";
			this.lCamara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbCamara
			// 
			this.pbCamara.Cursor = System.Windows.Forms.Cursors.No;
			this.pbCamara.Location = new System.Drawing.Point(318, 114);
			this.pbCamara.Name = "pbCamara";
			this.pbCamara.Size = new System.Drawing.Size(377, 186);
			this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbCamara.TabIndex = 77;
			this.pbCamara.TabStop = false;
			// 
			// bTerminar
			// 
			this.bTerminar.BackColor = System.Drawing.Color.LightCyan;
			this.bTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bTerminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.bTerminar.Location = new System.Drawing.Point(318, 306);
			this.bTerminar.Name = "bTerminar";
			this.bTerminar.Size = new System.Drawing.Size(377, 51);
			this.bTerminar.TabIndex = 1;
			this.bTerminar.Text = "Terminar";
			this.bTerminar.UseVisualStyleBackColor = false;
			this.bTerminar.Click += new System.EventHandler(this.bTerminar_Click);
			// 
			// lBienvenidoPerReg
			// 
			this.lBienvenidoPerReg.AutoSize = true;
			this.lBienvenidoPerReg.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lBienvenidoPerReg.ForeColor = System.Drawing.Color.Turquoise;
			this.lBienvenidoPerReg.Location = new System.Drawing.Point(22, 49);
			this.lBienvenidoPerReg.Name = "lBienvenidoPerReg";
			this.lBienvenidoPerReg.Size = new System.Drawing.Size(314, 37);
			this.lBienvenidoPerReg.TabIndex = 72;
			this.lBienvenidoPerReg.Text = "¡Bienvenid@ de vuelta!";
			this.lBienvenidoPerReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FRMSeguridadHub
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(721, 405);
			this.Controls.Add(this.pbCamara);
			this.Controls.Add(this.bTerminar);
			this.Controls.Add(this.lBienvenidoPerReg);
			this.Controls.Add(this.pbLogoQRLogInSeg);
			this.Controls.Add(this.lCamara);
			this.Controls.Add(this.lEscanea);
			this.Controls.Add(this.panelSeparador);
			this.Controls.Add(this.bEscanear);
			this.Controls.Add(this.msSeguridadHub);
			this.Controls.Add(this.pbEscanea);
			this.Controls.Add(this.panelAbajoSeguridad);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FRMSeguridadHub";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QR Parking | Seguridad";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMSeguridadHub_FormClosing);
			this.Load += new System.EventHandler(this.FRMSeguridadHub_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbEscanea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).EndInit();
			this.msSeguridadHub.ResumeLayout(false);
			this.msSeguridadHub.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelAbajoSeguridad;
        private System.Windows.Forms.PictureBox pbEscanea;
        private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
        private System.Windows.Forms.MenuStrip msSeguridadHub;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.Button bEscanear;
        private System.Windows.Forms.Panel panelSeparador;
        private System.Windows.Forms.Label lEscanea;
        private System.Windows.Forms.Label lCamara;
        private System.Windows.Forms.PictureBox pbCamara;
        private System.Windows.Forms.Button bTerminar;
		private System.Windows.Forms.Label lBienvenidoPerReg;
	}
}