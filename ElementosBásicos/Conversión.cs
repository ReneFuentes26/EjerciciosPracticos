using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class Conversión
    {
        static void Main(string[] args)
        {
            //Variables 
            double c, f;

            //Datos de Entrada

            Console.WriteLine("Ingrese los grados centigrados que desea convertir: ");
            c = Convert.ToDouble(Console.ReadLine());

            //Procedimiento

            f = (c * 9 / 5) + 32;

            //Resultados 

            Console.WriteLine("Estos son los grados Centgrados en Fahrenheit: " + f);
            Console.ReadKey();
         }
    }
}
