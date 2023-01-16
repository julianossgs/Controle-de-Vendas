using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Dao
{
    internal class FornecedorDAO
    {
        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            conexao=new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Fornecedores
        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"insert into tb_fornecedores(nome,email,cnpj, telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) values(@nome,@email,@cnpj,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                // 2º passo - Organizar o cmd sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@celular", obj.Celular);
                cmd.Parameters.AddWithValue("@cep", obj.Cep);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@numero", obj.Numero);
                cmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmd.Parameters.AddWithValue("@estado", obj.Estado);

                // 3º - Abrir a conexão e executar o comando sql
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
            catch (Exception e) 
            {

                MessageBox.Show("Erro ao cadastrar!! " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion

        #region Alterar Fornecedores
        public void AlterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"update tb_fornecedores set nome=@nome,email=@email,cnpj=@cnpj,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.ID);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@celular", obj.Celular);
                cmd.Parameters.AddWithValue("@cep", obj.Cep);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@numero", obj.Numero);
                cmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmd.Parameters.AddWithValue("@estado", obj.Estado);

                // 3º - Abrir a conexão e executar o comando sql
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterado com sucesso!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao cadastrar!! " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion

        #region Excluir Fornecedor
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = "delete from tb_fornecedores where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.ID);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluido com sucesso!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao excluir: " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion

        #region Listar Fornecedores
        public DataTable ListarFornecedores()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_fornecedores order by nome asc";

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
        public DataTable ListarFornecedoresNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";

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

        #region BuscarFuncionarioNome
        public DataTable BuscarFornecedorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_fornecedores where nome = @nome";

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
