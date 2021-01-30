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
    public partial class Ejercicio7_5 : Form
    {
        Hashtable Agenda = new Hashtable();

        public Ejercicio7_5()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Agenda.Add(Convert.ToString(nombreTextBox.Text), Convert.ToString(telefonoTextBox.Text));
            nombreTextBox.Text = telefonoTextBox.Text = "";
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Agenda.Remove(buscarTextBox.Text);
            resultadoTextBox.Text = "";
            buscarTextBox.Text = "";
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (Agenda.ContainsKey(buscarTextBox.Text))
            {
                resultadoTextBox.Text = (string)Agenda[Convert.ToString(buscarTextBox.Text)];
            }
            else
            {
                MessageBox.Show("Este contacto no existe");
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            resultadoTextBox.Text = buscarTextBox.Text = "";
        }
    }
}
