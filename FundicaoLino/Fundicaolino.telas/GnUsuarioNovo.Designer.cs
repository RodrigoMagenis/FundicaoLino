﻿namespace Fundicaolino.telas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GnUsuarioNovo));
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NovoUsuario
            // 
            resources.ApplyResources(this.NovoUsuario, "NovoUsuario");
            this.NovoUsuario.Name = "NovoUsuario";
            // 
            // NovoIdentificador
            // 
            resources.ApplyResources(this.NovoIdentificador, "NovoIdentificador");
            this.NovoIdentificador.Name = "NovoIdentificador";
            // 
            // NovoNomeUsuario
            // 
            resources.ApplyResources(this.NovoNomeUsuario, "NovoNomeUsuario");
            this.NovoNomeUsuario.Name = "NovoNomeUsuario";
            // 
            // NovoMatricula
            // 
            resources.ApplyResources(this.NovoMatricula, "NovoMatricula");
            this.NovoMatricula.Name = "NovoMatricula";
            // 
            // NovoGrupodeAcesso
            // 
            resources.ApplyResources(this.NovoGrupodeAcesso, "NovoGrupodeAcesso");
            this.NovoGrupodeAcesso.Name = "NovoGrupodeAcesso";
            // 
            // TxIdentificador
            // 
            resources.ApplyResources(this.TxIdentificador, "TxIdentificador");
            this.TxIdentificador.Name = "TxIdentificador";
            // 
            // TxNomeUsuario
            // 
            resources.ApplyResources(this.TxNomeUsuario, "TxNomeUsuario");
            this.TxNomeUsuario.Name = "TxNomeUsuario";
            // 
            // TxMatricula
            // 
            resources.ApplyResources(this.TxMatricula, "TxMatricula");
            this.TxMatricula.Name = "TxMatricula";
            // 
            // TxGrupodeAcesso
            // 
            resources.ApplyResources(this.TxGrupodeAcesso, "TxGrupodeAcesso");
            this.TxGrupodeAcesso.Name = "TxGrupodeAcesso";
            // 
            // CancelarNovoUsuario
            // 
            resources.ApplyResources(this.CancelarNovoUsuario, "CancelarNovoUsuario");
            this.CancelarNovoUsuario.Name = "CancelarNovoUsuario";
            this.CancelarNovoUsuario.UseVisualStyleBackColor = true;
            this.CancelarNovoUsuario.Click += new System.EventHandler(this.CancelarNovoUsuario_Click);
            // 
            // SalvarNovoUsuario
            // 
            resources.ApplyResources(this.SalvarNovoUsuario, "SalvarNovoUsuario");
            this.SalvarNovoUsuario.Name = "SalvarNovoUsuario";
            this.SalvarNovoUsuario.UseVisualStyleBackColor = true;
            this.SalvarNovoUsuario.Click += new System.EventHandler(this.SalvarNovoUsuario_Click);
            // 
            // BtAutoEncremento
            // 
            resources.ApplyResources(this.BtAutoEncremento, "BtAutoEncremento");
            this.BtAutoEncremento.Name = "BtAutoEncremento";
            this.BtAutoEncremento.UseVisualStyleBackColor = true;
            this.BtAutoEncremento.Click += new System.EventHandler(this.BtAutoEncremento_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtAutoEncremento_Click);
            // 
            // GnUsuarioNovo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalvarNovoUsuario);
            this.Controls.Add(this.button1);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button button1;
    }
}