namespace Fundicaolino.telas
{
    partial class GnGridGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GnGridGroup));
            this.CancelarGerenciaGrupo = new System.Windows.Forms.Button();
            this.SalvarGerenciaGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListarGrupos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelarGerenciaGrupo
            // 
            resources.ApplyResources(this.CancelarGerenciaGrupo, "CancelarGerenciaGrupo");
            this.CancelarGerenciaGrupo.Name = "CancelarGerenciaGrupo";
            this.CancelarGerenciaGrupo.UseVisualStyleBackColor = true;
            this.CancelarGerenciaGrupo.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalvarGerenciaGrupo
            // 
            resources.ApplyResources(this.SalvarGerenciaGrupo, "SalvarGerenciaGrupo");
            this.SalvarGerenciaGrupo.Name = "SalvarGerenciaGrupo";
            this.SalvarGerenciaGrupo.UseVisualStyleBackColor = true;
            this.SalvarGerenciaGrupo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ListarGrupos
            // 
            this.ListarGrupos.FormattingEnabled = true;
            resources.ApplyResources(this.ListarGrupos, "ListarGrupos");
            this.ListarGrupos.Name = "ListarGrupos";
            // 
            // GnGridGroup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.Controls.Add(this.ListarGrupos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalvarGerenciaGrupo);
            this.Controls.Add(this.CancelarGerenciaGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GnGridGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarGerenciaGrupo;
        private System.Windows.Forms.Button SalvarGerenciaGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListarGrupos;
    }
}