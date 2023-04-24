using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(textBox1.Text);

            if (numero % 2 == 0)
            {
                textBox2.Text = "el numero: " + numero + "es par";
            }
            else 
            {
                textBox2.Text = "el numero: " + numero + "es impar";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }
    }
}
