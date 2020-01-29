using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ClienteDAO
    {
        private ClienteDAO()
        {

        }

        static private List<Cliente> clientes = new List<Cliente>();

        /// <summary>
        /// Método para adicionar um cliente na lista caso o cpf seja único.
        /// </summary>
        /// <param name="c">Alguma informação sobre o parametro</param>
        /// <returns>Retorna verdadeiro caso consiga adicionar um cliente com cpf diferente na lista</returns>
        static public bool CadastrarCli(Cliente c)
        {

            if (BuscarCliente(c)!= null)
            {
                return false;
            }
               
            clientes.Add(c);
            return true;
        }

        static public List<Cliente> ListarClientes()
        {
            return clientes;
        }

        static public Cliente BuscarCliente(Cliente c)
        {
            foreach(var cliente in clientes)
            {
                if (cliente.Cpf.Equals(c.Cpf))
                {
                    return cliente;
                }
            }
            return null;
        }
    }
}
