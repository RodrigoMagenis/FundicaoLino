﻿namespace Fundicaolino.telas.Produto
{
    partial class GnProdutoNovo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbCodigoTipodeProduto = new System.Windows.Forms.ComboBox();
            this.lbCodigoTIpodeProduto = new System.Windows.Forms.Label();
            this.lbResponsavel = new System.Windows.Forms.Label();
            this.cbResponsavel = new System.Windows.Forms.ComboBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Produto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // cbCodigoTipodeProduto
            // 
            this.cbCodigoTipodeProduto.FormattingEnabled = true;
            this.cbCodigoTipodeProduto.Location = new System.Drawing.Point(212, 119);
            this.cbCodigoTipodeProduto.Name = "cbCodigoTipodeProduto";
            this.cbCodigoTipodeProduto.Size = new System.Drawing.Size(121, 21);
            this.cbCodigoTipodeProduto.TabIndex = 2;
            // 
            // lbCodigoTIpodeProduto
            // 
            this.lbCodigoTIpodeProduto.AutoSize = true;
            this.lbCodigoTIpodeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoTIpodeProduto.Location = new System.Drawing.Point(12, 119);
            this.lbCodigoTIpodeProduto.Name = "lbCodigoTIpodeProduto";
            this.lbCodigoTIpodeProduto.Size = new System.Drawing.Size(183, 18);
            this.lbCodigoTIpodeProduto.TabIndex = 0;
            this.lbCodigoTIpodeProduto.Text = "Codigo tipo de Produto";
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.AutoSize = true;
            this.lbResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResponsavel.Location = new System.Drawing.Point(90, 164);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(105, 18);
            this.lbResponsavel.TabIndex = 0;
            this.lbResponsavel.Text = "Responsavel";
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.FormattingEnabled = true;
            this.cbResponsavel.Location = new System.Drawing.Point(212, 165);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(121, 21);
            this.cbResponsavel.TabIndex = 2;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvar.Location = new System.Drawing.Point(688, 38);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(74, 42);
            this.BtSalvar.TabIndex = 12;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.Location = new System.Drawing.Point(585, 38);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(73, 42);
            this.BtCancelar.TabIndex = 11;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // GnProdutoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 445);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.cbResponsavel);
            this.Controls.Add(this.cbCodigoTipodeProduto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbResponsavel);
            this.Controls.Add(this.lbCodigoTIpodeProduto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GnProdutoNovo";
            this.Text = "GnProdutoNovo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbCodigoTipodeProduto;
        private System.Windows.Forms.Label lbCodigoTIpodeProduto;
        private System.Windows.Forms.Label lbResponsavel;
        private System.Windows.Forms.ComboBox cbResponsavel;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
    }
}