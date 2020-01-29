using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendedorDAO
    {
        private VendedorDAO()
        {

        }

        static private List<Vendedor> vendedores = new List<Vendedor>();

        static public bool CadastrarVen(Vendedor v)
        {

            if (BuscarVendedor(v) != null)
            {
                return false;
            }

            vendedores.Add(v);
            return true;
        }

        static public List<Vendedor> ListarVendedores()
        {
            return vendedores;
        }

        static public Vendedor BuscarVendedor(Vendedor v)
        {
            foreach (var vendedor in vendedores)
            {
                if (vendedor.Cpf.Equals(v.Cpf))
                {
                    return vendedor;
                }
            }
            return null;
        }
    }
}
