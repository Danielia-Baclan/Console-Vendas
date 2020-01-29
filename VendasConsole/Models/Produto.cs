using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Produto
    {
        public Produto()
        {

        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }


        public override string ToString()
        {
            return "Nome: " + Nome + "\n$: " + Preco + "\nEstoque: " + Quantidade;
        }

        public override bool Equals(object obj)
        {
            Produto produto = (Produto)obj;
            if (produto.Nome.Equals(Nome))
            {
                return true;
            }
            return false;
        }
    }
}
