using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b, x, i = 1;
                
        private void button3_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button0.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button2.Text;
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lbResultado.Text))
            {
                b = Convert.ToDouble(lbResultado.Text);

                switch(i){
                    case 1:
                        x = a + b;
                        break;
                    case 2:
                        x = a - b;
                        break;
                    case 3:
                        x = a * b;
                        break;
                    case 4:
                        x = a / b;
                        break;
                }
                
                lbResultado.Text = x.ToString();
                
            }
            else
            {

            }
        }
                
        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "";
            a = 0;
            b = 0;
        }

        private void buttonMenos_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lbResultado.Text))
            {
                i = 2;
                a = Convert.ToDouble(lbResultado.Text);
                lbResultado.Text = "";
            }
            else
            {

            }
        }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lbResultado.Text))
            {
                i = 3;
                a = Convert.ToDouble(lbResultado.Text);
                lbResultado.Text = "";
            }
            else
            {

            }
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lbResultado.Text))
            {
                i = 4;
                a = Convert.ToDouble(lbResultado.Text);
                lbResultado.Text = "";
            }
            else
            {

            }
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbResultado.Text += button1.Text;
        }
        
        private void buttonMais_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lbResultado.Text))
            {
                i = 1;
                a = Convert.ToDouble(lbResultado.Text);
                lbResultado.Text = "";
            }
            else
            {

            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lbResultado.Text))
            {
                i = 2;
                a = Convert.ToDouble(lbResultado.Text);
                lbResultado.Text = "";
            }
            else
            {

            }
        }
    }
}
