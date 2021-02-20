using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2.Tarea4.Cap_8
{
    public partial class Ejercicio8_5 : Form
    {
        public Ejercicio8_5()
        {
            InitializeComponent();
        }
        
        void limpiar()
        {
            PrimeraCadenaTextBox.Text = string.Empty;
            SegundaCadenaTextBox.Text = string.Empty;
        }
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            string cadena1 = PrimeraCadenaTextBox.Text; 
            string cadena2 = SegundaCadenaTextBox.Text;

            int comparar = String.Compare(cadena1, cadena2);
 
            if(comparar > 0)
            {
                limpiar();
                CadenasListBox.Items.Add("Cadenas sin ordenar:");
                CadenasListBox.Items.Add("1- " + cadena1);
                CadenasListBox.Items.Add("2- " + cadena2);
                CadenasListBox.Items.Add("Cadenas ordenadas:");
                CadenasListBox.Items.Add("1- " + cadena2);
                CadenasListBox.Items.Add("2- " + cadena1);
            }
            else
            {
                limpiar();
                CadenasListBox.Items.Add("Cadenas sin ordenar:");
                CadenasListBox.Items.Add("1- " + cadena1);
                CadenasListBox.Items.Add("2- " + cadena2);
                CadenasListBox.Items.Add("Cadenas ordenadas:");
                CadenasListBox.Items.Add("1- " + cadena1);
                CadenasListBox.Items.Add("2- " + cadena2);
            }
            
        }
    }
}
