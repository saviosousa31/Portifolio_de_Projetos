using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio4_
{
    public partial class exercicio4 : Form
    {
        public exercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            int i = Convert.ToInt32(textBox2.Text);
            if(i < 14)
                MessageBox.Show("O atleta " + n + " pertence a categoria: Mirim");
            else if(i == 14 || i == 15)            
                MessageBox.Show("O atleta " + n + " pertence a categoria: Infantil");
            else if (i == 14 || i == 15)
                MessageBox.Show("O atleta " + n + " pertence a categoria: Infantil");
            else if (i == 16 || i == 17)
                MessageBox.Show("O atleta " + n + " pertence a categoria: Juvenil");
            else if (i >= 18 && i <= 20)
                MessageBox.Show("O atleta " + n + " pertence a categoria: Juniores");
            else
                MessageBox.Show("O atleta " + n + " pertence a categoria: Profissional");
        }
    }
}
