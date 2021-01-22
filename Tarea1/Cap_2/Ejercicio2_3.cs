using System;

    class Ejercicio2_3
    {
        public Ejercicio2_3()
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
