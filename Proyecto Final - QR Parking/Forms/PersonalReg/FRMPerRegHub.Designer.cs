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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
			this.msPerRegHub = new System.Windows.Forms.MenuStrip();
			this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
			this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
			this.lBienvenidoPerReg = new System.Windows.Forms.Label();
			this.dgvRegistros = new System.Windows.Forms.DataGridView();
			this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.bAgregar = new System.Windows.Forms.Button();
			this.lDatos = new System.Windows.Forms.Label();
			this.tbPlaca = new System.Windows.Forms.TextBox();
			this.lBuscar = new System.Windows.Forms.Label();
			this.msPerRegHub.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
			this.SuspendLayout();
			// 
			// msPerRegHub
			// 
			this.msPerRegHub.BackColor = System.Drawing.Color.MediumTurquoise;
			this.msPerRegHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion});
			this.msPerRegHub.Location = new System.Drawing.Point(0, 0);
			this.msPerRegHub.Name = "msPerRegHub";
			this.msPerRegHub.Size = new System.Drawing.Size(981, 29);
			this.msPerRegHub.TabIndex = 70;
			this.msPerRegHub.Text = "menuStrip1";
			// 
			// tsmiCerrarSesion
			// 
			this.tsmiCerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiCerrarSesion.ForeColor = System.Drawing.Color.Red;
			this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
			this.tsmiCerrarSesion.Size = new System.Drawing.Size(119, 25);
			this.tsmiCerrarSesion.Text = "Cerrar Sesión";
			this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
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
			this.lBienvenidoPerReg.Location = new System.Drawing.Point(224, 53);
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
			dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
			this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRegistros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
			this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ver,
            this.Editar,
            this.Eliminar});
			this.dgvRegistros.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvRegistros.DefaultCellStyle = dataGridViewCellStyle39;
			this.dgvRegistros.Location = new System.Drawing.Point(12, 156);
			this.dgvRegistros.Name = "dgvRegistros";
			this.dgvRegistros.ReadOnly = true;
			dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
			this.dgvRegistros.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvRegistros.RowTemplate.DefaultCellStyle.NullValue = " ";
			this.dgvRegistros.RowTemplate.Height = 30;
			this.dgvRegistros.RowTemplate.ReadOnly = true;
			this.dgvRegistros.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistros.ShowRowErrors = false;
			this.dgvRegistros.Size = new System.Drawing.Size(957, 409);
			this.dgvRegistros.TabIndex = 72;
			this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
			// 
			// Ver
			// 
			this.Ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ver.FillWeight = 30F;
			this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Ver.HeaderText = "Ver";
			this.Ver.Name = "Ver";
			this.Ver.ReadOnly = true;
			this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Ver.Text = "Ver";
			this.Ver.UseColumnTextForButtonValue = true;
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
			// bAgregar
			// 
			this.bAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bAgregar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.bAgregar.Location = new System.Drawing.Point(853, 111);
			this.bAgregar.Name = "bAgregar";
			this.bAgregar.Size = new System.Drawing.Size(116, 39);
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
			// tbPlaca
			// 
			this.tbPlaca.AcceptsReturn = true;
			this.tbPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPlaca.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbPlaca.Location = new System.Drawing.Point(628, 122);
			this.tbPlaca.Margin = new System.Windows.Forms.Padding(4);
			this.tbPlaca.MaxLength = 8;
			this.tbPlaca.Name = "tbPlaca";
			this.tbPlaca.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tbPlaca.Size = new System.Drawing.Size(194, 25);
			this.tbPlaca.TabIndex = 1;
			this.tbPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlaca_KeyPress);
			// 
			// lBuscar
			// 
			this.lBuscar.AutoSize = true;
			this.lBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.lBuscar.Location = new System.Drawing.Point(655, 99);
			this.lBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lBuscar.Name = "lBuscar";
			this.lBuscar.Size = new System.Drawing.Size(167, 19);
			this.lBuscar.TabIndex = 134;
			this.lBuscar.Text = "Buscar registro por placa:";
			// 
			// FRMPerRegHub
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(981, 577);
			this.Controls.Add(this.tbPlaca);
			this.Controls.Add(this.lBuscar);
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
		private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
		private System.Windows.Forms.Label lBienvenidoPerReg;
		private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
		private System.Windows.Forms.DataGridView dgvRegistros;
		private System.Windows.Forms.Button bAgregar;
		private System.Windows.Forms.Label lDatos;
		private System.Windows.Forms.DataGridViewButtonColumn Ver;
		private System.Windows.Forms.DataGridViewButtonColumn Editar;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.TextBox tbPlaca;
		private System.Windows.Forms.Label lBuscar;
	}
}