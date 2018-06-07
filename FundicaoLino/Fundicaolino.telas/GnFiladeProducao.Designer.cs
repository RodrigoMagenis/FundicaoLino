namespace Fundicaolino.telas
{
    partial class GnFiladeProducao
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
            this.gnGridFrameUser = new System.Windows.Forms.DataGridView();
            this.DtProducao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gnGridFrameUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gnGridFrameUser
            // 
            this.gnGridFrameUser.AllowUserToAddRows = false;
            this.gnGridFrameUser.AllowUserToDeleteRows = false;
            this.gnGridFrameUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gnGridFrameUser.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gnGridFrameUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gnGridFrameUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DtProducao,
            this.IdProducao,
            this.NmProduto,
            this.QtProduto});
            this.gnGridFrameUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnGridFrameUser.Location = new System.Drawing.Point(0, 0);
            this.gnGridFrameUser.Name = "gnGridFrameUser";
            this.gnGridFrameUser.ReadOnly = true;
            this.gnGridFrameUser.Size = new System.Drawing.Size(800, 450);
            this.gnGridFrameUser.TabIndex = 1;
            // 
            // DtProducao
            // 
            this.DtProducao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DtProducao.DataPropertyName = "DtProducao";
            this.DtProducao.HeaderText = "Data";
            this.DtProducao.Name = "DtProducao";
            this.DtProducao.ReadOnly = true;
            // 
            // IdProducao
            // 
            this.IdProducao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdProducao.DataPropertyName = "IdProducao";
            this.IdProducao.HeaderText = "Codigo Produção";
            this.IdProducao.Name = "IdProducao";
            this.IdProducao.ReadOnly = true;
            // 
            // NmProduto
            // 
            this.NmProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NmProduto.DataPropertyName = "NmProduto";
            this.NmProduto.HeaderText = "Nome Produto";
            this.NmProduto.Name = "NmProduto";
            this.NmProduto.ReadOnly = true;
            // 
            // QtProduto
            // 
            this.QtProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QtProduto.HeaderText = "Quantidade Produto";
            this.QtProduto.Name = "QtProduto";
            this.QtProduto.ReadOnly = true;
            // 
            // GnFiladeProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gnGridFrameUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GnFiladeProducao";
            this.Text = "GnFiladeProducao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gnGridFrameUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gnGridFrameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtProducao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtProduto;
    }
}