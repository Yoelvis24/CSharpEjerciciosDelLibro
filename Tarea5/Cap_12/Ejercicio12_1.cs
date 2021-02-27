using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tarea5.Cap_12
{
    class Ejercicio12_1
    {
    
        public void Calcular()
        {
            int numero;
            
            Console.WriteLine("En este programa se mostrara el valor del factorial del numero que ingrese.");

            Console.Write("Ingrese el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El factorial de {numero} es: {Factorial(numero)}");
        }

        public int Factorial(int numero)
        {
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

}
