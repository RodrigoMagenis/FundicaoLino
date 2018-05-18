namespace Fundicaolino.telas
{
    partial class GnGrupoNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GnGrupoNovo));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.NvGrupo = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.NmGroup = new System.Windows.Forms.Label();
            this.TxNameGroup = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TelaExistentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelasHabilitadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // NvGrupo
            // 
            resources.ApplyResources(this.NvGrupo, "NvGrupo");
            this.NvGrupo.Name = "NvGrupo";
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // NmGroup
            // 
            resources.ApplyResources(this.NmGroup, "NmGroup");
            this.NmGroup.Name = "NmGroup";
            // 
            // TxNameGroup
            // 
            resources.ApplyResources(this.TxNameGroup, "TxNameGroup");
            this.TxNameGroup.Name = "TxNameGroup";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TelaExistentes,
            this.TelasHabilitadas});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // TelaExistentes
            // 
            resources.ApplyResources(this.TelaExistentes, "TelaExistentes");
            this.TelaExistentes.Name = "TelaExistentes";
            // 
            // TelasHabilitadas
            // 
            resources.ApplyResources(this.TelasHabilitadas, "TelasHabilitadas");
            this.TelasHabilitadas.Name = "TelasHabilitadas";
            // 
            // GrupoNovo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxNameGroup);
            this.Controls.Add(this.NmGroup);
            this.Controls.Add(this.NvGrupo);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrupoNovo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label NvGrupo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label NmGroup;
        private System.Windows.Forms.TextBox TxNameGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelaExistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelasHabilitadas;
    }
}