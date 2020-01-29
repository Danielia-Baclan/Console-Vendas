using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Cliente
    {
        #region C#
        //Construtor
        public Cliente()
        {

        }
        public Cliente(string nome, string cpf)
        {
            CriadoEm = DateTime.Now;
        }
        //propriedade/Atributos
        public string Nome { get; set; }
        public string Cpf { get; set; } 
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString()
        {
            return "Nome: " + Nome + "\nCPF: " + Cpf;
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = (Cliente) obj;
            if(cliente.Cpf.Equals(Cpf))
            {
                return true;
            }
            return false;
        }

        #endregion


        /* #region JAVA
         private string Nome, Cpf;

         public string GetNome()
         {
             return Nome;
         }
         public void SetNome(string nome)
         {
             Nome = nome;
         }

         public string GetCpf()
         {
             return Cpf;
         }
         public void SetCpf(string cpf)
         {
             Cpf = cpf;
         } 
         #endregion*/
    }
}