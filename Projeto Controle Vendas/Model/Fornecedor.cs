using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.Model
{
    internal class Fornecedor : Cliente
    {
        public string CNPJ { get; set; }

        public Fornecedor()
        {
        }

        public Fornecedor(string cNPJ)
        {
            CNPJ=cNPJ;
        }
    }
}
