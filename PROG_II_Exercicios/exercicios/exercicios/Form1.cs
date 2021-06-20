using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, y, consumo;
            x = Convert.ToDouble(this.textBox1.Text);
            y = Convert.ToDouble(this.textBox2.Text);
            consumo = y / x;

            MessageBox.Show("O consumo médio foi de " + consumo + " litros.", "Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
