using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservahoteles
{
    public partial class FormLogin : Form
    {
        private FormRegistro formulario2;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (formulario2 == null || formulario2.IsDisposed)
            {
                formulario2 = new FormRegistro();
            }

            // Muestra el formulario
            formulario2.Show();
            this.Visible = false;
        }


        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            string gmail = txtboxCorreo.Text;
            string contraseña = txtBoxContra.Text;

            try
            {
                controlador control = new controlador();
                string respuesta = control.ctrlLogin(gmail, contraseña);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormPrincipal fp = new FormPrincipal();
                    fp.Show();
                    this.Visible = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


      
