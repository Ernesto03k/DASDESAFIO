namespace Actividad
{
    partial class Programas
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 47D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 38D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.box11 = new System.Windows.Forms.TextBox();
            this.lista11 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lista12 = new System.Windows.Forms.ListBox();
            this.box12 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lista13 = new System.Windows.Forms.ListBox();
            this.box13 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.box11);
            this.tabPage1.Controls.Add(this.lista11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PYTHON";
            // 
            // box11
            // 
            this.box11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.box11.Location = new System.Drawing.Point(249, 35);
            this.box11.Multiline = true;
            this.box11.Name = "box11";
            this.box11.Size = new System.Drawing.Size(353, 198);
            this.box11.TabIndex = 1;
            // 
            // lista11
            // 
            this.lista11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lista11.FormattingEnabled = true;
            this.lista11.Location = new System.Drawing.Point(21, 35);
            this.lista11.Name = "lista11";
            this.lista11.Size = new System.Drawing.Size(165, 199);
            this.lista11.TabIndex = 0;
            this.lista11.SelectedIndexChanged += new System.EventHandler(this.lista11_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.lista12);
            this.tabPage2.Controls.Add(this.box12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "JAVA";
            // 
            // lista12
            // 
            this.lista12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lista12.FormattingEnabled = true;
            this.lista12.Location = new System.Drawing.Point(19, 52);
            this.lista12.Name = "lista12";
            this.lista12.Size = new System.Drawing.Size(173, 186);
            this.lista12.TabIndex = 1;
            this.lista12.SelectedIndexChanged += new System.EventHandler(this.lista12_SelectedIndexChanged);
            // 
            // box12
            // 
            this.box12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.box12.Location = new System.Drawing.Point(255, 52);
            this.box12.Multiline = true;
            this.box12.Name = "box12";
            this.box12.Size = new System.Drawing.Size(341, 187);
            this.box12.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.lista13);
            this.tabPage3.Controls.Add(this.box13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(654, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "JAVASCRIP";
            // 
            // lista13
            // 
            this.lista13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lista13.FormattingEnabled = true;
            this.lista13.Location = new System.Drawing.Point(24, 46);
            this.lista13.Name = "lista13";
            this.lista13.Size = new System.Drawing.Size(155, 186);
            this.lista13.TabIndex = 1;
            this.lista13.SelectedIndexChanged += new System.EventHandler(this.lista13_SelectedIndexChanged);
            // 
            // box13
            // 
            this.box13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.box13.Location = new System.Drawing.Point(253, 46);
            this.box13.Multiline = true;
            this.box13.Name = "box13";
            this.box13.Size = new System.Drawing.Size(331, 186);
            this.box13.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(654, 269);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ESTADISTICA";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Label = "PYTHON";
            dataPoint2.Label = "JAVA";
            dataPoint3.Label = "JAVASCRIP";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(464, 257);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Programas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Programas";
            this.Text = "Programas";
            this.Load += new System.EventHandler(this.Programas_Load);
            this.tabControl1.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox box11;
        private System.Windows.Forms.ListBox lista11;
        private System.Windows.Forms.ListBox lista12;
        private System.Windows.Forms.TextBox box12;
        private System.Windows.Forms.ListBox lista13;
        private System.Windows.Forms.TextBox box13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}