using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservahoteles
{
    class habitacion
    {
        internal hotel hotel;
        int id_habitacion, id_hotel;
        string numero_habitacion, tipoHabitación, datos_habitacion, precio;
        

        public string TipoHabitación { get => tipoHabitación; set => tipoHabitación = value; }
        public string Datos_habitacion { get => datos_habitacion; set => datos_habitacion = value; }
        public string Precio { get => precio; set => precio = value; }

        public int Id_habitacion { get => id_habitacion; set => id_habitacion = value; }
        public int Id_hotel { get => id_hotel; set => id_hotel = value; }
        public string Numero_habitacion { get => numero_habitacion; set => numero_habitacion = value; }
    }
}
