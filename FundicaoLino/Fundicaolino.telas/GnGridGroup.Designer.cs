namespace Fundicaolino.telas
{
    partial class GnGridGroup
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
            this.gnGridFrameUser = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmGroupUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gnGridFrameUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gnGridFrameUser
            // 
            this.gnGridFrameUser.AllowUserToAddRows = false;
            this.gnGridFrameUser.AllowUserToDeleteRows = false;
            this.gnGridFrameUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.gnGridFrameUser.TabIndex = 1;
            // 
            // idUser
            // 
            this.idUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idUser.HeaderText = "Matrícula";
            this.idUser.Name = "idUser";
            this.idUser.ReadOnly = true;
            // 
            // nmUser
            // 
            this.nmUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmUser.HeaderText = "Nome de Usuário";
            this.nmUser.Name = "nmUser";
            this.nmUser.ReadOnly = true;
            // 
            // nmGroupUser
            // 
            this.nmGroupUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmGroupUser.HeaderText = "Grupo de acesso";
            this.nmGroupUser.Name = "nmGroupUser";
            this.nmGroupUser.ReadOnly = true;
            // 
            // GnGridGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 409);
            this.ControlBox = false;
            this.Controls.Add(this.gnGridFrameUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GnGridGroup";
            this.Text = "GnGridGroup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gnGridFrameUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gnGridFrameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmGroupUser;
    }
}