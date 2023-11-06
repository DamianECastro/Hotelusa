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
    public partial class FormRegistro : Form
    {

        private FormLogin formL;
        public FormRegistro()
        {
            InitializeComponent();
        }


        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            cliente user = new cliente();
            user.Nombre = textBoxNombre.Text;
            user.Apellido = textBoxApellido.Text;
            user.Telefono = textBoxTelefono.Text;
            user.Gmail = textBoxCorreo.Text;
            user.Contraseña = textBoxContrasena.Text;
            user.ConfContraseña = textBoxCoContrasena.Text;

            controlador control = new controlador();
            string respuesta = control.CtrlRegistro(user);

            try
            {
                if(respuesta.Length > 0){
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (formL == null || formL.IsDisposed){
                        formL = new FormLogin();
                    }
                    // Muestra el formulario
                    formL.Show();
                    this.Visible = false;
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

        }
    }
}
