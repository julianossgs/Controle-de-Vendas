using Projeto_Controle_Vendas.Views;
using System;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frmhistorico());
        }
    }
}
