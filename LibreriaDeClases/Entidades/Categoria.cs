using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

        public Categoria()
        {


        }
        public Categoria(int cod, string nom)
        {

            _codigo = cod;
            _nombre = nom;

        }

        public string Nombre { get { return _nombre; } }
        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {

                _codigo = value;

            }

        }
    }



}
