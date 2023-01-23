using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Dao
{
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastrar um item de venda
        public void CadastrarItem(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into tb_itensvendas(venda_id,produto_id,qtd,subtotal)
                                values(@venda_id,@produto_id,@qtd,@subtotal)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@venda_id", obj.Venda_Id);
                cmd.Parameters.AddWithValue("@produto_id", obj.Produto_Id);
                cmd.Parameters.AddWithValue("@qtd", obj.Qtd);
                cmd.Parameters.AddWithValue("@subtotal", obj.SubTotal);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item cadastrado com sucesso!");
            }

            catch (Exception e)
            {

                MessageBox.Show("Erro ao Cadastrar Item de Venda: " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion
    }
}
