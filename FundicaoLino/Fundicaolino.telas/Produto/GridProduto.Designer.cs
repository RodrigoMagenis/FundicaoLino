namespace Fundicaolino.telas.Produto
{
    partial class GridProduto
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
            this.dgProducao = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProducao
            // 
            this.dgProducao.AllowUserToAddRows = false;
            this.dgProducao.AllowUserToDeleteRows = false;
            this.dgProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdTipoProduto,
            this.NmTipoProduto,
            this.Responsavel,
            this.date});
            this.dgProducao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProducao.Location = new System.Drawing.Point(0, 0);
            this.dgProducao.Name = "dgProducao";
            this.dgProducao.ReadOnly = true;
            this.dgProducao.Size = new System.Drawing.Size(763, 482);
            this.dgProducao.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID Produto";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // IdTipoProduto
            // 
            this.IdTipoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdTipoProduto.HeaderText = "ID Tipo do Produto";
            this.IdTipoProduto.Name = "IdTipoProduto";
            this.IdTipoProduto.ReadOnly = true;
            // 
            // NmTipoProduto
            // 
            this.NmTipoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NmTipoProduto.DataPropertyName = "NmTipoProduto";
            this.NmTipoProduto.HeaderText = "Nome Produto";
            this.NmTipoProduto.Name = "NmTipoProduto";
            this.NmTipoProduto.ReadOnly = true;
            // 
            // Responsavel
            // 
            this.Responsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Responsavel.HeaderText = "Responsavel";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // GridProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 482);
            this.Controls.Add(this.dgProducao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridProduto";
            this.Text = "GridProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgProducao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProducao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}