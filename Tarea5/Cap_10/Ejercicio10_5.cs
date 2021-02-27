using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tarea5.Cap_10
{
    class Ejercicio10_5
    {

    }

    public class Poligono2
    {
        public int Lados
        {
            get
            {
                return Lados;
            }
            set
            {
                if (value <= 0)
                {
                    Lados = 3;
                }
                else
                {
                    Lados = value;
                }
            }
        }

        public double MedidaLados
        {
            get
            {
                return MedidaLados;
            }
            set
            {
                if (value <= 0)
                {
                    MedidaLados = 3;
                }
                else
                {
                    MedidaLados = value;
                }
            }
        }

        public double Area { get; set; }
        public double Perimetro { get; set; }

        public Poligono2()
        {
            Lados = 0;
            MedidaLados = 0.0;
        }

        public Poligono2(int CantLado, double LongitudLado)
        {
            if (CantLado <= 2)
            {
                Lados = CantLado;
            }

            if (LongitudLado <= 0)
            {
                MedidaLados = LongitudLado;
            }

            Perimetro = CalcularPerimetro();
            Area = CalcularArea();
        }

        
        public double CalcularArea()
        {
            double angCentral = 360 / Lados;
            double apotema = Lados / (2 * Math.Tan(angCentral / 2));

            return (Perimetro * apotema) / 2;

        }

        public double CalcularPerimetro()
        {
            return Lados * MedidaLados;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Poligono: \n\tLados del polígono: {Lados}\n\tMedidas de los lados: {MedidaLados} \n\tÁrea: {Area}\n\tPerímetro: {Perimetro}");
            return (sb.ToString());
        }
    }
}
