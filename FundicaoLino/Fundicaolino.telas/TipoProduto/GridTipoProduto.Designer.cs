namespace Fundicaolino.telas
{
    partial class GridTipoProduto
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
            this.dgTipodeProduto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipodeProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTipodeProduto
            // 
            this.dgTipodeProduto.AllowUserToAddRows = false;
            this.dgTipodeProduto.AllowUserToDeleteRows = false;
            this.dgTipodeProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipodeProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NmTipoProduto,
            this.VlPeso});
            this.dgTipodeProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTipodeProduto.Location = new System.Drawing.Point(0, 0);
            this.dgTipodeProduto.Name = "dgTipodeProduto";
            this.dgTipodeProduto.ReadOnly = true;
            this.dgTipodeProduto.Size = new System.Drawing.Size(800, 450);
            this.dgTipodeProduto.TabIndex = 0;
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
            // GridTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgTipodeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridTipoProduto";
            this.Text = "GridProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridTipoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTipodeProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlPeso;
        public System.Windows.Forms.DataGridView dgTipodeProduto;
    }
}