using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2.Cap_6
{
    public partial class Ejercicio6_2 : Form
    {
        int salones;
        int cantidad;
        int cant = 0;
        int[][] calif;
        int menorCalif = 200;

        public Ejercicio6_2()
        {
            InitializeComponent();
        }

        private void AñadirButton_Click(object sender, EventArgs e)
        {
            salones = Convert.ToInt32(salonesTextBox.Text);
            calif = new int[salones][];

            for (int n = 0; n < salones; n++)
            {
                cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de alumnos del salón " + (n + 1), "Cantidad de Alumnos", " ", 100, 0));
                calif[n] = new int[cantidad];
            }
            salonesTextBox.Text = "";
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < salones; n++)
            {
                for (int m = 0; m < calif[n].GetLength(0); m++)
                {
                    calif[n][m] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la calificación del alumno " + (m + 1) + " del salón " + (n + 1), "Calificaciones", " ", 100, 0));
                    
                    if (calif[n][m] < menorCalif)
                        menorCalif = calif[n][m];
                }
            }
            //Imprimir la menor calificacion

            menorTextBox.Text = menorCalif.ToString();

            //imprimir listbox

            for (int n = 0; n < salones; n++)
            {
                califListBox.Items.Add("Salón " + (n + 1));

                for (int m = 0; m < calif[n].GetLength(0); m++)
                {
                    califListBox.Items.Add("El alumno " + (m + 1) + " tiene " + calif[n][m]);
                }
            }

        }
    }
}
