﻿namespace Proyecto_Final___QR_Parking
{
    partial class FRMBienvenidos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMBienvenidos));
			this.msBienvenidos = new System.Windows.Forms.MenuStrip();
			this.tsmiSeguridadUAM = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSeguridadUamSignIn = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSeguridadUamLogIn = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPersonalRegistroSignIn = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPersonalRegistroLogI = new System.Windows.Forms.ToolStripMenuItem();
			this.msadmin = new System.Windows.Forms.MenuStrip();
			this.tsmiMenuAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.msBienvenidos.SuspendLayout();
			this.msadmin.SuspendLayout();
			this.SuspendLayout();
			// 
			// msBienvenidos
			// 
			this.msBienvenidos.BackColor = System.Drawing.Color.MediumTurquoise;
			this.msBienvenidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeguridadUAM,
            this.tsmiIniciarSesion});
			this.msBienvenidos.Location = new System.Drawing.Point(0, 0);
			this.msBienvenidos.Name = "msBienvenidos";
			this.msBienvenidos.Size = new System.Drawing.Size(721, 29);
			this.msBienvenidos.TabIndex = 3;
			this.msBienvenidos.Text = "menuStrip1";
			// 
			// tsmiSeguridadUAM
			// 
			this.tsmiSeguridadUAM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeguridadUamSignIn,
            this.tsmiSeguridadUamLogIn});
			this.tsmiSeguridadUAM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiSeguridadUAM.Name = "tsmiSeguridadUAM";
			this.tsmiSeguridadUAM.Size = new System.Drawing.Size(173, 25);
			this.tsmiSeguridadUAM.Text = "Portal de Seguridad";
			// 
			// tsmiSeguridadUamSignIn
			// 
			this.tsmiSeguridadUamSignIn.BackColor = System.Drawing.Color.MediumTurquoise;
			this.tsmiSeguridadUamSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiSeguridadUamSignIn.Name = "tsmiSeguridadUamSignIn";
			this.tsmiSeguridadUamSignIn.Size = new System.Drawing.Size(180, 22);
			this.tsmiSeguridadUamSignIn.Text = "Registrarse";
			this.tsmiSeguridadUamSignIn.Click += new System.EventHandler(this.tsmiSeguridadUamSignIn_Click);
			// 
			// tsmiSeguridadUamLogIn
			// 
			this.tsmiSeguridadUamLogIn.BackColor = System.Drawing.Color.LightSeaGreen;
			this.tsmiSeguridadUamLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiSeguridadUamLogIn.Name = "tsmiSeguridadUamLogIn";
			this.tsmiSeguridadUamLogIn.Size = new System.Drawing.Size(180, 22);
			this.tsmiSeguridadUamLogIn.Text = "Iniciar Sesión";
			this.tsmiSeguridadUamLogIn.Click += new System.EventHandler(this.tsmiSeguridadUamLogIn_Click);
			// 
			// tsmiIniciarSesion
			// 
			this.tsmiIniciarSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonalRegistroSignIn,
            this.tsmiPersonalRegistroLogI});
			this.tsmiIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiIniciarSesion.Name = "tsmiIniciarSesion";
			this.tsmiIniciarSesion.Size = new System.Drawing.Size(251, 25);
			this.tsmiIniciarSesion.Text = "Portal de Personal de Registro";
			// 
			// tsmiPersonalRegistroSignIn
			// 
			this.tsmiPersonalRegistroSignIn.BackColor = System.Drawing.Color.MediumTurquoise;
			this.tsmiPersonalRegistroSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiPersonalRegistroSignIn.Name = "tsmiPersonalRegistroSignIn";
			this.tsmiPersonalRegistroSignIn.Size = new System.Drawing.Size(180, 22);
			this.tsmiPersonalRegistroSignIn.Text = "Registrarse";
			this.tsmiPersonalRegistroSignIn.Click += new System.EventHandler(this.tsmiPersonalRegistroSignIn_Click);
			// 
			// tsmiPersonalRegistroLogI
			// 
			this.tsmiPersonalRegistroLogI.BackColor = System.Drawing.Color.LightSeaGreen;
			this.tsmiPersonalRegistroLogI.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiPersonalRegistroLogI.Name = "tsmiPersonalRegistroLogI";
			this.tsmiPersonalRegistroLogI.Size = new System.Drawing.Size(180, 22);
			this.tsmiPersonalRegistroLogI.Text = "Iniciar Sesión";
			this.tsmiPersonalRegistroLogI.Click += new System.EventHandler(this.tsmiPersonalRegistroLogI_Click);
			// 
			// msadmin
			// 
			this.msadmin.BackColor = System.Drawing.Color.MediumTurquoise;
			this.msadmin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.msadmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenuAdmin});
			this.msadmin.Location = new System.Drawing.Point(0, 398);
			this.msadmin.Name = "msadmin";
			this.msadmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.msadmin.Size = new System.Drawing.Size(721, 29);
			this.msadmin.TabIndex = 5;
			this.msadmin.Text = "menuStrip1";
			// 
			// tsmiMenuAdmin
			// 
			this.tsmiMenuAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.tsmiMenuAdmin.Name = "tsmiMenuAdmin";
			this.tsmiMenuAdmin.Size = new System.Drawing.Size(180, 25);
			this.tsmiMenuAdmin.Text = "Menú Administrador";
			this.tsmiMenuAdmin.Click += new System.EventHandler(this.tsmiMenuAdmin_Click);
			// 
			// FRMBienvenidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(721, 427);
			this.Controls.Add(this.msadmin);
			this.Controls.Add(this.msBienvenidos);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.Name = "FRMBienvenidos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QR Parking | UAM";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FRMBienvenidos_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMBienvenidos_EscapeKeyClose);
			this.msBienvenidos.ResumeLayout(false);
			this.msBienvenidos.PerformLayout();
			this.msadmin.ResumeLayout(false);
			this.msadmin.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msBienvenidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeguridadUAM;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeguridadUamSignIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeguridadUamLogIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonalRegistroSignIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonalRegistroLogI;
        private System.Windows.Forms.MenuStrip msadmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuAdmin;
    }
}