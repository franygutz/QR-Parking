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
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditarSeguridad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarSeguridad = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.lDatosPersonal.Location = new System.Drawing.Point(17, 132);
            this.lDatosPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDatosPersonal.Name = "lDatosPersonal";
            this.lDatosPersonal.Size = new System.Drawing.Size(398, 37);
            this.lDatosPersonal.TabIndex = 77;
            this.lDatosPersonal.Text = "Cuentas del Personal Registro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbLogoQRLogInSeg);
            this.panel1.Controls.Add(this.lBienvenidoPerReg);
            this.panel1.Location = new System.Drawing.Point(16, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 86);
            this.panel1.TabIndex = 75;
            // 
            // pbLogoQRLogInSeg
            // 
            this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
            this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(4, 0);
            this.pbLogoQRLogInSeg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogoQRLogInSeg.Name = "pbLogoQRLogInSeg";
            this.pbLogoQRLogInSeg.Size = new System.Drawing.Size(275, 89);
            this.pbLogoQRLogInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoQRLogInSeg.TabIndex = 72;
            this.pbLogoQRLogInSeg.TabStop = false;
            // 
            // lBienvenidoPerReg
            // 
            this.lBienvenidoPerReg.AutoSize = true;
            this.lBienvenidoPerReg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBienvenidoPerReg.ForeColor = System.Drawing.Color.Turquoise;
            this.lBienvenidoPerReg.Location = new System.Drawing.Point(299, 21);
            this.lBienvenidoPerReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBienvenidoPerReg.Name = "lBienvenidoPerReg";
            this.lBienvenidoPerReg.Size = new System.Drawing.Size(296, 37);
            this.lBienvenidoPerReg.TabIndex = 72;
            this.lBienvenidoPerReg.Text = "Bienvenid@ de vuelta";
            // 
            // msAdminHub
            // 
            this.msAdminHub.BackColor = System.Drawing.Color.MediumTurquoise;
            this.msAdminHub.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msAdminHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmicerrarSesion});
            this.msAdminHub.Location = new System.Drawing.Point(0, 0);
            this.msAdminHub.Name = "msAdminHub";
            this.msAdminHub.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msAdminHub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msAdminHub.Size = new System.Drawing.Size(961, 36);
            this.msAdminHub.TabIndex = 78;
            this.msAdminHub.Text = "menuStrip1";
            // 
            // tsmicerrarSesion
            // 
            this.tsmicerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmicerrarSesion.ForeColor = System.Drawing.Color.DarkRed;
            this.tsmicerrarSesion.Name = "tsmicerrarSesion";
            this.tsmicerrarSesion.Size = new System.Drawing.Size(146, 32);
            this.tsmicerrarSesion.Text = "Cerrar Sesión";
            this.tsmicerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsmicerrarSesion.Click += new System.EventHandler(this.tsmicerrarSesion_Click);
            // 
            // dgvPersonalRegistro
            // 
            this.dgvPersonalRegistro.AllowUserToAddRows = false;
            this.dgvPersonalRegistro.AllowUserToDeleteRows = false;
            this.dgvPersonalRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dgvPersonalRegistro.Location = new System.Drawing.Point(24, 172);
            this.dgvPersonalRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPersonalRegistro.Name = "dgvPersonalRegistro";
            this.dgvPersonalRegistro.ReadOnly = true;
            this.dgvPersonalRegistro.RowHeadersWidth = 51;
            this.dgvPersonalRegistro.Size = new System.Drawing.Size(911, 146);
            this.dgvPersonalRegistro.TabIndex = 79;
            this.dgvPersonalRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonalRegistro_CellContentClick);
            // 
            // dgvSeguridad
            // 
            this.dgvSeguridad.AllowUserToAddRows = false;
            this.dgvSeguridad.AllowUserToDeleteRows = false;
            this.dgvSeguridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguridad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarSeguridad,
            this.EliminarSeguridad});
            this.dgvSeguridad.Location = new System.Drawing.Point(24, 363);
            this.dgvSeguridad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSeguridad.Name = "dgvSeguridad";
            this.dgvSeguridad.ReadOnly = true;
            this.dgvSeguridad.RowHeadersWidth = 51;
            this.dgvSeguridad.Size = new System.Drawing.Size(911, 146);
            this.dgvSeguridad.TabIndex = 81;
            this.dgvSeguridad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeguridad_CellContentClick);
            // 
            // lSeguridad
            // 
            this.lSeguridad.AutoSize = true;
            this.lSeguridad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeguridad.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSeguridad.Location = new System.Drawing.Point(17, 322);
            this.lSeguridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSeguridad.Name = "lSeguridad";
            this.lSeguridad.Size = new System.Drawing.Size(367, 37);
            this.lSeguridad.TabIndex = 80;
            this.lSeguridad.Text = "Cuentas de Seguridad UAM";
            // 
            // Editar
            // 
            this.Editar.FillWeight = 60F;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 60;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 75F;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 75;
            // 
            // EditarSeguridad
            // 
            this.EditarSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarSeguridad.HeaderText = "EditarSeguridad";
            this.EditarSeguridad.MinimumWidth = 6;
            this.EditarSeguridad.Name = "EditarSeguridad";
            this.EditarSeguridad.ReadOnly = true;
            this.EditarSeguridad.Text = "Editar";
            this.EditarSeguridad.UseColumnTextForButtonValue = true;
            this.EditarSeguridad.Width = 125;
            // 
            // EliminarSeguridad
            // 
            this.EliminarSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarSeguridad.HeaderText = "EliminarSeguridad";
            this.EliminarSeguridad.MinimumWidth = 6;
            this.EliminarSeguridad.Name = "EliminarSeguridad";
            this.EliminarSeguridad.ReadOnly = true;
            this.EliminarSeguridad.Text = "Eliminar";
            this.EliminarSeguridad.UseColumnTextForButtonValue = true;
            this.EliminarSeguridad.Width = 125;
            // 
            // FRMAdminHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 526);
            this.Controls.Add(this.dgvSeguridad);
            this.Controls.Add(this.lSeguridad);
            this.Controls.Add(this.dgvPersonalRegistro);
            this.Controls.Add(this.msAdminHub);
            this.Controls.Add(this.lDatosPersonal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn EditarSeguridad;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarSeguridad;
    }
}