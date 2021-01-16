using System;

namespace Ejercicio2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float dolar, euros, cambio;
            string entrada = "";
            int op;

            Console.WriteLine("Convertir: \n1)De Dolares a Euros.\n2)De Euros a Dolares");
            entrada = Console.ReadLine();
            op = Convert.ToInt32(entrada);

            if(op == 1)
            {
                //ToSingle convierte de cadena a flotante
                Console.WriteLine("Ingrese el valor del dolar actualizado en EUROS: ");
                entrada = Console.ReadLine();
                cambio = Convert.ToSingle(entrada);

                //ToSingle convierte de cadena a flotante
                Console.WriteLine("Ingrese el monto en dolares a cambiar: ");
                entrada = Console.ReadLine();
                dolar = Convert.ToSingle(entrada);

                euros = dolar * cambio;

                Console.WriteLine("El monto ({0} USD$) en EUROS vale: {1} EUR", cambio, euros);

            }else if(op == 2)
            {
                //ToSingle convierte de cadena a flotante
                Console.WriteLine("Ingrese el valor del Euro actualizado en Dolares: ");
                entrada = Console.ReadLine();
                cambio = Convert.ToSingle(entrada);

                //ToSingle convierte de cadena a flotante
                Console.WriteLine("Ingrese el monto en Euros a cambiar: ");
                entrada = Console.ReadLine();
                euros = Convert.ToSingle(entrada);

                dolar = euros * cambio;

                Console.WriteLine("El monto ({0} EUR) en Dolares vale: {1} USD$", cambio, dolar);
            }
            
        }
    }
}
