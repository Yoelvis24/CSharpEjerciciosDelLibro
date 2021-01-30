using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea2.Cap_5
{
    public partial class Ejercicio5_4 : Form
    {
        public Ejercicio5_4()
        {
            InitializeComponent();
        }

        int Factorial(int x)
        {
            if (x < 1)
            {
                MessageBox.Show("Solo se puede introducir valores positivos", "Error", MessageBoxButtons.OK);
                return 0;
            }

            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }


        private void AceptarButton_Click(object sender, EventArgs e)
        {
            resultado1TextBox.Text = "";
            resultado2TextBox.Text = "";

            int num = Convert.ToInt32(numTextBox.Text);

            resultado1TextBox.Text = num.ToString();
            resultado2TextBox.Text = Factorial(num).ToString();
            numTextBox.Text = "";
        }
    }
}
