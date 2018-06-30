namespace Fundicaolino.telas
{
    partial class ConsultaResponsavel
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
            this.tbIdProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdProduto
            // 
            this.tbIdProduto.Location = new System.Drawing.Point(211, 57);
            this.tbIdProduto.Name = "tbIdProduto";
            this.tbIdProduto.Size = new System.Drawing.Size(100, 20);
            this.tbIdProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(602, 49);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Responsavel,
            this.date});
            this.dgProduto.Location = new System.Drawing.Point(238, 171);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.Size = new System.Drawing.Size(323, 220);
            this.dgProduto.TabIndex = 3;
            // 
            // Responsavel
            // 
            this.Responsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Responsavel.DataPropertyName = "Responsavel";
            this.Responsavel.HeaderText = "Responsavel";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "DtProduto";
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // ConsultaResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgProduto);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaResponsavel";
            this.Text = "ConsultaResponsavel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultaResponsavel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}