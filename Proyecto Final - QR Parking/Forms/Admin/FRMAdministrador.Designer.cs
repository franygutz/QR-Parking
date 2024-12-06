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
            this.pbLogoQRParking = new System.Windows.Forms.PictureBox();
            this.lLogInAdmin = new System.Windows.Forms.Label();
            this.panelAbajoSeguridad = new System.Windows.Forms.Panel();
            this.bVolverLogInPerReg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lIndicacion = new System.Windows.Forms.Label();
            this.cbVerOcultarLogInAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRSignInSeg)).BeginInit();
            this.panelArribaSeguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRParking)).BeginInit();
            this.panelAbajoSeguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bIniciarSesionAdmin
            // 
            this.bIniciarSesionAdmin.BackColor = System.Drawing.Color.LightCyan;
            this.bIniciarSesionAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIniciarSesionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIniciarSesionAdmin.Location = new System.Drawing.Point(474, 267);
            this.bIniciarSesionAdmin.Name = "bIniciarSesionAdmin";
            this.bIniciarSesionAdmin.Size = new System.Drawing.Size(132, 38);
            this.bIniciarSesionAdmin.TabIndex = 86;
            this.bIniciarSesionAdmin.Text = "Inicia Sesión";
            this.bIniciarSesionAdmin.UseVisualStyleBackColor = false;
            this.bIniciarSesionAdmin.Click += new System.EventHandler(this.bIniciarSesionPerReg_Click);
            // 
            // pbLogoQRSignInSeg
            // 
            this.pbLogoQRSignInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRSignInSeg.Image")));
            this.pbLogoQRSignInSeg.Location = new System.Drawing.Point(367, 70);
            this.pbLogoQRSignInSeg.Name = "pbLogoQRSignInSeg";
            this.pbLogoQRSignInSeg.Size = new System.Drawing.Size(206, 72);
            this.pbLogoQRSignInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoQRSignInSeg.TabIndex = 85;
            this.pbLogoQRSignInSeg.TabStop = false;
            // 
            // mtbContraAdmin
            // 
            this.mtbContraAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbContraAdmin.Location = new System.Drawing.Point(489, 228);
            this.mtbContraAdmin.Name = "mtbContraAdmin";
            this.mtbContraAdmin.Size = new System.Drawing.Size(187, 20);
            this.mtbContraAdmin.TabIndex = 80;
            // 
            // tbCorreoAdmin
            // 
            this.tbCorreoAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorreoAdmin.Location = new System.Drawing.Point(489, 192);
            this.tbCorreoAdmin.Name = "tbCorreoAdmin";
            this.tbCorreoAdmin.Size = new System.Drawing.Size(187, 20);
            this.tbCorreoAdmin.TabIndex = 79;
            // 
            // lContrasenaLogInPerReg
            // 
            this.lContrasenaLogInPerReg.AutoSize = true;
            this.lContrasenaLogInPerReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContrasenaLogInPerReg.Location = new System.Drawing.Point(364, 228);
            this.lContrasenaLogInPerReg.Name = "lContrasenaLogInPerReg";
            this.lContrasenaLogInPerReg.Size = new System.Drawing.Size(84, 17);
            this.lContrasenaLogInPerReg.TabIndex = 84;
            this.lContrasenaLogInPerReg.Text = "Contraseña: ";
            // 
            // lCorreoLogInPerReg
            // 
            this.lCorreoLogInPerReg.AutoSize = true;
            this.lCorreoLogInPerReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCorreoLogInPerReg.Location = new System.Drawing.Point(364, 192);
            this.lCorreoLogInPerReg.Name = "lCorreoLogInPerReg";
            this.lCorreoLogInPerReg.Size = new System.Drawing.Size(122, 17);
            this.lCorreoLogInPerReg.TabIndex = 83;
            this.lCorreoLogInPerReg.Text = "Correo Electronico:";
            // 
            // panelArribaSeguridad
            // 
            this.panelArribaSeguridad.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelArribaSeguridad.Controls.Add(this.pbLogoQRParking);
            this.panelArribaSeguridad.Controls.Add(this.lLogInAdmin);
            this.panelArribaSeguridad.Location = new System.Drawing.Point(0, -1);
            this.panelArribaSeguridad.Name = "panelArribaSeguridad";
            this.panelArribaSeguridad.Size = new System.Drawing.Size(721, 39);
            this.panelArribaSeguridad.TabIndex = 82;
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
            // lLogInAdmin
            // 
            this.lLogInAdmin.AutoSize = true;
            this.lLogInAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogInAdmin.Location = new System.Drawing.Point(86, -1);
            this.lLogInAdmin.Name = "lLogInAdmin";
            this.lLogInAdmin.Size = new System.Drawing.Size(438, 37);
            this.lLogInAdmin.TabIndex = 8;
            this.lLogInAdmin.Text = "Iniciar Sesión como Administrador";
            // 
            // panelAbajoSeguridad
            // 
            this.panelAbajoSeguridad.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelAbajoSeguridad.Controls.Add(this.bVolverLogInPerReg);
            this.panelAbajoSeguridad.Location = new System.Drawing.Point(0, 389);
            this.panelAbajoSeguridad.Name = "panelAbajoSeguridad";
            this.panelAbajoSeguridad.Size = new System.Drawing.Size(721, 39);
            this.panelAbajoSeguridad.TabIndex = 81;
            // 
            // bVolverLogInPerReg
            // 
            this.bVolverLogInPerReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolverLogInPerReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVolverLogInPerReg.Location = new System.Drawing.Point(634, 6);
            this.bVolverLogInPerReg.Name = "bVolverLogInPerReg";
            this.bVolverLogInPerReg.Size = new System.Drawing.Size(75, 27);
            this.bVolverLogInPerReg.TabIndex = 0;
            this.bVolverLogInPerReg.Text = "Volver";
            this.bVolverLogInPerReg.UseVisualStyleBackColor = true;
            this.bVolverLogInPerReg.Click += new System.EventHandler(this.bVolverLogInPerReg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 354);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // lIndicacion
            // 
            this.lIndicacion.AutoSize = true;
            this.lIndicacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lIndicacion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lIndicacion.Location = new System.Drawing.Point(363, 145);
            this.lIndicacion.Name = "lIndicacion";
            this.lIndicacion.Size = new System.Drawing.Size(213, 21);
            this.lIndicacion.TabIndex = 87;
            this.lIndicacion.Text = "Clave única de Aministrador";
            // 
            // cbVerOcultarLogInAdmin
            // 
            this.cbVerOcultarLogInAdmin.AutoSize = true;
            this.cbVerOcultarLogInAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVerOcultarLogInAdmin.Location = new System.Drawing.Point(682, 228);
            this.cbVerOcultarLogInAdmin.Name = "cbVerOcultarLogInAdmin";
            this.cbVerOcultarLogInAdmin.Size = new System.Drawing.Size(42, 17);
            this.cbVerOcultarLogInAdmin.TabIndex = 88;
            this.cbVerOcultarLogInAdmin.Text = "Ver";
            this.cbVerOcultarLogInAdmin.UseVisualStyleBackColor = true;
            this.cbVerOcultarLogInAdmin.CheckedChanged += new System.EventHandler(this.cbVerOcultarLogInPerReg_CheckedChanged);
            // 
            // FRMAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 427);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Parking | Administrador";
            this.Load += new System.EventHandler(this.FRMAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRSignInSeg)).EndInit();
            this.panelArribaSeguridad.ResumeLayout(false);
            this.panelArribaSeguridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRParking)).EndInit();
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
        private System.Windows.Forms.PictureBox pbLogoQRParking;
        private System.Windows.Forms.Label lLogInAdmin;
        private System.Windows.Forms.Panel panelAbajoSeguridad;
        private System.Windows.Forms.Button bVolverLogInPerReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lIndicacion;
        private System.Windows.Forms.CheckBox cbVerOcultarLogInAdmin;
    }
}