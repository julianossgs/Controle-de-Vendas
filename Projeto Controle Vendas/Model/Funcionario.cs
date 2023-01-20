using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.Model
{
    public class Funcionario : Cliente
    {
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Nivel_Acesso { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string senha, string cargo, string nivel_Acesso)
        {
            Senha=senha;
            Cargo=cargo;
            Nivel_Acesso=nivel_Acesso;
        }
    }


}
