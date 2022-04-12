
namespace Application_CW1
{
    partial class OverAllReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.countChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.visitorListGV = new System.Windows.Forms.DataGridView();
            this.backPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorListGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPB)).BeginInit();
            this.SuspendLayout();
            // 
            // countChart
            // 
            chartArea1.Name = "ChartArea1";
            this.countChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.countChart.Legends.Add(legend1);
            this.countChart.Location = new System.Drawing.Point(55, 26);
            this.countChart.Name = "countChart";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Count";
            this.countChart.Series.Add(series1);
            this.countChart.Size = new System.Drawing.Size(375, 219);
            this.countChart.TabIndex = 1;
            this.countChart.Text = "Customer Count Chart";
            title1.Name = "Visitor Type Count";
            title1.Text = "Visitor Type Count";
            this.countChart.Titles.Add(title1);
            this.countChart.Click += new System.EventHandler(this.countChart_Click);
            // 
            // revenueChart
            // 
            chartArea2.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.revenueChart.Legends.Add(legend2);
            this.revenueChart.Location = new System.Drawing.Point(465, 26);
            this.revenueChart.Name = "revenueChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Income";
            this.revenueChart.Series.Add(series2);
            this.revenueChart.Size = new System.Drawing.Size(366, 219);
            this.revenueChart.TabIndex = 2;
            this.revenueChart.Text = "Vistor Revenue Chart";
            title2.Name = "incomeReport";
            title2.Text = "Income Report";
            this.revenueChart.Titles.Add(title2);
            // 
            // visitorListGV
            // 
            this.visitorListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorListGV.Location = new System.Drawing.Point(53, 259);
            this.visitorListGV.Name = "visitorListGV";
            this.visitorListGV.Size = new System.Drawing.Size(783, 229);
            this.visitorListGV.TabIndex = 3;
            this.visitorListGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitorListGV_CellContentClick);
            // 
            // backPB
            // 
            this.backPB.Image = global::Application_CW1.Properties.Resources.cancle;
            this.backPB.Location = new System.Drawing.Point(853, 3);
            this.backPB.Name = "backPB";
            this.backPB.Size = new System.Drawing.Size(35, 27);
            this.backPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPB.TabIndex = 4;
            this.backPB.TabStop = false;
            this.backPB.Click += new System.EventHandler(this.backPB_Click);
            // 
            // OverAllReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.backPB);
            this.Controls.Add(this.visitorListGV);
            this.Controls.Add(this.revenueChart);
            this.Controls.Add(this.countChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.Name = "OverAllReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverAllReport";
            this.Load += new System.EventHandler(this.OverAllReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorListGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart countChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
        private System.Windows.Forms.DataGridView visitorListGV;
        private System.Windows.Forms.PictureBox backPB;
    }
}