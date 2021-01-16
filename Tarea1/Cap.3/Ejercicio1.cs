using System;

namespace Ejercicio3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string entrada = "";

            Console.Write("Ingrese el numero a consultar: ");
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);

            if(n % 2 == 0)
            {
                Console.WriteLine("El numero {0} es par", n);
            }
            else
            {
                Console.WriteLine("El numero {0} no es par", n);
            }
        }
    }
}