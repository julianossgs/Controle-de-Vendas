namespace Projeto_Controle_Vendas.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QtdEstoque { get; set; }
       // public Fornecedor Fornecedor { get; set; }

        public int For_Id { get; set; }
    }
}
