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
    public partial class Ejercicio7_1 : Form
    {
        ArrayList calif = new ArrayList();

        public Ejercicio7_1()
        {
            InitializeComponent();
        }
        
        float Promedio(ArrayList array)
        {
            float suma = 0;
            for (int i = 0; i < array.Count; i++)
            {
                suma += Convert.ToInt32(array[i]);
            }

            return suma / array.Count;
        }

        float Mayor(ArrayList array)
        {
            int mayor = -1;
            for (int i = 0; i < array.Count; i++)
            {
                if (Convert.ToInt32(array[i]) > mayor)
                    mayor = Convert.ToInt32(array[i]);
            }
            return mayor;
        }

        float Menor(ArrayList array)
        {
            int menor = 100;
            for (int i = 0; i < array.Count; i++)
            {
                if (Convert.ToInt32(array[i]) < menor)
                    menor = Convert.ToInt32(array[i]);
            }
            return menor;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(califTextBox.Text) > 100 || Convert.ToInt32(califTextBox.Text) < 0)
            {
                MessageBox.Show("Solo se pueden ingresar calificaciones del 0 al 100");
                return;
            }

            calif.Add(Convert.ToInt32(califTextBox.Text));
            califTextBox.Text = "";
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            promedioTextBox.Text = Convert.ToString(Promedio(calif));
            maximaTextBox.Text = Convert.ToString(Mayor(calif));
            minimaTextBox.Text = Convert.ToString(Menor(calif));
        }
    }
}
