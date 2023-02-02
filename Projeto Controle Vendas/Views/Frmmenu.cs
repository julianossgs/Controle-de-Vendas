using System;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmmenu : Form
    {
        Frmclientes telaCliente = new Frmclientes();
        Frmfornecedores telaFornec = new Frmfornecedores();
        Frmfuncionarios telaFunc = new Frmfuncionarios();
        Frmprodutos telaProduto = new Frmprodutos();
        Frmvendas telaVenda = new Frmvendas();  
        Frmhistorico telaHistorico= new Frmhistorico();

        public Frmmenu()
        {
            InitializeComponent();
        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            //Buscando data atual
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:MM:ss");
        }

        private void menuCadClientes_Click(object sender, EventArgs e)
        {
            telaCliente.tabClientes.SelectedTab = telaCliente.tabCadastro;
            telaCliente.ShowDialog();
        }

        private void menuConClientes_Click(object sender, EventArgs e)
        {
            //abrir a tela de clientes com a aba de Consulta aberto
            telaCliente.tabClientes.SelectedTab = telaCliente.tabConsulta;
            telaCliente.ShowDialog(this);
            
        }

        private void menuCadFuncionarios_Click(object sender, EventArgs e)
        {
            
            telaFunc.tabFuncionarios.SelectedTab = telaFunc.tabCadastro;
            telaFunc.ShowDialog(this);
        }

        private void menuConsFuncionarios_Click(object sender, EventArgs e)
        {
            
            telaFunc.tabFuncionarios.SelectedTab = telaFunc.tabConsulta;
            telaFunc.ShowDialog(this);  
        }

        private void menuCadFornecedores_Click(object sender, EventArgs e)
        {
            telaFornec.tabFornecedores.SelectedTab = telaFornec.tabCadastro;
            telaFornec.ShowDialog(this);
        }

        private void menuConsFornecedores_Click(object sender, EventArgs e)
        {
            telaFornec.tabFornecedores.SelectedTab = telaFornec.tabConsulta;
            telaFornec.ShowDialog(this);
        }

        private void menuCadProdutos_Click(object sender, EventArgs e)
        {
            telaProduto.tabProdutos.SelectedTab = telaProduto.tabCadastro;
            telaProduto.ShowDialog(this);
        }

        private void menuConsProdutos_Click(object sender, EventArgs e)
        {
            telaProduto.tabProdutos.SelectedTab = telaProduto.tabConsulta;
            telaProduto.ShowDialog(this);
        }

        private void menuNovaVenda_Click(object sender, EventArgs e)
        {
            telaVenda.ShowDialog(this);
        }

        private void menuHistoricoVenda_Click(object sender, EventArgs e)
        {
            telaHistorico.ShowDialog(this);
        }

        //Trocar de usuário
        private void menuTrocarUsuario_Click(object sender, EventArgs e)
        {

        }

        //Sair do Sistema
        private void menuSairSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Sair?","Deseja Sair", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (result == DialogResult.OK) 
            {
                Application.Exit(); 
            }
        }
    }
}
