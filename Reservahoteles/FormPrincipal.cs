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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonAltaHotel_Click(object sender, EventArgs e)
        {
            FormAltaHotel fa = new FormAltaHotel();
            fa.Show();
        }
    }
}
