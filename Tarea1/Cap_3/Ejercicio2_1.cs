using System;

    class Ejercicio3_1
    {
        public Ejercicio3_1()
        {
            int n;

            Console.Write("Ingrese el numero a consultar: ");
            n = Convert.ToInt32(Console.ReadLine());

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