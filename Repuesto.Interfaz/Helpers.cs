using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuesto.Interfaz
{
    class Helpers
    {

         internal static bool ValidacionEntero(string dato, ref int salida)
        {

            bool flag = false;
            if (!int.TryParse(dato, out salida))
            {

                Console.WriteLine("Usted debe ingresar un dato numérico");
            }
            if (salida <= 0)
            {
                Console.WriteLine("Usted debe ingresar un número mayor que cero");
            }

            else
            {
                flag = true;
            }
            return flag;
        }

    

        //validar String 
        internal static bool ValidarString(string dato)
        {
            bool flag = false;
            
            if (dato.Equals(string.Empty))
            {
                Console.WriteLine("Ingrese el dato , no puede estar vacio ");
                return flag;
            }
            else
            {
                flag = true;
            }

            return flag;

        }

        internal static bool ValidacionDouble(string dato, ref double salida)
        {

            bool flag = false;
            if (!double.TryParse(dato, out salida))
            {

                Console.WriteLine("Usted debe ingresar un dato numérico");
            }
            if (salida <= 0)
            {
                Console.WriteLine("Usted debe ingresar un número mayor que cero");
            }

            else
            {
                flag = true;
            }
            return flag;
        }

        //Generador del codigo de repuesto 

        public int ObtenerMaxCodigo()
        {
            int resultado = 0;
            foreach (var item in _listaProductos)
            {
                resultado = item.codigo;
            }
            return ++resultado;


        }
}
