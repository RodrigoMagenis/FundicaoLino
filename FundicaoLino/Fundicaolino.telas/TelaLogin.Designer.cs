namespace Fundicaolino.telas
{
    partial class TelaLogin
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
            this.TelaInferiorLogin = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EsqueciMinhaSenha = new System.Windows.Forms.LinkLabel();
            this.SenhaUsuario = new System.Windows.Forms.Label();
            this.NomeUsuario = new System.Windows.Forms.Label();
            this.SuperiorTelaLogin = new System.Windows.Forms.Panel();
            this.TelaInferiorLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // TelaInferiorLogin
            // 
            this.TelaInferiorLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TelaInferiorLogin.Controls.Add(this.btLogin);
            this.TelaInferiorLogin.Controls.Add(this.textBox2);
            this.TelaInferiorLogin.Controls.Add(this.textBox1);
            this.TelaInferiorLogin.Controls.Add(this.EsqueciMinhaSenha);
            this.TelaInferiorLogin.Controls.Add(this.SenhaUsuario);
            this.TelaInferiorLogin.Controls.Add(this.NomeUsuario);
            this.TelaInferiorLogin.Location = new System.Drawing.Point(242, 180);
            this.TelaInferiorLogin.Name = "TelaInferiorLogin";
            this.TelaInferiorLogin.Size = new System.Drawing.Size(266, 166);
            this.TelaInferiorLogin.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(175, 119);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // EsqueciMinhaSenha
            // 
            this.EsqueciMinhaSenha.Location = new System.Drawing.Point(13, 124);
            this.EsqueciMinhaSenha.Name = "EsqueciMinhaSenha";
            this.EsqueciMinhaSenha.Size = new System.Drawing.Size(108, 13);
            this.EsqueciMinhaSenha.TabIndex = 0;
            this.EsqueciMinhaSenha.TabStop = true;
            this.EsqueciMinhaSenha.Text = "Esqueci minha senha";
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.AutoSize = true;
            this.SenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaUsuario.Location = new System.Drawing.Point(76, 58);
            this.SenhaUsuario.Name = "SenhaUsuario";
            this.SenhaUsuario.Size = new System.Drawing.Size(54, 18);
            this.SenhaUsuario.TabIndex = 0;
            this.SenhaUsuario.Text = "Senha:";
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.AutoSize = true;
            this.NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeUsuario.Location = new System.Drawing.Point(3, 25);
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Size = new System.Drawing.Size(127, 18);
            this.NomeUsuario.TabIndex = 0;
            this.NomeUsuario.Text = "Nome do usuário:";
            // 
            // SuperiorTelaLogin
            // 
            this.SuperiorTelaLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SuperiorTelaLogin.Location = new System.Drawing.Point(242, 157);
            this.SuperiorTelaLogin.Name = "SuperiorTelaLogin";
            this.SuperiorTelaLogin.Size = new System.Drawing.Size(266, 26);
            this.SuperiorTelaLogin.TabIndex = 0;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SuperiorTelaLogin);
            this.Controls.Add(this.TelaInferiorLogin);
            this.Name = "TelaLogin";
            this.Text = "TelaLogin";
            this.TelaInferiorLogin.ResumeLayout(false);
            this.TelaInferiorLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TelaInferiorLogin;
        private System.Windows.Forms.Panel SuperiorTelaLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel EsqueciMinhaSenha;
        private System.Windows.Forms.Label SenhaUsuario;
        private System.Windows.Forms.Label NomeUsuario;
    }
}