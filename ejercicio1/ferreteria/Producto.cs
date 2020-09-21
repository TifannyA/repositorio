using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria
{
    public class Producto
    {
        private int codigo;
        protected string nombre;
        public double precio;

        public Producto() //ctor doble tap
        {
        }

        public Producto(int pCodigo, string nom, double pPrecio) //p = parámetro
        {
            this.codigo = pCodigo;
            this.nombre = nom;
            this.precio = precio;

        }

        public void facturar()
        {
            Console.WriteLine("Paga el producto");
        }
    }
}
