using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosBásicos
{
    class División
    {
        static void Main(string[] args)
        {
            //Variables 
            int n1;
           int  n2;
            int res;

            //Datos de Entrada  
            Console.WriteLine("Escribe un numero entero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe segundo numero entero diferente a cero");
            n2 = int.Parse(Console.ReadLine());

            //Procedimiento 
            if (n2 <= 0 )
        {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            
            
            else
            {

                res = n1 / n2;
                //Resultado
                Console.WriteLine("Este es el resultado de división: " + res);
            }

            Console.ReadKey();
        }
    }
}
