using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tarea5.Cap_10
{
    class Ejercicio10_1
    {
        //El ejercicio solo pide el diseño de una clase de un inventario
        //por lo que este este ejercicio se ve un poco vacio.

        Articulo articulo = new Articulo();
    }

    class Articulo
    {
        public string Nombre { get; set; }
        public int codigoArticulo { get; set; }
        public int CantidadArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Articulo()
        {
            Nombre = " ";
            codigoArticulo = 0;
            CantidadArticulo = 0;
            Descripcion = "";
            Precio = 0.0;
        }

        public Articulo(string NombreArtic, int CodigoArtic, string DescripcionArtic, double Precio)
        {
            Nombre = NombreArtic;
            codigoArticulo = CodigoArtic;
            CantidadArticulo = 1;
            Descripcion = DescripcionArtic;
            Precio = Precio;
        }

        public int RetirarUnidades(int CantSolicitada)
        {
            if (CantSolicitada > 0)
            {
                if (CantidadArticulo <= CantSolicitada)
                {
                    CantidadArticulo -= CantSolicitada;
                }
                else
                {
                    CantSolicitada = CantidadArticulo;
                    CantidadArticulo -= CantidadArticulo;
                }

                return CantSolicitada;
            }
            else
            {
                return 0;
            }
        }

        public void AgregarUnidades(int CantRecibida)
        {
            if (CantRecibida > 0)
            {
                CantidadArticulo += CantRecibida;
            }
        }

        public string InfoProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Producto: \n\tCodigo del articulo: {codigoArticulo} \n\tNombre del articulo: {Nombre}\n\tDescripción: {Descripcion} \n\tPrecio por Unidad: {Precio} \n\tCantidad de unidades disponibles: {CantidadArticulo}");
            return (sb.ToString());
        }
    }
}
