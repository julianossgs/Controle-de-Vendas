using System;

namespace Projeto_Controle_Vendas.Model
{
    public class Venda
    {
        public int Id { get; set; }
        public int Cliente_Id { get; set; }
        public DateTime Data_Venda { get; set; }
        public decimal Total_Venda { get; set; }
        public string Obs { get; set; }
    }
}
