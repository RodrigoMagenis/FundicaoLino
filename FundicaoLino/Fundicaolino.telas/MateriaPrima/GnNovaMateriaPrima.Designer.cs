namespace Fundicaolino.telas.MateriaPrima
{
    partial class GnNovaMateriaPrima
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
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.tbIdMaterial = new System.Windows.Forms.TextBox();
            this.lbPesoMaterial = new System.Windows.Forms.Label();
            this.lbNomeMateriaL = new System.Windows.Forms.Label();
            this.lbIdMaterial = new System.Windows.Forms.Label();
            this.tbNmMaterial = new System.Windows.Forms.TextBox();
            this.tbPesoMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtSalvar
            // 
            this.BtSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvar.Location = new System.Drawing.Point(725, 22);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(74, 42);
            this.BtSalvar.TabIndex = 3;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.Location = new System.Drawing.Point(632, 22);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(73, 42);
            this.BtCancelar.TabIndex = 4;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // tbIdMaterial
            // 
            this.tbIdMaterial.Enabled = false;
            this.tbIdMaterial.Location = new System.Drawing.Point(266, 110);
            this.tbIdMaterial.Name = "tbIdMaterial";
            this.tbIdMaterial.Size = new System.Drawing.Size(121, 20);
            this.tbIdMaterial.TabIndex = 0;
            // 
            // lbPesoMaterial
            // 
            this.lbPesoMaterial.AutoSize = true;
            this.lbPesoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoMaterial.Location = new System.Drawing.Point(137, 202);
            this.lbPesoMaterial.Name = "lbPesoMaterial";
            this.lbPesoMaterial.Size = new System.Drawing.Size(112, 18);
            this.lbPesoMaterial.TabIndex = 13;
            this.lbPesoMaterial.Text = "Peso Material";
            // 
            // lbNomeMateriaL
            // 
            this.lbNomeMateriaL.AutoSize = true;
            this.lbNomeMateriaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeMateriaL.Location = new System.Drawing.Point(131, 157);
            this.lbNomeMateriaL.Name = "lbNomeMateriaL";
            this.lbNomeMateriaL.Size = new System.Drawing.Size(118, 18);
            this.lbNomeMateriaL.TabIndex = 14;
            this.lbNomeMateriaL.Text = "Nome Material";
            // 
            // lbIdMaterial
            // 
            this.lbIdMaterial.AutoSize = true;
            this.lbIdMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdMaterial.Location = new System.Drawing.Point(122, 110);
            this.lbIdMaterial.Name = "lbIdMaterial";
            this.lbIdMaterial.Size = new System.Drawing.Size(127, 18);
            this.lbIdMaterial.TabIndex = 15;
            this.lbIdMaterial.Text = "Codigo Material";
            // 
            // tbNmMaterial
            // 
            this.tbNmMaterial.Location = new System.Drawing.Point(266, 157);
            this.tbNmMaterial.Name = "tbNmMaterial";
            this.tbNmMaterial.Size = new System.Drawing.Size(121, 20);
            this.tbNmMaterial.TabIndex = 1;
            // 
            // tbPesoMaterial
            // 
            this.tbPesoMaterial.Location = new System.Drawing.Point(266, 200);
            this.tbPesoMaterial.Name = "tbPesoMaterial";
            this.tbPesoMaterial.Size = new System.Drawing.Size(121, 20);
            this.tbPesoMaterial.TabIndex = 2;
            // 
            // GnNovaMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 394);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.tbPesoMaterial);
            this.Controls.Add(this.tbNmMaterial);
            this.Controls.Add(this.tbIdMaterial);
            this.Controls.Add(this.lbPesoMaterial);
            this.Controls.Add(this.lbNomeMateriaL);
            this.Controls.Add(this.lbIdMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GnNovaMateriaPrima";
            this.Text = "GnNovaMateriaPrima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.TextBox tbIdMaterial;
        private System.Windows.Forms.Label lbPesoMaterial;
        private System.Windows.Forms.Label lbNomeMateriaL;
        private System.Windows.Forms.Label lbIdMaterial;
        private System.Windows.Forms.TextBox tbNmMaterial;
        private System.Windows.Forms.TextBox tbPesoMaterial;
    }
}