using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservahoteles
{
    class controlador
    {
        public string CtrlRegistro(cliente usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Apellido) || string.IsNullOrEmpty(usuario.Telefono)
                || string.IsNullOrEmpty(usuario.Gmail) || string.IsNullOrEmpty(usuario.Contraseña) || string.IsNullOrEmpty(usuario.ConfContraseña))
            {
                respuesta = "Completar todos los campos";
            }
            else
            {
                if (usuario.Contraseña == usuario.ConfContraseña)
                {
                    if (modelo.existeCliente(usuario.Gmail))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }


        public string ctrlRegistroHotelHabitacion(hotel hotelito, habitacion habi)
        {
            Modelo modelo = new Modelo();
            string respuesta = " ";

            if (hotelito.Imagen != null)
            {
                // Llama al método regisHotel pasando el objeto hotel correctamente inicializado
                int respuestaa = modelo.regisHotel(hotelito);
                // Realiza alguna acción adicional después de guardar, si es necesario
            }
            else
            {
                // Manejo si la imagen es nula
                respuesta = "La imagen es nula. No se puede guardar en la base de datos.";
                // Realiza alguna acción adicional si la imagen es nula
            }
            if (string.IsNullOrEmpty(hotelito.Nombre_hotel) || string.IsNullOrEmpty(hotelito.Ubicacion) || string.IsNullOrEmpty(hotelito.Numero) || string.IsNullOrEmpty(hotelito.Caracteristicas) || string.IsNullOrEmpty(hotelito.ImagenNombre) 
                || string.IsNullOrEmpty(habi.Numero_habitacion) || string.IsNullOrEmpty(habi.Precio) || string.IsNullOrEmpty(habi.Datos_habitacion))
            {
                respuesta = "Completar todos los campos";
            }
            else
            {
                if (modelo.existeHotel(hotelito.Nombre_hotel))
                {
                   respuesta = "El Hotel ya existe";
                }else
                {
                   modelo.regisHotel(hotelito);
                   modelo.regisHabi(habi);
                }
            }
            return respuesta;
        }


        public string ctrlLogin(string gmail, string contraseña)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            cliente datosCliente = null;

            if (string.IsNullOrEmpty(gmail) || string.IsNullOrEmpty(contraseña))
            {
                respuesta = "Completar todos los campos";

            } else
            {
                datosCliente = modelo.porCliente(gmail);

                if (datosCliente == null)
                {
                    respuesta = "EL USUARIO NO EXISTE";
                } else
                {
                    if(datosCliente.Contraseña != contraseña)
                    {
                        respuesta = "El usuario y/o contraseña incorrecta";
                    }
                }
            }
            return respuesta;
        }
    } 
}
