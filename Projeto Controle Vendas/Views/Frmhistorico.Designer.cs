namespace Projeto_Controle_Vendas.Views
{
    partial class Frmhistorico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHistoricoVendas = new System.Windows.Forms.GroupBox();
            this.gridRelVendas = new System.Windows.Forms.DataGridView();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbHistoricoVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 75);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(321, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico de Vendas";
            // 
            // gbHistoricoVendas
            // 
            this.gbHistoricoVendas.Controls.Add(this.btnPesquisar);
            this.gbHistoricoVendas.Controls.Add(this.label2);
            this.gbHistoricoVendas.Controls.Add(this.label3);
            this.gbHistoricoVendas.Controls.Add(this.dtFim);
            this.gbHistoricoVendas.Controls.Add(this.dtInicio);
            this.gbHistoricoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistoricoVendas.Location = new System.Drawing.Point(61, 81);
            this.gbHistoricoVendas.Name = "gbHistoricoVendas";
            this.gbHistoricoVendas.Size = new System.Drawing.Size(892, 93);
            this.gbHistoricoVendas.TabIndex = 2;
            this.gbHistoricoVendas.TabStop = false;
            this.gbHistoricoVendas.Text = "Consulta";
            // 
            // gridRelVendas
            // 
            this.gridRelVendas.AllowUserToAddRows = false;
            this.gridRelVendas.AllowUserToDeleteRows = false;
            this.gridRelVendas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridRelVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colDataVenda,
            this.colCliente,
            this.colTotal,
            this.colObs});
            this.gridRelVendas.Location = new System.Drawing.Point(25, 180);
            this.gridRelVendas.Name = "gridRelVendas";
            this.gridRelVendas.ReadOnly = true;
            this.gridRelVendas.RowHeadersWidth = 50;
            this.gridRelVendas.RowTemplate.Height = 30;
            this.gridRelVendas.Size = new System.Drawing.Size(973, 317);
            this.gridRelVendas.TabIndex = 0;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(209, 35);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(117, 26);
            this.dtInicio.TabIndex = 1;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(450, 35);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(118, 26);
            this.dtFim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(109, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(370, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Fim";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Location = new System.Drawing.Point(617, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(135, 45);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Código";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            this.colCod.Width = 60;
            // 
            // colDataVenda
            // 
            this.colDataVenda.HeaderText = "Data da Venda";
            this.colDataVenda.Name = "colDataVenda";
            this.colDataVenda.ReadOnly = true;
            this.colDataVenda.Width = 120;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 300;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 130;
            // 
            // colObs
            // 
            this.colObs.HeaderText = "Obs";
            this.colObs.Name = "colObs";
            this.colObs.ReadOnly = true;
            this.colObs.Width = 300;
            // 
            // Frmhistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 509);
            this.Controls.Add(this.gridRelVendas);
            this.Controls.Add(this.gbHistoricoVendas);
            this.Controls.Add(this.panel1);
            this.Name = "Frmhistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Vendas";
            this.Load += new System.EventHandler(this.Frmhistorico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbHistoricoVendas.ResumeLayout(false);
            this.gbHistoricoVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHistoricoVendas;
        private System.Windows.Forms.DataGridView gridRelVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
    }
}