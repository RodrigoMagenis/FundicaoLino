namespace Fundicaolino.telas.Controle
{
    partial class GraficoProdutosProduzidos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.ProducaoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.XboxFiltroPorResponsavel = new System.Windows.Forms.CheckBox();
            this.CbResponsavel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProducaoChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data inicial";
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(679, 23);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 37);
            this.Pesquisar.TabIndex = 2;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // ProducaoChart
            // 
            this.ProducaoChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.ProducaoChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ProducaoChart.Legends.Add(legend2);
            this.ProducaoChart.Location = new System.Drawing.Point(12, 100);
            this.ProducaoChart.Name = "ProducaoChart";
            this.ProducaoChart.Size = new System.Drawing.Size(776, 329);
            this.ProducaoChart.TabIndex = 3;
            this.ProducaoChart.Text = "chart1";
            // 
            // dpDataInicial
            // 
            this.dpDataInicial.Location = new System.Drawing.Point(77, 29);
            this.dpDataInicial.Name = "dpDataInicial";
            this.dpDataInicial.Size = new System.Drawing.Size(230, 20);
            this.dpDataInicial.TabIndex = 4;
            // 
            // dpDataFinal
            // 
            this.dpDataFinal.Location = new System.Drawing.Point(391, 29);
            this.dpDataFinal.Name = "dpDataFinal";
            this.dpDataFinal.Size = new System.Drawing.Size(232, 20);
            this.dpDataFinal.TabIndex = 4;
            // 
            // XboxFiltroPorResponsavel
            // 
            this.XboxFiltroPorResponsavel.AutoSize = true;
            this.XboxFiltroPorResponsavel.Location = new System.Drawing.Point(15, 65);
            this.XboxFiltroPorResponsavel.Name = "XboxFiltroPorResponsavel";
            this.XboxFiltroPorResponsavel.Size = new System.Drawing.Size(129, 17);
            this.XboxFiltroPorResponsavel.TabIndex = 5;
            this.XboxFiltroPorResponsavel.Text = "Filtrar por responsável";
            this.XboxFiltroPorResponsavel.UseVisualStyleBackColor = true;
            this.XboxFiltroPorResponsavel.CheckedChanged += new System.EventHandler(this.XboxFiltroPorResponsavel_CheckedChanged);
            // 
            // CbResponsavel
            // 
            this.CbResponsavel.Enabled = false;
            this.CbResponsavel.FormattingEnabled = true;
            this.CbResponsavel.Location = new System.Drawing.Point(151, 65);
            this.CbResponsavel.Name = "CbResponsavel";
            this.CbResponsavel.Size = new System.Drawing.Size(156, 21);
            this.CbResponsavel.TabIndex = 6;
            // 
            // GraficoProdutosProduzidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbResponsavel);
            this.Controls.Add(this.XboxFiltroPorResponsavel);
            this.Controls.Add(this.dpDataFinal);
            this.Controls.Add(this.dpDataInicial);
            this.Controls.Add(this.ProducaoChart);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraficoProdutosProduzidos";
            this.Text = "GraficoProdutosProduzidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GraficoProdutosProduzidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProducaoChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProducaoChart;
        private System.Windows.Forms.DateTimePicker dpDataInicial;
        private System.Windows.Forms.DateTimePicker dpDataFinal;
        private System.Windows.Forms.CheckBox XboxFiltroPorResponsavel;
        private System.Windows.Forms.ComboBox CbResponsavel;
    }
}