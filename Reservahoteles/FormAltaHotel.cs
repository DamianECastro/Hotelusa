using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservahoteles
{
    public partial class FormAltaHotel : Form
    {
        public FormAltaHotel()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {


            hotel hotelito = new hotel();
            habitacion habi = new habitacion();
            hotelito.Nombre_hotel = textBoxNombreHotel.Text;
            hotelito.Ubicacion = textBoxUbicacion.Text;
            hotelito.Numero = textBoxNumContacto.Text;
            hotelito.Caracteristicas = textBoxCaracteristica.Text;
            hotelito.ImagenNombre = textBoxNameImag.Text;
            hotelito.Imagen = pictureBoxSeleccionada.Image; // Asignar la imagen desde el PictureBox
            habi.Numero_habitacion = textBoxCantHabitacion.Text;
            habi.Precio = textBoxPrecio.Text;
            habi.Datos_habitacion = textBoxCaracteristica.Text;
            if (checkBoxGDepto.Checked) // Si el CheckBox está marcado
            {
                habi.TipoHabitación = checkBoxGDepto.Text;
            }
            if (checkBoxHGeneral.Checked) // Si el CheckBox está marcado
            {
                habi.TipoHabitación = checkBoxHGeneral.Text;
            }
            if (checkBoxHIndividual.Checked) // Si el CheckBox está marcado
            {
                habi.TipoHabitación = checkBoxHIndividual.Text;
            }
            if (checkBoxHPresidencial.Checked) // Si el CheckBox está marcado
            {
                habi.TipoHabitación = checkBoxHPresidencial.Text;
            }
            if (checkBoxHSuit.Checked) // Si el CheckBox está marcado
            {
                habi.TipoHabitación = checkBoxHSuit.Text;
            }

            controlador control = new controlador();
            string respuesta = control.ctrlRegistroHotelHabitacion(hotelito, habi);
            try
            {
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    this.Visible = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonSeleccionaImag_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionaImag = new OpenFileDialog();
            ofdSeleccionaImag.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionaImag.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionaImag.Title = "Seleccionar Imagen";
            if (ofdSeleccionaImag.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSeleccionada.Image = Image.FromFile(ofdSeleccionaImag.FileName);
            }
        }

    }
}
