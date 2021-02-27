using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tarea5.Cap_10
{
    class Ejercicio10_4
    {
    }

    public class Poligonos
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

        public float MedidaLados
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

        public Poligonos()
        {
            Lados = 0;
            MedidaLados = 0.0f;
        }

        public Poligonos(int CantLado, float LongitudLado)
        {
            if (CantLado <= 2)
            {
                Lados = CantLado;
            }
        
            if (LongitudLado <= 0)
            {
                MedidaLados = LongitudLado;
            }
        }

    }
}
