using Projeto_Controle_Vendas.Dao;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    
    public partial class Frmdetalhe : Form
    {
        int venda_id;
        public Frmdetalhe(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void gridDetalheVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //Carrega tela detalhes
        private void Frmdetalhe_Load(object sender, System.EventArgs e)
        {
            ItemVendaDAO dAO= new ItemVendaDAO();
            gridDetalheVendas.DataSource= dAO.ListarItensVenda(venda_id);

        }
    }
}
