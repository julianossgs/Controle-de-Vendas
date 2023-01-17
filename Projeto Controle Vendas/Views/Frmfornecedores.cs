using Projeto_Controle_Vendas.Dao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Methods().LimparTela(this);
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor
            {
                Nome = txtNome.Text,
                CNPJ = txtCNPJ.Text,
                Email= txtEmail.Text,
                Telefone= txtTelefone.Text,
                Celular= txtCelular.Text,
                Cep=txtCEP.Text,
                Endereco= txtEndereco.Text,
                Numero=int.Parse(txtNumero.Text),
                Complemento=txtComplemento.Text,
                Bairro=txtBairro.Text,
                Cidade=txtCidade.Text,
                Estado=cbUF.Text
            };

            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorDAO.CadastrarFornecedor(obj);

            //atualizando o grid após inserir
            gridFornecedores.DataSource= fornecedorDAO.ListarFornecedores();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor
            {
                ID = int.Parse(txtCodigo.Text),
                Nome = txtNome.Text,
                CNPJ = txtCNPJ.Text,
                Email= txtEmail.Text,
                Telefone= txtTelefone.Text,
                Celular= txtCelular.Text,
                Cep=txtCEP.Text,
                Endereco= txtEndereco.Text,
                Numero=int.Parse(txtNumero.Text),
                Complemento=txtComplemento.Text,
                Bairro=txtBairro.Text,
                Cidade=txtCidade.Text,
                Estado=cbUF.Text
            };

            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorDAO.AlterarFornecedor(obj);

            //atualizando o grid após inserir
            gridFornecedores.DataSource= fornecedorDAO.ListarFornecedores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor
            {
                ID = int.Parse(txtCodigo.Text),
              
            };

            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorDAO.ExcluirFornecedor(obj);

            //atualizando o grid após inserir
            gridFornecedores.DataSource= fornecedorDAO.ListarFornecedores();
        }

        private void btPesquisarAPI_Click(object sender, EventArgs e)
        {
            
            try
            {
                   
                    string cep = txtCEP.Text;
                    string xml = "https://viacep.com.br/ws/"+cep+"/xml/";
                
               
                    DataSet dados = new DataSet();
                    dados.ReadXml(xml);

                    txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                    txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                    txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                    txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                    cbUF.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado!!! ");
                txtCEP.Clear();
                return;
            }

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            FornecedorDAO fornecedorDAO = new FornecedorDAO();

            gridFornecedores.DataSource = fornecedorDAO.ListarFornecedoresNome(nome);

            if (gridFornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Fornecedor não encontrado!");
                txtPesquisa.Focus();
                gridFornecedores.DataSource = fornecedorDAO.ListarFornecedores();
                return;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            FornecedorDAO fornecedorDAO = new FornecedorDAO();

            if (txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Informe um nome para a pesquisa!");
                txtPesquisa.Focus();
                gridFornecedores.DataSource = fornecedorDAO.BuscarFornecedorNome(nome);
                return;

            }

            if (gridFornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Fornecedor não encontrado!");
                txtPesquisa.Clear();
                txtPesquisa.Focus();
                gridFornecedores.DataSource = fornecedorDAO.ListarFornecedores();
                return;
            }

            else
            {

                gridFornecedores.DataSource = fornecedorDAO.BuscarFornecedorNome(nome);
            }
        }

        private void gridFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1º passo pegar os dados da linha selecionada
            txtCodigo.Text = gridFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = gridFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = gridFornecedores.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = gridFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = gridFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtCEP.Text = gridFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = gridFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = gridFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = gridFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = gridFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = gridFornecedores.CurrentRow.Cells[11].Value.ToString();
            cbUF.Text = gridFornecedores.CurrentRow.Cells[12].Value.ToString();

            //alterando o tab page p/ a guia tabCadastro
            tabFornecedores.SelectedTab = tabCadastro;
        }

        private void Frmfornecedores_Load(object sender, EventArgs e)
        {
            //Listar todos os forneçedores
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            gridFornecedores.DataSource = fornecedorDAO.ListarFornecedores();
        }
    }
}
