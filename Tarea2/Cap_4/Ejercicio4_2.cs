using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea2.Cap_4
{
    public partial class Ejercicio4_2 : Form
    {
        public Ejercicio4_2()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();
            double num = Convert.ToDouble(numTextBox.Text);
            double potencia = Convert.ToDouble(potenciatextBox.Text);
            double resultado;

            resultado = Math.Pow(num, potencia);
            resultadoListBox.Items.Add(resultado);
        }
    }
}
