using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservahoteles.Clases
{
    internal class Conexion
    {
        private MySqlConnection sistema_de_reservas;
        private string server = "localhost";
        private string database = "Hotel";
        private string user = "root";
        private string password = "123456";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Server=" + server + ";Database=" + database + ";User ID=" + user + ";Password=" + password;
        }

        public MySqlConnection getConexion()
        {
            if (sistema_de_reservas == null)
            {
                sistema_de_reservas = new MySqlConnection(cadenaConexion);
                sistema_de_reservas.Open();
            }
            return sistema_de_reservas;
        }
    }
}
