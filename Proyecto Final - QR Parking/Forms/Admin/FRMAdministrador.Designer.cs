namespace Proyecto_Final___QR_Parking.Admin
{
    partial class FRMAdministrador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAdministrador));
			this.bIniciarSesionAdmin = new System.Windows.Forms.Button();
			this.pbLogoQRSignInSeg = new System.Windows.Forms.PictureBox();
			this.mtbContraAdmin = new System.Windows.Forms.MaskedTextBox();
			this.tbCorreoAdmin = new System.Windows.Forms.TextBox();
			this.lContrasenaLogInPerReg = new System.Windows.Forms.Label();
			this.lCorreoLogInPerReg = new System.Windows.Forms.Label();
			this.panelArribaSeguridad = new System.Windows.Forms.Panel();
			this.lLogInAdmin = new System.Windows.Forms.Label();
			this.panelAbajoSeguridad = new System.Windows.Forms.Panel();
			this.bVolverLogInPerReg = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lIndicacion = new System.Windows.Forms.Label();
			this.cbVerOcultarLogInAdmin = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRSignInSeg)).BeginInit();
			this.panelArribaSeguridad.SuspendLayout();
			this.panelAbajoSeguridad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bIniciarSesionAdmin
			// 
			this.bIniciarSesionAdmin.BackColor = System.Drawing.Color.LightCyan;
			this.bIniciarSesionAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bIniciarSesionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bIniciarSesionAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.bIniciarSesionAdmin.Location = new System.Drawing.Point(856, 392);
			this.bIniciarSesionAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.bIniciarSesionAdmin.Name = "bIniciarSesionAdmin";
			this.bIniciarSesionAdmin.Size = new System.Drawing.Size(154, 50);
			this.bIniciarSesionAdmin.TabIndex = 3;
			this.bIniciarSesionAdmin.Text = "Inicia Sesión";
			this.bIniciarSesionAdmin.UseVisualStyleBackColor = false;
			this.bIniciarSesionAdmin.Click += new System.EventHandler(this.bIniciarSesionPerReg_Click);
			// 
			// pbLogoQRSignInSeg
			// 
			this.pbLogoQRSignInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRSignInSeg.Image")));
			this.pbLogoQRSignInSeg.Location = new System.Drawing.Point(774, 122);
			this.pbLogoQRSignInSeg.Margin = new System.Windows.Forms.Padding(4);
			this.pbLogoQRSignInSeg.Name = "pbLogoQRSignInSeg";
			this.pbLogoQRSignInSeg.Size = new System.Drawing.Size(272, 106);
			this.pbLogoQRSignInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogoQRSignInSeg.TabIndex = 85;
			this.pbLogoQRSignInSeg.TabStop = false;
			// 
			// mtbContraAdmin
			// 
			this.mtbContraAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mtbContraAdmin.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.mtbContraAdmin.Location = new System.Drawing.Point(827, 347);
			this.mtbContraAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.mtbContraAdmin.Name = "mtbContraAdmin";
			this.mtbContraAdmin.Size = new System.Drawing.Size(218, 22);
			this.mtbContraAdmin.TabIndex = 1;
			// 
			// tbCorreoAdmin
			// 
			this.tbCorreoAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCorreoAdmin.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.tbCorreoAdmin.Location = new System.Drawing.Point(827, 300);
			this.tbCorreoAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.tbCorreoAdmin.Name = "tbCorreoAdmin";
			this.tbCorreoAdmin.Size = new System.Drawing.Size(218, 22);
			this.tbCorreoAdmin.TabIndex = 0;
			// 
			// lContrasenaLogInPerReg
			// 
			this.lContrasenaLogInPerReg.AutoSize = true;
			this.lContrasenaLogInPerReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lContrasenaLogInPerReg.Location = new System.Drawing.Point(744, 347);
			this.lContrasenaLogInPerReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lContrasenaLogInPerReg.Name = "lContrasenaLogInPerReg";
			this.lContrasenaLogInPerReg.Size = new System.Drawing.Size(84, 17);
			this.lContrasenaLogInPerReg.TabIndex = 84;
			this.lContrasenaLogInPerReg.Text = "Contraseña: ";
			// 
			// lCorreoLogInPerReg
			// 
			this.lCorreoLogInPerReg.AutoSize = true;
			this.lCorreoLogInPerReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lCorreoLogInPerReg.Location = new System.Drawing.Point(702, 300);
			this.lCorreoLogInPerReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lCorreoLogInPerReg.Name = "lCorreoLogInPerReg";
			this.lCorreoLogInPerReg.Size = new System.Drawing.Size(122, 17);
			this.lCorreoLogInPerReg.TabIndex = 83;
			this.lCorreoLogInPerReg.Text = "Correo Electrónico:";
			// 
			// panelArribaSeguridad
			// 
			this.panelArribaSeguridad.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelArribaSeguridad.Controls.Add(this.lLogInAdmin);
			this.panelArribaSeguridad.Location = new System.Drawing.Point(0, -1);
			this.panelArribaSeguridad.Margin = new System.Windows.Forms.Padding(4);
			this.panelArribaSeguridad.Name = "panelArribaSeguridad";
			this.panelArribaSeguridad.Size = new System.Drawing.Size(1128, 51);
			this.panelArribaSeguridad.TabIndex = 82;
			// 
			// lLogInAdmin
			// 
			this.lLogInAdmin.AutoSize = true;
			this.lLogInAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
			this.lLogInAdmin.Location = new System.Drawing.Point(143, 9);
			this.lLogInAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lLogInAdmin.Name = "lLogInAdmin";
			this.lLogInAdmin.Size = new System.Drawing.Size(386, 32);
			this.lLogInAdmin.TabIndex = 8;
			this.lLogInAdmin.Text = "Iniciar Sesión como Administrador";
			// 
			// panelAbajoSeguridad
			// 
			this.panelAbajoSeguridad.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panelAbajoSeguridad.Controls.Add(this.bVolverLogInPerReg);
			this.panelAbajoSeguridad.Location = new System.Drawing.Point(0, 509);
			this.panelAbajoSeguridad.Margin = new System.Windows.Forms.Padding(4);
			this.panelAbajoSeguridad.Name = "panelAbajoSeguridad";
			this.panelAbajoSeguridad.Size = new System.Drawing.Size(1128, 51);
			this.panelAbajoSeguridad.TabIndex = 81;
			// 
			// bVolverLogInPerReg
			// 
			this.bVolverLogInPerReg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bVolverLogInPerReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bVolverLogInPerReg.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.bVolverLogInPerReg.Location = new System.Drawing.Point(889, 8);
			this.bVolverLogInPerReg.Margin = new System.Windows.Forms.Padding(4);
			this.bVolverLogInPerReg.Name = "bVolverLogInPerReg";
			this.bVolverLogInPerReg.Size = new System.Drawing.Size(88, 35);
			this.bVolverLogInPerReg.TabIndex = 4;
			this.bVolverLogInPerReg.Text = "Volver";
			this.bVolverLogInPerReg.UseVisualStyleBackColor = true;
			this.bVolverLogInPerReg.Click += new System.EventHandler(this.bVolverLogInPerReg_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 50);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(682, 463);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 78;
			this.pictureBox1.TabStop = false;
			// 
			// lIndicacion
			// 
			this.lIndicacion.AutoSize = true;
			this.lIndicacion.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.lIndicacion.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.lIndicacion.Location = new System.Drawing.Point(762, 236);
			this.lIndicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lIndicacion.Name = "lIndicacion";
			this.lIndicacion.Size = new System.Drawing.Size(294, 30);
			this.lIndicacion.TabIndex = 87;
			this.lIndicacion.Text = "Clave Única de Aministrador";
			// 
			// cbVerOcultarLogInAdmin
			// 
			this.cbVerOcultarLogInAdmin.AutoSize = true;
			this.cbVerOcultarLogInAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbVerOcultarLogInAdmin.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.cbVerOcultarLogInAdmin.Location = new System.Drawing.Point(1053, 352);
			this.cbVerOcultarLogInAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.cbVerOcultarLogInAdmin.Name = "cbVerOcultarLogInAdmin";
			this.cbVerOcultarLogInAdmin.Size = new System.Drawing.Size(42, 17);
			this.cbVerOcultarLogInAdmin.TabIndex = 2;
			this.cbVerOcultarLogInAdmin.Text = "Ver";
			this.cbVerOcultarLogInAdmin.UseVisualStyleBackColor = true;
			this.cbVerOcultarLogInAdmin.CheckedChanged += new System.EventHandler(this.cbVerOcultarLogInPerReg_CheckedChanged);
			// 
			// FRMAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1127, 558);
			this.Controls.Add(this.cbVerOcultarLogInAdmin);
			this.Controls.Add(this.lIndicacion);
			this.Controls.Add(this.bIniciarSesionAdmin);
			this.Controls.Add(this.pbLogoQRSignInSeg);
			this.Controls.Add(this.mtbContraAdmin);
			this.Controls.Add(this.tbCorreoAdmin);
			this.Controls.Add(this.lContrasenaLogInPerReg);
			this.Controls.Add(this.lCorreoLogInPerReg);
			this.Controls.Add(this.panelArribaSeguridad);
			this.Controls.Add(this.panelAbajoSeguridad);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "FRMAdministrador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QR Parking | Administrador";
			this.Load += new System.EventHandler(this.FRMAdministrador_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRSignInSeg)).EndInit();
			this.panelArribaSeguridad.ResumeLayout(false);
			this.panelArribaSeguridad.PerformLayout();
			this.panelAbajoSeguridad.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bIniciarSesionAdmin;
        private System.Windows.Forms.PictureBox pbLogoQRSignInSeg;
        private System.Windows.Forms.MaskedTextBox mtbContraAdmin;
        private System.Windows.Forms.TextBox tbCorreoAdmin;
        private System.Windows.Forms.Label lContrasenaLogInPerReg;
        private System.Windows.Forms.Label lCorreoLogInPerReg;
        private System.Windows.Forms.Panel panelArribaSeguridad;
        private System.Windows.Forms.Label lLogInAdmin;
        private System.Windows.Forms.Panel panelAbajoSeguridad;
        private System.Windows.Forms.Button bVolverLogInPerReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lIndicacion;
        private System.Windows.Forms.CheckBox cbVerOcultarLogInAdmin;
    }
}