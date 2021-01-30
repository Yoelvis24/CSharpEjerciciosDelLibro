using System;

    class Ejercicio2_5
    {
        public Ejercicio2_5()
        {
            float dolar, euros, cambio;
            int op;

            Console.WriteLine("Convertir: \n1)De Dolares a Euros.\n2)De Euros a Dolares");
            op = Convert.ToInt32(Console.ReadLine());

            if(op == 1)
            {
                //ToSingle convierte de cadena a flotante
                Console.WriteLine("Ingrese el valor del dolar actualizado en EUROS: ");
                cambio = Convert.ToSingle(Console.ReadLine());

                //ToSingle convierte de cadena a flotante
                Console.WriteLine("Ingrese el monto en dolares a cambiar: ");
                dolar = Convert.ToSingle(Console.ReadLine());

                euros = dolar * cambio;

                Console.WriteLine("El monto ({0} USD$) en EUROS vale: {1} EUR", cambio, euros);

            }else if(op == 2)
            {
                //ToSingle convierte de cadena a flotante
                Console.WriteLine("Ingrese el valor del Euro actualizado en Dolares: ");
                cambio = Convert.ToSingle(Console.ReadLine());

                //ToSingle convierte de cadena a flotante
                Console.WriteLine("Ingrese el monto en Euros a cambiar: ");
                euros = Convert.ToSingle(Console.ReadLine());

                dolar = euros * cambio;

                Console.WriteLine("El monto ({0} EUR) en Dolares vale: {1} USD$", cambio, dolar);
            }
            
        }
    }

