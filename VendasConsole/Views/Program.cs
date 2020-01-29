using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class Program
    {
        static Cliente cliente = new Cliente();

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Dados.Inicializar();
            Menu();
        }


        public static void Menu()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("------------MENU------------\n");
                Console.WriteLine("1 - Cadastrar Cliente\n");
                Console.WriteLine("2 - Listar Clientes\n");
                Console.WriteLine("3 - Cadastrar Vendedor\n");
                Console.WriteLine("4 - Listar Vendedores\n");
                Console.WriteLine("5 - Cadastrar Produto\n");
                Console.WriteLine("6 - Listar Produtos\n");
                Console.WriteLine("7 - Registrar Venda\n");
                Console.WriteLine("8 - Listar Vendas\n");
                Console.WriteLine("9 - Listar Vendas por Cliente\n");
                Console.WriteLine("0 - Sair\n");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Cadastrar.RenderizarCli();
                        break;
                    case 2:
                        Console.Clear();
                        Listar.RenderizarCli();
                        break;
                    case 3:
                        Console.Clear();
                        Cadastrar.RenderizarVen();
                        break;
                    case 4:
                        Console.Clear();
                        Listar.RenderizarVen();
                        break;
                    case 5:
                        Console.Clear();
                        Cadastrar.RenderizarPro();
                        break;
                    case 6:
                        Console.Clear();
                        Listar.RenderizarPro();
                        break;
                    case 7:
                        Console.Clear();
                        Cadastrar.RenderizarVenda();
                        break;
                    case 8:
                        Console.Clear();
                        Listar.RenderizarVenda(VendaDAO.ListarVendas());
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Digite o Cpf do cliente: ");
                        string cpf = Console.ReadLine();

                        Listar.RenderizarVenda(VendaDAO.ListarVendasPorCliente(cpf));
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Encerrando*\n");
                        Console.WriteLine("\nAperte uma tecla para continuar...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.\n");
                        break;
                }

                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (op != 0);
        }

    }
}
