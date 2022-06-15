namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLog = new System.Windows.Forms.TextBox();
            this.Raiz = new System.Windows.Forms.Button();
            this.Exponencial = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.digt7 = new System.Windows.Forms.Button();
            this.digt8 = new System.Windows.Forms.Button();
            this.digt9 = new System.Windows.Forms.Button();
            this.Muntiplicar = new System.Windows.Forms.Button();
            this.digt4 = new System.Windows.Forms.Button();
            this.digt5 = new System.Windows.Forms.Button();
            this.digt6 = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.digt1 = new System.Windows.Forms.Button();
            this.digt2 = new System.Windows.Forms.Button();
            this.digt3 = new System.Windows.Forms.Button();
            this.Somar = new System.Windows.Forms.Button();
            this.dgt0 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Ponto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 13);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(164, 20);
            this.txtLog.TabIndex = 0;
            // 
            // Raiz
            // 
            this.Raiz.Location = new System.Drawing.Point(13, 40);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(38, 31);
            this.Raiz.TabIndex = 1;
            this.Raiz.Text = "√";
            this.Raiz.UseVisualStyleBackColor = true;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click_1);
            // 
            // Exponencial
            // 
            this.Exponencial.Location = new System.Drawing.Point(57, 40);
            this.Exponencial.Name = "Exponencial";
            this.Exponencial.Size = new System.Drawing.Size(36, 31);
            this.Exponencial.TabIndex = 2;
            this.Exponencial.Text = "^";
            this.Exponencial.UseVisualStyleBackColor = true;
            this.Exponencial.Click += new System.EventHandler(this.Exponencial_Click);
            // 
            // Divisao
            // 
            this.Divisao.Location = new System.Drawing.Point(99, 38);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(36, 33);
            this.Divisao.TabIndex = 3;
            this.Divisao.Text = "/";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(141, 38);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(36, 33);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "C";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // digt7
            // 
            this.digt7.Location = new System.Drawing.Point(13, 77);
            this.digt7.Name = "digt7";
            this.digt7.Size = new System.Drawing.Size(38, 31);
            this.digt7.TabIndex = 5;
            this.digt7.Text = "7";
            this.digt7.UseVisualStyleBackColor = true;
            this.digt7.Click += new System.EventHandler(this.digt7_Click);
            // 
            // digt8
            // 
            this.digt8.Location = new System.Drawing.Point(57, 77);
            this.digt8.Name = "digt8";
            this.digt8.Size = new System.Drawing.Size(36, 31);
            this.digt8.TabIndex = 6;
            this.digt8.Text = "8";
            this.digt8.UseVisualStyleBackColor = true;
            this.digt8.Click += new System.EventHandler(this.digt8_Click);
            // 
            // digt9
            // 
            this.digt9.Location = new System.Drawing.Point(99, 77);
            this.digt9.Name = "digt9";
            this.digt9.Size = new System.Drawing.Size(36, 31);
            this.digt9.TabIndex = 7;
            this.digt9.Text = "9";
            this.digt9.UseVisualStyleBackColor = true;
            this.digt9.Click += new System.EventHandler(this.digt9_Click);
            // 
            // Muntiplicar
            // 
            this.Muntiplicar.Location = new System.Drawing.Point(141, 77);
            this.Muntiplicar.Name = "Muntiplicar";
            this.Muntiplicar.Size = new System.Drawing.Size(36, 31);
            this.Muntiplicar.TabIndex = 8;
            this.Muntiplicar.Text = "*";
            this.Muntiplicar.UseVisualStyleBackColor = true;
            this.Muntiplicar.Click += new System.EventHandler(this.Muntiplicar_Click);
            // 
            // digt4
            // 
            this.digt4.Location = new System.Drawing.Point(13, 114);
            this.digt4.Name = "digt4";
            this.digt4.Size = new System.Drawing.Size(37, 31);
            this.digt4.TabIndex = 9;
            this.digt4.Text = "4";
            this.digt4.UseVisualStyleBackColor = true;
            this.digt4.Click += new System.EventHandler(this.digt4_Click);
            // 
            // digt5
            // 
            this.digt5.Location = new System.Drawing.Point(56, 114);
            this.digt5.Name = "digt5";
            this.digt5.Size = new System.Drawing.Size(37, 31);
            this.digt5.TabIndex = 10;
            this.digt5.Text = "5";
            this.digt5.UseVisualStyleBackColor = true;
            this.digt5.Click += new System.EventHandler(this.digt5_Click);
            // 
            // digt6
            // 
            this.digt6.Location = new System.Drawing.Point(99, 114);
            this.digt6.Name = "digt6";
            this.digt6.Size = new System.Drawing.Size(36, 31);
            this.digt6.TabIndex = 11;
            this.digt6.Text = "6";
            this.digt6.UseVisualStyleBackColor = true;
            this.digt6.Click += new System.EventHandler(this.digt6_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.Location = new System.Drawing.Point(141, 114);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(36, 31);
            this.Subtrair.TabIndex = 12;
            this.Subtrair.Text = "-";
            this.Subtrair.UseVisualStyleBackColor = true;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // digt1
            // 
            this.digt1.Location = new System.Drawing.Point(13, 151);
            this.digt1.Name = "digt1";
            this.digt1.Size = new System.Drawing.Size(37, 31);
            this.digt1.TabIndex = 13;
            this.digt1.Text = "1";
            this.digt1.UseVisualStyleBackColor = true;
            this.digt1.Click += new System.EventHandler(this.digt1_Click);
            // 
            // digt2
            // 
            this.digt2.Location = new System.Drawing.Point(56, 151);
            this.digt2.Name = "digt2";
            this.digt2.Size = new System.Drawing.Size(37, 31);
            this.digt2.TabIndex = 14;
            this.digt2.Text = "2";
            this.digt2.UseVisualStyleBackColor = true;
            this.digt2.Click += new System.EventHandler(this.digt2_Click);
            // 
            // digt3
            // 
            this.digt3.Location = new System.Drawing.Point(99, 151);
            this.digt3.Name = "digt3";
            this.digt3.Size = new System.Drawing.Size(36, 31);
            this.digt3.TabIndex = 15;
            this.digt3.Text = "3";
            this.digt3.UseVisualStyleBackColor = true;
            this.digt3.Click += new System.EventHandler(this.digt3_Click);
            // 
            // Somar
            // 
            this.Somar.Location = new System.Drawing.Point(141, 151);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(36, 68);
            this.Somar.TabIndex = 16;
            this.Somar.Text = "+";
            this.Somar.UseVisualStyleBackColor = true;
            this.Somar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // dgt0
            // 
            this.dgt0.Location = new System.Drawing.Point(56, 188);
            this.dgt0.Name = "dgt0";
            this.dgt0.Size = new System.Drawing.Size(37, 31);
            this.dgt0.TabIndex = 18;
            this.dgt0.Text = "0";
            this.dgt0.UseVisualStyleBackColor = true;
            this.dgt0.Click += new System.EventHandler(this.button18_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(99, 188);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(36, 31);
            this.Result.TabIndex = 19;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Ponto
            // 
            this.Ponto.Location = new System.Drawing.Point(13, 188);
            this.Ponto.Name = "Ponto";
            this.Ponto.Size = new System.Drawing.Size(37, 31);
            this.Ponto.TabIndex = 20;
            this.Ponto.Text = ",";
            this.Ponto.UseVisualStyleBackColor = true;
            this.Ponto.Click += new System.EventHandler(this.Ponto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 235);
            this.Controls.Add(this.Ponto);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.dgt0);
            this.Controls.Add(this.Somar);
            this.Controls.Add(this.digt3);
            this.Controls.Add(this.digt2);
            this.Controls.Add(this.digt1);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.digt6);
            this.Controls.Add(this.digt5);
            this.Controls.Add(this.digt4);
            this.Controls.Add(this.Muntiplicar);
            this.Controls.Add(this.digt9);
            this.Controls.Add(this.digt8);
            this.Controls.Add(this.digt7);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Exponencial);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Exponencial;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button digt7;
        private System.Windows.Forms.Button digt8;
        private System.Windows.Forms.Button digt9;
        private System.Windows.Forms.Button Muntiplicar;
        private System.Windows.Forms.Button digt4;
        private System.Windows.Forms.Button digt5;
        private System.Windows.Forms.Button digt6;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button digt1;
        private System.Windows.Forms.Button digt2;
        private System.Windows.Forms.Button digt3;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button dgt0;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Ponto;
    }
}

