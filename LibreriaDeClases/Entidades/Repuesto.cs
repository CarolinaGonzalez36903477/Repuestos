using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaDeClases
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        //Constructores
        public Repuesto()
        {

        }

        public Repuesto(int codigo, string nombre, double precio, int stock, Categoria categoria)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = categoria;

        }

        //Propiedades 
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
        public string Nombre
        {
            get
            {
                return _nombre;
            }


        }

        public double Precio
        {
            get
            {
                return _precio;
            }

        }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }

        }

        public Categoria Categoria
        {
            get
            {
                return _categoria;
            }

        }



        //ToString 

        public override string ToString()
        {
            return string.Format("Codigo:{0}" + System.Environment.NewLine + "Nombre:{1}" + System.Environment.NewLine + "Precio:{2}" + System.Environment.NewLine + "Stock:{3}" + System.Environment.NewLine + "Categorias:{4}" + System.Environment.NewLine + Codigo, Nombre, Precio, Stock, Categoria);
        }
      
    }
}
