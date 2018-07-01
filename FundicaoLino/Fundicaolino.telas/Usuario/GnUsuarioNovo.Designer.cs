namespace Fundicaolino.telas
{
    partial class GnUsuarioNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GnUsuarioNovo));
            this.NovoUsuario = new System.Windows.Forms.Label();
            this.NovoIdentificador = new System.Windows.Forms.Label();
            this.NovoNomeUsuario = new System.Windows.Forms.Label();
            this.NovoMatricula = new System.Windows.Forms.Label();
            this.NovoGrupodeAcesso = new System.Windows.Forms.Label();
            this.TxIdentificador = new System.Windows.Forms.TextBox();
            this.TxNomeUsuario = new System.Windows.Forms.TextBox();
            this.TxMatricula = new System.Windows.Forms.TextBox();
            this.CancelarNovoUsuario = new System.Windows.Forms.Button();
            this.SalvarNovoUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgGruposSelecionados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGruposExistentes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDireita = new System.Windows.Forms.Button();
            this.btEsquerdo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGruposSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGruposExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // NovoUsuario
            // 
            resources.ApplyResources(this.NovoUsuario, "NovoUsuario");
            this.NovoUsuario.Name = "NovoUsuario";
            // 
            // NovoIdentificador
            // 
            resources.ApplyResources(this.NovoIdentificador, "NovoIdentificador");
            this.NovoIdentificador.Name = "NovoIdentificador";
            // 
            // NovoNomeUsuario
            // 
            resources.ApplyResources(this.NovoNomeUsuario, "NovoNomeUsuario");
            this.NovoNomeUsuario.Name = "NovoNomeUsuario";
            // 
            // NovoMatricula
            // 
            resources.ApplyResources(this.NovoMatricula, "NovoMatricula");
            this.NovoMatricula.Name = "NovoMatricula";
            // 
            // NovoGrupodeAcesso
            // 
            resources.ApplyResources(this.NovoGrupodeAcesso, "NovoGrupodeAcesso");
            this.NovoGrupodeAcesso.Name = "NovoGrupodeAcesso";
            // 
            // TxIdentificador
            // 
            resources.ApplyResources(this.TxIdentificador, "TxIdentificador");
            this.TxIdentificador.Name = "TxIdentificador";
            // 
            // TxNomeUsuario
            // 
            resources.ApplyResources(this.TxNomeUsuario, "TxNomeUsuario");
            this.TxNomeUsuario.Name = "TxNomeUsuario";
            // 
            // TxMatricula
            // 
            resources.ApplyResources(this.TxMatricula, "TxMatricula");
            this.TxMatricula.Name = "TxMatricula";
            // 
            // CancelarNovoUsuario
            // 
            resources.ApplyResources(this.CancelarNovoUsuario, "CancelarNovoUsuario");
            this.CancelarNovoUsuario.Name = "CancelarNovoUsuario";
            this.CancelarNovoUsuario.UseVisualStyleBackColor = true;
            this.CancelarNovoUsuario.Click += new System.EventHandler(this.CancelarNovoUsuario_Click);
            // 
            // SalvarNovoUsuario
            // 
            resources.ApplyResources(this.SalvarNovoUsuario, "SalvarNovoUsuario");
            this.SalvarNovoUsuario.Name = "SalvarNovoUsuario";
            this.SalvarNovoUsuario.UseVisualStyleBackColor = true;
            this.SalvarNovoUsuario.Click += new System.EventHandler(this.SalvarNovoUsuario_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtAutoEncremento_Click);
            // 
            // dgGruposSelecionados
            // 
            this.dgGruposSelecionados.AllowUserToAddRows = false;
            this.dgGruposSelecionados.AllowUserToDeleteRows = false;
            this.dgGruposSelecionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGruposSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGruposSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            resources.ApplyResources(this.dgGruposSelecionados, "dgGruposSelecionados");
            this.dgGruposSelecionados.Name = "dgGruposSelecionados";
            this.dgGruposSelecionados.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgGruposExistentes
            // 
            this.dgGruposExistentes.AllowUserToAddRows = false;
            this.dgGruposExistentes.AllowUserToDeleteRows = false;
            this.dgGruposExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGruposExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGruposExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            resources.ApplyResources(this.dgGruposExistentes, "dgGruposExistentes");
            this.dgGruposExistentes.Name = "dgGruposExistentes";
            this.dgGruposExistentes.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btDireita
            // 
            resources.ApplyResources(this.btDireita, "btDireita");
            this.btDireita.Name = "btDireita";
            this.btDireita.UseVisualStyleBackColor = true;
            this.btDireita.Click += new System.EventHandler(this.BtAutoEncremento_Click);
            // 
            // btEsquerdo
            // 
            resources.ApplyResources(this.btEsquerdo, "btEsquerdo");
            this.btEsquerdo.Name = "btEsquerdo";
            this.btEsquerdo.UseVisualStyleBackColor = true;
            this.btEsquerdo.Click += new System.EventHandler(this.BtAutoEncremento_Click);
            // 
            // GnUsuarioNovo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgGruposExistentes);
            this.Controls.Add(this.dgGruposSelecionados);
            this.Controls.Add(this.SalvarNovoUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEsquerdo);
            this.Controls.Add(this.btDireita);
            this.Controls.Add(this.CancelarNovoUsuario);
            this.Controls.Add(this.TxMatricula);
            this.Controls.Add(this.TxNomeUsuario);
            this.Controls.Add(this.TxIdentificador);
            this.Controls.Add(this.NovoGrupodeAcesso);
            this.Controls.Add(this.NovoMatricula);
            this.Controls.Add(this.NovoNomeUsuario);
            this.Controls.Add(this.NovoIdentificador);
            this.Controls.Add(this.NovoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GnUsuarioNovo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GnUsuarioNovo_Load);
            this.Shown += new System.EventHandler(this.GnUsuarioNovo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgGruposSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGruposExistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NovoUsuario;
        private System.Windows.Forms.Label NovoIdentificador;
        private System.Windows.Forms.Label NovoNomeUsuario;
        private System.Windows.Forms.Label NovoMatricula;
        private System.Windows.Forms.Label NovoGrupodeAcesso;
        private System.Windows.Forms.TextBox TxIdentificador;
        private System.Windows.Forms.TextBox TxNomeUsuario;
        private System.Windows.Forms.TextBox TxMatricula;
        private System.Windows.Forms.Button CancelarNovoUsuario;
        private System.Windows.Forms.Button SalvarNovoUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgGruposSelecionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgGruposExistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btDireita;
        private System.Windows.Forms.Button btEsquerdo;
    }
}