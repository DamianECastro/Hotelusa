namespace Reservahoteles
{
    partial class FormRegistro
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
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCoContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.AccessibleName = "";
            this.textBoxCorreo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(303, 201);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(152, 22);
            this.textBoxCorreo.TabIndex = 0;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.AccessibleName = "textboxPassword";
            this.textBoxContrasena.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.Location = new System.Drawing.Point(303, 240);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(152, 22);
            this.textBoxContrasena.TabIndex = 1;
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.AccessibleName = "botonRegistrarse";
            this.buttonRegistro.BackColor = System.Drawing.Color.OldLace;
            this.buttonRegistro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistro.Location = new System.Drawing.Point(252, 332);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(125, 41);
            this.buttonRegistro.TabIndex = 3;
            this.buttonRegistro.Text = "Registrarse";
            this.buttonRegistro.UseVisualStyleBackColor = false;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(303, 83);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(152, 22);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(303, 123);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(152, 22);
            this.textBoxApellido.TabIndex = 5;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(303, 163);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(152, 22);
            this.textBoxTelefono.TabIndex = 6;
            // 
            // textBoxCoContrasena
            // 
            this.textBoxCoContrasena.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoContrasena.Location = new System.Drawing.Point(303, 279);
            this.textBoxCoContrasena.Name = "textBoxCoContrasena";
            this.textBoxCoContrasena.Size = new System.Drawing.Size(152, 22);
            this.textBoxCoContrasena.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirmar contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrarse";
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(634, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCoContrasena);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxCorreo);
            this.Name = "FormRegistro";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxCoContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}