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
            this.NovoUsuario = new System.Windows.Forms.Label();
            this.NovoIdentificador = new System.Windows.Forms.Label();
            this.NovoNomeUsuario = new System.Windows.Forms.Label();
            this.NovoMatricula = new System.Windows.Forms.Label();
            this.NovoGrupodeAcesso = new System.Windows.Forms.Label();
            this.TxIdentificador = new System.Windows.Forms.TextBox();
            this.TxNomeUsuario = new System.Windows.Forms.TextBox();
            this.TxMatricula = new System.Windows.Forms.TextBox();
            this.TxGrupodeAcesso = new System.Windows.Forms.TextBox();
            this.CancelarNovoUsuario = new System.Windows.Forms.Button();
            this.SalvarNovoUsuario = new System.Windows.Forms.Button();
            this.BtAutoEncremento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NovoUsuario
            // 
            this.NovoUsuario.AutoSize = true;
            this.NovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoUsuario.Location = new System.Drawing.Point(148, 69);
            this.NovoUsuario.Name = "NovoUsuario";
            this.NovoUsuario.Size = new System.Drawing.Size(142, 25);
            this.NovoUsuario.TabIndex = 0;
            this.NovoUsuario.Text = "Novo Usuario";
            // 
            // NovoIdentificador
            // 
            this.NovoIdentificador.AutoSize = true;
            this.NovoIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoIdentificador.Location = new System.Drawing.Point(121, 127);
            this.NovoIdentificador.Name = "NovoIdentificador";
            this.NovoIdentificador.Size = new System.Drawing.Size(101, 20);
            this.NovoIdentificador.TabIndex = 0;
            this.NovoIdentificador.Text = "Identificador:";
            // 
            // NovoNomeUsuario
            // 
            this.NovoNomeUsuario.AutoSize = true;
            this.NovoNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoNomeUsuario.Location = new System.Drawing.Point(115, 160);
            this.NovoNomeUsuario.Name = "NovoNomeUsuario";
            this.NovoNomeUsuario.Size = new System.Drawing.Size(111, 20);
            this.NovoNomeUsuario.TabIndex = 0;
            this.NovoNomeUsuario.Text = "Nome usuário:";
            // 
            // NovoMatricula
            // 
            this.NovoMatricula.AutoSize = true;
            this.NovoMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoMatricula.Location = new System.Drawing.Point(149, 194);
            this.NovoMatricula.Name = "NovoMatricula";
            this.NovoMatricula.Size = new System.Drawing.Size(77, 20);
            this.NovoMatricula.TabIndex = 0;
            this.NovoMatricula.Text = "Matrícula:";
            // 
            // NovoGrupodeAcesso
            // 
            this.NovoGrupodeAcesso.AutoSize = true;
            this.NovoGrupodeAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoGrupodeAcesso.Location = new System.Drawing.Point(91, 231);
            this.NovoGrupodeAcesso.Name = "NovoGrupodeAcesso";
            this.NovoGrupodeAcesso.Size = new System.Drawing.Size(135, 20);
            this.NovoGrupodeAcesso.TabIndex = 0;
            this.NovoGrupodeAcesso.Text = "Grupo de acesso:";
            // 
            // TxIdentificador
            // 
            this.TxIdentificador.Location = new System.Drawing.Point(229, 126);
            this.TxIdentificador.Name = "TxIdentificador";
            this.TxIdentificador.Size = new System.Drawing.Size(89, 20);
            this.TxIdentificador.TabIndex = 1;
            this.TxIdentificador.TextChanged += new System.EventHandler(this.TxIdentificador_TextChanged);
            // 
            // TxNomeUsuario
            // 
            this.TxNomeUsuario.Location = new System.Drawing.Point(228, 160);
            this.TxNomeUsuario.Name = "TxNomeUsuario";
            this.TxNomeUsuario.Size = new System.Drawing.Size(176, 20);
            this.TxNomeUsuario.TabIndex = 1;
            // 
            // TxMatricula
            // 
            this.TxMatricula.Location = new System.Drawing.Point(228, 196);
            this.TxMatricula.Name = "TxMatricula";
            this.TxMatricula.Size = new System.Drawing.Size(176, 20);
            this.TxMatricula.TabIndex = 1;
            this.TxMatricula.TextChanged += new System.EventHandler(this.TxMatricula_TextChanged);
            // 
            // TxGrupodeAcesso
            // 
            this.TxGrupodeAcesso.Location = new System.Drawing.Point(228, 233);
            this.TxGrupodeAcesso.Name = "TxGrupodeAcesso";
            this.TxGrupodeAcesso.Size = new System.Drawing.Size(176, 20);
            this.TxGrupodeAcesso.TabIndex = 1;
            this.TxGrupodeAcesso.TextChanged += new System.EventHandler(this.TxGrupodeAcesso_TextChanged);
            // 
            // CancelarNovoUsuario
            // 
            this.CancelarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarNovoUsuario.Location = new System.Drawing.Point(558, 63);
            this.CancelarNovoUsuario.Name = "CancelarNovoUsuario";
            this.CancelarNovoUsuario.Size = new System.Drawing.Size(73, 42);
            this.CancelarNovoUsuario.TabIndex = 2;
            this.CancelarNovoUsuario.Text = "Cancelar";
            this.CancelarNovoUsuario.UseVisualStyleBackColor = true;
            this.CancelarNovoUsuario.Click += new System.EventHandler(this.CancelarNovoUsuario_Click);
            // 
            // SalvarNovoUsuario
            // 
            this.SalvarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarNovoUsuario.Location = new System.Drawing.Point(649, 63);
            this.SalvarNovoUsuario.Name = "SalvarNovoUsuario";
            this.SalvarNovoUsuario.Size = new System.Drawing.Size(74, 42);
            this.SalvarNovoUsuario.TabIndex = 2;
            this.SalvarNovoUsuario.Text = "Salvar";
            this.SalvarNovoUsuario.UseVisualStyleBackColor = true;
            // 
            // BtAutoEncremento
            // 
            this.BtAutoEncremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAutoEncremento.Location = new System.Drawing.Point(324, 121);
            this.BtAutoEncremento.Name = "BtAutoEncremento";
            this.BtAutoEncremento.Size = new System.Drawing.Size(73, 28);
            this.BtAutoEncremento.TabIndex = 2;
            this.BtAutoEncremento.Text = "AUTO";
            this.BtAutoEncremento.UseVisualStyleBackColor = true;
            this.BtAutoEncremento.Click += new System.EventHandler(this.BtAutoEncremento_Click);
            // 
            // GnUsuarioNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalvarNovoUsuario);
            this.Controls.Add(this.BtAutoEncremento);
            this.Controls.Add(this.CancelarNovoUsuario);
            this.Controls.Add(this.TxGrupodeAcesso);
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
            this.Text = "GnUsuarioNovo";
            this.Load += new System.EventHandler(this.GnUsuarioNovo_Load);
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
        private System.Windows.Forms.TextBox TxGrupodeAcesso;
        private System.Windows.Forms.Button CancelarNovoUsuario;
        private System.Windows.Forms.Button SalvarNovoUsuario;
        private System.Windows.Forms.Button BtAutoEncremento;
    }
}