using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2.Cap_7
{
    public partial class Ejercicio7_2 : Form
    {
        Hashtable diccionario = new Hashtable();

        public Ejercicio7_2()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            significadoTextBox.Text = "";
            //El primer parametro es la clave, key o palabra  
            //y el segundo paramero es el valor o significado de la clave o key
            if(!diccionario.ContainsKey("carpeta"))
            { 
                diccionario.Add("carpeta", "Objeto que se utiliza para agrupar y proteger información");
                
                significadoTextBox.Text = (string)diccionario[Convert.ToString(palabraTextBox.Text)];
            }
            else
            {
                MessageBox.Show("Clave inexistente");
            }

        }
    }
}
