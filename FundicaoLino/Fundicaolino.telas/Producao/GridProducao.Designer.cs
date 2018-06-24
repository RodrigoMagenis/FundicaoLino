namespace Fundicaolino.telas
{
    partial class GridProducao
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
            this.QtProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtProducao = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.QtProduto,
            this.IdProcesso,
            this.DtProducao});
            this.dgProducao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProducao.Location = new System.Drawing.Point(0, 0);
            this.dgProducao.Name = "dgProducao";
            this.dgProducao.ReadOnly = true;
            this.dgProducao.Size = new System.Drawing.Size(800, 450);
            this.dgProducao.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // QtProduto
            // 
            this.QtProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QtProduto.DataPropertyName = "QtProduto";
            this.QtProduto.HeaderText = "Unidades";
            this.QtProduto.Name = "QtProduto";
            this.QtProduto.ReadOnly = true;
            // 
            // IdProcesso
            // 
            this.IdProcesso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdProcesso.DataPropertyName = "IdProcesso";
            this.IdProcesso.HeaderText = "Processo";
            this.IdProcesso.Name = "IdProcesso";
            this.IdProcesso.ReadOnly = true;
            // 
            // DtProducao
            // 
            this.DtProducao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DtProducao.DataPropertyName = "DtProducao";
            this.DtProducao.HeaderText = "Data produção";
            this.DtProducao.Name = "DtProducao";
            this.DtProducao.ReadOnly = true;
            // 
            // GridProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgProducao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridProducao";
            this.Text = "GridProducao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridProducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProducao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtProducao;
    }
}