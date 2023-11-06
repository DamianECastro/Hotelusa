using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservahoteles
{
    internal class Modelo
    {
        public int registro (cliente cliente)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open ();

            string sql = "INSERT INTO cliente (nombre, apellido, contraseña, gmail, telefono) VALUES (@nombre, @apellido, @contraseña, @gmail, @telefono)";

            MySqlCommand comando = new MySqlCommand (sql, conexion);
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@contraseña", cliente.Contraseña);
            comando.Parameters.AddWithValue("@gmail", cliente.Gmail);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool existeCliente (string cliente)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id_cliente FROM cliente where gmail LIKE @gmail";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@gmail", cliente);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public cliente porCliente(string gmail)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id_cliente, gmail, contraseña FROM cliente where gmail LIKE @gmail";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@gmail", gmail);

            reader = comando.ExecuteReader();

            cliente cli = null;

            while(reader.Read())
            {
                cli = new cliente();
                cli.Id_cliente = int.Parse(reader["id_cliente"].ToString());
                cli.Gmail = reader["gmail"].ToString();
                cli.Contraseña = reader["contraseña"].ToString();
            }
            return cli;
        }


        public int regisHotel(hotel hotel)
        {
            MemoryStream ms = new MemoryStream();
            hotel.Imagen.Save(ms, ImageFormat.Jpeg);
            byte[] abyte = ms.ToArray();

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO hotel (nombre_hotel, ubicacion, numero, caracteristicas, imagenNombre, imagen) VALUES (@nombre_hotel, @ubicacion, @numero, @caracteristicas, @imagenNombre, @imagen)";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre_hotel", hotel.Nombre_hotel);
            comando.Parameters.AddWithValue("@ubicacion", hotel.Ubicacion);
            comando.Parameters.AddWithValue("@numero", hotel.Numero);
            comando.Parameters.AddWithValue("@caracteristicas", hotel.Caracteristicas);
            comando.Parameters.AddWithValue("@imagenNombre", hotel.ImagenNombre);
            comando.Parameters.AddWithValue("@imagen", abyte);


            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }


        public int regisHabi(habitacion habi)
        {
            int Id_hotel = regisHotel(habi.hotel);
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO habitacion (id_hotel, numero_habitacion, tipoHabitación, datos_habitacion, precio) VALUES (@id_hotel, @numero_habitacion, @tipoHabitación, @datos_habitacion, @precio)";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_hotel", Id_hotel);
            comando.Parameters.AddWithValue("@numero_habitacion", habi.Numero_habitacion);
            comando.Parameters.AddWithValue("@tipoHabitación", habi.TipoHabitación);
            comando.Parameters.AddWithValue("@datos_habitacion", habi.Datos_habitacion);
            comando.Parameters.AddWithValue("@precio", habi.Precio);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }


        public bool existeHotel(string hotel)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id_hotel FROM hotel where nombre_hotel LIKE @nombre_hotel";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre_hotel", hotel);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public hotel porHotel(string nombre_hotel)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id_hotel, nombre_hotel, ubicacion FROM hotel where nombre_hotel LIKE @nombre_hotel";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre_hotel", nombre_hotel);

            reader = comando.ExecuteReader();

            hotel hotelito = null;

            while (reader.Read())
            {
                hotelito = new hotel();
                hotelito.Id_hotel = int.Parse(reader["id_cliente"].ToString());
                hotelito.Nombre_hotel = reader["gmail"].ToString();
                hotelito.Ubicacion = reader["contraseña"].ToString();
            }
            return hotelito;
        }
    }
}
