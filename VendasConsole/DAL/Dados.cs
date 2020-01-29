using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente c = new Cliente
            {
                Nome = "Danielia", Cpf = "10419011943", CriadoEm = DateTime.Now
            };
            Vendedor v = new Vendedor
            {
                Nome = "José da Silva",
                Cpf = "09400817924"
            };
            Produto p = new Produto
            {
                Nome = "Biscoito",
                Preco = 1.90,
                Quantidade = 2
            };
            ClienteDAO.CadastrarCli(c);
            VendedorDAO.CadastrarVen(v);
            ProdutoDAO.CadastrarPro(p);
        }
    }
}
