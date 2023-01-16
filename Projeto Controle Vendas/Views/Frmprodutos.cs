using Projeto_Controle_Vendas.Dao;
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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            cbFornecedor.DataSource= fornecedorDAO.ListarFornecedores();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";

            //Listando os produtos no grid
            ProdutoDAO produtoDAO = new ProdutoDAO();
            gridProdutos.DataSource = produtoDAO.ListarProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Methods().LimparTela(this);
            txtDescricao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto
            {
                Descricao = txtDescricao.Text,
                Preco = decimal.Parse(txtPreco.Text),
                QtdEstoque = int.Parse(txtQtdEstoque.Text),
                For_Id = int.Parse(cbFornecedor.SelectedValue.ToString())
            };

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.CadastrarProdutos(obj);

            new Methods().LimparTela(this);
            txtDescricao.Focus();

            //atualizando o grid após inserir
            // gridProdutos.DataSource= fornecedorDAO.ListarFornecedores();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
