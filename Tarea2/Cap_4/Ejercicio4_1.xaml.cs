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
    /// Interaction logic for Ejercicio4_1.xaml
    /// </summary>
    public partial class Ejercicio4_1 : Window
    {
        public Ejercicio4_1()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            tablaListBox.Items.Clear();
            int tabla = Convert.ToInt32(numTextBox.Text);
            int resultado;

            for (int i = 1; i <= 10; i++)
            {
                resultado = tabla * i;
                tablaListBox.Items.Add("\t" + tabla + " x " + i + "= " + resultado);
            }
        }
    }
}
