using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea2.Cap_4
{
    public partial class Ejercicio4_5 : Form
    {
        double promedio;
        int cont;
        int edadMayor;
        int edadMenor;
        int contador;

        public Ejercicio4_5()
        {
            promedio = 0;
            cont = 1;
            edadMayor = -1;
            edadMenor = 200;
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(cantidadTextBox.Text);
            contador  = cant - cont;
            contadorTextBox.Text = contador.ToString();

            promedio += Convert.ToDouble(edadesTextBox.Text);

            if (Convert.ToInt32(edadesTextBox.Text) > edadMayor)
                edadMayor = Convert.ToInt32(edadesTextBox.Text);

            if (Convert.ToInt32(edadesTextBox.Text) < edadMenor)
                edadMenor = Convert.ToInt32(edadesTextBox.Text);

            cont++;
            edadesTextBox.Text = "";
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(cantidadTextBox.Text);
            promedio = promedio / cant;

            promedioTextBox.Text = promedio.ToString();
            menorTextBox.Text = edadMenor.ToString();
            mayorTextBox.Text = edadMayor.ToString();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            //limpar valores
            promedioTextBox.Text = "";
            mayorTextBox.Text = "";
            menorTextBox.Text = "";
            edadesTextBox.Text = "";
            cantidadTextBox.Text = "";
        }
    }
}
