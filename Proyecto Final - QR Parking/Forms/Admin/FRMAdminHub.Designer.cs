namespace Proyecto_Final___QR_Parking.Admin
{
    partial class FRMAdminHub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAdminHub));
			this.lDatosPersonal = new System.Windows.Forms.Label();
			this.lBienvenidoPerReg = new System.Windows.Forms.Label();
			this.msAdminHub = new System.Windows.Forms.MenuStrip();
			this.tsmicerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvPersonalRegistro = new System.Windows.Forms.DataGridView();
			this.dgvSeguridad = new System.Windows.Forms.DataGridView();
			this.lSeguridad = new System.Windows.Forms.Label();
			this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
			this.msAdminHub.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPersonalRegistro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeguridad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
			this.SuspendLayout();
			// 
			// lDatosPersonal
			// 
			this.lDatosPersonal.AutoSize = true;
			this.lDatosPersonal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lDatosPersonal.ForeColor = System.Drawing.Color.DarkCyan;
			this.lDatosPersonal.Location = new System.Drawing.Point(15, 140);
			this.lDatosPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lDatosPersonal.Name = "lDatosPersonal";
			this.lDatosPersonal.Size = new System.Drawing.Size(303, 30);
			this.lDatosPersonal.TabIndex = 77;
			this.lDatosPersonal.Text = "Cuentas del Personal Registro";
			// 
			// lBienvenidoPerReg
			// 
			this.lBienvenidoPerReg.AutoSize = true;
			this.lBienvenidoPerReg.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lBienvenidoPerReg.ForeColor = System.Drawing.Color.Turquoise;
			this.lBienvenidoPerReg.Location = new System.Drawing.Point(291, 67);
			this.lBienvenidoPerReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lBienvenidoPerReg.Name = "lBienvenidoPerReg";
			this.lBienvenidoPerReg.Size = new System.Drawing.Size(314, 37);
			this.lBienvenidoPerReg.TabIndex = 72;
			this.lBienvenidoPerReg.Text = "¡Bienvenid@ de vuelta!";
			// 
			// msAdminHub
			// 
			this.msAdminHub.BackColor = System.Drawing.Color.MediumTurquoise;
			this.msAdminHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmicerrarSesion});
			this.msAdminHub.Location = new System.Drawing.Point(0, 0);
			this.msAdminHub.Name = "msAdminHub";
			this.msAdminHub.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			this.msAdminHub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.msAdminHub.Size = new System.Drawing.Size(841, 31);
			this.msAdminHub.TabIndex = 78;
			this.msAdminHub.Text = "menuStrip1";
			// 
			// tsmicerrarSesion
			// 
			this.tsmicerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmicerrarSesion.ForeColor = System.Drawing.Color.Red;
			this.tsmicerrarSesion.Name = "tsmicerrarSesion";
			this.tsmicerrarSesion.Size = new System.Drawing.Size(119, 25);
			this.tsmicerrarSesion.Text = "Cerrar Sesión";
			this.tsmicerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.tsmicerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
			// 
			// dgvPersonalRegistro
			// 
			this.dgvPersonalRegistro.AllowUserToAddRows = false;
			this.dgvPersonalRegistro.AllowUserToDeleteRows = false;
			this.dgvPersonalRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPersonalRegistro.Location = new System.Drawing.Point(21, 183);
			this.dgvPersonalRegistro.Margin = new System.Windows.Forms.Padding(4);
			this.dgvPersonalRegistro.Name = "dgvPersonalRegistro";
			this.dgvPersonalRegistro.ReadOnly = true;
			this.dgvPersonalRegistro.Size = new System.Drawing.Size(797, 156);
			this.dgvPersonalRegistro.TabIndex = 79;
			// 
			// dgvSeguridad
			// 
			this.dgvSeguridad.AllowUserToAddRows = false;
			this.dgvSeguridad.AllowUserToDeleteRows = false;
			this.dgvSeguridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeguridad.Location = new System.Drawing.Point(21, 386);
			this.dgvSeguridad.Margin = new System.Windows.Forms.Padding(4);
			this.dgvSeguridad.Name = "dgvSeguridad";
			this.dgvSeguridad.ReadOnly = true;
			this.dgvSeguridad.Size = new System.Drawing.Size(797, 156);
			this.dgvSeguridad.TabIndex = 81;
			// 
			// lSeguridad
			// 
			this.lSeguridad.AutoSize = true;
			this.lSeguridad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lSeguridad.ForeColor = System.Drawing.Color.DarkCyan;
			this.lSeguridad.Location = new System.Drawing.Point(15, 343);
			this.lSeguridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lSeguridad.Name = "lSeguridad";
			this.lSeguridad.Size = new System.Drawing.Size(283, 30);
			this.lSeguridad.TabIndex = 80;
			this.lSeguridad.Text = "Cuentas de Seguridad UAM";
			// 
			// pbLogoQRLogInSeg
			// 
			this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
			this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(20, 35);
			this.pbLogoQRLogInSeg.Margin = new System.Windows.Forms.Padding(4);
			this.pbLogoQRLogInSeg.Name = "pbLogoQRLogInSeg";
			this.pbLogoQRLogInSeg.Size = new System.Drawing.Size(240, 94);
			this.pbLogoQRLogInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogoQRLogInSeg.TabIndex = 72;
			this.pbLogoQRLogInSeg.TabStop = false;
			// 
			// FRMAdminHub
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(841, 558);
			this.Controls.Add(this.pbLogoQRLogInSeg);
			this.Controls.Add(this.dgvSeguridad);
			this.Controls.Add(this.lBienvenidoPerReg);
			this.Controls.Add(this.lSeguridad);
			this.Controls.Add(this.dgvPersonalRegistro);
			this.Controls.Add(this.msAdminHub);
			this.Controls.Add(this.lDatosPersonal);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FRMAdminHub";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QR Parking | Administrador";
			this.Load += new System.EventHandler(this.FRMAdminHub_Load);
			this.msAdminHub.ResumeLayout(false);
			this.msAdminHub.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPersonalRegistro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeguridad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDatosPersonal;
        private System.Windows.Forms.Label lBienvenidoPerReg;
        private System.Windows.Forms.MenuStrip msAdminHub;
        private System.Windows.Forms.ToolStripMenuItem tsmicerrarSesion;
        private System.Windows.Forms.DataGridView dgvPersonalRegistro;
        private System.Windows.Forms.DataGridView dgvSeguridad;
        private System.Windows.Forms.Label lSeguridad;
		private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
	}
}