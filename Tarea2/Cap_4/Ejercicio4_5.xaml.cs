using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tarea2
{
    /// <summary>
    /// Interaction logic for Ejercicio4_5.xaml
    /// </summary>
    public partial class Ejercicio4_5 : Window
    {
        double promedio;
        int cont;
        int edadMayor;
        int edadMenor;
        public Ejercicio4_5()
        {
            promedio = 0;
            cont = 1;
            edadMayor = -1;
            edadMenor = 200;
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {   
            int cant = Convert.ToInt32(cantidadTextBox.Text);
            contador2Label.Content = cant - cont;

            promedio += Convert.ToDouble(edadesTextBox.Text);

            if(Convert.ToInt32(edadesTextBox.Text) > edadMayor)
                edadMayor = Convert.ToInt32(edadesTextBox.Text);
            
            if(Convert.ToInt32(edadesTextBox.Text) < edadMenor)
                edadMenor = Convert.ToInt32(edadesTextBox.Text);
            
            cont++;
            edadesTextBox.Text = "";
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            int cant = Convert.ToInt32(cantidadTextBox.Text);
            promedio = promedio / cant;

            promedioTextBox.Text = promedio.ToString();
            menorTextBox.Text = edadMenor.ToString();
            mayorTextBox.Text = edadMayor.ToString();
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
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
