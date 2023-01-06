using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
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
        }
        #endregion
    }
}
