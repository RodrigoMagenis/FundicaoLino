namespace Fundicaolino.telas.Controle
{
    partial class GraficoProducao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mostragrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.mostragrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // mostragrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.mostragrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Data Inicio";
            this.mostragrafico.Legends.Add(legend1);
            this.mostragrafico.Location = new System.Drawing.Point(1, 92);
            this.mostragrafico.Name = "mostragrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Data Inicio";
            series1.Name = "Series1";
            this.mostragrafico.Series.Add(series1);
            this.mostragrafico.Size = new System.Drawing.Size(800, 357);
            this.mostragrafico.TabIndex = 0;
            this.mostragrafico.Text = "grafico";
            // 
            // GraficoProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostragrafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraficoProducao";
            this.Text = "GraficoProducao";
            ((System.ComponentModel.ISupportInitialize)(this.mostragrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mostragrafico;
    }
}