using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Utilidades
{
    class SolicitudDatos
    {
        public static string ValidarCadena(string mensaje)
        {
            string cadena;
            do
            {
                Console.WriteLine(mensaje);
                cadena = Console.ReadLine();

                if (string.IsNullOrEmpty(mensaje))
                {
                    Console.WriteLine("No puede dejar el campo vacio");
                }


            } while (string.IsNullOrEmpty(mensaje));
            return cadena;
        }

        public static float ValidarNumerico(string mensaje)
        {
            string dato;
            bool flag = false;
            do
            {
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();
                if (string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("Debe ingresar un valor");
                }
                else if (Convert.ToSingle(dato) < 0)
                {
                    Console.WriteLine("Debe ingresar un valor positivo");
                }
                else
                {

                    flag = true;
                }
            } while (flag == false);

            return Convert.ToSingle(dato);
        }

        public static DateTime ValidarFecha(string mensaje)
        {
            DateTime fecha;
            do
            {
                Console.WriteLine(mensaje);
                if (!DateTime.TryParse(Console.ReadLine(), out fecha))
                {
                    Console.WriteLine("Dato invalido");
                }


            } while (!DateTime.TryParse(Console.ReadLine(), out fecha));

            return fecha;
        }
    }
}
