using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios2
{
    public partial class exercicio1 : Form
    {
        public exercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, maior;
            x = Convert.ToDouble(this.textBox1.Text);
            y = Convert.ToDouble(this.textBox2.Text);

            if (x > y)
            {
                maior = x;
                MessageBox.Show("O maior número é: " + maior);
            }
            else
            {
                maior = y;
                MessageBox.Show("O maior número é: " + maior);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, maior;
            x = Convert.ToDouble(this.textBox1.Text);
            y = Convert.ToDouble(this.textBox2.Text);
            maior = (x > y ? x : y);
            MessageBox.Show("O maior número é: " + maior);
        }
               
    }
}
