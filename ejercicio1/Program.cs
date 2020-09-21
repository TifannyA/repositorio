using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ferreteria;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string dato;
            //    Console.WriteLine("Hola Clase");
            //    dato = Console.ReadLine();
            //    Console.WriteLine("Digito: " + dato);
            //}

            //Ctrl K + Ctrl C comentar
            //Ctrl K + Ctrl u descomentar 

            //    int tabla;
            //    int j = 0;

            //    Console.WriteLine("Ingrese una tabla");
            //    tabla = int.Parse(Console.ReadLine());

            //    while (j<=10)
            //    {
            //        Console.WriteLine("El resultado es: " + tabla*j);
            //        j++;
            //    }

            //    Console.ReadKey();
            //}


            //Ejemplos de switch
            do
            {
                switch (switch_on)
                {
                    case: 1
                    break;
                    default;

                }
            } while (true);

            //Ejemplos de for
            for (int i = 0; i < length; i++)
            {

            }

            foreach (var item in collection)
            {

            }

            //Ejemplos de arreglo
            int[] arreglo = { 1, 2, 3, 4, 5 };
            int[] datos = new int[5];
            datos[0] = 5;

            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine(1);

            }

            
            ferreteria.Producto clavo1 = new Producto();
            ferreteria.Producto clavo2 = new Producto(0,"Acero",1);
            clavo1.facturar();
            clavo2.facturar();

        }

    }
}
