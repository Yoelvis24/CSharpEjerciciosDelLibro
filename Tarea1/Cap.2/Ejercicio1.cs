using System;

namespace Ejercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float perimetro, medida;
            int cantidad;
            string entrada = "";

            //ToInt32 covierte cadena en entero
            Console.WriteLine("Ingrese la cantidad de los lados del poligono: ");
            entrada = Console.ReadLine();
            cantidad = Convert.ToInt32(entrada);

            //ToSingle convierte de cadena a flotante
            Console.WriteLine("Ingrese la medida de los lados del poligono: ");
            entrada = Console.ReadLine();
            medida = Convert.ToSingle(entrada);

            perimetro = medida * cantidad;

            Console.WriteLine("El perimetro del poligono regular es: {0}", perimetro);
            
        }
    }
}
