using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace c_sharp_gerador_de_senhas_Murilo_Nata_Nogueira
{
    public partial class Form1 : Form
    {
        GeradorSenha senha = new GeradorSenha();
        int tamanho;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if(verificarTamanho())
            {
                verificarChecks();
            }
        }

        private void verificarChecks()
        {
            bool maiusculas = checkMaiuscula.Checked;
            bool minusculas = checkMinuscula.Checked;
            bool numeros = checkNumeros.Checked;
            bool especiais = checkEspecial.Checked;

            if (maiusculas || minusculas || numeros || especiais)
            {
                String senhaGerada = senha.GerarSenha(maiusculas, minusculas, numeros, especiais, tamanho);
                labelSenha.Text = senhaGerada;
            } else
            {
                MessageBox.Show("Não é possível gerar senha sem ter um item selecionado");
            }
        }

        private bool verificarTamanho()
        {
            try
            {
                tamanho = Int32.Parse(textTamanho.Text);

                if(tamanho < 0)
                {
                    MessageBox.Show("Valor inválido para tamanho, coloque inteiros positivos");
                    return false;
                }
            } catch
            {
                MessageBox.Show("Valor inválido para tamanho, coloque inteiros positivos");
                return false;
            }
            return true;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!labelSenha.Text.Equals(String.Empty))
            {
                Clipboard.SetText(labelSenha.Text);
            }
        }
    }
}
