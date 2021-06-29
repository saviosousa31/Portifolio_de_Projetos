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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        double media = 0;
        int i = 0, maior = 0, menor = 1000;
        double[] notas = new double[5];

        private void button1_Click(object sender, EventArgs e)
        {
            if(i < 4)
            {
                MessageBox.Show("Favor informe as 5 idades!");
            }
            else
            {
                foreach(double x in notas)
                {
                    media += x;
                    if (x > maior)
                        maior = Convert.ToInt32(x);
                    if (x < menor)
                        menor = Convert.ToInt32(x);
                }
                lbMedia.Text = "Média das idades: " + media / 5;
                lbMaior.Text = "Maior idade: " + maior;
                lbMenor.Text = "Menor idade: " + menor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i > 4)
            {
                MessageBox.Show("Todas as 5 idades já foram informadas!");
            }
            else
            {
                label1.Text = "Idade da pessoa " + (i + 2) + ": ";
                notas[i] = Convert.ToDouble(textBox1.Text);
                i++;                
            }
        }
    }
}
