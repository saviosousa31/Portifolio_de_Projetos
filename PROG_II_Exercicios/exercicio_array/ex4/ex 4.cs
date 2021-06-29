using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        int x = 0, resto = 0;

        private void btPrimo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || Convert.ToInt32(textBox1.Text) < 0)
                MessageBox.Show("Verifique o número informado!");
            else
            {
                x = Convert.ToInt32(textBox1.Text);
                for (int i = 2; i < x; i++)
                {
                    resto = x % i;
                    i = x + 1;                    
                }
                if (resto == 0)
                    MessageBox.Show(x + " não é um número primo!");
                else
                    MessageBox.Show(x + " é um número primo!");
            }
        }

        private void btFatorial_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || Convert.ToInt32(textBox1.Text) < 0)
                MessageBox.Show("Verifique o número informado!");
            else
            {
                x = Convert.ToInt32(textBox1.Text);
                double resultado = 1;
                double numero = x;
                while (numero != 1)
                {
                    resultado = resultado * numero;
                    numero = numero - 1;
                }
                MessageBox.Show("Fatorial: " + resultado);
            }
        }
    }
}
