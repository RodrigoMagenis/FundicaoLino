namespace Fundicaolino.telas
{
    partial class GridGrupo
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FgGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Id,
            this.NomeGrupo,
            this.FgGrupo});
            this.gnGridFrameUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnGridFrameUser.Location = new System.Drawing.Point(0, 0);
            this.gnGridFrameUser.Name = "gnGridFrameUser";
            this.gnGridFrameUser.ReadOnly = true;
            this.gnGridFrameUser.Size = new System.Drawing.Size(557, 409);
            this.gnGridFrameUser.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NomeGrupo
            // 
            this.NomeGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeGrupo.DataPropertyName = "NomeGrupo";
            this.NomeGrupo.HeaderText = "Nome grupo";
            this.NomeGrupo.Name = "NomeGrupo";
            this.NomeGrupo.ReadOnly = true;
            // 
            // FgGrupo
            // 
            this.FgGrupo.DataPropertyName = "FgGrupo";
            this.FgGrupo.HeaderText = "Status";
            this.FgGrupo.Name = "FgGrupo";
            this.FgGrupo.ReadOnly = true;
            this.FgGrupo.Width = 62;
            // 
            // GridGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 409);
            this.ControlBox = false;
            this.Controls.Add(this.gnGridFrameUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridGrupo";
            this.Text = "GnGridGroup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gnGridFrameUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gnGridFrameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FgGrupo;
    }
}