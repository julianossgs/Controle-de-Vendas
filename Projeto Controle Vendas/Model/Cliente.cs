using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Model
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set;}
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Cliente()
        {
        }

        public Cliente(int iD, string nome, string rg, string cpf, string email, string telefone, string celular, string cep, string endereco, int numero, string complemento, string bairro, string cidade, string estado)
        {
            ID=iD;
            Nome=nome;
            Rg=rg;
            Cpf=cpf;
            Email=email;
            Telefone=telefone;
            Celular=celular;
            Cep=cep;
            Endereco=endereco;
            Numero=numero;
            Complemento=complemento;
            Bairro=bairro;
            Cidade=cidade;
            Estado=estado;
        }

       
    }
}
