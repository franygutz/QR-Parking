namespace Proyecto_Final___QR_Parking.Forms.Admin
{
    partial class FRMEditarPersonalSeguridad
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
            this.bVolverSignInPerReg = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.lContra = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.mtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.lCorreo = new System.Windows.Forms.Label();
            this.lCedula = new System.Windows.Forms.Label();
            this.lApellidos = new System.Windows.Forms.Label();
            this.lNombres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bVolverSignInPerReg
            // 
            this.bVolverSignInPerReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolverSignInPerReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVolverSignInPerReg.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.bVolverSignInPerReg.Location = new System.Drawing.Point(54, 381);
            this.bVolverSignInPerReg.Margin = new System.Windows.Forms.Padding(4);
            this.bVolverSignInPerReg.Name = "bVolverSignInPerReg";
            this.bVolverSignInPerReg.Size = new System.Drawing.Size(108, 35);
            this.bVolverSignInPerReg.TabIndex = 147;
            this.bVolverSignInPerReg.Text = "Volver";
            this.bVolverSignInPerReg.UseVisualStyleBackColor = true;
            this.bVolverSignInPerReg.Click += new System.EventHandler(this.bVolverSignInPerReg_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bGuardar.Location = new System.Drawing.Point(258, 381);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(108, 35);
            this.bGuardar.TabIndex = 146;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbContra
            // 
            this.tbContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContra.Enabled = false;
            this.tbContra.Location = new System.Drawing.Point(137, 288);
            this.tbContra.Margin = new System.Windows.Forms.Padding(4);
            this.tbContra.MaxLength = 8;
            this.tbContra.Name = "tbContra";
            this.tbContra.Size = new System.Drawing.Size(218, 22);
            this.tbContra.TabIndex = 144;
            this.tbContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lContra
            // 
            this.lContra.AutoSize = true;
            this.lContra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContra.Location = new System.Drawing.Point(38, 287);
            this.lContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lContra.Name = "lContra";
            this.lContra.Size = new System.Drawing.Size(101, 23);
            this.lContra.TabIndex = 145;
            this.lContra.Text = "Contraseña:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorreo.Enabled = false;
            this.tbCorreo.Location = new System.Drawing.Point(137, 246);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCorreo.MaxLength = 8;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(218, 22);
            this.tbCorreo.TabIndex = 139;
            this.tbCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCedula
            // 
            this.mtbCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCedula.Enabled = false;
            this.mtbCedula.Location = new System.Drawing.Point(137, 199);
            this.mtbCedula.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCedula.Mask = "000-000000-0000L";
            this.mtbCedula.Name = "mtbCedula";
            this.mtbCedula.Size = new System.Drawing.Size(218, 22);
            this.mtbCedula.TabIndex = 138;
            this.mtbCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbApellidos
            // 
            this.tbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellidos.Location = new System.Drawing.Point(137, 153);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(218, 22);
            this.tbApellidos.TabIndex = 137;
            this.tbApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNombres
            // 
            this.tbNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombres.Location = new System.Drawing.Point(137, 105);
            this.tbNombres.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(218, 22);
            this.tbNombres.TabIndex = 136;
            this.tbNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCorreo.Location = new System.Drawing.Point(73, 246);
            this.lCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(66, 23);
            this.lCorreo.TabIndex = 143;
            this.lCorreo.Text = "Correo:";
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCedula.Location = new System.Drawing.Point(70, 199);
            this.lCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(67, 23);
            this.lCedula.TabIndex = 142;
            this.lCedula.Text = "Cédula:";
            // 
            // lApellidos
            // 
            this.lApellidos.AutoSize = true;
            this.lApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApellidos.Location = new System.Drawing.Point(54, 151);
            this.lApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(83, 23);
            this.lApellidos.TabIndex = 141;
            this.lApellidos.Text = "Apellidos:";
            // 
            // lNombres
            // 
            this.lNombres.AutoSize = true;
            this.lNombres.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombres.Location = new System.Drawing.Point(50, 105);
            this.lNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombres.Name = "lNombres";
            this.lNombres.Size = new System.Drawing.Size(89, 23);
            this.lNombres.TabIndex = 140;
            this.lNombres.Text = "Nombres: ";
            // 
            // FRMEditarPersonalSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.bVolverSignInPerReg);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.lContra);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.mtbCedula);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.lCorreo);
            this.Controls.Add(this.lCedula);
            this.Controls.Add(this.lApellidos);
            this.Controls.Add(this.lNombres);
            this.Name = "FRMEditarPersonalSeguridad";
            this.Text = "FRMEditarPersonalSeguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVolverSignInPerReg;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tbContra;
        private System.Windows.Forms.Label lContra;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.MaskedTextBox mtbCedula;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.Label lNombres;
    }
}