using System;

    class Ejercicio3_4
    {
        public Ejercicio3_4()
        {
            int dia;

            Console.Write("Ingrese un numero del 1 al 7 porfavor: ");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("El dia es Lunes.");
                    break;
                case 2:
                    Console.WriteLine("El dia es Martes.");
                    break;
                case 3:
                    Console.WriteLine("El dia es Miercoles.");
                    break;
                case 4:
                    Console.WriteLine("El dia es Jueves.");
                    break;
                case 5:
                    Console.WriteLine("El dia es Viernes.");
                    break;
                case 6:
                    Console.WriteLine("El dia es Sabado.");
                    break;
                case 7:
                    Console.WriteLine("El dia es Domingo.");
                    break;
                default:
                    Console.WriteLine("El numero ingresado no pertence a los dias de la semana");
                    break;
            }
        }
    }