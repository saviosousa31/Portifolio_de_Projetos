using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, meses, semanas, anos;
            x = Convert.ToDouble(this.textBox1.Text);
            semanas = x / 7;
            meses = x / 30;
            anos = x / 365;

            MessageBox.Show("Semanas: " + semanas + " / Meses: " + meses + " / Anos: " + anos);
        }
    }
}
