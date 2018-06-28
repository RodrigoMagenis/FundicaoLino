namespace Fundicaolino.telas
{
    partial class CadastraTipoProduto
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
            this.TxIdentificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSalvarProcesso = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxNmProduto = new System.Windows.Forms.TextBox();
            this.TxVlPeso = new System.Windows.Forms.TextBox();
            this.dgGruposExistentes = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btEsquerdo = new System.Windows.Forms.Button();
            this.btDireita = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgGruposExistentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxIdentificador
            // 
            this.TxIdentificador.Location = new System.Drawing.Point(230, 82);
            this.TxIdentificador.Name = "TxIdentificador";
            this.TxIdentificador.Size = new System.Drawing.Size(138, 20);
            this.TxIdentificador.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Codigo tipo de Produto";
            // 
            // btSalvarProcesso
            // 
            this.btSalvarProcesso.Location = new System.Drawing.Point(651, 49);
            this.btSalvarProcesso.Name = "btSalvarProcesso";
            this.btSalvarProcesso.Size = new System.Drawing.Size(84, 42);
            this.btSalvarProcesso.TabIndex = 8;
            this.btSalvarProcesso.Text = "Salvar";
            this.btSalvarProcesso.UseVisualStyleBackColor = true;
            this.btSalvarProcesso.Click += new System.EventHandler(this.btSalvarProcesso_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(539, 49);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(83, 42);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Materiais";
            // 
            // TxNmProduto
            // 
            this.TxNmProduto.Location = new System.Drawing.Point(230, 120);
            this.TxNmProduto.Name = "TxNmProduto";
            this.TxNmProduto.Size = new System.Drawing.Size(138, 20);
            this.TxNmProduto.TabIndex = 10;
            // 
            // TxVlPeso
            // 
            this.TxVlPeso.Location = new System.Drawing.Point(230, 161);
            this.TxVlPeso.Name = "TxVlPeso";
            this.TxVlPeso.Size = new System.Drawing.Size(138, 20);
            this.TxVlPeso.TabIndex = 10;
            // 
            // dgGruposExistentes
            // 
            this.dgGruposExistentes.AllowUserToAddRows = false;
            this.dgGruposExistentes.AllowUserToDeleteRows = false;
            this.dgGruposExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGruposExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGruposExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgGruposExistentes.Location = new System.Drawing.Point(222, 206);
            this.dgGruposExistentes.Name = "dgGruposExistentes";
            this.dgGruposExistentes.ReadOnly = true;
            this.dgGruposExistentes.Size = new System.Drawing.Size(181, 204);
            this.dgGruposExistentes.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(504, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(187, 204);
            this.dataGridView2.TabIndex = 14;
            // 
            // btEsquerdo
            // 
            this.btEsquerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btEsquerdo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btEsquerdo.Location = new System.Drawing.Point(441, 308);
            this.btEsquerdo.Name = "btEsquerdo";
            this.btEsquerdo.Size = new System.Drawing.Size(29, 28);
            this.btEsquerdo.TabIndex = 11;
            this.btEsquerdo.Text = "<";
            this.btEsquerdo.UseVisualStyleBackColor = true;
            // 
            // btDireita
            // 
            this.btDireita.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btDireita.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btDireita.Location = new System.Drawing.Point(441, 263);
            this.btDireita.Name = "btDireita";
            this.btDireita.Size = new System.Drawing.Size(29, 28);
            this.btDireita.TabIndex = 12;
            this.btDireita.Text = ">";
            this.btDireita.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Materiais Existentes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Materiais Selecionados";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // CadastraTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgGruposExistentes);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btEsquerdo);
            this.Controls.Add(this.btDireita);
            this.Controls.Add(this.TxVlPeso);
            this.Controls.Add(this.TxNmProduto);
            this.Controls.Add(this.TxIdentificador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSalvarProcesso);
            this.Controls.Add(this.btCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastraTipoProduto";
            this.Text = "CadastraProducao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgGruposExistentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxIdentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSalvarProcesso;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxNmProduto;
        private System.Windows.Forms.TextBox TxVlPeso;
        private System.Windows.Forms.DataGridView dgGruposExistentes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btEsquerdo;
        private System.Windows.Forms.Button btDireita;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}