using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Utils;

namespace VendasConsole.Models
{
    class Cadastrar
    {
        public static void RenderizarCli()
        {
            Cliente clienteCad = new Cliente();
            Console.WriteLine("------Cadastro Cliente------\n");
            Console.WriteLine("Informe o nome do cliente:\n");
            clienteCad.Nome = Console.ReadLine();
            Console.WriteLine("\nInforme o CPF do cliente:\n");
            clienteCad.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(clienteCad.Cpf))
            {

                if (ClienteDAO.CadastrarCli(clienteCad))
                {
                    Console.WriteLine("\nCliente cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nNão é possível cadastrar, CPF já cadastrado");
                }
            }
            else
            {
                Console.WriteLine("\nNão é possível cadastrar, CPF inválido");
            }

        }

        public static void RenderizarVen()
        {
            Vendedor vendedorCad = new Vendedor();
            Console.WriteLine("------Cadastro Vendedor------\n");
            Console.WriteLine("Informe o nome do vendedor:\n");
            vendedorCad.Nome = Console.ReadLine();
            Console.WriteLine("\nInforme o CPF do vendedor:\n");
            vendedorCad.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(vendedorCad.Cpf))
            {
                if (VendedorDAO.CadastrarVen(vendedorCad))
                {
                    Console.WriteLine("\nVendedor cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nNão é possível cadastrar, CPF já cadastrado");
                }
            }
            else
            {
                Console.WriteLine("\nNão é possível cadastrar, CPF inválido");
            }

        }

        public static void RenderizarPro()
        {
            Produto produtoCad = new Produto();
            Console.WriteLine("------Cadastro Produto------\n");
            Console.WriteLine("Informe o nome do produto:\n");
            produtoCad.Nome = Console.ReadLine();
            Console.WriteLine("\nInforme o valor do produto:\n");
            produtoCad.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInforme a quantidade em estoque:\n");
            produtoCad.Quantidade = Convert.ToInt32(Console.ReadLine());
            if (ProdutoDAO.CadastrarPro(produtoCad))
            {
                Console.WriteLine("\nProduto cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão é possível cadastrar, Nome de produto já cadastrado");
            }
        }

        public static void RenderizarVenda()
        {
            Venda venda = new Venda();
            ItemVenda itemVenda = new ItemVenda();
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();

            Console.WriteLine("------Cadastro Venda------\n");
            Console.WriteLine("Informe o CPF do Cliente:\n");
            c.Cpf = Console.ReadLine();
            c = ClienteDAO.BuscarCliente(c);
            if (c != null)
            {
                venda.Cliente = c;

                Console.WriteLine("Informe o CPF do Vendedor:\n");
                v.Cpf = Console.ReadLine();
                v = VendedorDAO.BuscarVendedor(v);
                if (v != null)
                {
                    venda.Vendedor = v;

                    do
                    {
                        itemVenda = new ItemVenda();
                        Console.Clear();
                        Console.WriteLine("------Adicionar Produtos------\n");
                        Console.WriteLine("Informe o nome do produto:\n");
                        p.Nome = Console.ReadLine();
                        p = ProdutoDAO.BuscarProduto(p);
                        if (p != null)
                        {
                            itemVenda.Produto = p;

                            Console.WriteLine("Informe a quantidade desejada do produto:\n");
                            itemVenda.Quantidade = Convert.ToInt32(Console.ReadLine());
                            itemVenda.Preco = p.Preco;
                            
                            venda.Produtos.Add(itemVenda);
                        }
                        else
                        {
                            Console.WriteLine("Esse Produto não existe!");
                            p = new Produto();
                        }

                        Console.WriteLine("Deseja continuar venda? Digite: 1-Sim || 2-Não");
                        
                    } while (Console.ReadLine().Equals("1"));
                    VendaDAO.CadastrarVenda(venda);
                    Console.WriteLine("Venda cadastrada!\n");
                }
                else
                {
                    Console.WriteLine("Esse Vendedor não existe!");
                }
            }
            else
            {
                Console.WriteLine("Esse cliente não existe!");
            }


        }


    }
}
