using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservahoteles
{
    class hotel
    {
        int id_hotel;
        string nombre_hotel, ubicacion, numero, caracteristicas, imagenNombre;
        Image imagen;

        public string Nombre_hotel { get => nombre_hotel; set => nombre_hotel = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public string ImagenNombre { get => imagenNombre; set => imagenNombre = value; }
        public int Id_hotel { get => id_hotel; set => id_hotel = value; }
        public Image Imagen { get => imagen; set => imagen = value; }

    }
}
