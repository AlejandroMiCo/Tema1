#define DEPURACION

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void jugar(object sender, EventArgs e)
        {
            label1.Text = "Info";

            lblcredito.Text = (Convert.ToInt32(lblcredito.Text) - 2).ToString();

            Random generador = new Random();

            textBox1.Text = generador.Next(1, 8).ToString();
            textBox2.Text = generador.Next(1, 8).ToString();
            textBox3.Text = generador.Next(1, 8).ToString();

            if (textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text)
            {
                label1.Text = "Enhorabuena has ganado 20€";

                lblcredito.Text = (Convert.ToInt32(lblcredito.Text) + 20).ToString();
            }
            else
            {
                if (
                    textBox1.Text == textBox2.Text
                    || textBox1.Text == textBox3.Text
                    || textBox2.Text == textBox3.Text
                )
                {
                    label1.Text = "Enhorabuena has ganado 5€";
#if DEPURACION
                    lblcredito.Text = (Convert.ToInt32(lblcredito.Text) - 5).ToString();

#else
                lblcredito.Text = (Convert.ToInt32(lblcredito.Text) + 5).ToString();
#endif
                }
            }

            if (Convert.ToInt32(lblcredito.Text) < 2)
            {
                btnJugar.Enabled = false;

                if (Convert.ToInt32(lblcredito.Text) < 0)
                {
                    lblcredito.Text = 0.ToString();
                }
            }
        }

        private void añadirCredito(object sender, EventArgs e)
        {
            lblcredito.Text = (Convert.ToInt32(lblcredito.Text) + 10).ToString();
            btnJugar.Enabled = true;
        }
    }
}
