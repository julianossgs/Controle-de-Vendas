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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 passo - Armazenar os dados em um objeto model
            Cliente obj= new Cliente();

            obj.ID = int.Parse(txtCodigo.Text);
            obj.Nome = txtNome.Text;
            obj.Rg = txtRG.Text;
            obj.Cpf = txtCPF.Text;
            obj.Email= txtEmail.Text;
            obj.Telefone= txtTelefone.Text;
            obj.Celular= txtCelular.Text;
            obj.Cep=txtCPF.Text;
            obj.Endereco= txtCPF.Text;
            obj.Numero=int.Parse(txtNumero.Text);
            obj.Complemento=txtComplemento.Text;
            obj.Bairro=txtBairro.Text;
            obj.Cidade=txtCidade.Text;
            obj.Estado=cbUF.Text;
            
        }
    }
}
