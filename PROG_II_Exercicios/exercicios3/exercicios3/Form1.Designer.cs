
namespace exercicios3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSacar = new System.Windows.Forms.Button();
            this.btDepositar = new System.Windows.Forms.Button();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLimite = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btLimite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE CONTROLE DE CONTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "VALOR DA NEGOCIAÇÃO:";
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(12, 169);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(147, 64);
            this.btSacar.TabIndex = 2;
            this.btSacar.Text = "SACAR";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // btDepositar
            // 
            this.btDepositar.Location = new System.Drawing.Point(199, 169);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(147, 64);
            this.btDepositar.TabIndex = 2;
            this.btDepositar.Text = "DEPOSITAR";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSaldo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbSaldo.Location = new System.Drawing.Point(67, 81);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(64, 21);
            this.lbSaldo.TabIndex = 1;
            this.lbSaldo.Text = "R$ 0,00";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "LIMITE:";
            // 
            // lbLimite
            // 
            this.lbLimite.AutoSize = true;
            this.lbLimite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLimite.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbLimite.Location = new System.Drawing.Point(67, 251);
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(64, 21);
            this.lbLimite.TabIndex = 1;
            this.lbLimite.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "NOVO LIMITE:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 291);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 23);
            this.textBox2.TabIndex = 3;
            // 
            // btLimite
            // 
            this.btLimite.Location = new System.Drawing.Point(251, 273);
            this.btLimite.Name = "btLimite";
            this.btLimite.Size = new System.Drawing.Size(95, 41);
            this.btLimite.TabIndex = 4;
            this.btLimite.Text = "ALTERAR LIMITE";
            this.btLimite.UseVisualStyleBackColor = true;
            this.btLimite.Click += new System.EventHandler(this.btLimite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 345);
            this.Controls.Add(this.btLimite);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLimite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLimite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btLimite;
    }
}

