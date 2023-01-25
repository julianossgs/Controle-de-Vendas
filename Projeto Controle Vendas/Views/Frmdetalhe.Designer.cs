namespace Projeto_Controle_Vendas.Views
{
    partial class Frmdetalhe
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDetalhesVenda = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridDetalheVendas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbDetalhesVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalheVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 75);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(269, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes da Venda";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(77, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(247, 26);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente";
            // 
            // gbDetalhesVenda
            // 
            this.gbDetalhesVenda.Controls.Add(this.txtObs);
            this.gbDetalhesVenda.Controls.Add(this.txtCliente);
            this.gbDetalhesVenda.Controls.Add(this.label5);
            this.gbDetalhesVenda.Controls.Add(this.label3);
            this.gbDetalhesVenda.Controls.Add(this.txtTotal);
            this.gbDetalhesVenda.Controls.Add(this.label2);
            this.gbDetalhesVenda.Controls.Add(this.txtData);
            this.gbDetalhesVenda.Controls.Add(this.label4);
            this.gbDetalhesVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalhesVenda.Location = new System.Drawing.Point(12, 90);
            this.gbDetalhesVenda.Name = "gbDetalhesVenda";
            this.gbDetalhesVenda.Size = new System.Drawing.Size(918, 239);
            this.gbDetalhesVenda.TabIndex = 0;
            this.gbDetalhesVenda.TabStop = false;
            this.gbDetalhesVenda.Text = "Detalhes da Venda";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(77, 142);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(467, 74);
            this.txtObs.TabIndex = 0;
            this.txtObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(33, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Obs";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(598, 40);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(247, 26);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(475, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total da Venda";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(77, 88);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(247, 26);
            this.txtData.TabIndex = 0;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(27, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data";
            // 
            // gridDetalheVendas
            // 
            this.gridDetalheVendas.AllowUserToAddRows = false;
            this.gridDetalheVendas.AllowUserToDeleteRows = false;
            this.gridDetalheVendas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridDetalheVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalheVendas.Location = new System.Drawing.Point(12, 335);
            this.gridDetalheVendas.Name = "gridDetalheVendas";
            this.gridDetalheVendas.ReadOnly = true;
            this.gridDetalheVendas.RowTemplate.Height = 28;
            this.gridDetalheVendas.Size = new System.Drawing.Size(918, 176);
            this.gridDetalheVendas.TabIndex = 0;
            this.gridDetalheVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalheVendas_CellClick);
            // 
            // Frmdetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 523);
            this.Controls.Add(this.gridDetalheVendas);
            this.Controls.Add(this.gbDetalhesVenda);
            this.Controls.Add(this.panel1);
            this.Name = "Frmdetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmdetalhe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDetalhesVenda.ResumeLayout(false);
            this.gbDetalhesVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalheVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDetalhesVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridDetalheVendas;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtData;
        public System.Windows.Forms.TextBox txtObs;
    }
}