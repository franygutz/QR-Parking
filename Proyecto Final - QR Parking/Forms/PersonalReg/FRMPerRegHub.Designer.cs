﻿namespace Proyecto_Final___QR_Parking.PersonalReg
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.msPerRegHub = new System.Windows.Forms.MenuStrip();
			this.tsmiExportar = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmicerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
			this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
			this.lBienvenidoPerReg = new System.Windows.Forms.Label();
			this.dgvRegistros = new System.Windows.Forms.DataGridView();
			this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.bAgregar = new System.Windows.Forms.Button();
			this.lDatos = new System.Windows.Forms.Label();
			this.msPerRegHub.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
			this.SuspendLayout();
			// 
			// msPerRegHub
			// 
			this.msPerRegHub.BackColor = System.Drawing.Color.MediumTurquoise;
			this.msPerRegHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportar,
            this.tsmicerrarSesion});
			this.msPerRegHub.Location = new System.Drawing.Point(0, 0);
			this.msPerRegHub.Name = "msPerRegHub";
			this.msPerRegHub.Size = new System.Drawing.Size(981, 29);
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
			this.tsmiExportar.Size = new System.Drawing.Size(84, 25);
			this.tsmiExportar.Text = "Exportar";
			// 
			// formatoPDFToolStripMenuItem
			// 
			this.formatoPDFToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
			this.formatoPDFToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.formatoPDFToolStripMenuItem.Name = "formatoPDFToolStripMenuItem";
			this.formatoPDFToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
			this.formatoPDFToolStripMenuItem.Text = "Formato PDF";
			// 
			// formatoExcelToolStripMenuItem
			// 
			this.formatoExcelToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
			this.formatoExcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.formatoExcelToolStripMenuItem.Name = "formatoExcelToolStripMenuItem";
			this.formatoExcelToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
			this.formatoExcelToolStripMenuItem.Text = "Formato Excel";
			// 
			// tsmicerrarSesion
			// 
			this.tsmicerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmicerrarSesion.ForeColor = System.Drawing.Color.Red;
			this.tsmicerrarSesion.Name = "tsmicerrarSesion";
			this.tsmicerrarSesion.Size = new System.Drawing.Size(119, 25);
			this.tsmicerrarSesion.Text = "Cerrar Sesión";
			this.tsmicerrarSesion.Click += new System.EventHandler(this.tsmicerrarSesion_Click);
			// 
			// pbLogoQRLogInSeg
			// 
			this.pbLogoQRLogInSeg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoQRLogInSeg.Image")));
			this.pbLogoQRLogInSeg.Location = new System.Drawing.Point(12, 42);
			this.pbLogoQRLogInSeg.Name = "pbLogoQRLogInSeg";
			this.pbLogoQRLogInSeg.Size = new System.Drawing.Size(206, 72);
			this.pbLogoQRLogInSeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogoQRLogInSeg.TabIndex = 72;
			this.pbLogoQRLogInSeg.TabStop = false;
			// 
			// lBienvenidoPerReg
			// 
			this.lBienvenidoPerReg.AutoSize = true;
			this.lBienvenidoPerReg.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
			this.lBienvenidoPerReg.ForeColor = System.Drawing.Color.Turquoise;
			this.lBienvenidoPerReg.Location = new System.Drawing.Point(233, 55);
			this.lBienvenidoPerReg.Name = "lBienvenidoPerReg";
			this.lBienvenidoPerReg.Size = new System.Drawing.Size(365, 45);
			this.lBienvenidoPerReg.TabIndex = 72;
			this.lBienvenidoPerReg.Text = "¡Bienvenid@ de vuelta!";
			this.lBienvenidoPerReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvRegistros
			// 
			this.dgvRegistros.AllowUserToAddRows = false;
			this.dgvRegistros.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ver,
            this.Editar});
			this.dgvRegistros.Location = new System.Drawing.Point(12, 156);
			this.dgvRegistros.Name = "dgvRegistros";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvRegistros.RowTemplate.Height = 30;
			this.dgvRegistros.Size = new System.Drawing.Size(957, 409);
			this.dgvRegistros.TabIndex = 72;
			this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
			// 
			// Ver
			// 
			this.Ver.FillWeight = 30F;
			this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Ver.HeaderText = "Ver";
			this.Ver.Name = "Ver";
			this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Ver.Text = "Ver";
			this.Ver.UseColumnTextForButtonValue = true;
			this.Ver.Width = 30;
			// 
			// Editar
			// 
			this.Editar.FillWeight = 50F;
			this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Editar.HeaderText = "Editar";
			this.Editar.Name = "Editar";
			this.Editar.Text = "Editar";
			this.Editar.UseColumnTextForButtonValue = true;
			this.Editar.Width = 50;
			// 
			// bAgregar
			// 
			this.bAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bAgregar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.bAgregar.Location = new System.Drawing.Point(770, 90);
			this.bAgregar.Name = "bAgregar";
			this.bAgregar.Size = new System.Drawing.Size(199, 61);
			this.bAgregar.TabIndex = 0;
			this.bAgregar.Text = "Agregar";
			this.bAgregar.UseVisualStyleBackColor = true;
			this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
			// 
			// lDatos
			// 
			this.lDatos.AutoSize = true;
			this.lDatos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lDatos.ForeColor = System.Drawing.Color.DarkCyan;
			this.lDatos.Location = new System.Drawing.Point(12, 120);
			this.lDatos.Name = "lDatos";
			this.lDatos.Size = new System.Drawing.Size(189, 30);
			this.lDatos.TabIndex = 74;
			this.lDatos.Text = "Datos Registrados";
			// 
			// FRMPerRegHub
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(981, 577);
			this.Controls.Add(this.pbLogoQRLogInSeg);
			this.Controls.Add(this.lDatos);
			this.Controls.Add(this.lBienvenidoPerReg);
			this.Controls.Add(this.bAgregar);
			this.Controls.Add(this.dgvRegistros);
			this.Controls.Add(this.msPerRegHub);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
	}
}