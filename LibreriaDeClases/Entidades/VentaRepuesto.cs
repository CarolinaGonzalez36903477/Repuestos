using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class VentaRepuesto
    {
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;
        private static List<Repuesto> _listaProductosPorCategoria = new List<Repuesto>();

        public VentaRepuesto()
        {

        }

        public VentaRepuesto(List<Repuesto> listaproductos, string nombre, string direccion)
        {
            _listaProductos = listaproductos;
            _nombreComercio = nombre;
            _direccion = direccion;

        }

        //Propiedades
        public List<Repuesto> listaProductos { get { return _listaProductos; } }
        public string nombreComercio { get { return _nombreComercio; } }

        public string direccion { get { return _direccion; } }

        //metodos 

        public void QuitarRepuesto(int codigo)
        {
            Repuesto repuesto;

            repuesto = BuscarRepuesto(codigo);

            if (repuesto == null)
            {
                Console.Write("El codigo ingresado no se encuentra en el sistema");

            }

            else
            {
                _listaProductos.Remove(repuesto);

            }

        }

        public Repuesto BuscarRepuesto(int codigo)
        {
            return _listaProductos.Find(_listaProductos => _listaProductos.Codigo == codigo);
        }


        public void AgregarStock(int codigo, int stockAAgregar)
        {
            Repuesto repuesto;
            repuesto = BuscarRepuesto(codigo);
            if (repuesto == null)
            {
                Console.Write("El codigo ingresado no se encuentra en el sistema");

            }

            else
            {

                repuesto.Stock = repuesto.Stock + stockAAgregar;

            }

        }

        public List <Repuesto> TraerPorCategoria(int codcategoria)
        {
            List<Repuesto> productoPorCategoria = new List<Repuesto>();

            foreach (Repuesto R in _listaProductos)
            {
                if (R.Categoria.Codigo == codcategoria)
                {
                    productoPorCategoria.Add(R);
                }
            
            }

            return productoPorCategoria;

        }


        public void MostrarRepuestosCategoria()
        {

            int cat; 
            Console.WriteLine("Ingrese el codigo de la categoria");
            cat = int.Parse(Console.ReadLine());

            List<Repuesto> RepuestosPorCategoria = new List<Repuesto>();

            RepuestosPorCategoria = TraerPorCategoria(cat);

            foreach (Repuesto r in RepuestosPorCategoria)
            {
                Console.WriteLine(r.Nombre + System.Environment.NewLine); 
                
            }


        }

        public int GeneracionCodigo()
        {
            int num = 1;
            foreach (var item in _listaProductos)
            {
                num = item.Codigo;
            }
            return ++num;
        }

        public void AgregarRepuesto(Repuesto repuesto)
        {
            if (repuesto == null)
            {
                Console.WriteLine("No se puede agregar un repuesto vacio");
               
            }

            else
            {

                foreach (Repuesto r in _listaProductos)
                {
                    if (r.Codigo == repuesto.Codigo)
                    {

                        Console.WriteLine("El repuesto con el codigo " + repuesto.Codigo + " ya se encuentra agregado");

                        break;
                    }

                    else

                    {
                        _listaProductos.Add(repuesto);
                    
                    }
                }
            
            }
        
                
        }

      
    }
}