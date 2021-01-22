using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tarea2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejercicio4Abutton_Click(object sender, RoutedEventArgs e)
        {
            Window Ejercicio4A = new Ejercicio4_1();
            Ejercicio4A.Show();
        }

        private void Ejercicio4Bbutton_Click(object sender, RoutedEventArgs e)
        {
            Window Ejercicio4B = new Ejercicio4_2();
            Ejercicio4B.Show();
        }

        private void Ejercicio4Cbutton_Click(object sender, RoutedEventArgs e)
        {
            Window Ejercicio4C = new Ejercicio4_5();
            Ejercicio4C.Show();
        }

        private void Ejercicio5Abutton_Click(object sender, RoutedEventArgs e)
        {
            Window Ejercicio5A = new Ejercicio5_4();
            Ejercicio5A.Show();
        }

        private void Ejercicio5Bbutton_Click(object sender, RoutedEventArgs e)
        {
            Window Ejercicio5B = new Ejercicio5_5();
            Ejercicio5B.Show();
        }
    }
}
