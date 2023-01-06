using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Conexao
{
    public class ConnectionFactory
    {
        //Método que conecta o banco de dados
        public MySqlConnection GetConnection()
        {
            
                string conexao = ConfigurationManager.ConnectionStrings["dbvendas"].ConnectionString;

                return new MySqlConnection(conexao);
          
        }
    }
}
