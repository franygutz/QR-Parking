namespace Proyecto_Final___QR_Parking.PersonalReg
{
	partial class FRMPerRegHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPerRegHub));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msPerRegHub = new System.Windows.Forms.MenuStrip();
            this.tsmiExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
            this.lBienvenidoPerReg = new System.Windows.Forms.Label();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.bAgregar = new System.Windows.Forms.Button();
            this.lDatos = new System.Windows.Forms.Label();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.msPerRegHub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // msPerRegHub
            // 
            this.msPerRegHub.BackColor = System.Drawing.Color.MediumTurquoise;
            this.msPerRegHub.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPerRegHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportar,
            this.tsmicerrarSesion});
            this.msPerRegHub.Location = new System.Drawing.Point(0, 0);
            this.msPerRegHub.Name = "msPerRegHub";
            this.msPerRegHub.Size = new System.Drawing.Size(1308, 36);
            this.msPerRegHub.TabIndex = 70;
            this.msPerRegHub.Text = "menuStrip1";
            // 
            // tsmiExportar
            // 
            this.tsmiExportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatoPDFToolStripMenuItem,
            this.formatoExcelToolStripMenuItem});
            this.tsmiExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiExportar.Name = "tsmiExportar";
            this.tsmiExportar.Size = new System.Drawing.Size(102, 32);
            this.tsmiExportar.Text = "Exportar";
            // 
            // formatoPDFToolStripMenuItem
            // 
            this.formatoPDFToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.formatoPDFToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.formatoPDFToolStripMenuItem.Name = "formatoPDFToolStripMenuItem";
            this.formatoPDFToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.formatoPDFToolStripMenuItem.Text = "Formato PDF";
            // 
            // formatoExcelToolStripMenuItem
            // 
            this.formatoExcelToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.formatoExcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.formatoExcelToolStripMenuItem.Name = "formatoExcelToolStripMenuItem";
            this.formatoExcelToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.formatoExcelToolStripMenuItem.Text = "Formato Excel";
            // 
            // tsmicerrarSesion
            // 
            this.tsmicerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmicerrarSesion.ForeColor = System.Drawing.Color.DarkRed;
            this.tsmicerrarSesion.Name = "tsmicerrarSesion";
            this.tsmicerrarSesion.Size = new System.Drawing.Size(146, 32);
            this.tsmicerrarSesion.Text = "Cerrar Sesión";
            this.tsmicerrarSesion.Click += new System.EventHandler(this.tsmicerrarSesion_Click);
            // 
            // pbLogoQRLogInSeg
            // 
            this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
            this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(16, 52);
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
            this.lBienvenidoPerReg.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lBienvenidoPerReg.ForeColor = System.Drawing.Color.Turquoise;
            this.lBienvenidoPerReg.Location = new System.Drawing.Point(311, 68);
            this.lBienvenidoPerReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBienvenidoPerReg.Name = "lBienvenidoPerReg";
            this.lBienvenidoPerReg.Size = new System.Drawing.Size(460, 54);
            this.lBienvenidoPerReg.TabIndex = 72;
            this.lBienvenidoPerReg.Text = "¡Bienvenid@ de vuelta!";
            this.lBienvenidoPerReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ver,
            this.Editar,
            this.Eliminar});
            this.dgvRegistros.Location = new System.Drawing.Point(16, 192);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRegistros.Name = "dgvRegistros";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 30;
            this.dgvRegistros.Size = new System.Drawing.Size(1276, 503);
            this.dgvRegistros.TabIndex = 72;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // bAgregar
            // 
            this.bAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAgregar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.bAgregar.Location = new System.Drawing.Point(1027, 111);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(265, 75);
            this.bAgregar.TabIndex = 73;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // lDatos
            // 
            this.lDatos.AutoSize = true;
            this.lDatos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatos.ForeColor = System.Drawing.Color.DarkCyan;
            this.lDatos.Location = new System.Drawing.Point(16, 148);
            this.lDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDatos.Name = "lDatos";
            this.lDatos.Size = new System.Drawing.Size(251, 37);
            this.lDatos.TabIndex = 74;
            this.lDatos.Text = "Datos Registrados";
            // 
            // Ver
            // 
            this.Ver.FillWeight = 40F;
            this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ver.HeaderText = "Ver";
            this.Ver.MinimumWidth = 6;
            this.Ver.Name = "Ver";
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ver.Text = "Ver";
            this.Ver.UseColumnTextForButtonValue = true;
            this.Ver.Width = 40;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 60F;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
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
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 75;
            // 
            // FRMPerRegHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 710);
            this.Controls.Add(this.pbLogoQRLogInSeg);
            this.Controls.Add(this.lDatos);
            this.Controls.Add(this.lBienvenidoPerReg);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.msPerRegHub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FRMPerRegHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Parking | Personal de Registro";
            this.Load += new System.EventHandler(this.FRMPerRegHub_Load);
            this.msPerRegHub.ResumeLayout(false);
            this.msPerRegHub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip msPerRegHub;
		private System.Windows.Forms.ToolStripMenuItem tsmiExportar;
		private System.Windows.Forms.ToolStripMenuItem tsmicerrarSesion;
		private System.Windows.Forms.Label lBienvenidoPerReg;
		private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
		private System.Windows.Forms.DataGridView dgvRegistros;
		private System.Windows.Forms.ToolStripMenuItem formatoPDFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatoExcelToolStripMenuItem;
		private System.Windows.Forms.Button bAgregar;
		private System.Windows.Forms.Label lDatos;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}