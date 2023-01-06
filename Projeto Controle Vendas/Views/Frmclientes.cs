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

        }

        //botão salvar
        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        //botão excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            gridCliente.DataSource = clienteDAO.ListarClientes();
        }
    }
}
