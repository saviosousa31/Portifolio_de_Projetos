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
    public partial class exercicio3 : Form
    {
        public exercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            string z;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = (y <= (x * 0.7) ? "Etanol" : "Gasolina");
            MessageBox.Show("Compensa abastecer com " + z);
        }
    }
}
