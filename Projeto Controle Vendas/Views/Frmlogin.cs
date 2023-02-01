using Projeto_Controle_Vendas.Dao;
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
    public partial class Frmlogin : Form
    {
        
        FuncionarioDAO dAO= new FuncionarioDAO();
        public Frmlogin()
        {
            InitializeComponent();
        }

        //botão entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (dAO.Login(email,senha))
            {
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou Senha inválidos!");
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
            }
        }
    }
}
