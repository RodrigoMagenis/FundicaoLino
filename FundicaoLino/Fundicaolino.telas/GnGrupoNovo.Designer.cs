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
            this.XboxUsuario = new System.Windows.Forms.CheckBox();
            this.XboxControleProducao = new System.Windows.Forms.CheckBox();
            this.XboxControleQualidade = new System.Windows.Forms.CheckBox();
            this.XboxProducao = new System.Windows.Forms.CheckBox();
            this.XboxProcesso = new System.Windows.Forms.CheckBox();
            this.XboxProduto = new System.Windows.Forms.CheckBox();
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
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // XboxUsuario
            // 
            resources.ApplyResources(this.XboxUsuario, "XboxUsuario");
            this.XboxUsuario.Name = "XboxUsuario";
            this.XboxUsuario.UseVisualStyleBackColor = true;
            // 
            // XboxControleProducao
            // 
            resources.ApplyResources(this.XboxControleProducao, "XboxControleProducao");
            this.XboxControleProducao.Name = "XboxControleProducao";
            this.XboxControleProducao.UseVisualStyleBackColor = true;
            // 
            // XboxControleQualidade
            // 
            resources.ApplyResources(this.XboxControleQualidade, "XboxControleQualidade");
            this.XboxControleQualidade.Name = "XboxControleQualidade";
            this.XboxControleQualidade.UseVisualStyleBackColor = true;
            // 
            // XboxProducao
            // 
            resources.ApplyResources(this.XboxProducao, "XboxProducao");
            this.XboxProducao.Name = "XboxProducao";
            this.XboxProducao.UseVisualStyleBackColor = true;
            // 
            // XboxProcesso
            // 
            resources.ApplyResources(this.XboxProcesso, "XboxProcesso");
            this.XboxProcesso.Name = "XboxProcesso";
            this.XboxProcesso.UseVisualStyleBackColor = true;
            // 
            // XboxProduto
            // 
            resources.ApplyResources(this.XboxProduto, "XboxProduto");
            this.XboxProduto.Name = "XboxProduto";
            this.XboxProduto.UseVisualStyleBackColor = true;
            // 
            // GnGrupoNovo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.XboxProduto);
            this.Controls.Add(this.XboxProcesso);
            this.Controls.Add(this.XboxProducao);
            this.Controls.Add(this.XboxControleQualidade);
            this.Controls.Add(this.XboxControleProducao);
            this.Controls.Add(this.XboxUsuario);
            this.Controls.Add(this.TxNameGroup);
            this.Controls.Add(this.NmGroup);
            this.Controls.Add(this.NvGrupo);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GnGrupoNovo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label NvGrupo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label NmGroup;
        private System.Windows.Forms.TextBox TxNameGroup;
        private System.Windows.Forms.CheckBox XboxUsuario;
        private System.Windows.Forms.CheckBox XboxControleProducao;
        private System.Windows.Forms.CheckBox XboxControleQualidade;
        private System.Windows.Forms.CheckBox XboxProducao;
        private System.Windows.Forms.CheckBox XboxProcesso;
        private System.Windows.Forms.CheckBox XboxProduto;
    }
}