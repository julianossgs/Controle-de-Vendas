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
    public partial class Frmvendas : Form
    {
        //Criando os objetos cliente e clienteDAO
        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();

        //Criando objeto produto e produtoDAO
        Produto produto = new Produto();
        ProdutoDAO produtoDAO= new ProdutoDAO();

        //Variáveis
        int qtd;
        decimal preco,subtotal,total;

        //Carrinho(GridView)
        DataTable carrinho = new DataTable();
        
        public Frmvendas()
        {
            InitializeComponent();

            //Add colunas no datatable através do construtor
            carrinho.Columns.Add("Codigo",typeof(int));
            carrinho.Columns.Add("Produto",typeof(string));
            carrinho.Columns.Add("Qtd",typeof(int));
            carrinho.Columns.Add("Preco",typeof(decimal));
            carrinho.Columns.Add("SubTotal",typeof(decimal));

            gridVendas.DataSource= carrinho;    
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)//o número 13 representa a tecla enter do teclado
            {
                cliente = clienteDAO.RetornaCpf(txtCPF.Text);
                txtNome.Text = cliente.Nome;
            }
        }

        //botão Remover item
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subproduto = decimal.Parse(gridVendas.CurrentRow.Cells[4].Value.ToString());

                int indice = gridVendas.CurrentRow.Index;//pegando o indíce da linha a ser removida
                DataRow linha = carrinho.Rows[indice];

                carrinho.Rows.RemoveAt(indice);
                carrinho.AcceptChanges();

                total -= subproduto;

                txtTotal.Text = total.ToString();

                MessageBox.Show("Item removido com sucesso!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao remover item: ");
            }
        }

        //botão add itens
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txtQtdEstoque.Text);
            preco = decimal.Parse(txtPreco.Text);

            subtotal = qtd * preco;//calculando o subtotal
            total += subtotal;//calculando o total

            //add o produto no carrinho
            carrinho.Rows.Add(int.Parse(txtCodigo.Text),this.txtDescricao.Text,qtd,preco,subtotal);
            txtTotal.Text = total.ToString();   

            //Limpar campos
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtQtdEstoque.Clear();
            txtPreco.Clear();

            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                produto = produtoDAO.RetornaProdutoId(int.Parse(txtCodigo.Text));
                this.txtDescricao.Text = produto.Descricao;
                this.txtPreco.Text = produto.Preco.ToString();
            }
        }
    }
}
