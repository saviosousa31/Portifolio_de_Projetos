
namespace ex4
{
    partial class ex4
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
            this.btPrimo = new System.Windows.Forms.Button();
            this.btFatorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btPrimo
            // 
            this.btPrimo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPrimo.Location = new System.Drawing.Point(13, 137);
            this.btPrimo.Name = "btPrimo";
            this.btPrimo.Size = new System.Drawing.Size(171, 68);
            this.btPrimo.TabIndex = 0;
            this.btPrimo.Text = "Primo";
            this.btPrimo.UseVisualStyleBackColor = true;
            this.btPrimo.Click += new System.EventHandler(this.btPrimo_Click);
            // 
            // btFatorial
            // 
            this.btFatorial.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btFatorial.Location = new System.Drawing.Point(190, 137);
            this.btFatorial.Name = "btFatorial";
            this.btFatorial.Size = new System.Drawing.Size(171, 68);
            this.btFatorial.TabIndex = 0;
            this.btFatorial.Text = "Fatorial";
            this.btFatorial.UseVisualStyleBackColor = true;
            this.btFatorial.Click += new System.EventHandler(this.btFatorial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programa de cálculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite um número inteiro positivo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 220);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFatorial);
            this.Controls.Add(this.btPrimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPrimo;
        private System.Windows.Forms.Button btFatorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

