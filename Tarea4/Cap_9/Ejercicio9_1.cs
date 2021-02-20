using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tarea2.Tarea4.Cap_9
{
    public partial class Ejercicio9_1 : Form
    {
        public List<Articulos> articulos = new List<Articulos>();
        public int con = 1;

        public Ejercicio9_1()
        {
            InitializeComponent();
        }
        public struct Articulos
        {
            string nombre;
            string descripcion;
            double precioUnit;

            public Articulos(string Nombre, string Descripcion, double Precio)
            {
                nombre = Nombre;
                descripcion = Descripcion;
                precioUnit = Precio;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Nombre:{nombre}/Precio:{precioUnit}/Descripcion:{descripcion}");
                return (sb.ToString());
            }
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            foreach (Articulos a in articulos)
            {
                ResultadoListBox.Items.Clear();
                ResultadoListBox.Items.Add(a.ToString());
                con++;
            }    
            
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string descripcion = "";
            double precio = 0.0;
            
            nombre = NombreTextBox.Text;
            descripcion = DescripcionTextBox.Text;
            precio = Convert.ToDouble(PrecioTextBox.Text);

            articulos.Add(new Articulos(nombre, descripcion, precio));
            MessageBox.Show("El articulo se guardó correctamente");
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
