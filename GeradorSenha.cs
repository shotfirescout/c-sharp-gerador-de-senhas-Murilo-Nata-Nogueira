using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_gerador_de_senhas_Murilo_Nata_Nogueira
{
    internal class GeradorSenha
    {
        private String maiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private String minusuclas = "abcdefghijklmnopqrstuvwxyz";
        private String numeros = "0123456789";
        private String especiais = "!@#$%¨&*()-=_+[]{},.<>?/;:´`^~";

        public String GerarSenha(bool maiuscula, bool minusucla, bool numero, bool especial, int tamanho)
        {
            String combinacao = "";
            
            if(maiuscula)
            {
                combinacao += maiusculas;
            }

            if (minusucla)
            {
                combinacao += minusuclas;
            }
            if (numero)
            {
                combinacao += numeros;
            }

            if(especial)
            {
                combinacao += especiais;
            }

            Random random = new Random();
            
            StringBuilder senha = new StringBuilder();

            for(int i = 0; i <= tamanho; i++)
            {
                int selecionado = random.Next(0, combinacao.Length);
                senha.Append(combinacao[selecionado]);
            }

            return senha.ToString();
        }
    }
}
