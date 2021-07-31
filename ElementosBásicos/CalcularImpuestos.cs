using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class CalcularImpuestos
    {
        static void Main(string[] args)
        {

            //Variables
            double imp, precio, preconimpuesto;
            int producto;

            //Datos de entrada
            Console.WriteLine("Menú de Opciones");
            Console.WriteLine("\n1 Frutas");
            Console.WriteLine("\n2 Lacteos");
            Console.WriteLine("\n3 Medicinas");
            Console.WriteLine("\nSelecciona una opción");
            producto = Int32.Parse(Console.ReadLine());

            Console.Write("\nIngresa el impuesto al dia (%)");
            imp = Double.Parse(Console.ReadLine());

            if (producto == 1 || producto == 2) 
            {
                Console.Write("\nIngrese el precio del producto");
                precio = Double.Parse(Console.ReadLine());
                preconimpuesto = ((imp / 100) * precio) + precio;
                Console.WriteLine("\nEl precio del producto es: " + preconimpuesto);
            }

            else if (producto == 3)
            {
                Console.WriteLine("\nIngrese el precio del producto: ");
                precio = Double.Parse(Console.ReadLine());
                Console.WriteLine("\nEl precio del producto es: " + precio);
            }

            else
            {
                Console.WriteLine("\nEl producto no esta disponible");
            }

            Console.ReadKey();
        }
    }
}
