using System;

    class Ejercicio2_1
    {
        public Ejercicio2_1()
        {
            float perimetro, medida;
            int cantidad;

            //ToInt32 covierte cadena en entero
            Console.WriteLine("Ingrese la cantidad de los lados del poligono: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            //ToSingle convierte de cadena a flotante
            Console.WriteLine("Ingrese la medida de los lados del poligono: ");
            medida = Convert.ToSingle(Console.ReadLine());

            perimetro = medida * cantidad;

            Console.WriteLine("El perimetro del poligono regular es: {0}", perimetro);
            
        }
    }

