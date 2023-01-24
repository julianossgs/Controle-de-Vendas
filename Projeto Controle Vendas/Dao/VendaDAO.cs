using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Dao
{
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            conexao = new ConnectionFactory().GetConnection();
        }

        #region Método de Cadastrar Venda
        public void CadastrarVenda(Venda obj)
        {
            try
            {
                string sql = @"insert into tb_vendas(cliente_id,data_venda,total_venda,observacoes)
                             values(@cliente_id,@data_venda,@total_venda,@observacoes)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@cliente_id",obj.Cliente_Id);
                cmd.Parameters.AddWithValue("@data_venda",obj.Data_Venda);
                cmd.Parameters.AddWithValue("@total_venda",obj.Total_Venda);
                cmd.Parameters.AddWithValue("@observacoes",obj.Obs);

                conexao.Open(); 
                cmd.ExecuteNonQuery();

               // MessageBox.Show("Venda cadastrada com sucesso!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no método de cadastrar venda: " + e.Message);
            }
            finally { conexao.Close(); }
        }

        #endregion

        #region Método que retorna o Id da ultima venda
        public int RetornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;

                string sql = @"select max(id) id from tb_vendas";

                MySqlCommand cmd = new MySqlCommand(sql, conexao );
                conexao.Open();

                MySqlDataReader reader= cmd.ExecuteReader();
                if (reader.Read())
                {
                    idvenda = reader.GetInt32("id");
                   
                }
                return idvenda;


            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao reternar o ID da venda: " + e.Message);
                return 0;
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion
    }
}
