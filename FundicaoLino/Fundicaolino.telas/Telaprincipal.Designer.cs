namespace Fundicaolino.telas
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GenericaProducao = new System.Windows.Forms.Label();
            this.Genericacontroleemtemporeal = new System.Windows.Forms.Button();
            this.btGerenciarProdutos = new System.Windows.Forms.Button();
            this.Genericacadastrarproduto = new System.Windows.Forms.Button();
            this.Genericacontrole = new System.Windows.Forms.Label();
            this.GenericaControleQualidade = new System.Windows.Forms.Button();
            this.Genericaexibirfiladeproducao = new System.Windows.Forms.Button();
            this.btCadastraMateriaPrima = new System.Windows.Forms.Button();
            this.btCadastraProducao = new System.Windows.Forms.Button();
            this.Genericacadastrarprocesso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GenericaControleProducao = new System.Windows.Forms.Button();
            this.Genericagerenciarusuario = new System.Windows.Forms.Button();
            this.Genericagerenciargrupo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenericaExluir = new System.Windows.Forms.Button();
            this.GenericaEditar = new System.Windows.Forms.Button();
            this.GeniricaAlterarsituacao = new System.Windows.Forms.Button();
            this.GenericoNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 559);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(220, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 477);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.GenericaProducao);
            this.panel3.Controls.Add(this.Genericacontroleemtemporeal);
            this.panel3.Controls.Add(this.btGerenciarProdutos);
            this.panel3.Controls.Add(this.Genericacadastrarproduto);
            this.panel3.Controls.Add(this.Genericacontrole);
            this.panel3.Controls.Add(this.GenericaControleQualidade);
            this.panel3.Controls.Add(this.Genericaexibirfiladeproducao);
            this.panel3.Controls.Add(this.btCadastraMateriaPrima);
            this.panel3.Controls.Add(this.btCadastraProducao);
            this.panel3.Controls.Add(this.Genericacadastrarprocesso);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.GenericaControleProducao);
            this.panel3.Controls.Add(this.Genericagerenciarusuario);
            this.panel3.Controls.Add(this.Genericagerenciargrupo);
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 477);
            this.panel3.TabIndex = 0;
            // 
            // GenericaProducao
            // 
            this.GenericaProducao.AutoSize = true;
            this.GenericaProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenericaProducao.Location = new System.Drawing.Point(12, 223);
            this.GenericaProducao.Name = "GenericaProducao";
            this.GenericaProducao.Size = new System.Drawing.Size(104, 25);
            this.GenericaProducao.TabIndex = 10;
            this.GenericaProducao.Text = "Produção";
            this.GenericaProducao.Click += new System.EventHandler(this.label2_Click);
            // 
            // Genericacontroleemtemporeal
            // 
            this.Genericacontroleemtemporeal.Location = new System.Drawing.Point(38, 433);
            this.Genericacontroleemtemporeal.Name = "Genericacontroleemtemporeal";
            this.Genericacontroleemtemporeal.Size = new System.Drawing.Size(163, 23);
            this.Genericacontroleemtemporeal.TabIndex = 8;
            this.Genericacontroleemtemporeal.Text = "Monitoramento em tempo real";
            this.Genericacontroleemtemporeal.UseVisualStyleBackColor = true;
            this.Genericacontroleemtemporeal.Click += new System.EventHandler(this.Genericacontroleemtemporeal_Click);
            // 
            // btGerenciarProdutos
            // 
            this.btGerenciarProdutos.Location = new System.Drawing.Point(38, 375);
            this.btGerenciarProdutos.Name = "btGerenciarProdutos";
            this.btGerenciarProdutos.Size = new System.Drawing.Size(163, 23);
            this.btGerenciarProdutos.TabIndex = 8;
            this.btGerenciarProdutos.Text = "Gerenciar Produto";
            this.btGerenciarProdutos.UseVisualStyleBackColor = true;
            this.btGerenciarProdutos.Click += new System.EventHandler(this.btGerenciarProdutos_Click);
            // 
            // Genericacadastrarproduto
            // 
            this.Genericacadastrarproduto.Location = new System.Drawing.Point(38, 346);
            this.Genericacadastrarproduto.Name = "Genericacadastrarproduto";
            this.Genericacadastrarproduto.Size = new System.Drawing.Size(163, 23);
            this.Genericacadastrarproduto.TabIndex = 8;
            this.Genericacadastrarproduto.Text = "Gerenciar Tipo Produto";
            this.Genericacadastrarproduto.UseVisualStyleBackColor = true;
            this.Genericacadastrarproduto.Click += new System.EventHandler(this.Genericacadastrarproduto_Click);
            // 
            // Genericacontrole
            // 
            this.Genericacontrole.AutoSize = true;
            this.Genericacontrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genericacontrole.Location = new System.Drawing.Point(12, 120);
            this.Genericacontrole.Name = "Genericacontrole";
            this.Genericacontrole.Size = new System.Drawing.Size(93, 25);
            this.Genericacontrole.TabIndex = 10;
            this.Genericacontrole.Text = "Controle";
            this.Genericacontrole.Click += new System.EventHandler(this.label2_Click);
            // 
            // GenericaControleQualidade
            // 
            this.GenericaControleQualidade.Location = new System.Drawing.Point(38, 177);
            this.GenericaControleQualidade.Name = "GenericaControleQualidade";
            this.GenericaControleQualidade.Size = new System.Drawing.Size(163, 23);
            this.GenericaControleQualidade.TabIndex = 8;
            this.GenericaControleQualidade.Text = "Qualidade";
            this.GenericaControleQualidade.UseVisualStyleBackColor = true;
            this.GenericaControleQualidade.Click += new System.EventHandler(this.GenericaControleQualidade_Click);
            // 
            // Genericaexibirfiladeproducao
            // 
            this.Genericaexibirfiladeproducao.Location = new System.Drawing.Point(38, 404);
            this.Genericaexibirfiladeproducao.Name = "Genericaexibirfiladeproducao";
            this.Genericaexibirfiladeproducao.Size = new System.Drawing.Size(163, 23);
            this.Genericaexibirfiladeproducao.TabIndex = 8;
            this.Genericaexibirfiladeproducao.Text = "Exibir fila de produção";
            this.Genericaexibirfiladeproducao.UseVisualStyleBackColor = true;
            this.Genericaexibirfiladeproducao.Click += new System.EventHandler(this.Genericaexibirfiladeproducao_Click);
            // 
            // btCadastraMateriaPrima
            // 
            this.btCadastraMateriaPrima.Location = new System.Drawing.Point(38, 288);
            this.btCadastraMateriaPrima.Name = "btCadastraMateriaPrima";
            this.btCadastraMateriaPrima.Size = new System.Drawing.Size(163, 23);
            this.btCadastraMateriaPrima.TabIndex = 8;
            this.btCadastraMateriaPrima.Text = "Gerenciar Materia Prima";
            this.btCadastraMateriaPrima.UseVisualStyleBackColor = true;
            this.btCadastraMateriaPrima.Click += new System.EventHandler(this.btCadastraMateriaPrima_Click);
            // 
            // btCadastraProducao
            // 
            this.btCadastraProducao.Location = new System.Drawing.Point(38, 259);
            this.btCadastraProducao.Name = "btCadastraProducao";
            this.btCadastraProducao.Size = new System.Drawing.Size(163, 23);
            this.btCadastraProducao.TabIndex = 8;
            this.btCadastraProducao.Text = "Gerenciar Produção";
            this.btCadastraProducao.UseVisualStyleBackColor = true;
            this.btCadastraProducao.Click += new System.EventHandler(this.btCadastraProducao_Click);
            // 
            // Genericacadastrarprocesso
            // 
            this.Genericacadastrarprocesso.Location = new System.Drawing.Point(38, 317);
            this.Genericacadastrarprocesso.Name = "Genericacadastrarprocesso";
            this.Genericacadastrarprocesso.Size = new System.Drawing.Size(163, 23);
            this.Genericacadastrarprocesso.TabIndex = 8;
            this.Genericacadastrarprocesso.Text = "Gerenciar Processo";
            this.Genericacadastrarprocesso.UseVisualStyleBackColor = true;
            this.Genericacadastrarprocesso.Click += new System.EventHandler(this.Genericacadastrarprocesso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Administração";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GenericaControleProducao
            // 
            this.GenericaControleProducao.Location = new System.Drawing.Point(38, 148);
            this.GenericaControleProducao.Name = "GenericaControleProducao";
            this.GenericaControleProducao.Size = new System.Drawing.Size(163, 23);
            this.GenericaControleProducao.TabIndex = 8;
            this.GenericaControleProducao.Text = "Produção";
            this.GenericaControleProducao.UseVisualStyleBackColor = true;
            this.GenericaControleProducao.Click += new System.EventHandler(this.GenericaControleProducao_Click);
            // 
            // Genericagerenciarusuario
            // 
            this.Genericagerenciarusuario.Location = new System.Drawing.Point(38, 72);
            this.Genericagerenciarusuario.Name = "Genericagerenciarusuario";
            this.Genericagerenciarusuario.Size = new System.Drawing.Size(163, 23);
            this.Genericagerenciarusuario.TabIndex = 8;
            this.Genericagerenciarusuario.Text = "Gerenciar Usuario";
            this.Genericagerenciarusuario.UseVisualStyleBackColor = true;
            this.Genericagerenciarusuario.Click += new System.EventHandler(this.Genericagerenciarusuario_Click);
            // 
            // Genericagerenciargrupo
            // 
            this.Genericagerenciargrupo.Location = new System.Drawing.Point(38, 43);
            this.Genericagerenciargrupo.Name = "Genericagerenciargrupo";
            this.Genericagerenciargrupo.Size = new System.Drawing.Size(163, 23);
            this.Genericagerenciargrupo.TabIndex = 8;
            this.Genericagerenciargrupo.Text = "Gerenciar grupo";
            this.Genericagerenciargrupo.UseVisualStyleBackColor = true;
            this.Genericagerenciargrupo.Click += new System.EventHandler(this.Genericagerenciargrupo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.GenericaExluir);
            this.panel2.Controls.Add(this.GenericaEditar);
            this.panel2.Controls.Add(this.GeniricaAlterarsituacao);
            this.panel2.Controls.Add(this.GenericoNovo);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 73);
            this.panel2.TabIndex = 0;
            // 
            // GenericaExluir
            // 
            this.GenericaExluir.Location = new System.Drawing.Point(413, 13);
            this.GenericaExluir.Name = "GenericaExluir";
            this.GenericaExluir.Size = new System.Drawing.Size(86, 46);
            this.GenericaExluir.TabIndex = 5;
            this.GenericaExluir.Text = "Excluir";
            this.GenericaExluir.UseVisualStyleBackColor = true;
            this.GenericaExluir.Click += new System.EventHandler(this.GenericaExluir_Click);
            // 
            // GenericaEditar
            // 
            this.GenericaEditar.Location = new System.Drawing.Point(321, 13);
            this.GenericaEditar.Name = "GenericaEditar";
            this.GenericaEditar.Size = new System.Drawing.Size(86, 46);
            this.GenericaEditar.TabIndex = 6;
            this.GenericaEditar.Text = "Editar";
            this.GenericaEditar.UseVisualStyleBackColor = true;
            // 
            // GeniricaAlterarsituacao
            // 
            this.GeniricaAlterarsituacao.Location = new System.Drawing.Point(505, 13);
            this.GeniricaAlterarsituacao.Name = "GeniricaAlterarsituacao";
            this.GeniricaAlterarsituacao.Size = new System.Drawing.Size(86, 46);
            this.GeniricaAlterarsituacao.TabIndex = 7;
            this.GeniricaAlterarsituacao.Text = "Alterar situação";
            this.GeniricaAlterarsituacao.UseVisualStyleBackColor = true;
            // 
            // GenericoNovo
            // 
            this.GenericoNovo.Location = new System.Drawing.Point(229, 13);
            this.GenericoNovo.Name = "GenericoNovo";
            this.GenericoNovo.Size = new System.Drawing.Size(86, 46);
            this.GenericoNovo.TabIndex = 8;
            this.GenericoNovo.Text = "Novo";
            this.GenericoNovo.UseVisualStyleBackColor = true;
            this.GenericoNovo.Click += new System.EventHandler(this.GenericoNovo_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 559);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Genericagerenciargrupo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GenericaExluir;
        private System.Windows.Forms.Button GenericaEditar;
        private System.Windows.Forms.Button GeniricaAlterarsituacao;
        private System.Windows.Forms.Button GenericoNovo;
        private System.Windows.Forms.Button Genericagerenciarusuario;
        private System.Windows.Forms.Label GenericaProducao;
        private System.Windows.Forms.Button Genericacontroleemtemporeal;
        private System.Windows.Forms.Button Genericacadastrarproduto;
        private System.Windows.Forms.Label Genericacontrole;
        private System.Windows.Forms.Button GenericaControleQualidade;
        private System.Windows.Forms.Button Genericaexibirfiladeproducao;
        private System.Windows.Forms.Button Genericacadastrarprocesso;
        private System.Windows.Forms.Button GenericaControleProducao;
        private System.Windows.Forms.Button btCadastraProducao;
        private System.Windows.Forms.Button btGerenciarProdutos;
        private System.Windows.Forms.Button btCadastraMateriaPrima;
    }
}



