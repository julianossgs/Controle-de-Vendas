using Projeto_Controle_Vendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmpagto : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        
        public Frmpagto(Cliente cliente,DataTable carrinho)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            InitializeComponent();
        }

        private void Frmpagto_Load(object sender, EventArgs e)
        {

        }
    }
}
