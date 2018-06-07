namespace Fundicaolino.telas
{
    partial class GnGridUser
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
            this.nmGroupUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnGridPanelUser = new System.Windows.Forms.Panel();
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
            this.idUser,
            this.nmUser,
            this.nmGroupUser});
            this.gnGridFrameUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnGridFrameUser.Location = new System.Drawing.Point(0, 0);
            this.gnGridFrameUser.Name = "gnGridFrameUser";
            this.gnGridFrameUser.ReadOnly = true;
            this.gnGridFrameUser.Size = new System.Drawing.Size(557, 409);
            this.gnGridFrameUser.TabIndex = 0;
            // 
            // nmGroupUser
            // 
            this.nmGroupUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmGroupUser.HeaderText = "Grupo de acesso";
            this.nmGroupUser.Name = "nmGroupUser";
            this.nmGroupUser.ReadOnly = true;
            // 
            // nmUser
            // 
            this.nmUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmUser.HeaderText = "Nome de Usuário";
            this.nmUser.Name = "nmUser";
            this.nmUser.ReadOnly = true;
            // 
            // idUser
            // 
            this.idUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idUser.HeaderText = "Matrícula";
            this.idUser.Name = "idUser";
            this.idUser.ReadOnly = true;
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
            // GnGridUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(557, 409);
            this.Controls.Add(this.gnGridPanelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GnGridUser";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmGroupUser;
    }
}