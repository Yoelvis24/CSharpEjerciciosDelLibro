using System;

namespace Ejercicio2_3
{
    class Program
    {
        static void Main(string[] args)
        { 
            double radianes;
            float grados;
            string entrada = "";

            //ToSingle convierte de cadena a flotante
            Console.WriteLine("Ingrese el valor en grados: ");
            entrada = Console.ReadLine();
            grados = Convert.ToSingle(entrada);

            radianes = grados * System.Math.PI / 180;

            Console.WriteLine("El resultado es igual a: ");
            Console.WriteLine("Radianes: {0}", radianes);
        }
    }
}
