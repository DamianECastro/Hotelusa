using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservahoteles
{
    internal class Conexion
    {
        public static MySqlConnection getConexion()
        { 
            string server = "localhost";
            string database = "Hotel";
            string user = "root";
            string password = "123456";

            string cadenaConexion = "Server=" + server + ";Database=" + database + ";User ID=" + user + ";Password=" + password;
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }
        
    }
}