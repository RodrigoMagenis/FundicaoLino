namespace Fundicaolino.telas
{
    partial class dgTipodeProdutoFundo
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
            this.GridTipoProduto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTipoProduto
            // 
            this.GridTipoProduto.AllowUserToAddRows = false;
            this.GridTipoProduto.AllowUserToDeleteRows = false;
            this.GridTipoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NmTipoProduto,
            this.VlPeso});
            this.GridTipoProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTipoProduto.Location = new System.Drawing.Point(0, 0);
            this.GridTipoProduto.Name = "GridTipoProduto";
            this.GridTipoProduto.ReadOnly = true;
            this.GridTipoProduto.Size = new System.Drawing.Size(800, 450);
            this.GridTipoProduto.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NmTipoProduto
            // 
            this.NmTipoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NmTipoProduto.DataPropertyName = "NmTipoProduto";
            this.NmTipoProduto.HeaderText = "Nome Produto";
            this.NmTipoProduto.Name = "NmTipoProduto";
            this.NmTipoProduto.ReadOnly = true;
            // 
            // VlPeso
            // 
            this.VlPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VlPeso.DataPropertyName = "VlPeso";
            this.VlPeso.HeaderText = "Peso";
            this.VlPeso.Name = "VlPeso";
            this.VlPeso.ReadOnly = true;
            // 
            // dgTipodeProdutoFundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridTipoProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dgTipodeProdutoFundo";
            this.Text = "GridProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dgTipoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView GridTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlPeso;
    }
}