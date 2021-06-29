
namespace ex2
{
    partial class ex3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMedia = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbMaior = new System.Windows.Forms.Label();
            this.lbMenor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade da pessoa 1:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMedia
            // 
            this.lbMedia.AutoSize = true;
            this.lbMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMedia.Location = new System.Drawing.Point(13, 147);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(150, 21);
            this.lbMedia.TabIndex = 3;
            this.lbMedia.Text = "Média das idades: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbMaior
            // 
            this.lbMaior.AutoSize = true;
            this.lbMaior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaior.Location = new System.Drawing.Point(13, 179);
            this.lbMaior.Name = "lbMaior";
            this.lbMaior.Size = new System.Drawing.Size(110, 21);
            this.lbMaior.TabIndex = 3;
            this.lbMaior.Text = "Maior idade: ";
            // 
            // lbMenor
            // 
            this.lbMenor.AutoSize = true;
            this.lbMenor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMenor.Location = new System.Drawing.Point(13, 213);
            this.lbMenor.Name = "lbMenor";
            this.lbMenor.Size = new System.Drawing.Size(115, 21);
            this.lbMenor.TabIndex = 3;
            this.lbMenor.Text = "Menor idade: ";
            // 
            // ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 254);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbMenor);
            this.Controls.Add(this.lbMaior);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ex3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMedia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbMaior;
        private System.Windows.Forms.Label lbMenor;
    }
}

