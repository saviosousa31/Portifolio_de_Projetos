namespace trabalhoBD2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNomeBanco = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.MaskedTextBox();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharAplicacao = new System.Windows.Forms.Button();
            this.btnFuncCadastrados = new System.Windows.Forms.Button();
            this.txtQteFuncCadastrado = new System.Windows.Forms.TextBox();
            this.btnQteFuncAtivos = new System.Windows.Forms.Button();
            this.txtQteFuncAtivos = new System.Windows.Forms.TextBox();
            this.btnQteFuncAtivosPorSexo = new System.Windows.Forms.Button();
            this.txtQteFuncAtivosSexo0 = new System.Windows.Forms.TextBox();
            this.txtQteFuncAtivosSexo1 = new System.Windows.Forms.TextBox();
            this.btnSalarioMedio = new System.Windows.Forms.Button();
            this.txtSalarioMedio = new System.Windows.Forms.TextBox();
            this.btnFolhaDepComercial = new System.Windows.Forms.Button();
            this.btnFolhaDepDesenvolvimento = new System.Windows.Forms.Button();
            this.btnFolhaDepSuporte = new System.Windows.Forms.Button();
            this.btnMediaSalDepSuporte = new System.Windows.Forms.Button();
            this.btnMediaSalDepDesenvolvimento = new System.Windows.Forms.Button();
            this.btnMediaSalDepComercial = new System.Windows.Forms.Button();
            this.btnMediaIdadeDepSuporte = new System.Windows.Forms.Button();
            this.btnMediaIdadeDepDesenvolvimento = new System.Windows.Forms.Button();
            this.btnMediaIdadeDepComercial = new System.Windows.Forms.Button();
            this.txtFolhaDepComercial = new System.Windows.Forms.TextBox();
            this.txtFolhaDepDesenvolvimento = new System.Windows.Forms.TextBox();
            this.txtFolhaDepSuporte = new System.Windows.Forms.TextBox();
            this.btnQteCPFInvalidos = new System.Windows.Forms.Button();
            this.txtQteFuncCPFinvalidos = new System.Windows.Forms.TextBox();
            this.txtMediaSalDepComercial = new System.Windows.Forms.TextBox();
            this.txtMediaSalDepDesenvolvimento = new System.Windows.Forms.TextBox();
            this.txtMediaSalDepSuporte = new System.Windows.Forms.TextBox();
            this.txtMediaIdadeDepComercial = new System.Windows.Forms.TextBox();
            this.txtMediaIdadeDepDesenvolvimento = new System.Windows.Forms.TextBox();
            this.txtMediaIdadeDepSuporte = new System.Windows.Forms.TextBox();
            this.btnValidarBD = new System.Windows.Forms.Button();
            this.txtValiidarBD = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReajusteTrigger = new System.Windows.Forms.Button();
            this.txtVrReajuste = new System.Windows.Forms.NumericUpDown();
            this.txtSomatorioSalarioTemp = new System.Windows.Forms.TextBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVrReajuste)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textNomeBanco);
            this.groupBox1.Controls.Add(this.textPort);
            this.groupBox1.Controls.Add(this.btnTestarConexao);
            this.groupBox1.Controls.Add(this.textPass);
            this.groupBox1.Controls.Add(this.textUser);
            this.groupBox1.Controls.Add(this.textHost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão com o Banco de dados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome banco:";
            // 
            // textNomeBanco
            // 
            this.textNomeBanco.Location = new System.Drawing.Point(447, 25);
            this.textNomeBanco.Name = "textNomeBanco";
            this.textNomeBanco.Size = new System.Drawing.Size(206, 20);
            this.textNomeBanco.TabIndex = 2;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(594, 51);
            this.textPort.Mask = "####";
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(59, 20);
            this.textPort.TabIndex = 5;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Image = global::trabalhoBD2.Properties.Resources.DataBase;
            this.btnTestarConexao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestarConexao.Location = new System.Drawing.Point(659, 25);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(118, 46);
            this.btnTestarConexao.TabIndex = 6;
            this.btnTestarConexao.Text = "Testar conexão";
            this.btnTestarConexao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(355, 51);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(192, 20);
            this.textPass.TabIndex = 4;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(58, 51);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(244, 20);
            this.textUser.TabIndex = 3;
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(58, 25);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(306, 20);
            this.textHost.TabIndex = 1;
            this.textHost.TextChanged += new System.EventHandler(this.textHost_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // btnFecharAplicacao
            // 
            this.btnFecharAplicacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharAplicacao.Location = new System.Drawing.Point(677, 440);
            this.btnFecharAplicacao.Name = "btnFecharAplicacao";
            this.btnFecharAplicacao.Size = new System.Drawing.Size(118, 30);
            this.btnFecharAplicacao.TabIndex = 42;
            this.btnFecharAplicacao.Text = "Fechar aplicação";
            this.btnFecharAplicacao.UseVisualStyleBackColor = true;
            this.btnFecharAplicacao.Click += new System.EventHandler(this.btnFecharAplicacao_Click);
            // 
            // btnFuncCadastrados
            // 
            this.btnFuncCadastrados.Location = new System.Drawing.Point(12, 173);
            this.btnFuncCadastrados.Name = "btnFuncCadastrados";
            this.btnFuncCadastrados.Size = new System.Drawing.Size(139, 20);
            this.btnFuncCadastrados.TabIndex = 9;
            this.btnFuncCadastrados.Text = "Qte func cadastrados";
            this.toolTip1.SetToolTip(this.btnFuncCadastrados, "Quantidade de funcionários cadastrados");
            this.btnFuncCadastrados.UseVisualStyleBackColor = true;
            this.btnFuncCadastrados.Click += new System.EventHandler(this.btnFuncCadastrados_Click);
            // 
            // txtQteFuncCadastrado
            // 
            this.txtQteFuncCadastrado.Enabled = false;
            this.txtQteFuncCadastrado.Location = new System.Drawing.Point(157, 173);
            this.txtQteFuncCadastrado.Name = "txtQteFuncCadastrado";
            this.txtQteFuncCadastrado.Size = new System.Drawing.Size(53, 20);
            this.txtQteFuncCadastrado.TabIndex = 10;
            // 
            // btnQteFuncAtivos
            // 
            this.btnQteFuncAtivos.Location = new System.Drawing.Point(12, 199);
            this.btnQteFuncAtivos.Name = "btnQteFuncAtivos";
            this.btnQteFuncAtivos.Size = new System.Drawing.Size(139, 20);
            this.btnQteFuncAtivos.TabIndex = 11;
            this.btnQteFuncAtivos.Text = "Qte func ativos";
            this.toolTip1.SetToolTip(this.btnQteFuncAtivos, "Quantidade de funcionários com situação de ativo (0)");
            this.btnQteFuncAtivos.UseVisualStyleBackColor = true;
            this.btnQteFuncAtivos.Click += new System.EventHandler(this.btnQteFuncAtivos_Click);
            // 
            // txtQteFuncAtivos
            // 
            this.txtQteFuncAtivos.Enabled = false;
            this.txtQteFuncAtivos.Location = new System.Drawing.Point(157, 199);
            this.txtQteFuncAtivos.Name = "txtQteFuncAtivos";
            this.txtQteFuncAtivos.Size = new System.Drawing.Size(53, 20);
            this.txtQteFuncAtivos.TabIndex = 12;
            // 
            // btnQteFuncAtivosPorSexo
            // 
            this.btnQteFuncAtivosPorSexo.Location = new System.Drawing.Point(12, 251);
            this.btnQteFuncAtivosPorSexo.Name = "btnQteFuncAtivosPorSexo";
            this.btnQteFuncAtivosPorSexo.Size = new System.Drawing.Size(139, 20);
            this.btnQteFuncAtivosPorSexo.TabIndex = 15;
            this.btnQteFuncAtivosPorSexo.Text = "Qte func ativos por sexo";
            this.toolTip1.SetToolTip(this.btnQteFuncAtivosPorSexo, "Quantidade de funcionários ativos por sexo");
            this.btnQteFuncAtivosPorSexo.UseVisualStyleBackColor = true;
            this.btnQteFuncAtivosPorSexo.Click += new System.EventHandler(this.btnQteFuncAtivosPorSexo_Click);
            // 
            // txtQteFuncAtivosSexo0
            // 
            this.txtQteFuncAtivosSexo0.Enabled = false;
            this.txtQteFuncAtivosSexo0.Location = new System.Drawing.Point(157, 251);
            this.txtQteFuncAtivosSexo0.Name = "txtQteFuncAtivosSexo0";
            this.txtQteFuncAtivosSexo0.Size = new System.Drawing.Size(53, 20);
            this.txtQteFuncAtivosSexo0.TabIndex = 16;
            // 
            // txtQteFuncAtivosSexo1
            // 
            this.txtQteFuncAtivosSexo1.Enabled = false;
            this.txtQteFuncAtivosSexo1.Location = new System.Drawing.Point(216, 251);
            this.txtQteFuncAtivosSexo1.Name = "txtQteFuncAtivosSexo1";
            this.txtQteFuncAtivosSexo1.Size = new System.Drawing.Size(53, 20);
            this.txtQteFuncAtivosSexo1.TabIndex = 17;
            // 
            // btnSalarioMedio
            // 
            this.btnSalarioMedio.Location = new System.Drawing.Point(12, 291);
            this.btnSalarioMedio.Name = "btnSalarioMedio";
            this.btnSalarioMedio.Size = new System.Drawing.Size(139, 20);
            this.btnSalarioMedio.TabIndex = 21;
            this.btnSalarioMedio.Text = "Salário médio";
            this.toolTip1.SetToolTip(this.btnSalarioMedio, "Salário médio dos funcionários ativos");
            this.btnSalarioMedio.UseVisualStyleBackColor = true;
            this.btnSalarioMedio.Click += new System.EventHandler(this.btnSalarioMedio_Click);
            // 
            // txtSalarioMedio
            // 
            this.txtSalarioMedio.Enabled = false;
            this.txtSalarioMedio.Location = new System.Drawing.Point(157, 291);
            this.txtSalarioMedio.Name = "txtSalarioMedio";
            this.txtSalarioMedio.Size = new System.Drawing.Size(112, 20);
            this.txtSalarioMedio.TabIndex = 22;
            // 
            // btnFolhaDepComercial
            // 
            this.btnFolhaDepComercial.Location = new System.Drawing.Point(12, 317);
            this.btnFolhaDepComercial.Name = "btnFolhaDepComercial";
            this.btnFolhaDepComercial.Size = new System.Drawing.Size(139, 20);
            this.btnFolhaDepComercial.TabIndex = 23;
            this.btnFolhaDepComercial.Text = "Folha dep comercial";
            this.toolTip1.SetToolTip(this.btnFolhaDepComercial, "Valor da folha de pagamento do departamento Comercial");
            this.btnFolhaDepComercial.UseVisualStyleBackColor = true;
            this.btnFolhaDepComercial.Click += new System.EventHandler(this.btnFolhaDepComercial_Click);
            // 
            // btnFolhaDepDesenvolvimento
            // 
            this.btnFolhaDepDesenvolvimento.Location = new System.Drawing.Point(12, 343);
            this.btnFolhaDepDesenvolvimento.Name = "btnFolhaDepDesenvolvimento";
            this.btnFolhaDepDesenvolvimento.Size = new System.Drawing.Size(139, 21);
            this.btnFolhaDepDesenvolvimento.TabIndex = 29;
            this.btnFolhaDepDesenvolvimento.Text = "Folha dep desenv";
            this.toolTip1.SetToolTip(this.btnFolhaDepDesenvolvimento, "Valor da folha de pagamento do departamento Desenvolvimento");
            this.btnFolhaDepDesenvolvimento.UseVisualStyleBackColor = true;
            this.btnFolhaDepDesenvolvimento.Click += new System.EventHandler(this.btnFolhaDepDesenvolvimento_Click);
            // 
            // btnFolhaDepSuporte
            // 
            this.btnFolhaDepSuporte.Location = new System.Drawing.Point(12, 370);
            this.btnFolhaDepSuporte.Name = "btnFolhaDepSuporte";
            this.btnFolhaDepSuporte.Size = new System.Drawing.Size(139, 20);
            this.btnFolhaDepSuporte.TabIndex = 35;
            this.btnFolhaDepSuporte.Text = "Folha dep suporte";
            this.toolTip1.SetToolTip(this.btnFolhaDepSuporte, "Valor da folha de pagamento do departamento Suporte");
            this.btnFolhaDepSuporte.UseVisualStyleBackColor = true;
            this.btnFolhaDepSuporte.Click += new System.EventHandler(this.btnFolhaDepSuporte_Click);
            // 
            // btnMediaSalDepSuporte
            // 
            this.btnMediaSalDepSuporte.Location = new System.Drawing.Point(275, 370);
            this.btnMediaSalDepSuporte.Name = "btnMediaSalDepSuporte";
            this.btnMediaSalDepSuporte.Size = new System.Drawing.Size(139, 20);
            this.btnMediaSalDepSuporte.TabIndex = 37;
            this.btnMediaSalDepSuporte.Text = "Média Sal Dep Suporte";
            this.toolTip1.SetToolTip(this.btnMediaSalDepSuporte, "Média salarial do departamento Suporte");
            this.btnMediaSalDepSuporte.UseVisualStyleBackColor = true;
            this.btnMediaSalDepSuporte.Click += new System.EventHandler(this.btnMediaSalDepSuporte_Click);
            // 
            // btnMediaSalDepDesenvolvimento
            // 
            this.btnMediaSalDepDesenvolvimento.Location = new System.Drawing.Point(275, 343);
            this.btnMediaSalDepDesenvolvimento.Name = "btnMediaSalDepDesenvolvimento";
            this.btnMediaSalDepDesenvolvimento.Size = new System.Drawing.Size(139, 20);
            this.btnMediaSalDepDesenvolvimento.TabIndex = 31;
            this.btnMediaSalDepDesenvolvimento.Text = "Média Sal Dep Desenv";
            this.toolTip1.SetToolTip(this.btnMediaSalDepDesenvolvimento, "Média salarial do departamento Desenvolvimento");
            this.btnMediaSalDepDesenvolvimento.UseVisualStyleBackColor = true;
            this.btnMediaSalDepDesenvolvimento.Click += new System.EventHandler(this.btnMediaSalDepDesenvolvimento_Click);
            // 
            // btnMediaSalDepComercial
            // 
            this.btnMediaSalDepComercial.Location = new System.Drawing.Point(275, 317);
            this.btnMediaSalDepComercial.Name = "btnMediaSalDepComercial";
            this.btnMediaSalDepComercial.Size = new System.Drawing.Size(139, 20);
            this.btnMediaSalDepComercial.TabIndex = 25;
            this.btnMediaSalDepComercial.Text = "Média Sal Dep Comercial";
            this.toolTip1.SetToolTip(this.btnMediaSalDepComercial, "Média salarial do departamento Comercial");
            this.btnMediaSalDepComercial.UseVisualStyleBackColor = true;
            this.btnMediaSalDepComercial.Click += new System.EventHandler(this.btnMediaSalDepComercial_Click);
            // 
            // btnMediaIdadeDepSuporte
            // 
            this.btnMediaIdadeDepSuporte.Location = new System.Drawing.Point(538, 370);
            this.btnMediaIdadeDepSuporte.Name = "btnMediaIdadeDepSuporte";
            this.btnMediaIdadeDepSuporte.Size = new System.Drawing.Size(139, 20);
            this.btnMediaIdadeDepSuporte.TabIndex = 39;
            this.btnMediaIdadeDepSuporte.Text = "Média Idade Dep Sup";
            this.toolTip1.SetToolTip(this.btnMediaIdadeDepSuporte, "Média de idade dos funcionários ativos do Departamento Suporte");
            this.btnMediaIdadeDepSuporte.UseVisualStyleBackColor = true;
            this.btnMediaIdadeDepSuporte.Click += new System.EventHandler(this.btnMediaIdadeDepSuporte_Click);
            // 
            // btnMediaIdadeDepDesenvolvimento
            // 
            this.btnMediaIdadeDepDesenvolvimento.Location = new System.Drawing.Point(538, 343);
            this.btnMediaIdadeDepDesenvolvimento.Name = "btnMediaIdadeDepDesenvolvimento";
            this.btnMediaIdadeDepDesenvolvimento.Size = new System.Drawing.Size(139, 21);
            this.btnMediaIdadeDepDesenvolvimento.TabIndex = 33;
            this.btnMediaIdadeDepDesenvolvimento.Text = "Média Idade Dep Des";
            this.toolTip1.SetToolTip(this.btnMediaIdadeDepDesenvolvimento, "Média de idade dos funcionários ativos do Departamento Desenvolvimento");
            this.btnMediaIdadeDepDesenvolvimento.UseVisualStyleBackColor = true;
            this.btnMediaIdadeDepDesenvolvimento.Click += new System.EventHandler(this.btnMediaIdadeDepDesenvolvimento_Click);
            // 
            // btnMediaIdadeDepComercial
            // 
            this.btnMediaIdadeDepComercial.Location = new System.Drawing.Point(538, 317);
            this.btnMediaIdadeDepComercial.Name = "btnMediaIdadeDepComercial";
            this.btnMediaIdadeDepComercial.Size = new System.Drawing.Size(139, 20);
            this.btnMediaIdadeDepComercial.TabIndex = 27;
            this.btnMediaIdadeDepComercial.Text = "Média Idade Dep Com";
            this.toolTip1.SetToolTip(this.btnMediaIdadeDepComercial, "Média de idade dos funcionários ativos do Departamento Comercial");
            this.btnMediaIdadeDepComercial.UseVisualStyleBackColor = true;
            this.btnMediaIdadeDepComercial.Click += new System.EventHandler(this.btnMediaIdadeDepComercial_Click);
            // 
            // txtFolhaDepComercial
            // 
            this.txtFolhaDepComercial.Enabled = false;
            this.txtFolhaDepComercial.Location = new System.Drawing.Point(157, 317);
            this.txtFolhaDepComercial.Name = "txtFolhaDepComercial";
            this.txtFolhaDepComercial.Size = new System.Drawing.Size(112, 20);
            this.txtFolhaDepComercial.TabIndex = 24;
            // 
            // txtFolhaDepDesenvolvimento
            // 
            this.txtFolhaDepDesenvolvimento.Enabled = false;
            this.txtFolhaDepDesenvolvimento.Location = new System.Drawing.Point(157, 344);
            this.txtFolhaDepDesenvolvimento.Name = "txtFolhaDepDesenvolvimento";
            this.txtFolhaDepDesenvolvimento.Size = new System.Drawing.Size(112, 20);
            this.txtFolhaDepDesenvolvimento.TabIndex = 30;
            // 
            // txtFolhaDepSuporte
            // 
            this.txtFolhaDepSuporte.Enabled = false;
            this.txtFolhaDepSuporte.Location = new System.Drawing.Point(157, 370);
            this.txtFolhaDepSuporte.Name = "txtFolhaDepSuporte";
            this.txtFolhaDepSuporte.Size = new System.Drawing.Size(112, 20);
            this.txtFolhaDepSuporte.TabIndex = 36;
            // 
            // btnQteCPFInvalidos
            // 
            this.btnQteCPFInvalidos.Location = new System.Drawing.Point(12, 225);
            this.btnQteCPFInvalidos.Name = "btnQteCPFInvalidos";
            this.btnQteCPFInvalidos.Size = new System.Drawing.Size(139, 20);
            this.btnQteCPFInvalidos.TabIndex = 13;
            this.btnQteCPFInvalidos.Text = "Qte func CPF inválidos";
            this.toolTip1.SetToolTip(this.btnQteCPFInvalidos, "Quantidade de funcionários cadastrados com CPFs inválidos");
            this.btnQteCPFInvalidos.UseVisualStyleBackColor = true;
            this.btnQteCPFInvalidos.Click += new System.EventHandler(this.btnQteCPFInvalidos_Click);
            // 
            // txtQteFuncCPFinvalidos
            // 
            this.txtQteFuncCPFinvalidos.Enabled = false;
            this.txtQteFuncCPFinvalidos.Location = new System.Drawing.Point(157, 225);
            this.txtQteFuncCPFinvalidos.Name = "txtQteFuncCPFinvalidos";
            this.txtQteFuncCPFinvalidos.Size = new System.Drawing.Size(53, 20);
            this.txtQteFuncCPFinvalidos.TabIndex = 14;
            // 
            // txtMediaSalDepComercial
            // 
            this.txtMediaSalDepComercial.Enabled = false;
            this.txtMediaSalDepComercial.Location = new System.Drawing.Point(420, 317);
            this.txtMediaSalDepComercial.Name = "txtMediaSalDepComercial";
            this.txtMediaSalDepComercial.Size = new System.Drawing.Size(112, 20);
            this.txtMediaSalDepComercial.TabIndex = 26;
            // 
            // txtMediaSalDepDesenvolvimento
            // 
            this.txtMediaSalDepDesenvolvimento.Enabled = false;
            this.txtMediaSalDepDesenvolvimento.Location = new System.Drawing.Point(420, 343);
            this.txtMediaSalDepDesenvolvimento.Name = "txtMediaSalDepDesenvolvimento";
            this.txtMediaSalDepDesenvolvimento.Size = new System.Drawing.Size(112, 20);
            this.txtMediaSalDepDesenvolvimento.TabIndex = 32;
            // 
            // txtMediaSalDepSuporte
            // 
            this.txtMediaSalDepSuporte.Enabled = false;
            this.txtMediaSalDepSuporte.Location = new System.Drawing.Point(420, 370);
            this.txtMediaSalDepSuporte.Name = "txtMediaSalDepSuporte";
            this.txtMediaSalDepSuporte.Size = new System.Drawing.Size(112, 20);
            this.txtMediaSalDepSuporte.TabIndex = 38;
            // 
            // txtMediaIdadeDepComercial
            // 
            this.txtMediaIdadeDepComercial.Enabled = false;
            this.txtMediaIdadeDepComercial.Location = new System.Drawing.Point(683, 317);
            this.txtMediaIdadeDepComercial.Name = "txtMediaIdadeDepComercial";
            this.txtMediaIdadeDepComercial.Size = new System.Drawing.Size(112, 20);
            this.txtMediaIdadeDepComercial.TabIndex = 28;
            // 
            // txtMediaIdadeDepDesenvolvimento
            // 
            this.txtMediaIdadeDepDesenvolvimento.Enabled = false;
            this.txtMediaIdadeDepDesenvolvimento.Location = new System.Drawing.Point(683, 343);
            this.txtMediaIdadeDepDesenvolvimento.Name = "txtMediaIdadeDepDesenvolvimento";
            this.txtMediaIdadeDepDesenvolvimento.Size = new System.Drawing.Size(112, 20);
            this.txtMediaIdadeDepDesenvolvimento.TabIndex = 34;
            // 
            // txtMediaIdadeDepSuporte
            // 
            this.txtMediaIdadeDepSuporte.Enabled = false;
            this.txtMediaIdadeDepSuporte.Location = new System.Drawing.Point(683, 370);
            this.txtMediaIdadeDepSuporte.Name = "txtMediaIdadeDepSuporte";
            this.txtMediaIdadeDepSuporte.Size = new System.Drawing.Size(112, 20);
            this.txtMediaIdadeDepSuporte.TabIndex = 40;
            // 
            // btnValidarBD
            // 
            this.btnValidarBD.Location = new System.Drawing.Point(12, 97);
            this.btnValidarBD.Name = "btnValidarBD";
            this.btnValidarBD.Size = new System.Drawing.Size(139, 42);
            this.btnValidarBD.TabIndex = 7;
            this.btnValidarBD.Text = "Validar BD";
            this.toolTip1.SetToolTip(this.btnValidarBD, "Botão para validar se existem as procedures, funções e triggers no banco de dados" +
        "");
            this.btnValidarBD.UseVisualStyleBackColor = true;
            this.btnValidarBD.Click += new System.EventHandler(this.btnValidarBD_Click);
            // 
            // txtValiidarBD
            // 
            this.txtValiidarBD.Location = new System.Drawing.Point(157, 97);
            this.txtValiidarBD.Multiline = true;
            this.txtValiidarBD.Name = "txtValiidarBD";
            this.txtValiidarBD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValiidarBD.Size = new System.Drawing.Size(375, 70);
            this.txtValiidarBD.TabIndex = 8;
            // 
            // btnReajusteTrigger
            // 
            this.btnReajusteTrigger.Location = new System.Drawing.Point(275, 251);
            this.btnReajusteTrigger.Name = "btnReajusteTrigger";
            this.btnReajusteTrigger.Size = new System.Drawing.Size(139, 20);
            this.btnReajusteTrigger.TabIndex = 18;
            this.btnReajusteTrigger.Text = "Aplicar reaj Salário Cargo";
            this.toolTip1.SetToolTip(this.btnReajusteTrigger, "Aplicar reajuste em % do campo na lateral para o cargo. Neste ponto, aplicar nos " +
        "campos de salário em tab. funcionário, via trigger, o valor que foi aplicado no " +
        "campo salariotemp");
            this.btnReajusteTrigger.UseVisualStyleBackColor = true;
            this.btnReajusteTrigger.Click += new System.EventHandler(this.btnReajusteTrigger_Click);
            // 
            // txtVrReajuste
            // 
            this.txtVrReajuste.Location = new System.Drawing.Point(420, 251);
            this.txtVrReajuste.Name = "txtVrReajuste";
            this.txtVrReajuste.Size = new System.Drawing.Size(52, 20);
            this.txtVrReajuste.TabIndex = 19;
            // 
            // txtSomatorioSalarioTemp
            // 
            this.txtSomatorioSalarioTemp.Enabled = false;
            this.txtSomatorioSalarioTemp.Location = new System.Drawing.Point(478, 250);
            this.txtSomatorioSalarioTemp.Name = "txtSomatorioSalarioTemp";
            this.txtSomatorioSalarioTemp.Size = new System.Drawing.Size(122, 20);
            this.txtSomatorioSalarioTemp.TabIndex = 20;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCampos.Location = new System.Drawing.Point(553, 439);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(118, 30);
            this.btnLimparCampos.TabIndex = 41;
            this.btnLimparCampos.Text = "Limpar campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 481);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.txtSomatorioSalarioTemp);
            this.Controls.Add(this.btnReajusteTrigger);
            this.Controls.Add(this.txtVrReajuste);
            this.Controls.Add(this.txtValiidarBD);
            this.Controls.Add(this.btnValidarBD);
            this.Controls.Add(this.txtMediaIdadeDepSuporte);
            this.Controls.Add(this.txtMediaIdadeDepDesenvolvimento);
            this.Controls.Add(this.txtMediaIdadeDepComercial);
            this.Controls.Add(this.txtMediaSalDepSuporte);
            this.Controls.Add(this.txtMediaSalDepDesenvolvimento);
            this.Controls.Add(this.txtMediaSalDepComercial);
            this.Controls.Add(this.txtQteFuncCPFinvalidos);
            this.Controls.Add(this.btnQteCPFInvalidos);
            this.Controls.Add(this.txtFolhaDepSuporte);
            this.Controls.Add(this.txtFolhaDepDesenvolvimento);
            this.Controls.Add(this.txtFolhaDepComercial);
            this.Controls.Add(this.btnMediaIdadeDepSuporte);
            this.Controls.Add(this.btnMediaIdadeDepDesenvolvimento);
            this.Controls.Add(this.btnMediaIdadeDepComercial);
            this.Controls.Add(this.btnMediaSalDepSuporte);
            this.Controls.Add(this.btnMediaSalDepDesenvolvimento);
            this.Controls.Add(this.btnMediaSalDepComercial);
            this.Controls.Add(this.btnFolhaDepSuporte);
            this.Controls.Add(this.btnFolhaDepDesenvolvimento);
            this.Controls.Add(this.btnFolhaDepComercial);
            this.Controls.Add(this.txtSalarioMedio);
            this.Controls.Add(this.btnSalarioMedio);
            this.Controls.Add(this.txtQteFuncAtivosSexo1);
            this.Controls.Add(this.txtQteFuncAtivosSexo0);
            this.Controls.Add(this.btnQteFuncAtivosPorSexo);
            this.Controls.Add(this.txtQteFuncAtivos);
            this.Controls.Add(this.btnQteFuncAtivos);
            this.Controls.Add(this.txtQteFuncCadastrado);
            this.Controls.Add(this.btnFuncCadastrados);
            this.Controls.Add(this.btnFecharAplicacao);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Trabalho BD2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVrReajuste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNomeBanco;
        private System.Windows.Forms.Button btnFecharAplicacao;
        private System.Windows.Forms.Button btnFuncCadastrados;
        private System.Windows.Forms.TextBox txtQteFuncCadastrado;
        private System.Windows.Forms.Button btnQteFuncAtivos;
        private System.Windows.Forms.TextBox txtQteFuncAtivos;
        private System.Windows.Forms.Button btnQteFuncAtivosPorSexo;
        private System.Windows.Forms.TextBox txtQteFuncAtivosSexo0;
        private System.Windows.Forms.TextBox txtQteFuncAtivosSexo1;
        private System.Windows.Forms.Button btnSalarioMedio;
        private System.Windows.Forms.TextBox txtSalarioMedio;
        private System.Windows.Forms.Button btnFolhaDepComercial;
        private System.Windows.Forms.Button btnFolhaDepDesenvolvimento;
        private System.Windows.Forms.Button btnFolhaDepSuporte;
        private System.Windows.Forms.Button btnMediaSalDepSuporte;
        private System.Windows.Forms.Button btnMediaSalDepDesenvolvimento;
        private System.Windows.Forms.Button btnMediaSalDepComercial;
        private System.Windows.Forms.Button btnMediaIdadeDepSuporte;
        private System.Windows.Forms.Button btnMediaIdadeDepDesenvolvimento;
        private System.Windows.Forms.Button btnMediaIdadeDepComercial;
        private System.Windows.Forms.TextBox txtFolhaDepComercial;
        private System.Windows.Forms.TextBox txtFolhaDepDesenvolvimento;
        private System.Windows.Forms.TextBox txtFolhaDepSuporte;
        private System.Windows.Forms.Button btnQteCPFInvalidos;
        private System.Windows.Forms.TextBox txtQteFuncCPFinvalidos;
        private System.Windows.Forms.TextBox txtMediaSalDepComercial;
        private System.Windows.Forms.TextBox txtMediaSalDepDesenvolvimento;
        private System.Windows.Forms.TextBox txtMediaSalDepSuporte;
        private System.Windows.Forms.TextBox txtMediaIdadeDepComercial;
        private System.Windows.Forms.TextBox txtMediaIdadeDepDesenvolvimento;
        private System.Windows.Forms.TextBox txtMediaIdadeDepSuporte;
        private System.Windows.Forms.Button btnValidarBD;
        private System.Windows.Forms.TextBox txtValiidarBD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown txtVrReajuste;
        private System.Windows.Forms.Button btnReajusteTrigger;
        private System.Windows.Forms.TextBox txtSomatorioSalarioTemp;
        private System.Windows.Forms.Button btnLimparCampos;
    }
}

