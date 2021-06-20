using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(this.textBox1.Text);
            y = Convert.ToDouble(this.textBox2.Text);
            lbResultado.Text = "Resultado: " + (x + y).ToString();
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(this.textBox1.Text);
            y = Convert.ToDouble(this.textBox2.Text);
            lbResultado.Text = "Resultado: " + (x - y).ToString();
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(this.textBox1.Text);
            y = Convert.ToDouble(this.textBox2.Text);
            lbResultado.Text = "Resultado: " + (x / y).ToString();
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(this.textBox1.Text);
            y = Convert.ToDouble(this.textBox2.Text);
            lbResultado.Text = "Resultado: " + (x * y).ToString();
        }
    }
}
