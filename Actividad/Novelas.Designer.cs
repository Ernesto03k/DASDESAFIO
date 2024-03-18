namespace Actividad
{
    partial class Novelas
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 44D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 26D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Lista5 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.juanito = new System.Windows.Forms.TextBox();
            this.novela1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.juanita = new System.Windows.Forms.TextBox();
            this.lista4 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BOX2 = new System.Windows.Forms.TextBox();
            this.Listan = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lista5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista5
            // 
            this.Lista5.Controls.Add(this.tabPage1);
            this.Lista5.Controls.Add(this.tabPage2);
            this.Lista5.Controls.Add(this.tabPage3);
            this.Lista5.Controls.Add(this.tabPage4);
            this.Lista5.Location = new System.Drawing.Point(12, 12);
            this.Lista5.Name = "Lista5";
            this.Lista5.SelectedIndex = 0;
            this.Lista5.Size = new System.Drawing.Size(681, 311);
            this.Lista5.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.juanito);
            this.tabPage1.Controls.Add(this.novela1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HARRY POTTER";
            // 
            // juanito
            // 
            this.juanito.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.juanito.Location = new System.Drawing.Point(285, 36);
            this.juanito.Multiline = true;
            this.juanito.Name = "juanito";
            this.juanito.Size = new System.Drawing.Size(329, 225);
            this.juanito.TabIndex = 1;
            this.juanito.TextChanged += new System.EventHandler(this.juanito_TextChanged);
            // 
            // novela1
            // 
            this.novela1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.novela1.FormattingEnabled = true;
            this.novela1.Location = new System.Drawing.Point(19, 36);
            this.novela1.Name = "novela1";
            this.novela1.Size = new System.Drawing.Size(207, 225);
            this.novela1.TabIndex = 0;
            this.novela1.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.juanita);
            this.tabPage2.Controls.Add(this.lista4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GOOSEBUMPS";
            // 
            // juanita
            // 
            this.juanita.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.juanita.Location = new System.Drawing.Point(262, 53);
            this.juanita.Multiline = true;
            this.juanita.Name = "juanita";
            this.juanita.Size = new System.Drawing.Size(346, 213);
            this.juanita.TabIndex = 1;
            this.juanita.TextChanged += new System.EventHandler(this.juanita_TextChanged);
            // 
            // lista4
            // 
            this.lista4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lista4.FormattingEnabled = true;
            this.lista4.Location = new System.Drawing.Point(17, 53);
            this.lista4.Name = "lista4";
            this.lista4.Size = new System.Drawing.Size(185, 212);
            this.lista4.TabIndex = 0;
            this.lista4.SelectedIndexChanged += new System.EventHandler(this.lista4_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.BOX2);
            this.tabPage3.Controls.Add(this.Listan);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PERRY MASON";
            // 
            // BOX2
            // 
            this.BOX2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BOX2.Location = new System.Drawing.Point(262, 42);
            this.BOX2.Multiline = true;
            this.BOX2.Name = "BOX2";
            this.BOX2.Size = new System.Drawing.Size(370, 231);
            this.BOX2.TabIndex = 1;
            this.BOX2.TextChanged += new System.EventHandler(this.BOX2_TextChanged);
            // 
            // Listan
            // 
            this.Listan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Listan.FormattingEnabled = true;
            this.Listan.Location = new System.Drawing.Point(20, 42);
            this.Listan.Name = "Listan";
            this.Listan.Size = new System.Drawing.Size(170, 225);
            this.Listan.TabIndex = 0;
            this.Listan.SelectedIndexChanged += new System.EventHandler(this.Listan_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(673, 285);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ESTADISTICA";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-4, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Label = "HARRY POTTER";
            dataPoint2.Label = "GOOSEBUMPS";
            dataPoint3.Label = "PERRY MASON";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.YValueMembers = "44";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(479, 304);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Name = "HARRY POTTER";
            title2.Name = "GOOSEBUMPS";
            title3.Name = "PERRY MASON";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            // 
            // Novelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lista5);
            this.Name = "Novelas";
            this.Text = "Novelas";
            this.Load += new System.EventHandler(this.Novelas_Load);
            this.Lista5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Lista5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox novela1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lista4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox Listan;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox juanito;
        private System.Windows.Forms.TextBox juanita;
        private System.Windows.Forms.TextBox BOX2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}