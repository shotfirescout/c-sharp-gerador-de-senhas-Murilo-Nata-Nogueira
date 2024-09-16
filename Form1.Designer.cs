namespace c_sharp_gerador_de_senhas_Murilo_Nata_Nogueira
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
            this.checkMaiuscula = new System.Windows.Forms.CheckBox();
            this.checkMinuscula = new System.Windows.Forms.CheckBox();
            this.checkNumeros = new System.Windows.Forms.CheckBox();
            this.checkEspecial = new System.Windows.Forms.CheckBox();
            this.textTamanho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkMaiuscula
            // 
            this.checkMaiuscula.AutoSize = true;
            this.checkMaiuscula.Location = new System.Drawing.Point(12, 94);
            this.checkMaiuscula.Name = "checkMaiuscula";
            this.checkMaiuscula.Size = new System.Drawing.Size(97, 20);
            this.checkMaiuscula.TabIndex = 0;
            this.checkMaiuscula.Text = "Maiusculas";
            this.checkMaiuscula.UseVisualStyleBackColor = true;
            // 
            // checkMinuscula
            // 
            this.checkMinuscula.AutoSize = true;
            this.checkMinuscula.Location = new System.Drawing.Point(115, 94);
            this.checkMinuscula.Name = "checkMinuscula";
            this.checkMinuscula.Size = new System.Drawing.Size(96, 20);
            this.checkMinuscula.TabIndex = 1;
            this.checkMinuscula.Text = "Minusculas";
            this.checkMinuscula.UseVisualStyleBackColor = true;
            // 
            // checkNumeros
            // 
            this.checkNumeros.AutoSize = true;
            this.checkNumeros.Location = new System.Drawing.Point(217, 94);
            this.checkNumeros.Name = "checkNumeros";
            this.checkNumeros.Size = new System.Drawing.Size(84, 20);
            this.checkNumeros.TabIndex = 2;
            this.checkNumeros.Text = "Numeros";
            this.checkNumeros.UseVisualStyleBackColor = true;
            // 
            // checkEspecial
            // 
            this.checkEspecial.AutoSize = true;
            this.checkEspecial.Location = new System.Drawing.Point(307, 94);
            this.checkEspecial.Name = "checkEspecial";
            this.checkEspecial.Size = new System.Drawing.Size(89, 20);
            this.checkEspecial.TabIndex = 3;
            this.checkEspecial.Text = "Especiais";
            this.checkEspecial.UseVisualStyleBackColor = true;
            // 
            // textTamanho
            // 
            this.textTamanho.Location = new System.Drawing.Point(45, 166);
            this.textTamanho.Name = "textTamanho";
            this.textTamanho.Size = new System.Drawing.Size(349, 22);
            this.textTamanho.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tamanho da senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "GERADOR DE SENHAS";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(44, 235);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(350, 60);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "GERAR SENHA";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(86, 351);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(45, 20);
            this.labelSenha.TabIndex = 9;
            this.labelSenha.Text = "texto";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(90, 398);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(270, 40);
            this.btnCopiar.TabIndex = 10;
            this.btnCopiar.Text = "Copiar Senha";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTamanho);
            this.Controls.Add(this.checkEspecial);
            this.Controls.Add(this.checkNumeros);
            this.Controls.Add(this.checkMinuscula);
            this.Controls.Add(this.checkMaiuscula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkMaiuscula;
        private System.Windows.Forms.CheckBox checkMinuscula;
        private System.Windows.Forms.CheckBox checkNumeros;
        private System.Windows.Forms.CheckBox checkEspecial;
        private System.Windows.Forms.TextBox textTamanho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button btnCopiar;
    }
}

