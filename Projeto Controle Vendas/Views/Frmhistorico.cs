using Projeto_Controle_Vendas.Dao;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmhistorico : Form
    {
        VendaDAO vendaDAO = new VendaDAO();
        DateTime datainicio, datafim;
        
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            
            gridRelVendas.DataSource = vendaDAO.ListarVendas();
            gridRelVendas.DefaultCellStyle.ForeColor = Color.Black;
        }

        //pegando os dados do histórico de vendas e passando p/ os detalhes da venda
        private void gridRelVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //Passando o id da venda p/ o Frmdetalhe
            int idvenda = Convert.ToInt32(gridRelVendas.CurrentRow.Cells[0].ToString());

            Frmdetalhe tela = new Frmdetalhe(idvenda);

            //1º - passo abrir um outro formulário
            tela.ShowDialog();

            //Formatando a data
            DateTime dataVenda = Convert.ToDateTime(gridRelVendas.CurrentRow.Cells[1].ToString());

            //tela.txtCodigo.Text = gridRelVendas.CurrentRow.Cells[0].Value.ToString();
            tela.txtData.Text = dataVenda.ToString("dd/MM/yyyy");
            tela.txtCliente.Text = gridRelVendas.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotal.Text = gridRelVendas.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = gridRelVendas.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VendaDAO vendaDAO = new VendaDAO();
            

            datainicio= Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim= Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            //carregando os dados no gridView
            gridRelVendas.DataSource = vendaDAO.ListarVendasPeriodo(datainicio, datafim);
        }
    }
}
