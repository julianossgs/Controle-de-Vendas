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
            gridProdutos.DataSource= produtoDAO.ListarProdutos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto
            {
                Id= int.Parse(txtCodigo.Text),
                Descricao = txtDescricao.Text,
                Preco = decimal.Parse(txtPreco.Text),
                QtdEstoque = int.Parse(txtQtdEstoque.Text),
                For_Id = int.Parse(cbFornecedor.SelectedValue.ToString())
            };

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.AlterarProdutos(obj);

            new Methods().LimparTela(this);
            txtDescricao.Focus();

            //atualizando o grid após alterar
             gridProdutos.DataSource= produtoDAO.ListarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto
            {
                Id= int.Parse(txtCodigo.Text),
               
            };

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.ExcluirProdutos(obj);

            new Methods().LimparTela(this);
            txtDescricao.Focus();

            //atualizando o grid após excluir
            gridProdutos.DataSource= produtoDAO.ListarProdutos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO produtoDAO = new ProdutoDAO();

            gridProdutos.DataSource = produtoDAO.ListarProdutosNome(nome);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            ProdutoDAO produtoDAO = new ProdutoDAO();

            if (txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Informe um produto para a pesquisa!");
                btnPesquisar.Focus();
                gridProdutos.DataSource = produtoDAO.ListarProdutos();
                return;

            }

            if (gridProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Produto não encontrado!");
                txtPesquisa.Clear();
                txtPesquisa.Focus();
                gridProdutos.DataSource = produtoDAO.ListarProdutos();
                return;
            }

            else
            {
                gridProdutos.DataSource = produtoDAO.BuscarProdutoNome(nome);
            }
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1º passo pegar os dados da linha selecionada
            txtCodigo.Text = gridProdutos.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = gridProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = gridProdutos.CurrentRow.Cells[2].Value.ToString();
            txtQtdEstoque.Text = gridProdutos.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = gridProdutos.CurrentRow.Cells[4].Value.ToString();

            //alterando o tab page p/ a guia tabCadastro
            tabProdutos.SelectedTab = tabCadastro;
        }
    }
}
