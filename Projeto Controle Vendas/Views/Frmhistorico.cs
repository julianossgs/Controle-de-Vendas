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
