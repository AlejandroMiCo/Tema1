using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CambiarNombre(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    text: $"¿Estas segudo que deseas cambiar el titulo del formulario a \"{textBox1.Text}\" ?",
                    caption: "Cambio de titulo",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question,
                    defaultButton: MessageBoxDefaultButton.Button1
                ) == DialogResult.Yes
            )
            {
                this.Text = textBox1.Text;
            }
        }
    }
}
