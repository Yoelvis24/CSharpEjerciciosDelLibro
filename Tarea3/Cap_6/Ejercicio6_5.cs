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
    public partial class Ejercicio6_5 : Form
    {
        int salones;
        int cantidad;
        int cant = 0;
        

        public Ejercicio6_5()
        {
            InitializeComponent();
        }

        void Imprimir(float[][] calif)
        {
            for (int n = 0; n < salones; n++)
            {
                califListBox.Items.Add("Salón " + (n + 1));

                for (int m = 0; m < calif[n].GetLength(0); m++)
                {
                    califListBox.Items.Add("El alumno " + (m + 1) + " tiene " + calif[n][m]);
                }
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            float suma = 0.0f;
            float promedio = 0.0f;
            int menorCalif = 200;
            int mayorCalif = -999; 
            
            salones = Convert.ToInt32(salonesTextBox.Text);            
            float[][] calif = new float[salones][];

            //Agregamos la cantidad de salones y alumnos por salon
            for (int n = 0; n < salones; n++)
            {
                cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de alumnos del salón " + (n + 1), "Cantidad de Alumnos", " ", 100, 0));
                calif[n] = new float[cantidad];
                cant += cantidad;
            }
            salonesTextBox.Text = "";

            //Añadiendo calificaciones
            for (int n = 0; n < salones; n++)
            {
                for (int m = 0; m < calif[n].GetLength(0); m++)
                {
                    calif[n][m] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la calificación del alumno " + (m + 1) + " del salón " + (n + 1), "Calificaciones", " ", 100, 0));
                    suma += calif[n][m];

                    if (calif[n][m] < menorCalif)
                        menorCalif = Convert.ToInt32(calif[n][m]);

                    if (calif[n][m] > mayorCalif)
                        mayorCalif = Convert.ToInt32(calif[n][m]);
                }
            }
            
            //Imprimir la menor calificacion
            menorTextBox.Text = menorCalif.ToString();

            //Imprimir la mayor calificacion
            mayorTextBox.Text = mayorCalif.ToString();

            //Imprimir el promedio
            promedio = suma / cant;
            promedioTextBox.Text = promedio.ToString();

            //funcion imprimir listbox 
            Imprimir(calif);
           
        }
    }
}
