using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumas_sucesivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma = 0;
            Console.WriteLine("Sumas sucesivas");
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            
            while (num2 != 0)
            {
                suma = suma + num1;
                num2 = num2 - 1;
            }

            Console.WriteLine("El resultado es: {0}", suma);
            Console.ReadKey();
        }
    }
}
