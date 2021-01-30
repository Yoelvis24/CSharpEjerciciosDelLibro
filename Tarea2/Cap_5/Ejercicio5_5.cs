using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea2.Cap_5
{
    public partial class Ejercicio5_5 : Form
    {
        public Ejercicio5_5()
        {
            InitializeComponent();
        }

        string cadenaDeNumeros(int num)
        {
            string cadena = "";

            switch (num)
            {
                case 0:
                    cadena = "Cero";
                    break;

                case 1:
                    cadena = "Uno";
                    break;

                case 2:
                    cadena = "Dos";
                    break;

                case 3:
                    cadena = "Tres";
                    break;

                case 4:
                    cadena = "Cuatro";
                    break;

                case 5:
                    cadena = "Cinco";
                    break;

                case 6:
                    cadena = "Seis";
                    break;

                case 7:
                    cadena = "Siete";
                    break;

                case 8:
                    cadena = "Ocho";
                    break;

                case 9:
                    cadena = "Nueve";
                    break;

                case 10:
                    cadena = "Diez";
                    break;

                default:
                    MessageBox.Show("Solo se puede introducir valores del (0-10)", "Error", MessageBoxButtons.OK);
                    break;
            }
            return cadena;
        }


        private void AceptarButton_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numTextBox.Text);

            resultadoLabel.Text = cadenaDeNumeros(num);
            numTextBox.Text = "";
        }
    }
}
