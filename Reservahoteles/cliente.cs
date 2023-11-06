using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservahoteles
{
    internal class cliente
    {
        int id_cliente;
        string nombre, apellido, contraseña, confContraseña, gmail, telefono;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string ConfContraseña { get => confContraseña; set => confContraseña = value; }
    }
}
