namespace Reservahoteles
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxCorreo = new System.Windows.Forms.TextBox();
            this.txtBoxContra = new System.Windows.Forms.TextBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxCorreo
            // 
            this.txtboxCorreo.AccessibleName = "textboxCorreoL";
            this.txtboxCorreo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCorreo.Location = new System.Drawing.Point(258, 146);
            this.txtboxCorreo.Name = "txtboxCorreo";
            this.txtboxCorreo.Size = new System.Drawing.Size(194, 23);
            this.txtboxCorreo.TabIndex = 0;
            // 
            // txtBoxContra
            // 
            this.txtBoxContra.AccessibleName = "textboxPasswordL";
            this.txtBoxContra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContra.Location = new System.Drawing.Point(258, 194);
            this.txtBoxContra.Name = "txtBoxContra";
            this.txtBoxContra.PasswordChar = '*';
            this.txtBoxContra.Size = new System.Drawing.Size(194, 23);
            this.txtBoxContra.TabIndex = 1;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.AccessibleName = "botonIngreso";
            this.buttonIniciar.BackColor = System.Drawing.Color.OldLace;
            this.buttonIniciar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.Location = new System.Drawing.Point(332, 280);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(98, 37);
            this.buttonIniciar.TabIndex = 2;
            this.buttonIniciar.Text = "Ingresar";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.AccessibleName = "botonRegistroL";
            this.buttonRegistrar.BackColor = System.Drawing.Color.OldLace;
            this.buttonRegistrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegistrar.Location = new System.Drawing.Point(192, 280);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRegistrar.Size = new System.Drawing.Size(98, 37);
            this.buttonRegistrar.TabIndex = 3;
            this.buttonRegistrar.Text = "Registrarse";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(271, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(634, 410);
            this.Controls.Add(this.txtboxCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.txtBoxContra);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxCorreo;
        private System.Windows.Forms.TextBox txtBoxContra;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

