using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_array
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        int x = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = "Tabuada do número:";
            int i = 1;
            while (i < 11)
            {
                label2.Text += "\n" + x + " x " + i + " = " + x * i + ".";
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = "Tabuada do número:";
            for(int i = 1; i < 11; i++)
            {
                label2.Text += "\n" + x + " x " + i + " = " + x * i + ".";
            }
        }
    }
}
