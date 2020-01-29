using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Vendedor
    {
        #region C#
        public Vendedor()
        {
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }


        public override string ToString()
        {
            return "Nome: " + Nome + "\nCPF: " + Cpf;
        }

        public override bool Equals(object obj)
        {
            Vendedor vendedor = (Vendedor)obj;
            if (vendedor.Cpf.Equals(Cpf))
            {
                return true;
            }
            return false;
        } 
        #endregion
    }
}
