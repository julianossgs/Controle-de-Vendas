using Projeto_Controle_Vendas.Dao;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmhistorico : Form
    {
        DateTime datainicio, datafim;
        
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            VendaDAO vendaDAO = new VendaDAO();
            gridRelVendas.DataSource = vendaDAO.ListarVendas();
            gridRelVendas.DefaultCellStyle.ForeColor = Color.Black;
        }

        //pegando os dados do histórico de vendas e passando p/ os detalhes da venda
        private void gridRelVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1º - passo abrir um outro formulário
            Frmdetalhe tela = new Frmdetalhe();
            //tela.ShowDialog();

            tela.txtData.Text = gridRelVendas.CurrentRow.Cells[1].ToString();
            tela.txtCliente.Text = gridRelVendas.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotal.Text = gridRelVendas.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = gridRelVendas.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (gridRelVendas.Rows.Count == 0)
            {
                MessageBox.Show("Não há vendas neste período!! Informe outras datas!!");
                dtInicio.Focus();

            }

            datainicio= Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim= Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO vendaDAO = new VendaDAO(); 

            //carregando os dados no gridView
            gridRelVendas.DataSource = vendaDAO.ListarVendasPeriodo(datainicio, datafim);
        }
    }
}
