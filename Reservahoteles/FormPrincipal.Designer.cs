
namespace Reservahoteles
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.comboBoxNombreHotel = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDATOS = new System.Windows.Forms.Label();
            this.labeltextImagen = new System.Windows.Forms.Label();
            this.buttonMisReservas = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAltaHotel = new System.Windows.Forms.Button();
            this.labelEsDisponible = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPuntuación = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONA HOTEL";
            // 
            // dateTimeFechaInicio
            // 
            this.dateTimeFechaInicio.Location = new System.Drawing.Point(47, 131);
            this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            this.dateTimeFechaInicio.Size = new System.Drawing.Size(211, 20);
            this.dateTimeFechaInicio.TabIndex = 2;
            // 
            // dateTimeFechaFinal
            // 
            this.dateTimeFechaFinal.Location = new System.Drawing.Point(47, 189);
            this.dateTimeFechaFinal.Name = "dateTimeFechaFinal";
            this.dateTimeFechaFinal.Size = new System.Drawing.Size(211, 20);
            this.dateTimeFechaFinal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Final";
            // 
            // comboBoxUbicacion
            // 
            this.comboBoxUbicacion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUbicacion.FormattingEnabled = true;
            this.comboBoxUbicacion.Location = new System.Drawing.Point(47, 68);
            this.comboBoxUbicacion.Name = "comboBoxUbicacion";
            this.comboBoxUbicacion.Size = new System.Drawing.Size(211, 24);
            this.comboBoxUbicacion.TabIndex = 6;
            // 
            // comboBoxNombreHotel
            // 
            this.comboBoxNombreHotel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNombreHotel.FormattingEnabled = true;
            this.comboBoxNombreHotel.Location = new System.Drawing.Point(47, 295);
            this.comboBoxNombreHotel.Name = "comboBoxNombreHotel";
            this.comboBoxNombreHotel.Size = new System.Drawing.Size(184, 24);
            this.comboBoxNombreHotel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(335, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "¿Donde quieres ir?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hoteles de tu Elección";
            // 
            // labelDATOS
            // 
            this.labelDATOS.AutoSize = true;
            this.labelDATOS.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDATOS.Location = new System.Drawing.Point(102, 336);
            this.labelDATOS.Name = "labelDATOS";
            this.labelDATOS.Size = new System.Drawing.Size(0, 16);
            this.labelDATOS.TabIndex = 12;
            // 
            // labeltextImagen
            // 
            this.labeltextImagen.AutoSize = true;
            this.labeltextImagen.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltextImagen.Location = new System.Drawing.Point(338, 311);
            this.labeltextImagen.Name = "labeltextImagen";
            this.labeltextImagen.Size = new System.Drawing.Size(89, 18);
            this.labeltextImagen.TabIndex = 13;
            this.labeltextImagen.Text = "Imagen Hotel";
            // 
            // buttonMisReservas
            // 
            this.buttonMisReservas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMisReservas.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMisReservas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMisReservas.ImageKey = "(ninguno)";
            this.buttonMisReservas.Location = new System.Drawing.Point(637, 68);
            this.buttonMisReservas.Name = "buttonMisReservas";
            this.buttonMisReservas.Size = new System.Drawing.Size(121, 34);
            this.buttonMisReservas.TabIndex = 14;
            this.buttonMisReservas.Text = "Mis reservas";
            this.buttonMisReservas.UseVisualStyleBackColor = false;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSiguiente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSiguiente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSiguiente.Location = new System.Drawing.Point(622, 384);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(136, 56);
            this.buttonSiguiente.TabIndex = 15;
            this.buttonSiguiente.Text = "Siguiente >>";
            this.buttonSiguiente.UseVisualStyleBackColor = false;
            // 
            // buttonAltaHotel
            // 
            this.buttonAltaHotel.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAltaHotel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltaHotel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAltaHotel.ImageKey = "(ninguno)";
            this.buttonAltaHotel.Location = new System.Drawing.Point(637, 117);
            this.buttonAltaHotel.Name = "buttonAltaHotel";
            this.buttonAltaHotel.Size = new System.Drawing.Size(121, 34);
            this.buttonAltaHotel.TabIndex = 16;
            this.buttonAltaHotel.Text = "Subir Hotel";
            this.buttonAltaHotel.UseVisualStyleBackColor = false;
            this.buttonAltaHotel.Click += new System.EventHandler(this.buttonAltaHotel_Click);
            // 
            // labelEsDisponible
            // 
            this.labelEsDisponible.AutoSize = true;
            this.labelEsDisponible.BackColor = System.Drawing.Color.LightGreen;
            this.labelEsDisponible.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEsDisponible.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEsDisponible.Location = new System.Drawing.Point(246, 405);
            this.labelEsDisponible.Name = "labelEsDisponible";
            this.labelEsDisponible.Size = new System.Drawing.Size(143, 18);
            this.labelEsDisponible.TabIndex = 17;
            this.labelEsDisponible.Text = "Esta disponible ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "PUNTUACIÓN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "/8";
            // 
            // labelPuntuación
            // 
            this.labelPuntuación.AutoSize = true;
            this.labelPuntuación.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelPuntuación.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntuación.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelPuntuación.Location = new System.Drawing.Point(184, 405);
            this.labelPuntuación.Name = "labelPuntuación";
            this.labelPuntuación.Size = new System.Drawing.Size(17, 16);
            this.labelPuntuación.TabIndex = 20;
            this.labelPuntuación.Text = "7";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelPuntuación);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelEsDisponible);
            this.Controls.Add(this.buttonAltaHotel);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonMisReservas);
            this.Controls.Add(this.labeltextImagen);
            this.Controls.Add(this.labelDATOS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxNombreHotel);
            this.Controls.Add(this.comboBoxUbicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeFechaFinal);
            this.Controls.Add(this.dateTimeFechaInicio);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "Hotelusa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUbicacion;
        private System.Windows.Forms.ComboBox comboBoxNombreHotel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDATOS;
        private System.Windows.Forms.Label labeltextImagen;
        private System.Windows.Forms.Button buttonMisReservas;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAltaHotel;
        private System.Windows.Forms.Label labelEsDisponible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPuntuación;
    }
}