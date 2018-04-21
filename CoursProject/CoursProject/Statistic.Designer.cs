namespace CoursProject
{
    partial class Statistic
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.time = new System.Windows.Forms.TabPage();
            this.deviation = new System.Windows.Forms.TabPage();
            this.SpeedDiagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.time);
            this.tabControl1.Controls.Add(this.deviation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // time
            // 
            this.time.Controls.Add(this.SpeedDiagram);
            this.time.Location = new System.Drawing.Point(4, 22);
            this.time.Name = "time";
            this.time.Padding = new System.Windows.Forms.Padding(3);
            this.time.Size = new System.Drawing.Size(594, 296);
            this.time.TabIndex = 0;
            this.time.Text = "Час роботи";
            this.time.UseVisualStyleBackColor = true;
            // 
            // deviation
            // 
            this.deviation.Location = new System.Drawing.Point(4, 22);
            this.deviation.Name = "deviation";
            this.deviation.Padding = new System.Windows.Forms.Padding(3);
            this.deviation.Size = new System.Drawing.Size(276, 239);
            this.deviation.TabIndex = 1;
            this.deviation.Text = "Відхилення";
            this.deviation.UseVisualStyleBackColor = true;
            // 
            // SpeedDiagram
            // 
            chartArea1.Name = "ChartArea1";
            this.SpeedDiagram.ChartAreas.Add(chartArea1);
            this.SpeedDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.SpeedDiagram.Legends.Add(legend1);
            this.SpeedDiagram.Location = new System.Drawing.Point(3, 3);
            this.SpeedDiagram.Name = "SpeedDiagram";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Жадібний алгоритм";
            series1.Name = "Greedy";
            this.SpeedDiagram.Series.Add(series1);
            this.SpeedDiagram.Size = new System.Drawing.Size(588, 290);
            this.SpeedDiagram.TabIndex = 0;
            this.SpeedDiagram.Text = "Час роботи";
            title1.Name = "cartName";
            title1.Text = "Графік швидкості роботи алгоритмів залежно від розмірності задачі";
            this.SpeedDiagram.Titles.Add(title1);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistic";
            this.Text = "Результати дослідження";
            this.tabControl1.ResumeLayout(false);
            this.time.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedDiagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage time;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpeedDiagram;
        private System.Windows.Forms.TabPage deviation;
    }
}