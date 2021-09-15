using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Utilidades
{
    class AgregarRepuesto
    {
        public  AgregarRepuesto()
        {
            List<string>  Repuesto = new List<string>();
            string nombre;
            int codigo;
            double precio;
            int stock;
            Categoria categoria; 

            do
            {
                Console.WriteLine("Por favor ingrese Nombre del repuesto que desea agregar ");
                nombre = Console.ReadLine();

                Console.WriteLine("¿Desea seguir agregando registros S/N?");
                Condicion = Console.ReadLine();

            } while (Condicion == "S");

            string lista = "";
            Console.WriteLine("Los registros cargados son: ");

            foreach (int registros in Registro)
            {
                lista += registros + System.Environment.NewLine;
            }
            Console.WriteLine(lista);

        }
    }
}
