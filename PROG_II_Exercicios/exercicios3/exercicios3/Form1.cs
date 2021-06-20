using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double saldo = 0, limite = 0;

        private void btSacar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (saldo >= Convert.ToDouble(textBox1.Text) && Convert.ToDouble(textBox1.Text) <= limite)
                {
                    saldo -= Convert.ToDouble(textBox1.Text);
                    lbSaldo.Text = "R$ " + saldo + ",00";
                }
                else
                    MessageBox.Show("Valor indisponível para saque!");
            }
            else            
                MessageBox.Show("Informe o valor da movimentação!");
        }

        private void btLimite_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                if (Convert.ToDouble(textBox2.Text) >= 0)
                {
                    limite = Convert.ToDouble(textBox2.Text);
                    lbLimite.Text = "R$ " + limite + ",00";
                }
                else
                    MessageBox.Show("Valor inválido!");
            }
            else
                MessageBox.Show("Informe o valor da movimentação!");
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (Convert.ToDouble(textBox1.Text) >= 0)
                {
                    saldo += Convert.ToDouble(textBox1.Text);
                    lbSaldo.Text = "R$ " + saldo + ",00";
                } else
                    MessageBox.Show("Valor inválido!");
            }
            else
                MessageBox.Show("Informe o valor da movimentação!");
        }
    }
}
