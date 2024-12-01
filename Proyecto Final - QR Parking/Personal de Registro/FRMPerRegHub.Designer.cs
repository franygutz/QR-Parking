namespace Proyecto_Final___QR_Parking.Personal_de_Registro
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
            this.msPerRegHub = new System.Windows.Forms.MenuStrip();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lBienvenidoPerReg = new System.Windows.Forms.Label();
            this.tsmiSeguridadUAM = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogoQRLogInSeg = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.msPerRegHub.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // msPerRegHub
            // 
            this.msPerRegHub.BackColor = System.Drawing.Color.MediumTurquoise;
            this.msPerRegHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeguridadUAM,
            this.tsmiIniciarSesion,
            this.tsmiAyuda,
            this.eliminaRegistroToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.msPerRegHub.Location = new System.Drawing.Point(0, 0);
            this.msPerRegHub.Name = "msPerRegHub";
            this.msPerRegHub.Size = new System.Drawing.Size(721, 29);
            this.msPerRegHub.TabIndex = 70;
            this.msPerRegHub.Text = "menuStrip1";
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(145, 25);
            this.tsmiAyuda.Text = "Eliminar Registro";
            this.tsmiAyuda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tsmiIniciarSesion
            // 
            this.tsmiIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiIniciarSesion.Name = "tsmiIniciarSesion";
            this.tsmiIniciarSesion.Size = new System.Drawing.Size(130, 25);
            this.tsmiIniciarSesion.Text = "Editar Registro";
            this.tsmiIniciarSesion.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // eliminaRegistroToolStripMenuItem
            // 
            this.eliminaRegistroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminaRegistroToolStripMenuItem.Name = "eliminaRegistroToolStripMenuItem";
            this.eliminaRegistroToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.eliminaRegistroToolStripMenuItem.Text = "Ayuda";
            this.eliminaRegistroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbLogoQRLogInSeg);
            this.panel1.Controls.Add(this.lBienvenidoPerReg);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 70);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // tsmiSeguridadUAM
            // 
            this.tsmiSeguridadUAM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiSeguridadUAM.Name = "tsmiSeguridadUAM";
            this.tsmiSeguridadUAM.Size = new System.Drawing.Size(148, 25);
            this.tsmiSeguridadUAM.Text = "Agregar Registro";
            this.tsmiSeguridadUAM.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 216);
            this.dataGridView1.TabIndex = 72;
            // 
            // FRMPerRegHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msPerRegHub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FRMPerRegHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Parking | Personal de Registro";
            this.msPerRegHub.ResumeLayout(false);
            this.msPerRegHub.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoQRLogInSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msPerRegHub;
        private System.Windows.Forms.ToolStripMenuItem tsmiIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem eliminaRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeguridadUAM;
        private System.Windows.Forms.Label lBienvenidoPerReg;
        private System.Windows.Forms.PictureBox pbLogoQRLogInSeg;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}