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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxIdentificador
            // 
            this.TxIdentificador.Location = new System.Drawing.Point(252, 128);
            this.TxIdentificador.Name = "TxIdentificador";
            this.TxIdentificador.Size = new System.Drawing.Size(138, 20);
            this.TxIdentificador.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 128);
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
            this.label1.Location = new System.Drawing.Point(100, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Material";
            // 
            // TxNmProduto
            // 
            this.TxNmProduto.Location = new System.Drawing.Point(252, 166);
            this.TxNmProduto.Name = "TxNmProduto";
            this.TxNmProduto.Size = new System.Drawing.Size(138, 20);
            this.TxNmProduto.TabIndex = 10;
            // 
            // TxVlPeso
            // 
            this.TxVlPeso.Location = new System.Drawing.Point(252, 207);
            this.TxVlPeso.Name = "TxVlPeso";
            this.TxVlPeso.Size = new System.Drawing.Size(138, 20);
            this.TxVlPeso.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // CadastraTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}