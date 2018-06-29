namespace Fundicaolino.telas.Controle
{
    partial class ConsultarResponsavel
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
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbNumeroProduto = new System.Windows.Forms.TextBox();
            this.nmproduto = new System.Windows.Forms.Label();
            this.tbCodigoResponsavel = new System.Windows.Forms.TextBox();
            this.tbNomeResponsavel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(337, 117);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(61, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // tbNumeroProduto
            // 
            this.tbNumeroProduto.Location = new System.Drawing.Point(219, 120);
            this.tbNumeroProduto.Name = "tbNumeroProduto";
            this.tbNumeroProduto.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroProduto.TabIndex = 1;
            // 
            // nmproduto
            // 
            this.nmproduto.AutoSize = true;
            this.nmproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmproduto.Location = new System.Drawing.Point(107, 121);
            this.nmproduto.Name = "nmproduto";
            this.nmproduto.Size = new System.Drawing.Size(109, 16);
            this.nmproduto.TabIndex = 2;
            this.nmproduto.Text = "Numero Produto:";
            // 
            // tbCodigoResponsavel
            // 
            this.tbCodigoResponsavel.Enabled = false;
            this.tbCodigoResponsavel.Location = new System.Drawing.Point(219, 213);
            this.tbCodigoResponsavel.Name = "tbCodigoResponsavel";
            this.tbCodigoResponsavel.ReadOnly = true;
            this.tbCodigoResponsavel.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoResponsavel.TabIndex = 1;
            // 
            // tbNomeResponsavel
            // 
            this.tbNomeResponsavel.Enabled = false;
            this.tbNomeResponsavel.Location = new System.Drawing.Point(219, 239);
            this.tbNomeResponsavel.Name = "tbNomeResponsavel";
            this.tbNomeResponsavel.ReadOnly = true;
            this.tbNomeResponsavel.Size = new System.Drawing.Size(100, 20);
            this.tbNomeResponsavel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Responsavel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Responsavel:";
            // 
            // ConsultarResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmproduto);
            this.Controls.Add(this.tbNomeResponsavel);
            this.Controls.Add(this.tbCodigoResponsavel);
            this.Controls.Add(this.tbNumeroProduto);
            this.Controls.Add(this.btPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarResponsavel";
            this.Text = "ConsultarResponsavel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbNumeroProduto;
        private System.Windows.Forms.Label nmproduto;
        private System.Windows.Forms.TextBox tbCodigoResponsavel;
        private System.Windows.Forms.TextBox tbNomeResponsavel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}