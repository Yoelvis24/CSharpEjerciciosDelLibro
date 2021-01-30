using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Ejercicio4_1 : Form
    {
        public Ejercicio4_1()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            tablaListBox.Items.Clear();
            int tabla = Convert.ToInt32(numTablaTextBox.Text);
            int resultado;

            for(int i = 1; i <= 10; i++)
            {
                resultado = tabla * i;
                tablaListBox.Items.Add(tabla + " x " + i + "=" + resultado);
            }
        }
    }
}
