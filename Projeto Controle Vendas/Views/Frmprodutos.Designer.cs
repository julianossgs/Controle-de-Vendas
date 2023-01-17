namespace Projeto_Controle_Vendas.Views
{
    partial class Frmprodutos
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabProdutos.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(493, 298);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 34);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Location = new System.Drawing.Point(376, 298);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(109, 34);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(256, 298);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 34);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Location = new System.Drawing.Point(141, 298);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 34);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbFornecedor.Location = new System.Drawing.Point(139, 189);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(322, 28);
            this.cbFornecedor.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(42, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Forneçedor";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(139, 148);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(247, 26);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(48, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Preço (R$)";
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Location = new System.Drawing.Point(139, 107);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(94, 26);
            this.txtQtdEstoque.TabIndex = 2;
            this.txtQtdEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(34, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qtd Estoque";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(139, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(322, 26);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(53, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(58, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(74, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabCadastro);
            this.tabProdutos.Controls.Add(this.tabConsulta);
            this.tabProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProdutos.Location = new System.Drawing.Point(12, 81);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(880, 507);
            this.tabProdutos.TabIndex = 6;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.btnExcluir);
            this.tabCadastro.Controls.Add(this.btnAlterar);
            this.tabCadastro.Controls.Add(this.btnSalvar);
            this.tabCadastro.Controls.Add(this.btnNovo);
            this.tabCadastro.Controls.Add(this.cbFornecedor);
            this.tabCadastro.Controls.Add(this.label15);
            this.tabCadastro.Controls.Add(this.txtPreco);
            this.tabCadastro.Controls.Add(this.label13);
            this.tabCadastro.Controls.Add(this.txtQtdEstoque);
            this.tabCadastro.Controls.Add(this.label4);
            this.tabCadastro.Controls.Add(this.txtDescricao);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.txtCodigo);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadastro.Location = new System.Drawing.Point(4, 29);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(872, 474);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Dados do Produto";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.gridProdutos);
            this.tabConsulta.Controls.Add(this.btnPesquisar);
            this.tabConsulta.Controls.Add(this.txtPesquisa);
            this.tabConsulta.Controls.Add(this.label16);
            this.tabConsulta.Location = new System.Drawing.Point(4, 29);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(872, 474);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.GridColor = System.Drawing.SystemColors.Control;
            this.gridProdutos.Location = new System.Drawing.Point(20, 80);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.Size = new System.Drawing.Size(828, 312);
            this.gridProdutos.TabIndex = 30;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Location = new System.Drawing.Point(355, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 34);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(81, 28);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(247, 26);
            this.txtPesquisa.TabIndex = 5;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(16, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 75);
            this.panel1.TabIndex = 5;
            // 
            // Frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 591);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.panel1);
            this.Name = "Frmprodutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Frmprodutos_Load);
            this.tabProdutos.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQtdEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}