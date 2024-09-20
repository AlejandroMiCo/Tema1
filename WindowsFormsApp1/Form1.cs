using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void clickEnBoton(object sender, EventArgs e)
        {

            double valor1 = Convert.ToInt64(textBox1.Text);
            double valor2 = Convert.ToInt64(textBox2.Text);

            double resultado = valor1 + valor2;
            label2.Text = resultado.ToString();
        }
    }
}
