namespace Projeto_Controle_Vendas.Views
{
    partial class Frmmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoricoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSairSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionarios,
            this.menuFornecedores,
            this.menuProdutos,
            this.menuVendas,
            this.menuConfiguracoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadClientes,
            this.menuConClientes});
            this.menuCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.Image = global::Projeto_Controle_Vendas.Properties.Resources.cadastro_clientes_40_x_40;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(89, 24);
            this.menuCliente.Text = "Clientes";
            // 
            // menuCadClientes
            // 
            this.menuCadClientes.Name = "menuCadClientes";
            this.menuCadClientes.Size = new System.Drawing.Size(214, 24);
            this.menuCadClientes.Text = "Cadastro de Clientes";
            this.menuCadClientes.Click += new System.EventHandler(this.menuCadClientes_Click);
            // 
            // menuConClientes
            // 
            this.menuConClientes.Name = "menuConClientes";
            this.menuConClientes.Size = new System.Drawing.Size(214, 24);
            this.menuConClientes.Text = "Consulta de Clientes";
            this.menuConClientes.Click += new System.EventHandler(this.menuConClientes_Click);
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadFuncionarios,
            this.menuConsFuncionarios});
            this.menuFuncionarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFuncionarios.Image = global::Projeto_Controle_Vendas.Properties.Resources.usuarios_40x40;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(120, 24);
            this.menuFuncionarios.Text = "Funcionários";
            // 
            // menuCadFuncionarios
            // 
            this.menuCadFuncionarios.Name = "menuCadFuncionarios";
            this.menuCadFuncionarios.Size = new System.Drawing.Size(245, 24);
            this.menuCadFuncionarios.Text = "Cadastro de Funcionários";
            this.menuCadFuncionarios.Click += new System.EventHandler(this.menuCadFuncionarios_Click);
            // 
            // menuConsFuncionarios
            // 
            this.menuConsFuncionarios.Name = "menuConsFuncionarios";
            this.menuConsFuncionarios.Size = new System.Drawing.Size(245, 24);
            this.menuConsFuncionarios.Text = "Consulta de Funcionários";
            this.menuConsFuncionarios.Click += new System.EventHandler(this.menuConsFuncionarios_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadFornecedores,
            this.menuConsFornecedores});
            this.menuFornecedores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFornecedores.Image = global::Projeto_Controle_Vendas.Properties.Resources.couple64;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(126, 24);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // menuCadFornecedores
            // 
            this.menuCadFornecedores.Name = "menuCadFornecedores";
            this.menuCadFornecedores.Size = new System.Drawing.Size(251, 24);
            this.menuCadFornecedores.Text = "Cadastro de Fornecedores";
            this.menuCadFornecedores.Click += new System.EventHandler(this.menuCadFornecedores_Click);
            // 
            // menuConsFornecedores
            // 
            this.menuConsFornecedores.Name = "menuConsFornecedores";
            this.menuConsFornecedores.Size = new System.Drawing.Size(251, 24);
            this.menuConsFornecedores.Text = "Consulta de Fornecedores";
            this.menuConsFornecedores.Click += new System.EventHandler(this.menuConsFornecedores_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadProdutos,
            this.menuConsProdutos});
            this.menuProdutos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProdutos.Image = global::Projeto_Controle_Vendas.Properties.Resources.cad_produtos_40x40;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(96, 24);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadProdutos
            // 
            this.menuCadProdutos.Name = "menuCadProdutos";
            this.menuCadProdutos.Size = new System.Drawing.Size(221, 24);
            this.menuCadProdutos.Text = "Cadastro de Produtos";
            this.menuCadProdutos.Click += new System.EventHandler(this.menuCadProdutos_Click);
            // 
            // menuConsProdutos
            // 
            this.menuConsProdutos.Name = "menuConsProdutos";
            this.menuConsProdutos.Size = new System.Drawing.Size(221, 24);
            this.menuConsProdutos.Text = "Consulta de Produtos";
            this.menuConsProdutos.Click += new System.EventHandler(this.menuConsProdutos_Click);
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaVenda,
            this.menuHistoricoVenda});
            this.menuVendas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVendas.Image = global::Projeto_Controle_Vendas.Properties.Resources._1481080293_Money;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(84, 24);
            this.menuVendas.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(210, 24);
            this.menuNovaVenda.Text = "Nova Venda";
            this.menuNovaVenda.Click += new System.EventHandler(this.menuNovaVenda_Click);
            // 
            // menuHistoricoVenda
            // 
            this.menuHistoricoVenda.Name = "menuHistoricoVenda";
            this.menuHistoricoVenda.Size = new System.Drawing.Size(210, 24);
            this.menuHistoricoVenda.Text = "Histórico de Vendas";
            this.menuHistoricoVenda.Click += new System.EventHandler(this.menuHistoricoVenda_Click);
            // 
            // menuConfiguracoes
            // 
            this.menuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocarUsuario,
            this.menuSairSistema});
            this.menuConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuConfiguracoes.Image = global::Projeto_Controle_Vendas.Properties.Resources.configurações;
            this.menuConfiguracoes.Name = "menuConfiguracoes";
            this.menuConfiguracoes.Size = new System.Drawing.Size(132, 24);
            this.menuConfiguracoes.Text = "Configurações";
            // 
            // menuTrocarUsuario
            // 
            this.menuTrocarUsuario.Name = "menuTrocarUsuario";
            this.menuTrocarUsuario.Size = new System.Drawing.Size(192, 24);
            this.menuTrocarUsuario.Text = "Trocar de usuário";
            this.menuTrocarUsuario.Click += new System.EventHandler(this.menuTrocarUsuario_Click);
            // 
            // menuSairSistema
            // 
            this.menuSairSistema.Name = "menuSairSistema";
            this.menuSairSistema.Size = new System.Drawing.Size(192, 24);
            this.menuSairSistema.Text = "Sair do Sistema";
            this.menuSairSistema.Click += new System.EventHandler(this.menuSairSistema_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.txtusuarioLogado,
            this.txtUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(941, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel1.Text = "Data Atual";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.Red;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(85, 20);
            this.toolStripStatusLabel3.Text = "Hora Atual";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.Red;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(0, 20);
            // 
            // txtusuarioLogado
            // 
            this.txtusuarioLogado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuarioLogado.ForeColor = System.Drawing.Color.Red;
            this.txtusuarioLogado.Name = "txtusuarioLogado";
            this.txtusuarioLogado.Size = new System.Drawing.Size(0, 20);
            this.txtusuarioLogado.ToolTipText = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Red;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(0, 20);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Projeto_Controle_Vendas.Properties.Resources.bannerVenda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmmenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadClientes;
        private System.Windows.Forms.ToolStripMenuItem menuConClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuConsFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuCadFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuConsFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSairSistema;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripMenuItem menuCliente;
        public System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        public System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        public System.Windows.Forms.ToolStripMenuItem menuProdutos;
        public System.Windows.Forms.ToolStripMenuItem menuVendas;
        public System.Windows.Forms.ToolStripMenuItem menuConfiguracoes;
        public System.Windows.Forms.ToolStripStatusLabel txtData;
        public System.Windows.Forms.ToolStripStatusLabel txtHora;
        public System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel txtusuarioLogado;
        public System.Windows.Forms.ToolStripMenuItem menuNovaVenda;
        public System.Windows.Forms.ToolStripMenuItem menuHistoricoVenda;
    }
}