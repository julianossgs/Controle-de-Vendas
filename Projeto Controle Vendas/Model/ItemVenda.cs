using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.Model
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int Venda_Id { get; set; }
        public int Produto_Id { get; set; }
        public int Qtd { get; set; }
        public decimal SubTotal { get; set; }
    }
}
