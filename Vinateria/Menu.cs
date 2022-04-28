using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinateria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Agregar_Empleado();
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Agregar_Cliente();
            form.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Show();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Agregar_Producto();
            form.Show();

            this.Close();
        }
    }
}
