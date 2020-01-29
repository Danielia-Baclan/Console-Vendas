using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Utils
{
    class Validacao
    {
        public static bool ValidarCpf(string cpf)
        {
            
            #region Validação simples
            //Remover formatação
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            //Validar quantidade de caracteres
            if (cpf.Length != 11)
            {
                return false;
            }

            // Validar se todos os caracteres são iguais
            switch (cpf)
            {
                case "00000000000": return false;
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
            }

            #endregion

            #region Variaveis
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;

            int soma = 0;
            int soma2 = 0;
            int resto;
            
            #endregion

            #region Digito 1

            tempCpf = cpf.Substring(0, 9);
            
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * (multiplicador1[i]);
            }
            
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            #endregion
            
            #region Digito 2
            
            for (int i = 0; i < 10; i++)
            {
                soma2 += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma2 % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();

            #endregion

            #region Verificação dos digitos

            if (cpf.EndsWith(digito))
            {
                return true;
            }
            else
            {
                return false;
            }
            #endregion
        }
    }
}
