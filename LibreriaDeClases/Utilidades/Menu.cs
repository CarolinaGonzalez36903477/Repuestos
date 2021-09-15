using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Utilidades
{
    class Menu
    {
        public void Inicio()
        {
            Console.WriteLine("*****SISTEMA REPUESTOS*****" + Environment.NewLine +
                "ELIJA LA OPCION QUE DESEA REALIZAR:" + Environment.NewLine +
                "1 - LISTAR REPUESTOS " + Environment.NewLine +
                "2- AGREGAR STOCK " + Environment.NewLine +
                "3- QUITAR STOCK");

        }
    }
}
