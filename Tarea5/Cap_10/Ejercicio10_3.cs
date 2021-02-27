using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tarea5.Cap_10
{
    class Ejercicio10_3
    {
        //En este ejercicio solo se pide mostrar 
        //una sobrecarga de constructor de la clase Poligono
    }

    class Poligono
    {
        public int Lados { get; set; }
        public float MedidaLados { get; set; }

        public Poligono()
        {
            Lados = 0;
            MedidaLados = 0.0f;
        }

        public Poligono(int CantLado, float LongitudLado)
        {
            Lados = CantLado;
            MedidaLados = LongitudLado;
        }

    }
}
