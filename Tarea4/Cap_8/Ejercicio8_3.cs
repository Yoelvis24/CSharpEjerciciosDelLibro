using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2.Tarea4.Cap_8
{
    public partial class Ejercicio8_3 : Form
    {
        public Ejercicio8_3()
        {
            InitializeComponent();
            
            
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            FechaListBox.Items.Add(DateTime.Now.ToString("yyyy/dd/MM"));
            HoraListBox.Items.Add(DateTime.Now.ToString("hh:mm:ss tt"));
        }

    }
}
