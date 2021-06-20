using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double valor, prestacoes, pagos;
            valor = Convert.ToDouble(this.textBox1.Text);
            prestacoes = Convert.ToDouble(this.textBox2.Text);
            pagos = Convert.ToDouble(this.textBox3.Text);
            lbPago.Text = "Valor pago: " + (valor * pagos).ToString();
            lbDevedor.Text = "Saldo devedor: " + (valor * (prestacoes - pagos)).ToString();
        }
    }
}
