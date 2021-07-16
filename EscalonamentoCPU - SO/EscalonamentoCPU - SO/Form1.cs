using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalonamentoCPU___SO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // definição do contador de processos e do quantum
        int qtdProcessos = 0, quantum, tempo = 0;
        List<Processo> listaprocessos = new List<Processo>();

        private void btAlterarQuantum_Click(object sender, EventArgs e)
        {
            quantum = Convert.ToInt32(txtQuantum.Text);

        }

        // função para criar novo processo
        public void NovoProcesso()
        {
            Processo p = new Processo(txtNome.Text, tempo, Convert.ToInt32(txtQtdES.Text), Convert.ToInt32(txtQtdCPU.Text), 
                             Convert.ToInt32(txtES1.Text), Convert.ToInt32(txtES2.Text), Convert.ToInt32(txtES3.Text),
                             Convert.ToInt32(txtCPU1.Text), Convert.ToInt32(txtCPU2.Text), Convert.ToInt32(txtCPU3.Text));
            listaprocessos.Add(p);
        }



        // definição da estrutura dos Processos
        public class Processo
        {
            public string nome;
            public int tempocriacao, qtdES, qtdCPU, tES1, tES2, tES3, tCPU1, tCPU2, tCPU3, tempotermino;
            public double turnaround;

            // método construtor
            public Processo(string n, int tc, int qtes, int qtcpu, int es1, int es2, int es3, int cpu1, int cpu2, int cpu3)
            {
                nome = n;
                tempocriacao = tc;
                qtdES = qtes;
                qtdCPU = qtcpu;
                tES1 = es1;
                tES2 = es2;
                tES3 = es3;
                tCPU1 = cpu1;
                tCPU2 = cpu2;
                tCPU3 = cpu3;
            }
        }

        
        
    }
}
