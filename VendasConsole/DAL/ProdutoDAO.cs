using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ProdutoDAO
    {
        private ProdutoDAO()
        {

        }

        static private List<Produto> produtos = new List<Produto>();

        static public bool CadastrarPro(Produto p )
        {
            if (BuscarProduto(p) != null) {
                return false;
            }
            produtos.Add(p);
            return true;
        }

        static public List<Produto> ListarProdutos()
        {
            return produtos;
        }

        static public Produto BuscarProduto (Produto p)
        {
            foreach (var produto in produtos)
            {
                if (produto.Nome.Equals(p.Nome))
                {
                    return produto;
                }
            }
            return null;
        }
    }
}
