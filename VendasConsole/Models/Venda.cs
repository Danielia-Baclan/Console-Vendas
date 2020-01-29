using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Venda
    {
        public Venda()
        {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            Produtos = new List<ItemVenda>();
        }
        //Relacionamento entre classes, agregação: a parte (ex:Cliente) existe sem o todo  
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }

        public DateTime CriadoEm { get; set; }

        //Relacionamento composição, a parte só exite se o todo(Venda) existir também
        public List<ItemVenda> Produtos { get; set; }                                                                                                                          
     
    }
}
