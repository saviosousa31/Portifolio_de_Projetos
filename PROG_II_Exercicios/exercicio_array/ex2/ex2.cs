using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        double media = 0;
        int i = 0;
        double[] notas = new double[5];

        private void button1_Click(object sender, EventArgs e)
        {
            if(i < 4)
            {
                MessageBox.Show("Favor informe as 5 notas!");
            }
            else
            {
                foreach(double x in notas)
                {
                    media += x;
                }
                lbMedia.Text = "Média: " + media / 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i > 4)
            {
                MessageBox.Show("Todas as 5 notas já foram cadastradas!");
            }
            else
            {
                label1.Text = "Nota do aluno " + (i + 2) + ": ";
                notas[i] = Convert.ToDouble(textBox1.Text);
                i++;                
            }
        }
    }
}
