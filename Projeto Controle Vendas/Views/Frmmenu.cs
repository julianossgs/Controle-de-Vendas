using System;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class Frmmenu : Form
    {
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
    }
}
