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
            Cliente obj= new Cliente();

            obj.Nome = txtNome.Text;
            obj.Rg = txtRG.Text;
            obj.Cpf = txtCPF.Text;
            obj.Email= txtEmail.Text;
            obj.Telefone= txtTelefone.Text;
            obj.Celular= txtCelular.Text;
            obj.Cep=txtCEP.Text;
            obj.Endereco= txtCEP.Text;
            obj.Numero=int.Parse(txtNumero.Text);
            obj.Complemento=txtComplemento.Text;
            obj.Bairro=txtBairro.Text;
            obj.Cidade=txtCidade.Text;
            obj.Estado=cbUF.Text;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.CadastrarCliente(obj);
            
        }

        //botão Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCidade.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCEP.Clear();
            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtComplemento.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtNome.Focus();
            
        }

        //botão salvar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.Nome = txtNome.Text;
            obj.Rg = txtRG.Text;
            obj.Cpf = txtCPF.Text;
            obj.Email= txtEmail.Text;
            obj.Telefone= txtTelefone.Text;
            obj.Celular= txtCelular.Text;
            obj.Cep=txtCEP.Text;
            obj.Endereco= txtEndereco.Text;
            obj.Numero=int.Parse(txtNumero.Text);
            obj.Complemento=txtComplemento.Text;
            obj.Bairro=txtBairro.Text;
            obj.Cidade=txtCidade.Text;
            obj.Estado=cbUF.Text;

            ClienteDAO clienteDAO= new ClienteDAO();
            clienteDAO.AlterarCliente(obj);
        }

        //botão excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj =new Cliente();
            obj.ID = int.Parse(txtCodigo.Text);

            ClienteDAO clienteDAO=new ClienteDAO();
            clienteDAO.ExcluirCliente(obj);
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
            txtTelefone.Text = gridCliente.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = gridCliente.CurrentRow.Cells[5].Value.ToString();
            txtCEP.Text = gridCliente.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = gridCliente.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = gridCliente.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = gridCliente.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = gridCliente.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = gridCliente.CurrentRow.Cells[11].Value.ToString();
            cbUF.Text = gridCliente.CurrentRow.Cells[12].Value.ToString();
           
        }
    }
}
