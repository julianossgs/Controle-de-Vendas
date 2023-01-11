﻿using Projeto_Controle_Vendas.Dao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario
            {
                Nome = txtNome.Text,
                Rg = txtRG.Text,
                Cpf = txtCPF.Text,
                Email= txtEmail.Text,
                Senha= txtSenha.Text,
                Nivel_Acesso = cbNivel.SelectedItem.ToString(),
                Cargo = cbNivel.SelectedItem.ToString(),
                Telefone= txtTelefone.Text,
                Celular= txtCelular.Text,
                Cep=txtCEP.Text,
                Endereco= txtCEP.Text,
                Numero=int.Parse(txtNumero.Text),
                Complemento=txtComplemento.Text,
                Bairro=txtBairro.Text,
                Cidade=txtCidade.Text,
                Estado = cbUF.Text
            };

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();   
            funcionarioDAO.CadastrarFuncionario(obj);

            gridFuncionario.DataSource = funcionarioDAO.ListarFuncionarios();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario
            {
                Nome = txtNome.Text,
                Rg = txtRG.Text,
                Cpf = txtCPF.Text,
                Email= txtEmail.Text,
                Senha= txtSenha.Text,
                Nivel_Acesso = cbNivel.SelectedItem.ToString(),
                Cargo = cbNivel.SelectedItem.ToString(),
                Telefone= txtTelefone.Text,
                Celular= txtCelular.Text,
                Cep=txtCEP.Text,
                Endereco= txtCEP.Text,
                Numero=int.Parse(txtNumero.Text),
                Complemento=txtComplemento.Text,
                Bairro=txtBairro.Text,
                Cidade=txtCidade.Text,
                Estado = cbUF.Text
            };
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionarioDAO.Alterarfuncionario(obj);

            gridFuncionario.DataSource = funcionarioDAO.ListarFuncionarios();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario
            {
                ID = int.Parse(txtCodigo.Text)
            };
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionarioDAO.ExcluirFuncionario(obj);

            gridFuncionario.DataSource = funcionarioDAO.ListarFuncionarios();
        }

        private void btPesquisarAPI_Click(object sender, EventArgs e)
        {

        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            gridFuncionario.DataSource = funcionarioDAO.ListarFuncionarios();
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            if (txtPesquisa.Text == null || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Informe um nome para a pesquisa!");
                txtPesquisa.Focus();
                gridFuncionario.DataSource = funcionarioDAO.ListarFuncionarios();
                return;

            }

            if (gridFuncionario.Rows.Count == 0)
            {
                MessageBox.Show("Funcionário não encontrado!");
                txtPesquisa.Focus();
                gridFuncionario.DataSource = funcionarioDAO.ListarFuncionarios();
                return;
            }

            else
            {

                gridFuncionario.DataSource = funcionarioDAO.BuscarFuncionariosNome(nome);
            }

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            gridFuncionario.DataSource = funcionarioDAO.ListarFuncionarioNome(nome);

            if (gridFuncionario.Rows.Count == 0)
            {
                MessageBox.Show("Funcionário não encontrado!");
                txtPesquisa.Focus();
                gridFuncionario.DataSource = funcionarioDAO.ListarFuncionarios();
                return;
            }
        }

        //Evento de click no grid view
        private void gridFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1º passo pegar os dados da linha selecionada
            txtCodigo.Text = gridFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = gridFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = gridFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = gridFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = gridFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = gridFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbNivel.Text = gridFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = gridFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = gridFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCEP.Text = gridFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = gridFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = gridFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = gridFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = gridFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = gridFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbUF.Text = gridFuncionario.CurrentRow.Cells[16].Value.ToString();

            //alterando o tab page p/ a guia tabCadastro
            tabFuncionarios.SelectedTab = tabCadastro;
        }
    }
}
