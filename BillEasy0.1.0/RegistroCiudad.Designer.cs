namespace BillEasy0._1._0
{
    partial class RegistroCiudad
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
            this.CodigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CiudadIdtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.DatosCiudadgroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatosCiudadgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodigoPostalTextBox
            // 
            this.CodigoPostalTextBox.Location = new System.Drawing.Point(109, 104);
            this.CodigoPostalTextBox.Name = "CodigoPostalTextBox";
            this.CodigoPostalTextBox.Size = new System.Drawing.Size(214, 20);
            this.CodigoPostalTextBox.TabIndex = 24;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(109, 68);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(214, 20);
            this.NombreTextBox.TabIndex = 23;
            // 
            // CiudadIdtextBox
            // 
            this.CiudadIdtextBox.Location = new System.Drawing.Point(109, 32);
            this.CiudadIdtextBox.Name = "CiudadIdtextBox";
            this.CiudadIdtextBox.Size = new System.Drawing.Size(134, 20);
            this.CiudadIdtextBox.TabIndex = 22;
            this.CiudadIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CiudadIdtextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Codigo Postal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CiudadId:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::BillEasy0._1._0.Properties.Resources._1443839488_file_search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(249, 20);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(74, 42);
            this.Buscarbutton.TabIndex = 31;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.Image = global::BillEasy0._1._0.Properties.Resources._1445977752_Save;
            this.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGuardar.Location = new System.Drawing.Point(138, 142);
            this.ButtonGuardar.MaximumSize = new System.Drawing.Size(81, 44);
            this.ButtonGuardar.MinimumSize = new System.Drawing.Size(81, 44);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(81, 44);
            this.ButtonGuardar.TabIndex = 30;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGuardar.UseVisualStyleBackColor = true;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::BillEasy0._1._0.Properties.Resources._1445976510_Delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(242, 142);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(81, 44);
            this.EliminarButton.TabIndex = 29;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::BillEasy0._1._0.Properties.Resources._1445976554_Plus__Orange;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(31, 142);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(81, 44);
            this.Nuevobutton.TabIndex = 28;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // DatosCiudadgroupBox
            // 
            this.DatosCiudadgroupBox.Controls.Add(this.CiudadIdtextBox);
            this.DatosCiudadgroupBox.Controls.Add(this.Buscarbutton);
            this.DatosCiudadgroupBox.Controls.Add(this.label1);
            this.DatosCiudadgroupBox.Controls.Add(this.ButtonGuardar);
            this.DatosCiudadgroupBox.Controls.Add(this.label2);
            this.DatosCiudadgroupBox.Controls.Add(this.EliminarButton);
            this.DatosCiudadgroupBox.Controls.Add(this.label3);
            this.DatosCiudadgroupBox.Controls.Add(this.Nuevobutton);
            this.DatosCiudadgroupBox.Controls.Add(this.NombreTextBox);
            this.DatosCiudadgroupBox.Controls.Add(this.CodigoPostalTextBox);
            this.DatosCiudadgroupBox.Location = new System.Drawing.Point(12, 71);
            this.DatosCiudadgroupBox.Name = "DatosCiudadgroupBox";
            this.DatosCiudadgroupBox.Size = new System.Drawing.Size(355, 196);
            this.DatosCiudadgroupBox.TabIndex = 32;
            this.DatosCiudadgroupBox.TabStop = false;
            this.DatosCiudadgroupBox.Text = "Datos Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 36);
            this.label4.TabIndex = 33;
            this.label4.Text = "Registro de ciudades";
            // 
            // RegistroCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DatosCiudadgroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de ciudades";
            this.DatosCiudadgroupBox.ResumeLayout(false);
            this.DatosCiudadgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox CodigoPostalTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox CiudadIdtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DatosCiudadgroupBox;
        private System.Windows.Forms.Label label4;
    }
}