
namespace Atividade_4___Sávio_Soares_Sousa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbX = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.rbDev = new System.Windows.Forms.RadioButton();
            this.rbGerente = new System.Windows.Forms.RadioButton();
            this.rbDiretor = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbX);
            this.groupBox1.Controls.Add(this.btCalcular);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rbVendedor);
            this.groupBox1.Controls.Add(this.rbDev);
            this.groupBox1.Controls.Add(this.rbGerente);
            this.groupBox1.Controls.Add(this.rbDiretor);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário:";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(236, 124);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(13, 15);
            this.lbX.TabIndex = 4;
            this.lbX.Text = "x\r\n";
            this.lbX.Visible = false;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(235, 23);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(179, 49);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "Calcular salário";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(6, 128);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(75, 19);
            this.rbVendedor.TabIndex = 1;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            this.rbVendedor.CheckedChanged += new System.EventHandler(this.rbVendedor_CheckedChanged);
            // 
            // rbDev
            // 
            this.rbDev.AutoSize = true;
            this.rbDev.Location = new System.Drawing.Point(6, 103);
            this.rbDev.Name = "rbDev";
            this.rbDev.Size = new System.Drawing.Size(103, 19);
            this.rbDev.TabIndex = 1;
            this.rbDev.TabStop = true;
            this.rbDev.Text = "Desenvolvedor";
            this.rbDev.UseVisualStyleBackColor = true;
            this.rbDev.CheckedChanged += new System.EventHandler(this.rbDev_CheckedChanged);
            // 
            // rbGerente
            // 
            this.rbGerente.AutoSize = true;
            this.rbGerente.Location = new System.Drawing.Point(6, 78);
            this.rbGerente.Name = "rbGerente";
            this.rbGerente.Size = new System.Drawing.Size(66, 19);
            this.rbGerente.TabIndex = 1;
            this.rbGerente.TabStop = true;
            this.rbGerente.Text = "Gerente";
            this.rbGerente.UseVisualStyleBackColor = true;
            this.rbGerente.CheckedChanged += new System.EventHandler(this.rbGerente_CheckedChanged);
            // 
            // rbDiretor
            // 
            this.rbDiretor.AutoSize = true;
            this.rbDiretor.Location = new System.Drawing.Point(7, 53);
            this.rbDiretor.Name = "rbDiretor";
            this.rbDiretor.Size = new System.Drawing.Size(61, 19);
            this.rbDiretor.TabIndex = 1;
            this.rbDiretor.TabStop = true;
            this.rbDiretor.Text = "Diretor";
            this.rbDiretor.UseVisualStyleBackColor = true;
            this.rbDiretor.CheckedChanged += new System.EventHandler(this.rbDiretor_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mailson",
            "Messi",
            "Cristiano",
            "Pelé",
            "Tsubasa"});
            this.comboBox1.Location = new System.Drawing.Point(7, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 193);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.RadioButton rbDev;
        private System.Windows.Forms.RadioButton rbGerente;
        private System.Windows.Forms.RadioButton rbDiretor;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

