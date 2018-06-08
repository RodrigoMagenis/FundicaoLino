﻿namespace Fundicaolino.telas
{
    partial class GridUsuario
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.gnGridFrameUser = new System.Windows.Forms.DataGridView();
            this.gnGridPanelUser = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FgUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnGridFrameUser)).BeginInit();
            this.gnGridPanelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gnGridFrameUser
            // 
            this.gnGridFrameUser.AllowUserToAddRows = false;
            this.gnGridFrameUser.AllowUserToDeleteRows = false;
            this.gnGridFrameUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gnGridFrameUser.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gnGridFrameUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gnGridFrameUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NmUsuario,
            this.IdMatricula,
            this.IdGrupo,
            this.NmLogin,
            this.FgUsuario});
            this.gnGridFrameUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnGridFrameUser.Location = new System.Drawing.Point(0, 0);
            this.gnGridFrameUser.Name = "gnGridFrameUser";
            this.gnGridFrameUser.ReadOnly = true;
            this.gnGridFrameUser.Size = new System.Drawing.Size(557, 409);
            this.gnGridFrameUser.TabIndex = 0;
            // 
            // gnGridPanelUser
            // 
            this.gnGridPanelUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gnGridPanelUser.Controls.Add(this.gnGridFrameUser);
            this.gnGridPanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnGridPanelUser.Location = new System.Drawing.Point(0, 0);
            this.gnGridPanelUser.Name = "gnGridPanelUser";
            this.gnGridPanelUser.Size = new System.Drawing.Size(557, 409);
            this.gnGridPanelUser.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NmUsuario
            // 
            this.NmUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NmUsuario.DataPropertyName = "NmUsuario";
            this.NmUsuario.HeaderText = "Nome de Usuário";
            this.NmUsuario.Name = "NmUsuario";
            this.NmUsuario.ReadOnly = true;
            // 
            // IdMatricula
            // 
            this.IdMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdMatricula.DataPropertyName = "IdMatricula";
            this.IdMatricula.HeaderText = "Matrícula";
            this.IdMatricula.Name = "IdMatricula";
            this.IdMatricula.ReadOnly = true;
            // 
            // IdGrupo
            // 
            this.IdGrupo.DataPropertyName = "IdGrupo";
            this.IdGrupo.HeaderText = "Grupo";
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.ReadOnly = true;
            // 
            // NmLogin
            // 
            this.NmLogin.DataPropertyName = "NmLogin";
            this.NmLogin.HeaderText = "Login";
            this.NmLogin.Name = "NmLogin";
            this.NmLogin.ReadOnly = true;
            // 
            // FgUsuario
            // 
            this.FgUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FgUsuario.HeaderText = "Status";
            this.FgUsuario.Name = "FgUsuario";
            this.FgUsuario.ReadOnly = true;
            // 
            // GridUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(557, 409);
            this.Controls.Add(this.gnGridPanelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GridUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GridUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnGridFrameUser)).EndInit();
            this.gnGridPanelUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel gnGridPanelUser;
        private System.Windows.Forms.DataGridView gnGridFrameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn FgUsuario;
    }
}