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
    /// Interaction logic for Ejercicio5_5.xaml
    /// </summary>
    public partial class Ejercicio5_5 : Window
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
                    MessageBox.Show("Solo se puede introducir valores del (0-10)", "Error", MessageBoxButton.OK);
                    break;
            }
            return cadena;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(numTextBox.Text);

            resultadoLabel.Content = cadenaDeNumeros(num);
            numTextBox.Text = "";
        }
    }
}
