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
    /// Interaction logic for Ejercicio4_2.xaml
    /// </summary>
    public partial class Ejercicio4_2 : Window
    {
        public Ejercicio4_2()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            resultadoListBox.Items.Clear();
            double numero = Convert.ToDouble(numeroTextBox.Text);
            double potencia = Convert.ToDouble(potenciaTextBox.Text);
            double resultado;

            resultado = Math.Pow(numero, potencia);
            resultadoListBox.Items.Add(resultado);
        }
    }
}
