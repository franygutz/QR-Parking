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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lDatosPersonal = new System.Windows.Forms.Label();
			this.lBienvenidoPerReg = new System.Windows.Forms.Label();
			this.msAdminHub = new System.Windows.Forms.MenuStrip();
			this.tsmicerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
			this.lSeguridad = new System.Windows.Forms.Label();
			this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
			this.dgvPersonalRegistro = new System.Windows.Forms.DataGridView();
			this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dgvSeguridad = new System.Windows.Forms.DataGridView();
			this.EditarSeguridad = new System.Windows.Forms.DataGridViewButtonColumn();
			this.EliminarSeguridad = new System.Windows.Forms.DataGridViewButtonColumn();
			this.msAdminHub.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPersonalRegistro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeguridad)).BeginInit();
			this.SuspendLayout();
			// 
			// lDatosPersonal
			// 
			this.lDatosPersonal.AutoSize = true;
			this.lDatosPersonal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lDatosPersonal.ForeColor = System.Drawing.Color.DarkCyan;
			this.lDatosPersonal.Location = new System.Drawing.Point(237, 160);
			this.lDatosPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lDatosPersonal.Name = "lDatosPersonal";
			this.lDatosPersonal.Size = new System.Drawing.Size(303, 30);
			this.lDatosPersonal.TabIndex = 77;
			this.lDatosPersonal.Text = "Cuentas del Personal Registro";
			// 
			// lBienvenidoPerReg
			// 
			this.lBienvenidoPerReg.AutoSize = true;
			this.lBienvenidoPerReg.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
			this.lBienvenidoPerReg.ForeColor = System.Drawing.Color.Turquoise;
			this.lBienvenidoPerReg.Location = new System.Drawing.Point(602, 108);
			this.lBienvenidoPerReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lBienvenidoPerReg.Name = "lBienvenidoPerReg";
			this.lBienvenidoPerReg.Size = new System.Drawing.Size(345, 41);
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
			this.msAdminHub.Size = new System.Drawing.Size(1505, 31);
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
			// lSeguridad
			// 
			this.lSeguridad.AutoSize = true;
			this.lSeguridad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lSeguridad.ForeColor = System.Drawing.Color.DarkCyan;
			this.lSeguridad.Location = new System.Drawing.Point(996, 160);
			this.lSeguridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lSeguridad.Name = "lSeguridad";
			this.lSeguridad.Size = new System.Drawing.Size(283, 30);
			this.lSeguridad.TabIndex = 80;
			this.lSeguridad.Text = "Cuentas de Seguridad UAM";
			// 
			// pbLogoQRLogInSeg
			// 
			this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
			this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(681, 35);
			this.pbLogoQRLogInSeg.Margin = new System.Windows.Forms.Padding(4);
			this.pbLogoQRLogInSeg.Name = "pbLogoQRLogInSeg";
			this.pbLogoQRLogInSeg.Size = new System.Drawing.Size(170, 69);
			this.pbLogoQRLogInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogoQRLogInSeg.TabIndex = 72;
			this.pbLogoQRLogInSeg.TabStop = false;
			// 
			// dgvPersonalRegistro
			// 
			this.dgvPersonalRegistro.AllowUserToAddRows = false;
			this.dgvPersonalRegistro.AllowUserToDeleteRows = false;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPersonalRegistro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvPersonalRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPersonalRegistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvPersonalRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPersonalRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvPersonalRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPersonalRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
			this.dgvPersonalRegistro.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPersonalRegistro.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgvPersonalRegistro.Location = new System.Drawing.Point(12, 203);
			this.dgvPersonalRegistro.Name = "dgvPersonalRegistro";
			this.dgvPersonalRegistro.ReadOnly = true;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPersonalRegistro.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvPersonalRegistro.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvPersonalRegistro.RowTemplate.DefaultCellStyle.NullValue = " ";
			this.dgvPersonalRegistro.RowTemplate.Height = 30;
			this.dgvPersonalRegistro.RowTemplate.ReadOnly = true;
			this.dgvPersonalRegistro.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPersonalRegistro.ShowRowErrors = false;
			this.dgvPersonalRegistro.Size = new System.Drawing.Size(735, 544);
			this.dgvPersonalRegistro.TabIndex = 82;
			this.dgvPersonalRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonalRegistro_CellContentClick);
			// 
			// Editar
			// 
			this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Editar.FillWeight = 50F;
			this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Editar.HeaderText = "Editar";
			this.Editar.Name = "Editar";
			this.Editar.ReadOnly = true;
			this.Editar.Text = "Editar";
			this.Editar.UseColumnTextForButtonValue = true;
			// 
			// Eliminar
			// 
			this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Eliminar.HeaderText = "Eliminar";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.ReadOnly = true;
			this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseColumnTextForButtonValue = true;
			// 
			// dgvSeguridad
			// 
			this.dgvSeguridad.AllowUserToAddRows = false;
			this.dgvSeguridad.AllowUserToDeleteRows = false;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSeguridad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvSeguridad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSeguridad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSeguridad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSeguridad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvSeguridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeguridad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarSeguridad,
            this.EliminarSeguridad});
			this.dgvSeguridad.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSeguridad.DefaultCellStyle = dataGridViewCellStyle15;
			this.dgvSeguridad.Location = new System.Drawing.Point(782, 203);
			this.dgvSeguridad.Name = "dgvSeguridad";
			this.dgvSeguridad.ReadOnly = true;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSeguridad.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvSeguridad.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvSeguridad.RowTemplate.DefaultCellStyle.NullValue = " ";
			this.dgvSeguridad.RowTemplate.Height = 30;
			this.dgvSeguridad.RowTemplate.ReadOnly = true;
			this.dgvSeguridad.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSeguridad.ShowRowErrors = false;
			this.dgvSeguridad.Size = new System.Drawing.Size(708, 544);
			this.dgvSeguridad.TabIndex = 83;
			this.dgvSeguridad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeguridad_CellContentClick);
			// 
			// EditarSeguridad
			// 
			this.EditarSeguridad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EditarSeguridad.FillWeight = 50F;
			this.EditarSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditarSeguridad.HeaderText = "Editar";
			this.EditarSeguridad.Name = "EditarSeguridad";
			this.EditarSeguridad.ReadOnly = true;
			this.EditarSeguridad.Text = "Editar";
			this.EditarSeguridad.UseColumnTextForButtonValue = true;
			// 
			// EliminarSeguridad
			// 
			this.EliminarSeguridad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EliminarSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EliminarSeguridad.HeaderText = "Eliminar";
			this.EliminarSeguridad.Name = "EliminarSeguridad";
			this.EliminarSeguridad.ReadOnly = true;
			this.EliminarSeguridad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.EliminarSeguridad.Text = "Eliminar";
			this.EliminarSeguridad.UseColumnTextForButtonValue = true;
			// 
			// FRMAdminHub
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1505, 759);
			this.Controls.Add(this.dgvSeguridad);
			this.Controls.Add(this.dgvPersonalRegistro);
			this.Controls.Add(this.pbLogoQRLogInSeg);
			this.Controls.Add(this.lBienvenidoPerReg);
			this.Controls.Add(this.lSeguridad);
			this.Controls.Add(this.msAdminHub);
			this.Controls.Add(this.lDatosPersonal);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "FRMAdminHub";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QR Parking | Administrador";
			this.Load += new System.EventHandler(this.FRMAdminHub_Load);
			this.msAdminHub.ResumeLayout(false);
			this.msAdminHub.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPersonalRegistro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeguridad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDatosPersonal;
        private System.Windows.Forms.Label lBienvenidoPerReg;
        private System.Windows.Forms.MenuStrip msAdminHub;
        private System.Windows.Forms.ToolStripMenuItem tsmicerrarSesion;
        private System.Windows.Forms.Label lSeguridad;
		private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
		private System.Windows.Forms.DataGridView dgvPersonalRegistro;
		private System.Windows.Forms.DataGridView dgvSeguridad;
		private System.Windows.Forms.DataGridViewButtonColumn Editar;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.DataGridViewButtonColumn EditarSeguridad;
		private System.Windows.Forms.DataGridViewButtonColumn EliminarSeguridad;
	}
}