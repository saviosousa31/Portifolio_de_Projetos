namespace aulaTransacaoA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_testeconexao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscaprofessores = new System.Windows.Forms.Button();
            this.cb_professores = new System.Windows.Forms.ComboBox();
            this.btn_buscaalunos = new System.Windows.Forms.Button();
            this.cb_alunos = new System.Windows.Forms.ComboBox();
            this.btn_criarprofessor = new System.Windows.Forms.Button();
            this.btn_criaraluno = new System.Windows.Forms.Button();
            this.btn_buscaidade = new System.Windows.Forms.Button();
            this.btn_buscadados = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_listapessoas = new System.Windows.Forms.ComboBox();
            this.txt_hostname = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_preencherconexao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_masculino = new System.Windows.Forms.RadioButton();
            this.rbtn_feminino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dtnasc = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_inserirpessoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_excluiraluno = new System.Windows.Forms.Button();
            this.btn_excluirprofessor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_testeconexao
            // 
            this.btn_testeconexao.Location = new System.Drawing.Point(672, 44);
            this.btn_testeconexao.Name = "btn_testeconexao";
            this.btn_testeconexao.Size = new System.Drawing.Size(173, 50);
            this.btn_testeconexao.TabIndex = 5;
            this.btn_testeconexao.Text = "Teste de conexão";
            this.btn_testeconexao.UseVisualStyleBackColor = true;
            this.btn_testeconexao.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_excluirprofessor);
            this.groupBox1.Controls.Add(this.btn_excluiraluno);
            this.groupBox1.Controls.Add(this.btn_buscaprofessores);
            this.groupBox1.Controls.Add(this.cb_professores);
            this.groupBox1.Controls.Add(this.btn_buscaalunos);
            this.groupBox1.Controls.Add(this.cb_alunos);
            this.groupBox1.Controls.Add(this.btn_criarprofessor);
            this.groupBox1.Controls.Add(this.btn_criaraluno);
            this.groupBox1.Controls.Add(this.btn_buscaidade);
            this.groupBox1.Controls.Add(this.btn_buscadados);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_listapessoas);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 217);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa no banco de dados:";
            // 
            // btn_buscaprofessores
            // 
            this.btn_buscaprofessores.Location = new System.Drawing.Point(671, 98);
            this.btn_buscaprofessores.Name = "btn_buscaprofessores";
            this.btn_buscaprofessores.Size = new System.Drawing.Size(92, 36);
            this.btn_buscaprofessores.TabIndex = 16;
            this.btn_buscaprofessores.Text = "Buscar professores";
            this.btn_buscaprofessores.UseVisualStyleBackColor = true;
            this.btn_buscaprofessores.Click += new System.EventHandler(this.btn_buscaprofessores_Click);
            // 
            // cb_professores
            // 
            this.cb_professores.FormattingEnabled = true;
            this.cb_professores.Location = new System.Drawing.Point(444, 113);
            this.cb_professores.Name = "cb_professores";
            this.cb_professores.Size = new System.Drawing.Size(221, 21);
            this.cb_professores.TabIndex = 15;
            // 
            // btn_buscaalunos
            // 
            this.btn_buscaalunos.Location = new System.Drawing.Point(238, 98);
            this.btn_buscaalunos.Name = "btn_buscaalunos";
            this.btn_buscaalunos.Size = new System.Drawing.Size(92, 36);
            this.btn_buscaalunos.TabIndex = 13;
            this.btn_buscaalunos.Text = "Buscar\r\nalunos";
            this.btn_buscaalunos.UseVisualStyleBackColor = true;
            this.btn_buscaalunos.Click += new System.EventHandler(this.btn_buscaalunos_Click);
            // 
            // cb_alunos
            // 
            this.cb_alunos.FormattingEnabled = true;
            this.cb_alunos.Location = new System.Drawing.Point(9, 112);
            this.cb_alunos.Name = "cb_alunos";
            this.cb_alunos.Size = new System.Drawing.Size(221, 21);
            this.cb_alunos.TabIndex = 12;
            // 
            // btn_criarprofessor
            // 
            this.btn_criarprofessor.Location = new System.Drawing.Point(715, 18);
            this.btn_criarprofessor.Name = "btn_criarprofessor";
            this.btn_criarprofessor.Size = new System.Drawing.Size(144, 46);
            this.btn_criarprofessor.TabIndex = 11;
            this.btn_criarprofessor.Text = "Cadastrar como professor(a)";
            this.btn_criarprofessor.UseVisualStyleBackColor = true;
            this.btn_criarprofessor.Click += new System.EventHandler(this.btn_criarprofessor_Click);
            // 
            // btn_criaraluno
            // 
            this.btn_criaraluno.Location = new System.Drawing.Point(565, 19);
            this.btn_criaraluno.Name = "btn_criaraluno";
            this.btn_criaraluno.Size = new System.Drawing.Size(144, 45);
            this.btn_criaraluno.TabIndex = 10;
            this.btn_criaraluno.Text = "Cadastrar como aluno(a)";
            this.btn_criaraluno.UseVisualStyleBackColor = true;
            this.btn_criaraluno.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_buscaidade
            // 
            this.btn_buscaidade.Location = new System.Drawing.Point(467, 29);
            this.btn_buscaidade.Name = "btn_buscaidade";
            this.btn_buscaidade.Size = new System.Drawing.Size(92, 35);
            this.btn_buscaidade.TabIndex = 9;
            this.btn_buscaidade.Text = "Calcular idade";
            this.btn_buscaidade.UseVisualStyleBackColor = true;
            this.btn_buscaidade.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_buscadados
            // 
            this.btn_buscadados.Location = new System.Drawing.Point(369, 28);
            this.btn_buscadados.Name = "btn_buscadados";
            this.btn_buscadados.Size = new System.Drawing.Size(92, 35);
            this.btn_buscadados.TabIndex = 8;
            this.btn_buscadados.Text = "Buscar\r\npessoas";
            this.btn_buscadados.UseVisualStyleBackColor = true;
            this.btn_buscadados.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Professores:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alunos:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pessoas:";
            // 
            // cb_listapessoas
            // 
            this.cb_listapessoas.FormattingEnabled = true;
            this.cb_listapessoas.Location = new System.Drawing.Point(9, 43);
            this.cb_listapessoas.Name = "cb_listapessoas";
            this.cb_listapessoas.Size = new System.Drawing.Size(354, 21);
            this.cb_listapessoas.TabIndex = 7;
            this.cb_listapessoas.SelectedIndexChanged += new System.EventHandler(this.cb_listapessoas_SelectedIndexChanged);
            // 
            // txt_hostname
            // 
            this.txt_hostname.AllowDrop = true;
            this.txt_hostname.Location = new System.Drawing.Point(21, 60);
            this.txt_hostname.Name = "txt_hostname";
            this.txt_hostname.Size = new System.Drawing.Size(141, 20);
            this.txt_hostname.TabIndex = 0;
            this.txt_hostname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(168, 60);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(115, 20);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(289, 60);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(141, 20);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_database
            // 
            this.txt_database.Location = new System.Drawing.Point(436, 60);
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(157, 20);
            this.txt_database.TabIndex = 3;
            this.txt_database.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hostname:                                User:                                Pas" +
    "sword:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Database:                                      Port:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(599, 60);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(67, 20);
            this.txt_port.TabIndex = 4;
            this.txt_port.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btn_preencherconexao
            // 
            this.btn_preencherconexao.Location = new System.Drawing.Point(839, 32);
            this.btn_preencherconexao.Name = "btn_preencherconexao";
            this.btn_preencherconexao.Size = new System.Drawing.Size(20, 50);
            this.btn_preencherconexao.TabIndex = 6;
            this.btn_preencherconexao.Text = "*";
            this.btn_preencherconexao.UseVisualStyleBackColor = true;
            this.btn_preencherconexao.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_masculino);
            this.groupBox2.Controls.Add(this.rbtn_feminino);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_dtnasc);
            this.groupBox2.Controls.Add(this.txt_cpf);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Controls.Add(this.btn_inserirpessoa);
            this.groupBox2.Location = new System.Drawing.Point(12, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 86);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inserir pessoas no banco de dados:";
            // 
            // rbtn_masculino
            // 
            this.rbtn_masculino.AutoSize = true;
            this.rbtn_masculino.Location = new System.Drawing.Point(598, 39);
            this.rbtn_masculino.Name = "rbtn_masculino";
            this.rbtn_masculino.Size = new System.Drawing.Size(73, 17);
            this.rbtn_masculino.TabIndex = 0;
            this.rbtn_masculino.Text = "Masculino";
            this.rbtn_masculino.UseVisualStyleBackColor = true;
            this.rbtn_masculino.CheckedChanged += new System.EventHandler(this.rbtn_masculino_CheckedChanged);
            // 
            // rbtn_feminino
            // 
            this.rbtn_feminino.AutoSize = true;
            this.rbtn_feminino.Location = new System.Drawing.Point(598, 55);
            this.rbtn_feminino.Name = "rbtn_feminino";
            this.rbtn_feminino.Size = new System.Drawing.Size(67, 17);
            this.rbtn_feminino.TabIndex = 0;
            this.rbtn_feminino.Text = "Feminino";
            this.rbtn_feminino.UseVisualStyleBackColor = true;
            this.rbtn_feminino.CheckedChanged += new System.EventHandler(this.rbtn_feminino_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(622, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome:                                                             CPF: (incluindo" +
    " os símbolos)                  Data de nascimento: (YYYY-MM-DD)    Sexo:";
            // 
            // txt_dtnasc
            // 
            this.txt_dtnasc.Location = new System.Drawing.Point(409, 43);
            this.txt_dtnasc.Name = "txt_dtnasc";
            this.txt_dtnasc.Size = new System.Drawing.Size(180, 20);
            this.txt_dtnasc.TabIndex = 13;
            this.txt_dtnasc.TextChanged += new System.EventHandler(this.txt_dtnasc_TextChanged);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(223, 43);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(180, 20);
            this.txt_cpf.TabIndex = 12;
            this.txt_cpf.TextChanged += new System.EventHandler(this.txt_cpf_TextChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(9, 43);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(208, 20);
            this.txt_nome.TabIndex = 11;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // btn_inserirpessoa
            // 
            this.btn_inserirpessoa.Location = new System.Drawing.Point(677, 27);
            this.btn_inserirpessoa.Name = "btn_inserirpessoa";
            this.btn_inserirpessoa.Size = new System.Drawing.Size(182, 45);
            this.btn_inserirpessoa.TabIndex = 14;
            this.btn_inserirpessoa.Text = "Inserir Pessoa";
            this.btn_inserirpessoa.UseVisualStyleBackColor = true;
            this.btn_inserirpessoa.Click += new System.EventHandler(this.btn_inserirpessoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_preencherconexao);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(871, 98);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de conexão:";
            // 
            // btn_excluiraluno
            // 
            this.btn_excluiraluno.Location = new System.Drawing.Point(336, 98);
            this.btn_excluiraluno.Name = "btn_excluiraluno";
            this.btn_excluiraluno.Size = new System.Drawing.Size(90, 36);
            this.btn_excluiraluno.TabIndex = 14;
            this.btn_excluiraluno.Text = "Remover aluno(a)";
            this.btn_excluiraluno.UseVisualStyleBackColor = true;
            this.btn_excluiraluno.Click += new System.EventHandler(this.btn_excluiraluno_Click);
            // 
            // btn_excluirprofessor
            // 
            this.btn_excluirprofessor.Location = new System.Drawing.Point(769, 98);
            this.btn_excluirprofessor.Name = "btn_excluirprofessor";
            this.btn_excluirprofessor.Size = new System.Drawing.Size(90, 36);
            this.btn_excluirprofessor.TabIndex = 17;
            this.btn_excluirprofessor.Text = "Remover professor(a)";
            this.btn_excluirprofessor.UseVisualStyleBackColor = true;
            this.btn_excluirprofessor.Click += new System.EventHandler(this.btn_excluirprofessor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(893, 459);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_database);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_hostname);
            this.Controls.Add(this.btn_testeconexao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Aplicação do SAVIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_testeconexao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscadados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_listapessoas;
        private System.Windows.Forms.Button btn_buscaidade;
        private System.Windows.Forms.Button btn_criaraluno;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_preencherconexao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_inserirpessoa;
        private System.Windows.Forms.RadioButton rbtn_masculino;
        private System.Windows.Forms.RadioButton rbtn_feminino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dtnasc;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_hostname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_criarprofessor;
        private System.Windows.Forms.ComboBox cb_alunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscaprofessores;
        private System.Windows.Forms.ComboBox cb_professores;
        private System.Windows.Forms.Button btn_buscaalunos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_excluirprofessor;
        private System.Windows.Forms.Button btn_excluiraluno;
    }
}

