using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Data;
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

              
            }

            catch (Exception e)
            {

                MessageBox.Show("Erro ao Cadastrar Item de Venda: " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion

        #region
        public DataTable ListarItensVenda(int venda_id)
        {
            try
            {
                DataTable gridItens = new DataTable();


                string sql = @"select i.id as 'Código',
	                                  p.descricao as 'Descrição',
                                      i.qtd as 'Quantidade',
                                      p.preco as 'Preço',
                                      i.subtotal as 'SubTotal'
                                      from tb_itensvendas i
                                      inner join tb_produtos p
                                      on i.produto_id = p.id
                                      where venda_id = @venda_id";


                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@venda_id", venda_id);
               

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(gridItens);

                return gridItens;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no método Listar vendas por itens: " + e.Message);
                return null;
            }

            finally
            {
                conexao.Close();
            }
        }
        #endregion
    }
}
