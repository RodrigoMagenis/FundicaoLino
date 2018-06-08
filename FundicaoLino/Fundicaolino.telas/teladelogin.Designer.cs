namespace Fundicaolino.telas
{
    partial class teladelogin
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
            this.TelaLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomeUsuario = new System.Windows.Forms.Label();
            this.SenhaUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TelaLogin
            // 
            this.TelaLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TelaLogin.Location = new System.Drawing.Point(299, 132);
            this.TelaLogin.Name = "TelaLogin";
            this.TelaLogin.Size = new System.Drawing.Size(222, 20);
            this.TelaLogin.TabIndex = 0;
            this.TelaLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.SenhaUsuario);
            this.panel1.Controls.Add(this.NomeUsuario);
            this.panel1.Location = new System.Drawing.Point(299, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 144);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.AutoSize = true;
            this.NomeUsuario.Location = new System.Drawing.Point(3, 37);
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Size = new System.Drawing.Size(89, 13);
            this.NomeUsuario.TabIndex = 0;
            this.NomeUsuario.Text = "Nome de Usuário";
            this.NomeUsuario.Click += new System.EventHandler(this.NomeUsuario_Click);
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.AutoSize = true;
            this.SenhaUsuario.Location = new System.Drawing.Point(3, 73);
            this.SenhaUsuario.Name = "SenhaUsuario";
            this.SenhaUsuario.Size = new System.Drawing.Size(89, 13);
            this.SenhaUsuario.TabIndex = 0;
            this.SenhaUsuario.Text = "Nome de Usuário";
            this.SenhaUsuario.Click += new System.EventHandler(this.NomeUsuario_Click);
            // 
            // teladelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TelaLogin);
            this.Name = "teladelogin";
            this.Text = "teladelogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TelaLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NomeUsuario;
        private System.Windows.Forms.Label SenhaUsuario;
    }
}