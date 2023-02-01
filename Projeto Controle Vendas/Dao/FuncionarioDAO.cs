using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using Projeto_Controle_Vendas.Views;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Dao
{
    internal class FuncionarioDAO 
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            conexao=new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Funcionarios
        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"insert into tb_funcionarios(nome,rg,cpf,email,senha,cargo, nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) values(@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                // 2º passo - Organizar o cmd sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@rg", obj.Rg);
                cmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@senha",obj.Senha);
                cmd.Parameters.AddWithValue("@cargo",obj.Cargo);
                cmd.Parameters.AddWithValue("@nivel_acesso",obj.Nivel_Acesso);
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

                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao cadastrar!! " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion

        #region Alterar Funcionarios
        public void Alterarfuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"update tb_funcionarios
                   set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel_acesso,telefone=@telefone,c elular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado 
                      where id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.ID);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@rg", obj.Rg);
                cmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@senha",obj.Senha);
                cmd.Parameters.AddWithValue("@cargo",obj.Cargo);
                cmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel_Acesso);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@celular", obj.Celular);
                cmd.Parameters.AddWithValue("@cep", obj.Cep);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@numero", obj.Numero);
                cmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmd.Parameters.AddWithValue("@estado", obj.Estado);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario alterado com sucesso!");

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao alterar: " + e.Message);
            }

            finally { conexao.Close(); }
        }
        #endregion

        #region Excluir Funcionarios
        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "delete from tb_funcionarios where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.ID);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluido com sucesso!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao alterar: " + e.Message);
            }
            finally { conexao.Close(); }
        }
        #endregion

        #region Listar Funcionarios
        public DataTable ListarFuncionarios()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_funcionarios order by nome asc";

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

        #region Listar Funcionarios por nome
        public DataTable ListarFuncionariosNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

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
        public DataTable BuscarFuncionarioNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

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

        #region Método que efetua Login
        public bool Login(string email,string senha)
        {
            try
            {

                // 1º passo - comando sql
                string sql =  @"select * from tb_funcionarios
                 where email = @email and senha = @senha";

                //2º passo - executar o comando sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                MySqlDataReader reader= cmd.ExecuteReader();

                if (reader.Read())
                {
                    //Login realizado com sucesso
                    //Buscndo nivel e usuário do sistema
                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");

                    MessageBox.Show("Seja bem vindo ao sistema, " + nome + " Você acessou como: " + nivel);

                    //Abrir a tela menu principal
                    Frmmenu telaMenu = new Frmmenu();

                    //Nivel de administrador
                    if (nivel.Equals("Administrador"))
                    {
                       
                        telaMenu.Show();
                        telaMenu.txtUsuario.Text = nome;
                    }

                    else if (nivel.Equals("Usuário"))
                    {
                        //Personalizando as permissões p/ acesso do vendedor
                        telaMenu.menuConfiguracoes.Enabled= false;
                        telaMenu.Show();
                        telaMenu.txtUsuario.Text = nome;

                    }

                    return true;
                }

                else
                {
                    //Falha no Login
                      return false;
                }

            }
            

            catch (Exception e)
            {

                MessageBox.Show("Erro no Método de Login: " + e.Message);
            }
            finally { conexao.Close(); }

            return true;
        }
        #endregion
    }
}
