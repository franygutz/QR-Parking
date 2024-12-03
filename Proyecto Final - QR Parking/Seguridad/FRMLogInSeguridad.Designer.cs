namespace Proyecto_Final___QR_Parking
{
    partial class FRMLogInSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMLogInSeguridad));
            this.bIniciarSesionSeguridad = new System.Windows.Forms.Button();
            this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
            this.cbVerOcultarLogInSeg = new System.Windows.Forms.CheckBox();
            this.mtbContraLogInSeg = new System.Windows.Forms.MaskedTextBox();
            this.tbCorreoLogInSeg = new System.Windows.Forms.TextBox();
            this.lContrasenaLogInSeg = new System.Windows.Forms.Label();
            this.lCorreoLogInSeg = new System.Windows.Forms.Label();
            this.panelArribaSeguridad = new System.Windows.Forms.Panel();
            this.pbLogoQRParking = new System.Windows.Forms.PictureBox();
            this.lLogInSeguridad = new System.Windows.Forms.Label();
            this.panelAbajoSeguridad = new System.Windows.Forms.Panel();
            this.bVolverLogInSeg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lContraOlvidada = new System.Windows.Forms.Label();
            this.lRegistrarse = new System.Windows.Forms.Label();
            this.linklRecuperar = new System.Windows.Forms.LinkLabel();
            this.linklRegistrate = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
            this.panelArribaSeguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRParking)).BeginInit();
            this.panelAbajoSeguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bIniciarSesionSeguridad
            // 
            this.bIniciarSesionSeguridad.BackColor = System.Drawing.Color.LightCyan;
            this.bIniciarSesionSeguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIniciarSesionSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIniciarSesionSeguridad.Location = new System.Drawing.Point(457, 221);
            this.bIniciarSesionSeguridad.Name = "bIniciarSesionSeguridad";
            this.bIniciarSesionSeguridad.Size = new System.Drawing.Size(132, 38);
            this.bIniciarSesionSeguridad.TabIndex = 59;
            this.bIniciarSesionSeguridad.Text = "Inicia Sesión";
            this.bIniciarSesionSeguridad.UseVisualStyleBackColor = false;
            this.bIniciarSesionSeguridad.Click += new System.EventHandler(this.bIniciarSesionSeguridad_Click);
            // 
            // pbLogoQRLogInSeg
            // 
            this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
            this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(436, 44);
            this.pbLogoQRLogInSeg.Name = "pbLogoQRLogInSeg";
            this.pbLogoQRLogInSeg.Size = new System.Drawing.Size(206, 72);
            this.pbLogoQRLogInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoQRLogInSeg.TabIndex = 58;
            this.pbLogoQRLogInSeg.TabStop = false;
            // 
            // cbVerOcultarLogInSeg
            // 
            this.cbVerOcultarLogInSeg.AutoSize = true;
            this.cbVerOcultarLogInSeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVerOcultarLogInSeg.Location = new System.Drawing.Point(665, 182);
            this.cbVerOcultarLogInSeg.Name = "cbVerOcultarLogInSeg";
            this.cbVerOcultarLogInSeg.Size = new System.Drawing.Size(42, 17);
            this.cbVerOcultarLogInSeg.TabIndex = 56;
            this.cbVerOcultarLogInSeg.Text = "Ver";
            this.cbVerOcultarLogInSeg.UseVisualStyleBackColor = true;
            this.cbVerOcultarLogInSeg.CheckedChanged += new System.EventHandler(this.cbVerOcultarLogInSeg_CheckedChanged);
            // 
            // mtbContraLogInSeg
            // 
            this.mtbContraLogInSeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbContraLogInSeg.Location = new System.Drawing.Point(472, 182);
            this.mtbContraLogInSeg.Name = "mtbContraLogInSeg";
            this.mtbContraLogInSeg.Size = new System.Drawing.Size(187, 20);
            this.mtbContraLogInSeg.TabIndex = 45;
            // 
            // tbCorreoLogInSeg
            // 
            this.tbCorreoLogInSeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorreoLogInSeg.Location = new System.Drawing.Point(472, 146);
            this.tbCorreoLogInSeg.Name = "tbCorreoLogInSeg";
            this.tbCorreoLogInSeg.Size = new System.Drawing.Size(187, 20);
            this.tbCorreoLogInSeg.TabIndex = 44;
            // 
            // lContrasenaLogInSeg
            // 
            this.lContrasenaLogInSeg.AutoSize = true;
            this.lContrasenaLogInSeg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContrasenaLogInSeg.Location = new System.Drawing.Point(347, 182);
            this.lContrasenaLogInSeg.Name = "lContrasenaLogInSeg";
            this.lContrasenaLogInSeg.Size = new System.Drawing.Size(84, 17);
            this.lContrasenaLogInSeg.TabIndex = 52;
            this.lContrasenaLogInSeg.Text = "Contraseña: ";
            // 
            // lCorreoLogInSeg
            // 
            this.lCorreoLogInSeg.AutoSize = true;
            this.lCorreoLogInSeg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCorreoLogInSeg.Location = new System.Drawing.Point(347, 146);
            this.lCorreoLogInSeg.Name = "lCorreoLogInSeg";
            this.lCorreoLogInSeg.Size = new System.Drawing.Size(122, 17);
            this.lCorreoLogInSeg.TabIndex = 51;
            this.lCorreoLogInSeg.Text = "Correo Electronico:";
            // 
            // panelArribaSeguridad
            // 
            this.panelArribaSeguridad.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelArribaSeguridad.Controls.Add(this.pbLogoQRParking);
            this.panelArribaSeguridad.Controls.Add(this.lLogInSeguridad);
            this.panelArribaSeguridad.Location = new System.Drawing.Point(0, -1);
            this.panelArribaSeguridad.Name = "panelArribaSeguridad";
            this.panelArribaSeguridad.Size = new System.Drawing.Size(721, 39);
            this.panelArribaSeguridad.TabIndex = 47;
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
            // lLogInSeguridad
            // 
            this.lLogInSeguridad.AutoSize = true;
            this.lLogInSeguridad.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogInSeguridad.Location = new System.Drawing.Point(86, -1);
            this.lLogInSeguridad.Name = "lLogInSeguridad";
            this.lLogInSeguridad.Size = new System.Drawing.Size(454, 37);
            this.lLogInSeguridad.TabIndex = 8;
            this.lLogInSeguridad.Text = "Iniciar Sesión como Seguridad UAM";
            // 
            // panelAbajoSeguridad
            // 
            this.panelAbajoSeguridad.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelAbajoSeguridad.Controls.Add(this.bVolverLogInSeg);
            this.panelAbajoSeguridad.Location = new System.Drawing.Point(0, 389);
            this.panelAbajoSeguridad.Name = "panelAbajoSeguridad";
            this.panelAbajoSeguridad.Size = new System.Drawing.Size(721, 39);
            this.panelAbajoSeguridad.TabIndex = 46;
            // 
            // bVolverLogInSeg
            // 
            this.bVolverLogInSeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolverLogInSeg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVolverLogInSeg.Location = new System.Drawing.Point(634, 6);
            this.bVolverLogInSeg.Name = "bVolverLogInSeg";
            this.bVolverLogInSeg.Size = new System.Drawing.Size(75, 27);
            this.bVolverLogInSeg.TabIndex = 0;
            this.bVolverLogInSeg.Text = "Volver";
            this.bVolverLogInSeg.UseVisualStyleBackColor = true;
            this.bVolverLogInSeg.Click += new System.EventHandler(this.bVolverLogInSeg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 354);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lContraOlvidada
            // 
            this.lContraOlvidada.AutoSize = true;
            this.lContraOlvidada.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContraOlvidada.Location = new System.Drawing.Point(374, 289);
            this.lContraOlvidada.Name = "lContraOlvidada";
            this.lContraOlvidada.Size = new System.Drawing.Size(166, 17);
            this.lContraOlvidada.TabIndex = 60;
            this.lContraOlvidada.Text = "¿Olvidaste tu Contraseña?";
            // 
            // lRegistrarse
            // 
            this.lRegistrarse.AutoSize = true;
            this.lRegistrarse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRegistrarse.Location = new System.Drawing.Point(390, 324);
            this.lRegistrarse.Name = "lRegistrarse";
            this.lRegistrarse.Size = new System.Drawing.Size(150, 17);
            this.lRegistrarse.TabIndex = 61;
            this.lRegistrarse.Text = "¿No tienes una cuenta?";
            // 
            // linklRecuperar
            // 
            this.linklRecuperar.AutoSize = true;
            this.linklRecuperar.Location = new System.Drawing.Point(557, 293);
            this.linklRecuperar.Name = "linklRecuperar";
            this.linklRecuperar.Size = new System.Drawing.Size(114, 13);
            this.linklRecuperar.TabIndex = 62;
            this.linklRecuperar.TabStop = true;
            this.linklRecuperar.Text = "Recuperar Contraseña";
            this.linklRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRecuperar_LinkClicked);
            // 
            // linklRegistrate
            // 
            this.linklRegistrate.AutoSize = true;
            this.linklRegistrate.Location = new System.Drawing.Point(557, 328);
            this.linklRegistrate.Name = "linklRegistrate";
            this.linklRegistrate.Size = new System.Drawing.Size(63, 13);
            this.linklRegistrate.TabIndex = 63;
            this.linklRegistrate.TabStop = true;
            this.linklRegistrate.Text = "¡Regístrate!";
            this.linklRegistrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegistrate_LinkClicked);
            // 
            // FRMLogInSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 427);
            this.Controls.Add(this.linklRegistrate);
            this.Controls.Add(this.linklRecuperar);
            this.Controls.Add(this.lRegistrarse);
            this.Controls.Add(this.lContraOlvidada);
            this.Controls.Add(this.bIniciarSesionSeguridad);
            this.Controls.Add(this.pbLogoQRLogInSeg);
            this.Controls.Add(this.cbVerOcultarLogInSeg);
            this.Controls.Add(this.mtbContraLogInSeg);
            this.Controls.Add(this.tbCorreoLogInSeg);
            this.Controls.Add(this.lContrasenaLogInSeg);
            this.Controls.Add(this.lCorreoLogInSeg);
            this.Controls.Add(this.panelArribaSeguridad);
            this.Controls.Add(this.panelAbajoSeguridad);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMLogInSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Parking | Iniciar Sesión | Seguridad";
            this.Load += new System.EventHandler(this.FRMLogInSeguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).EndInit();
            this.panelArribaSeguridad.ResumeLayout(false);
            this.panelArribaSeguridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRParking)).EndInit();
            this.panelAbajoSeguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bIniciarSesionSeguridad;
        private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
        private System.Windows.Forms.CheckBox cbVerOcultarLogInSeg;
        private System.Windows.Forms.MaskedTextBox mtbContraLogInSeg;
        private System.Windows.Forms.TextBox tbCorreoLogInSeg;
        private System.Windows.Forms.Label lContrasenaLogInSeg;
        private System.Windows.Forms.Label lCorreoLogInSeg;
        private System.Windows.Forms.Panel panelArribaSeguridad;
        private System.Windows.Forms.PictureBox pbLogoQRParking;
        private System.Windows.Forms.Label lLogInSeguridad;
        private System.Windows.Forms.Panel panelAbajoSeguridad;
        private System.Windows.Forms.Button bVolverLogInSeg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lContraOlvidada;
        private System.Windows.Forms.Label lRegistrarse;
        private System.Windows.Forms.LinkLabel linklRecuperar;
        private System.Windows.Forms.LinkLabel linklRegistrate;
    }
}