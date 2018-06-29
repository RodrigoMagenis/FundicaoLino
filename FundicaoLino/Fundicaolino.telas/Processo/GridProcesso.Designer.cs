namespace Fundicaolino.telas
{
    partial class GridProcesso
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
            this.dgProcesso = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtapaProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProcesso
            // 
            this.dgProcesso.AllowUserToAddRows = false;
            this.dgProcesso.AllowUserToDeleteRows = false;
            this.dgProcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcesso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NmProcesso,
            this.EtapaProcesso});
            this.dgProcesso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProcesso.Location = new System.Drawing.Point(0, 0);
            this.dgProcesso.Name = "dgProcesso";
            this.dgProcesso.ReadOnly = true;
            this.dgProcesso.Size = new System.Drawing.Size(800, 450);
            this.dgProcesso.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NmProcesso
            // 
            this.NmProcesso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NmProcesso.DataPropertyName = "NmProcesso";
            this.NmProcesso.HeaderText = "Nome Processo";
            this.NmProcesso.Name = "NmProcesso";
            this.NmProcesso.ReadOnly = true;
            // 
            // EtapaProcesso
            // 
            this.EtapaProcesso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EtapaProcesso.DataPropertyName = "EtapaProcesso";
            this.EtapaProcesso.HeaderText = "Etapa";
            this.EtapaProcesso.Name = "EtapaProcesso";
            this.EtapaProcesso.ReadOnly = true;
            // 
            // GridProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgProcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridProcesso";
            this.Text = "GridUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridProcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProcesso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtapaProcesso;
        public System.Windows.Forms.DataGridView dgProcesso;
    }
}