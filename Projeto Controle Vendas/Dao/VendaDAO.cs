using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Data;
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

        #region Método que mostra histórico de vendas
        public DataTable ListarVendasPeriodo(DateTime datainicio,DateTime datafim)
        {
            try
            {
                DataTable gridHistorico = new DataTable();


                string sql = @"select v.id as 'Código',
                             v.data_venda as 'Data da venda',
                             c.nome as 'Cliente',
                             v.total_venda as 'Total',
                             v.observacoes as 'Obs'
                             from tb_vendas v
                             inner join tb_clientes c
                             on v.cliente_id = c.id
                             where v.data_venda between @datainicio and @datafim";
                           

                MySqlCommand cmd = new MySqlCommand(sql,conexao);
                cmd.Parameters.AddWithValue("@datainicio", datainicio);
                cmd.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(gridHistorico);

                return gridHistorico;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no método Listar vendas por periodo: " + e.Message);
                return null;
            }

            finally
            {
                conexao.Close();
            }
        }
        #endregion

        #region Método de Listar vendas
        public DataTable ListarVendas()
        {
            try
            {
                DataTable gridHistorico = new DataTable();

                string sql = @"select v.id as 'Código',
                             v.data_venda as 'Data da venda',
                             c.nome as 'Cliente',
                             v.total_venda as 'Total',
                             v.observacoes as 'Obs'
                             from tb_vendas v
                             inner join tb_clientes c
                             on v.cliente_id = c.id
                             order by data_venda desc";
                            

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(gridHistorico);

                return gridHistorico;

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no Método de Listar Vendas: " + e.Message);
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
