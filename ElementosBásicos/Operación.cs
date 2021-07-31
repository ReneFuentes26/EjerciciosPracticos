using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class Operación

    {
      static void Main(string[] args)
    {
            //Variables 
            int num1;
            int num2;
            double res;

            //Datos de entrada
            Console.WriteLine("Introduzca el Primer valor");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el Segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Resultados
            Console.WriteLine("Presiona cualquier tecla para ver los resultados");
            Console.ReadKey();
            res = (num1 + num2) * (num1 - num2);
            Console.WriteLine(" Este es el resultado de la primera operación " +  res);
            res = num1*2 - num2;
            Console.WriteLine(" Este es el resultado de la segunda operación " + res);

            Console.ReadKey();
        }
    }
}
