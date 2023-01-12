using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Dao
{
    internal class ClienteDAO
    {
        //atributo da classe
        private MySqlConnection conexao;

        //Construtor da classe
        public ClienteDAO() 
        {
            conexao = new ConnectionFactory().GetConnection();
        }

       

        #region Cadastrar Cliente
        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                // 1º passo - definir o cmd Sql 
                string sql = @"insert into tb_clientes(nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) 
                   values(@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                // 2º passo - Organizar o cmd sql
                MySqlCommand cmd = new MySqlCommand(sql,conexao);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@rg", obj.Rg);
                cmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@celular", obj.Celular);
                cmd.Parameters.AddWithValue("@cep", obj.Cep);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@numero", obj.Numero);
                cmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@bairro",obj.Bairro);
                cmd.Parameters.AddWithValue("@cidade",obj.Cidade);
                cmd.Parameters.AddWithValue("@estado",obj.Estado);

                // 3º - Abrir a conexão e executar o comando sql
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao cadastrar: " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion

        #region Alterar Cliente
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                // 1º passo - definir o cmd Sql 
                string sql = @"update tb_clientes
                   set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,c elular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado 
                      where id=@id";
                  

                // 2º passo - Organizar o cmd sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id",obj.ID);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@rg", obj.Rg);
                cmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                cmd.Parameters.AddWithValue("@email", obj.Email);
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

                MessageBox.Show("Cliente alterado com sucesso!");

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao alterar: " + e.Message);
            }
            finally { conexao.Close(); }
        }

        #endregion

        #region Excluir Cliente
        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                string sql = "delete from tb_clientes where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.ID);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso!");

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao alterar: " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion

        #region ListarClientes
        public DataTable ListarClientes()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_clientes";

                // 2º passo - organizar o comando sql e executar
                MySqlCommand executaCmd = new MySqlCommand(sql,conexao);

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

        #region BuscarClienteNome
        public DataTable BuscarClienteNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

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

        #region ListarClienteNome
        public DataTable ListarClienteNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

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
