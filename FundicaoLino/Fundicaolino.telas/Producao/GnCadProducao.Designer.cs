namespace Fundicaolino.telas
{
    partial class GnCadProducao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelarCad = new System.Windows.Forms.Button();
            this.SalvarNovoUsuario = new System.Windows.Forms.Button();
            this.TxQuantidade = new System.Windows.Forms.TextBox();
            this.TxIdentificador = new System.Windows.Forms.TextBox();
            this.TxProcesso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Produção";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Produção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade";
            // 
            // CancelarCad
            // 
            this.CancelarCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarCad.Location = new System.Drawing.Point(556, 55);
            this.CancelarCad.Name = "CancelarCad";
            this.CancelarCad.Size = new System.Drawing.Size(73, 42);
            this.CancelarCad.TabIndex = 4;
            this.CancelarCad.Text = "Cancelar";
            this.CancelarCad.UseVisualStyleBackColor = true;
            this.CancelarCad.Click += new System.EventHandler(this.CancelarCad_Click);
            // 
            // SalvarNovoUsuario
            // 
            this.SalvarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarNovoUsuario.Location = new System.Drawing.Point(659, 55);
            this.SalvarNovoUsuario.Name = "SalvarNovoUsuario";
            this.SalvarNovoUsuario.Size = new System.Drawing.Size(74, 42);
            this.SalvarNovoUsuario.TabIndex = 3;
            this.SalvarNovoUsuario.Text = "Salvar";
            this.SalvarNovoUsuario.UseVisualStyleBackColor = true;
            this.SalvarNovoUsuario.Click += new System.EventHandler(this.SalvarNovoUsuario_Click);
            // 
            // TxQuantidade
            // 
            this.TxQuantidade.Location = new System.Drawing.Point(237, 183);
            this.TxQuantidade.Name = "TxQuantidade";
            this.TxQuantidade.Size = new System.Drawing.Size(138, 20);
            this.TxQuantidade.TabIndex = 1;
            // 
            // TxIdentificador
            // 
            this.TxIdentificador.Enabled = false;
            this.TxIdentificador.Location = new System.Drawing.Point(237, 153);
            this.TxIdentificador.Name = "TxIdentificador";
            this.TxIdentificador.Size = new System.Drawing.Size(138, 20);
            this.TxIdentificador.TabIndex = 0;
            // 
            // TxProcesso
            // 
            this.TxProcesso.Location = new System.Drawing.Point(237, 218);
            this.TxProcesso.Name = "TxProcesso";
            this.TxProcesso.Size = new System.Drawing.Size(138, 20);
            this.TxProcesso.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Processo";
            // 
            // GnCadProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalvarNovoUsuario);
            this.Controls.Add(this.CancelarCad);
            this.Controls.Add(this.TxProcesso);
            this.Controls.Add(this.TxQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxIdentificador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GnCadProducao";
            this.Text = "GnCadProducao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.GnCadProducao_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelarCad;
        private System.Windows.Forms.Button SalvarNovoUsuario;
        private System.Windows.Forms.TextBox TxQuantidade;
        private System.Windows.Forms.TextBox TxIdentificador;
        private System.Windows.Forms.TextBox TxProcesso;
        private System.Windows.Forms.Label label4;
    }
}