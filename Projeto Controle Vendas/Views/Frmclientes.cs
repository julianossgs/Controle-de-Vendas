using Projeto_Controle_Vendas.Dao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmclientes : Form
    {
        
        public Frmclientes()
        {
            InitializeComponent();
        }

        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 passo - Armazenar os dados em um objeto model
            Cliente obj = new Cliente
            {
                Nome = txtNome.Text,
                Rg = txtRG.Text,
                Cpf = txtCPF.Text,
                Email= txtEmail.Text,
                Telefone= txtTelefone.Text,
                Celular= txtCelular.Text,
                Cep=txtCEP.Text,
                Endereco= txtCEP.Text,
                Numero=int.Parse(txtNumero.Text),
                Complemento=txtComplemento.Text,
                Bairro=txtBairro.Text,
                Cidade=txtCidade.Text,
                Estado=cbUF.Text
            };

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.CadastrarCliente(obj);

            //atualizando o grid após a exclusão
            gridCliente.DataSource= clienteDAO.ListarClientes(); 

        }

        //botão Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            new Methods().LimparTela(this);
            txtNome.Focus();
            
        }

        //botão salvar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente
            {
                ID = int.Parse(txtCodigo.Text),
                Nome = txtNome.Text,
                Rg = txtRG.Text,
                Cpf = txtCPF.Text,
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

            ClienteDAO clienteDAO= new ClienteDAO();
            clienteDAO.AlterarCliente(obj);

            //atualizando o grid após a exclusão
            gridCliente.DataSource= clienteDAO.ListarClientes(); 
        }

        //botão excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
                Cliente obj = new Cliente();
                obj.ID = int.Parse(txtCodigo.Text);

                ClienteDAO clienteDAO = new ClienteDAO();
                clienteDAO.ExcluirCliente(obj);

                //atualizando o grid após a exclusão
                gridCliente.DataSource= clienteDAO.ListarClientes(); 
            
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            gridCliente.DataSource = clienteDAO.ListarClientes();
            txtNome.Focus();
        }

        private void gridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1º passo pegar os dados da linha selecionada
            txtCodigo.Text = gridCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridCliente.CurrentRow.Cells[1].Value.ToString();  
            txtRG.Text = gridCliente.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = gridCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = gridCliente.CurrentRow.Cells[4].Value.ToString(); 
            txtTelefone.Text = gridCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = gridCliente.CurrentRow.Cells[6].Value.ToString();
            txtCEP.Text = gridCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = gridCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = gridCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = gridCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = gridCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = gridCliente.CurrentRow.Cells[12].Value.ToString();
            cbUF.Text = gridCliente.CurrentRow.Cells[13].Value.ToString();
           
            //alterando o tab page p/ a guia tabCadastro
            tabClientes.SelectedTab = tabCadastro;
        }

        //botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ClienteDAO clienteDAO = new ClienteDAO();

            if (txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Informe um nome para a pesquisa!");
                txtPesquisa.Focus();
                gridCliente.DataSource = clienteDAO.ListarClientes();
                return;
                  
            }

            if (gridCliente.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado!");
                txtPesquisa.Clear();
                txtPesquisa.Focus();
                gridCliente.DataSource = clienteDAO.ListarClientes();
                return;
            }

            else
            {
               
                gridCliente.DataSource = clienteDAO.BuscarClienteNome(nome);
            }

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            ClienteDAO clienteDAO = new ClienteDAO();

            gridCliente.DataSource = clienteDAO.BuscarClienteNome(nome);

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
            }
        }
    }
}
