using System;

    class Ejercicio2_4
    {
        public Ejercicio2_4()
        {
            float gradoC;
            float gradoF;
            string entrada = "";

            Console.Write("Ingrese el valor de celsius: ");
            entrada = Console.ReadLine();
            gradoC = Convert.ToSingle(entrada);

            gradoF = (float)(gradoC * 1.80) + 32;

            Console.WriteLine("La conversion de {0} C a grados fahrenheit es: {1}", gradoC, gradoF);

        }
    }