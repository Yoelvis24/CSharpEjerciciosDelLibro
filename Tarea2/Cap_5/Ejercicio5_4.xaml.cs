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
    /// Interaction logic for Ejercicio5_4.xaml
    /// </summary>
    public partial class Ejercicio5_4 : Window
    {
        public Ejercicio5_4()
        {
            InitializeComponent();
        }

        int Factorial(int x)
        {
            if (x < 1)
            {
                MessageBox.Show("Solo se puede introducir valores positivos", "Error",  MessageBoxButton.OK);
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

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            resultado2Label.Content = "";
            factorialLabel.Content = "";
            int num = Convert.ToInt32(numTextBox.Text);

            resultado2Label.Content = num.ToString();
            factorialLabel.Content = Factorial(num);
            numTextBox.Text = "";
        }
    }
}
