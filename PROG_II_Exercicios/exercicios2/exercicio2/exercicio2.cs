using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class exercicio2 : Form
    {
        public exercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(this.textBox1.Text);

            if (x % 2 == 0)
            {
                MessageBox.Show("O número " + x + " é par!");
            }
            else
            {
                MessageBox.Show("O número " + x + " é ímpar!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x;
            string y;
            x = Convert.ToDouble(this.textBox1.Text);

            y = (x % 2 == 0 ? "par" : "ímpar");
            MessageBox.Show("O número " + x + " é " + y + "!");
        }
    }
}
