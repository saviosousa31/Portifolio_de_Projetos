using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4___Sávio_Soares_Sousa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nome, cargo;
        double calculo = 0, salario = 0;

        private void rbGerente_CheckedChanged(object sender, EventArgs e)
        {
            lbX.Text = "Bônus:";
            lbX.Visible = true;
            textBox1.Visible = true;
        }

        private void rbDev_CheckedChanged(object sender, EventArgs e)
        {
            lbX.Text = "Horas de\ntrabalho:";
            lbX.Visible = true;
            textBox1.Visible = true;
        }

        private void rbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            lbX.Text = "Total de\nvendas:";
            lbX.Visible = true;
            textBox1.Visible = true;
        }

        private void rbDiretor_CheckedChanged(object sender, EventArgs e)
        {
            lbX.Visible = false;
            textBox1.Visible = false;
            textBox1.Text = "0";
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            nome = comboBox1.SelectedItem.ToString();

            if (rbGerente.Checked)
            {
                cargo = rbGerente.Text.ToString();
                calculo = Convert.ToDouble(textBox1.Text);
                salario = 6000 + calculo;
            }

            if (rbDev.Checked)
            {
                cargo = rbDev.Text.ToString();
                calculo = Convert.ToDouble(textBox1.Text) * 50;
                salario = calculo;
            }

            if (rbVendedor.Checked)
            {
                cargo = rbVendedor.Text.ToString();
                calculo = Convert.ToDouble(textBox1.Text) * 0.10;
                salario = 1000 + calculo;
            }

            if (rbDiretor.Checked)
            {
                cargo = rbDiretor.Text.ToString();
                salario = 10000;
            }

            MessageBox.Show("Nome: " + nome + "; Cargo: " + cargo + "; \nCálculo: " + calculo.ToString("C") + "; Salário total: " + salario.ToString("C"));
        }
    }
}
