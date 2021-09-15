using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDeClases;


namespace Repuesto.Interfaz
{
    class Program
    {

        static VentaRepuesto _listaProductos;
        List<Categoria> todasCategorias = new List<Categoria>();

        static void Main(string[] args)
        {
            

          
        }

        public  void RepuestoAgregar()
        {
            

            int code;
            string nombre;
            string stock;
            string Precio;
            Categoria categoria;
            bool flag = true;
            int salidaEntero=0;
            double salidaDouble = 0;


        

            do
            {
                Console.WriteLine("Ingrese El nombre");
                nombre = Console.ReadLine();
                flag = Helpers.ValidarString(nombre);

            } while (flag == false);
            flag = false;

            do
            {
                Console.WriteLine("Ingrese El stock del producto "+ nombre);
                stock = Console.ReadLine();
                flag = Helpers.ValidacionEntero(stock, ref salidaEntero);

            } while (flag == false);
            
            flag = false;

            do
            {
                Console.WriteLine("Ingrese El precio");
                Precio = Console.ReadLine();
                flag = Helpers.ValidacionDouble(Precio, ref salidaDouble);

            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el codigo de la categoria");
                . = Console.ReadLine();
                flag = Helpers.ValidacionDouble(Precio, ref salidaDouble);

            } while (flag == false);

            //Preguntar como asignar el codigo 

            //Preguntar comoa asignar la categoria. 



        }

        
    }
}
