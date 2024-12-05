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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
            this.lBienvenidoPerReg = new System.Windows.Forms.Label();
            this.msAdminHub = new System.Windows.Forms.MenuStrip();
            this.tsmicerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPersonalRegistro = new System.Windows.Forms.DataGridView();
            this.dgvSeguridad = new System.Windows.Forms.DataGridView();
            this.lSeguridad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
            this.msAdminHub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguridad)).BeginInit();
            this.SuspendLayout();
            // 
            // lDatosPersonal
            // 
            this.lDatosPersonal.AutoSize = true;
            this.lDatosPersonal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatosPersonal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lDatosPersonal.Location = new System.Drawing.Point(13, 107);
            this.lDatosPersonal.Name = "lDatosPersonal";
            this.lDatosPersonal.Size = new System.Drawing.Size(303, 30);
            this.lDatosPersonal.TabIndex = 77;
            this.lDatosPersonal.Text = "Cuentas del Personal Registro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbLogoQRLogInSeg);
            this.panel1.Controls.Add(this.lBienvenidoPerReg);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 70);
            this.panel1.TabIndex = 75;
            // 
            // pbLogoQRLogInSeg
            // 
            this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
            this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(3, 0);
            this.pbLogoQRLogInSeg.Name = "pbLogoQRLogInSeg";
            this.pbLogoQRLogInSeg.Size = new System.Drawing.Size(206, 72);
            this.pbLogoQRLogInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoQRLogInSeg.TabIndex = 72;
            this.pbLogoQRLogInSeg.TabStop = false;
            // 
            // lBienvenidoPerReg
            // 
            this.lBienvenidoPerReg.AutoSize = true;
            this.lBienvenidoPerReg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBienvenidoPerReg.ForeColor = System.Drawing.Color.Turquoise;
            this.lBienvenidoPerReg.Location = new System.Drawing.Point(224, 17);
            this.lBienvenidoPerReg.Name = "lBienvenidoPerReg";
            this.lBienvenidoPerReg.Size = new System.Drawing.Size(226, 30);
            this.lBienvenidoPerReg.TabIndex = 72;
            this.lBienvenidoPerReg.Text = "Bienvenid@ de vuelta";
            // 
            // msAdminHub
            // 
            this.msAdminHub.BackColor = System.Drawing.Color.MediumTurquoise;
            this.msAdminHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmicerrarSesion});
            this.msAdminHub.Location = new System.Drawing.Point(0, 0);
            this.msAdminHub.Name = "msAdminHub";
            this.msAdminHub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msAdminHub.Size = new System.Drawing.Size(721, 29);
            this.msAdminHub.TabIndex = 78;
            this.msAdminHub.Text = "menuStrip1";
            // 
            // tsmicerrarSesion
            // 
            this.tsmicerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmicerrarSesion.ForeColor = System.Drawing.Color.DarkRed;
            this.tsmicerrarSesion.Name = "tsmicerrarSesion";
            this.tsmicerrarSesion.Size = new System.Drawing.Size(119, 25);
            this.tsmicerrarSesion.Text = "Cerrar Sesión";
            this.tsmicerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsmicerrarSesion.Click += new System.EventHandler(this.tsmicerrarSesion_Click);
            // 
            // dgvPersonalRegistro
            // 
            this.dgvPersonalRegistro.AllowUserToAddRows = false;
            this.dgvPersonalRegistro.AllowUserToDeleteRows = false;
            this.dgvPersonalRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalRegistro.Location = new System.Drawing.Point(18, 140);
            this.dgvPersonalRegistro.Name = "dgvPersonalRegistro";
            this.dgvPersonalRegistro.ReadOnly = true;
            this.dgvPersonalRegistro.Size = new System.Drawing.Size(683, 119);
            this.dgvPersonalRegistro.TabIndex = 79;
            // 
            // dgvSeguridad
            // 
            this.dgvSeguridad.AllowUserToAddRows = false;
            this.dgvSeguridad.AllowUserToDeleteRows = false;
            this.dgvSeguridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguridad.Location = new System.Drawing.Point(18, 295);
            this.dgvSeguridad.Name = "dgvSeguridad";
            this.dgvSeguridad.ReadOnly = true;
            this.dgvSeguridad.Size = new System.Drawing.Size(683, 119);
            this.dgvSeguridad.TabIndex = 81;
            // 
            // lSeguridad
            // 
            this.lSeguridad.AutoSize = true;
            this.lSeguridad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeguridad.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSeguridad.Location = new System.Drawing.Point(13, 262);
            this.lSeguridad.Name = "lSeguridad";
            this.lSeguridad.Size = new System.Drawing.Size(283, 30);
            this.lSeguridad.TabIndex = 80;
            this.lSeguridad.Text = "Cuentas de Seguridad UAM";
            // 
            // FRMAdminHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 427);
            this.Controls.Add(this.dgvSeguridad);
            this.Controls.Add(this.lSeguridad);
            this.Controls.Add(this.dgvPersonalRegistro);
            this.Controls.Add(this.msAdminHub);
            this.Controls.Add(this.lDatosPersonal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMAdminHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Parking | Administrador";
            this.Load += new System.EventHandler(this.FRMAdminHub_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).EndInit();
            this.msAdminHub.ResumeLayout(false);
            this.msAdminHub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDatosPersonal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
        private System.Windows.Forms.Label lBienvenidoPerReg;
        private System.Windows.Forms.MenuStrip msAdminHub;
        private System.Windows.Forms.ToolStripMenuItem tsmicerrarSesion;
        private System.Windows.Forms.DataGridView dgvPersonalRegistro;
        private System.Windows.Forms.DataGridView dgvSeguridad;
        private System.Windows.Forms.Label lSeguridad;
    }
}