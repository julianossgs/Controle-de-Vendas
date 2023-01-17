using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Dao
{
    internal class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Produtos
        public void CadastrarProdutos(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_produtos(descricao,preco,qtd_estoque,for_id) values(@descricao,@preco,@qtd_estoque,@for_id)";

                // 2º passo - Organizar o cmd sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@preco",obj.Preco);
                cmd.Parameters.AddWithValue("@qtd_estoque",obj.QtdEstoque);
                cmd.Parameters.AddWithValue("@for_id",obj.For_Id);

                // 3º - Abrir a conexão e executar o comando sql
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao cadastrar!! " + e.Message);
            }

            finally { conexao.Close(); }
        }
        #endregion

        #region Alterar Produtos
        public void AlterarProdutos(Produto obj)
        {
            try
            {
                string sql = @"update tb_produtos 
                                set descricao=@descricao,preco=@preco,
                                qtd_estoque=@qtd_estoque,
                                for_id=@for_id where id=@id";

                // 2º passo - Organizar o cmd sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id",obj.Id);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@preco", obj.Preco);
                cmd.Parameters.AddWithValue("@qtd_estoque", obj.QtdEstoque);
                cmd.Parameters.AddWithValue("@for_id", obj.For_Id);

                // 3º - Abrir a conexão e executar o comando sql
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao cadastrar!! " + e.Message);
            }

            finally { conexao.Close(); }
        }
        #endregion

        #region Excluir Produtos
        public void ExcluirProdutos(Produto obj)
        {
            try
            {
                string sql = "delete from tb_produtos where id=@id";

                // 2º passo - Organizar o cmd sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.Id);

                // 3º - Abrir a conexão e executar o comando sql
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao excluir!! " + e.Message);
            }

            finally { conexao.Close(); }
          

        }
        #endregion

        #region Listar Produtos
        public DataTable ListarProdutos()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select p.id,
                                      p.descricao as 'Descrição',
                                      p.preco as 'Preço',
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor'
                                      from tb_produtos p
                                      inner join tb_fornecedores f
                                      on p.for_id = f.id;";

                // 2º passo - organizar o comando sql e executar
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                // 3º passo - Criar o DataAdapter p/ preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);
                da.Fill(dt);

                return dt;

            }

            catch (Exception e)
            {

                MessageBox.Show("Erro ao executar o comando sql" + e.Message);
                return null;
            }
            finally { conexao.Close(); }

        }
        #endregion

        #region Listar Fornecedores Nome
        public DataTable ListarProdutosNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select p.id,
                                      p.descricao as 'Descrição',
                                      p.preco as 'Preço',
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor'
                                      from tb_produtos p
                                      inner join tb_fornecedores f
                                      on p.for_id = f.id 
                                      where p.descricao like @nome;";

                // 2º passo - organizar o comando sql e executar
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                // 3º passo - Criar o DataAdapter p/ preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);
                da.Fill(dt);

                return dt;

            }

            catch (Exception e)
            {

                MessageBox.Show("Erro ao executar o comando sql" + e.Message);
                return null;
            }
            finally { conexao.Close(); }

        }
        #endregion

        #region Buscar Produto por Nome
        public DataTable BuscarProdutoNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select p.id,
                                      p.descricao as 'Descrição',
                                      p.preco as 'Preço',
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor'
                                      from tb_produtos p
                                      inner join tb_fornecedores f
                                      on p.for_id = f.id 
                                      where p.descricao = @nome;";

                // 2º passo - organizar o comando sql e executar
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                // 3º passo - Criar o DataAdapter p/ preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);
                da.Fill(dt);

                return dt;

            }


            catch (Exception e)
            {

                MessageBox.Show("Erro ao executar o comando sql" + e.Message);
                return null;
            }
            finally { conexao.Close(); }

        }
        #endregion
    }
}
