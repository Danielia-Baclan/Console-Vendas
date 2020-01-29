using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;

namespace VendasConsole.Models
{
    class Listar
    {
        public static void RenderizarCli()
        {
            Console.WriteLine("------Lista Clientes------\n");
            /* Console.WriteLine("1° Cliente\n");
             Console.WriteLine(cliente);*/
            int i = 0;

            foreach (var cliente in ClienteDAO.ListarClientes())
            {
                i = i + 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n" + i + "° Cliente\n");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("NOME: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.Cpf);
            }
        }

        public static void RenderizarVen()
        {
            Console.WriteLine("------Lista Vendedores------\n");

            int i = 0;
            foreach (var vendedor in VendedorDAO.ListarVendedores())
            {
                i = i + 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n" + i + "° Vendedor\n");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("NOME: " + vendedor.Nome);
                Console.WriteLine("CPF: " + vendedor.Cpf);
            }
        }

        public static void RenderizarPro()
        {
            Console.WriteLine("------Lista Produtos------\n");

            int i = 0;
            foreach (var produto in ProdutoDAO.ListarProdutos())
            {
                i = i + 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n" + i + "° Produto\n");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("NOME: " + produto.Nome);
                Console.WriteLine("PREÇO: " + produto.Preco);
                Console.WriteLine("QUANTIDADE: " + produto.Quantidade);
            }
        }

        public static void RenderizarVenda(List<Venda> vendas)
        {
            Console.Clear();
            Console.WriteLine("------Lista Vendas------\n");

            int i = 0, y=0;
            double subtotal, total = 0, totalGeral=0;
            foreach (var venda in vendas)
            {
                i = i + 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n" + i + "° Venda\n");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\tData: " + venda.CriadoEm.ToString("dd/MM/yy || hh:mm")); // ou com ToLongDateString()
                Console.WriteLine("\n\tCliente: " + venda.Cliente.Nome);
                Console.WriteLine("\tVendedor: " + venda.Vendedor.Nome);

                total = 0;
                foreach(var produto in venda.Produtos)
                {
                    y = y = 1;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n" + y + "° Item");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nProduto: " + produto.Produto.Nome);
                    Console.WriteLine("Preço unidade: " + produto.Produto.Preco);
                    Console.WriteLine("Quantidade: " + produto.Quantidade);
                    subtotal = produto.Quantidade * produto.Produto.Preco;
                    total += subtotal;
                }
                
                Console.WriteLine("\nTotal venda:   " + total.ToString("C2"));
                totalGeral += total;
            }
            Console.WriteLine("\nTotal Geral das vendas:   " + totalGeral.ToString("C2"));
        }
    }
}
