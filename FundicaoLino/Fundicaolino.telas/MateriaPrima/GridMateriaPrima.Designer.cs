namespace Fundicaolino.telas.MateriaPrima
{
    partial class GridMateriaPrima
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
            this.dgMateriaPrima = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtapaProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMateriaPrima
            // 
            this.dgMateriaPrima.AllowUserToAddRows = false;
            this.dgMateriaPrima.AllowUserToDeleteRows = false;
            this.dgMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NmProcesso,
            this.EtapaProcesso});
            this.dgMateriaPrima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMateriaPrima.Location = new System.Drawing.Point(0, 0);
            this.dgMateriaPrima.Name = "dgMateriaPrima";
            this.dgMateriaPrima.ReadOnly = true;
            this.dgMateriaPrima.Size = new System.Drawing.Size(801, 403);
            this.dgMateriaPrima.TabIndex = 1;
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
            this.NmProcesso.DataPropertyName = "NmMaterial";
            this.NmProcesso.HeaderText = "Nome Material";
            this.NmProcesso.Name = "NmProcesso";
            this.NmProcesso.ReadOnly = true;
            // 
            // EtapaProcesso
            // 
            this.EtapaProcesso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EtapaProcesso.DataPropertyName = "VlPesoMaterial";
            this.EtapaProcesso.HeaderText = "Peso Material";
            this.EtapaProcesso.Name = "EtapaProcesso";
            this.EtapaProcesso.ReadOnly = true;
            // 
            // GridMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 403);
            this.Controls.Add(this.dgMateriaPrima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridMateriaPrima";
            this.Text = "GridMateriaPrima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridMateriaPrima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriaPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtapaProcesso;
    }
}