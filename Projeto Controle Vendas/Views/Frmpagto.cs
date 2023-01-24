using Projeto_Controle_Vendas.Dao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmpagto : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        ProdutoDAO dao_produto = new ProdutoDAO();
        DateTime DataAtual;
        
        public Frmpagto(Cliente cliente,DataTable carrinho,DateTime dataAtual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.DataAtual= dataAtual;
            InitializeComponent();
        }

        private void Frmpagto_Load(object sender, EventArgs e)
        {
            //Carrega tela
            txtDinheiro.Focus();
            txtTroco.Text = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
        }

        //botão finalizar venda
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dinheiro, v_cartao, troco, total_pago,total;

                int qtd_estoque, qtd_comprada, estoque_atualizado;

                v_dinheiro = decimal.Parse(txtDinheiro.Text);
                v_cartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);   

                //calcular o total pago
                total_pago = v_dinheiro + v_cartao;

                if (total_pago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor Total da venda!!");
                }
                else
                {
                    //calcular o troco
                    troco = total_pago - total;

                    //Pegando o id do cliente e salvando na tabela vendas
                    Venda vendas = new Venda();

                    vendas.Cliente_Id = cliente.ID;
                    vendas.Data_Venda = DataAtual;
                    vendas.Total_Venda = total; 
                    vendas.Obs = txtObs.Text;

                    VendaDAO vendaDAO = new VendaDAO();
                    txtTroco.Text = troco.ToString();

                    vendaDAO.CadastrarVenda(vendas);

                    //Percorrendo os itens do carrinho
                    foreach (DataRow linha in carrinho.Rows)
                    {
                        //Cadastrar os itens da venda
                        ItemVenda item = new ItemVenda();
                        item.Venda_Id = vendaDAO.RetornaIdUltimaVenda();
                        item.Produto_Id = int.Parse(linha["Codigo"].ToString());
                        item.Qtd = int.Parse(linha["Qtd"].ToString());
                        item.SubTotal = decimal.Parse(linha["SubTotal"].ToString());

                        //Baixa no estoque
                        qtd_estoque = dao_produto.RetornaEstoqueAtual(item.Produto_Id);
                        qtd_comprada = item.Qtd;
                        estoque_atualizado = qtd_estoque - qtd_comprada;

                        dao_produto.BaixaEstoque(item.Produto_Id,estoque_atualizado);

                        ItemVendaDAO itemDAO = new ItemVendaDAO();
                        itemDAO.CadastrarItem(item);
                      
                    }

                    MessageBox.Show("Venda finalizada com sucesso!");
                    this.Dispose();
                    new Frmvendas().ShowDialog();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao finalizar o pagamento");
            }
        }
    }
}
