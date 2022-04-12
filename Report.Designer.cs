
namespace Application_CW1
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.titleB = new System.Windows.Forms.Button();
            this.userL = new System.Windows.Forms.Label();
            this.logInB = new System.Windows.Forms.Button();
            this.weekB = new System.Windows.Forms.Button();
            this.reportL = new System.Windows.Forms.Button();
            this.dailyReportB = new System.Windows.Forms.Button();
            this.weeklyReportB = new System.Windows.Forms.Button();
            this.allReportB = new System.Windows.Forms.Button();
            this.finishB = new System.Windows.Forms.Button();
            this.userPB = new System.Windows.Forms.PictureBox();
            this.detailB = new System.Windows.Forms.Button();
            this.businessChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTitleB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessChart)).BeginInit();
            this.SuspendLayout();
            // 
            // titleB
            // 
            this.titleB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleB.Location = new System.Drawing.Point(145, 4);
            this.titleB.Name = "titleB";
            this.titleB.Size = new System.Drawing.Size(544, 40);
            this.titleB.TabIndex = 28;
            this.titleB.Text = "The Amusement Park";
            this.titleB.UseVisualStyleBackColor = false;
            //this.titleB.Click += new System.EventHandler(this.button1_Click);
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userL.Location = new System.Drawing.Point(87, 20);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(51, 15);
            this.userL.TabIndex = 27;
            this.userL.Text = "Staff";
            // 
            // logInB
            // 
            this.logInB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInB.Location = new System.Drawing.Point(700, 10);
            this.logInB.Name = "logInB";
            this.logInB.Size = new System.Drawing.Size(75, 23);
            this.logInB.TabIndex = 25;
            this.logInB.Text = "Log In";
            this.logInB.UseVisualStyleBackColor = true;
            this.logInB.Click += new System.EventHandler(this.logInB_Click);
            // 
            // weekB
            // 
            this.weekB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekB.Location = new System.Drawing.Point(783, 10);
            this.weekB.Name = "weekB";
            this.weekB.Size = new System.Drawing.Size(97, 23);
            this.weekB.TabIndex = 24;
            this.weekB.Text = "WeekDay";
            this.weekB.UseVisualStyleBackColor = true;
            // 
            // reportL
            // 
            this.reportL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportL.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reportL.Location = new System.Drawing.Point(10, 54);
            this.reportL.Name = "reportL";
            this.reportL.Size = new System.Drawing.Size(248, 40);
            this.reportL.TabIndex = 29;
            this.reportL.Text = "Select Report Type";
            this.reportL.UseVisualStyleBackColor = false;
            // 
            // dailyReportB
            // 
            this.dailyReportB.BackColor = System.Drawing.SystemColors.Control;
            this.dailyReportB.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dailyReportB.Location = new System.Drawing.Point(9, 109);
            this.dailyReportB.Name = "dailyReportB";
            this.dailyReportB.Size = new System.Drawing.Size(200, 40);
            this.dailyReportB.TabIndex = 30;
            this.dailyReportB.Text = "Daily Report";
            this.dailyReportB.UseVisualStyleBackColor = false;
            this.dailyReportB.Click += new System.EventHandler(this.dailyReportB_Click);
            // 
            // weeklyReportB
            // 
            this.weeklyReportB.BackColor = System.Drawing.SystemColors.Control;
            this.weeklyReportB.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyReportB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.weeklyReportB.Location = new System.Drawing.Point(9, 167);
            this.weeklyReportB.Name = "weeklyReportB";
            this.weeklyReportB.Size = new System.Drawing.Size(200, 40);
            this.weeklyReportB.TabIndex = 31;
            this.weeklyReportB.Text = "Weekly Report";
            this.weeklyReportB.UseVisualStyleBackColor = false;
            this.weeklyReportB.Click += new System.EventHandler(this.weeklyReportB_Click);
            // 
            // allReportB
            // 
            this.allReportB.BackColor = System.Drawing.SystemColors.Control;
            this.allReportB.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allReportB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.allReportB.Location = new System.Drawing.Point(9, 230);
            this.allReportB.Name = "allReportB";
            this.allReportB.Size = new System.Drawing.Size(200, 40);
            this.allReportB.TabIndex = 33;
            this.allReportB.Text = "overAll Report";
            this.allReportB.UseVisualStyleBackColor = false;
            this.allReportB.Click += new System.EventHandler(this.allReportB_Click);
            // 
            // finishB
            // 
            this.finishB.BackColor = System.Drawing.Color.Red;
            this.finishB.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishB.ForeColor = System.Drawing.Color.White;
            this.finishB.Location = new System.Drawing.Point(9, 411);
            this.finishB.Name = "finishB";
            this.finishB.Size = new System.Drawing.Size(142, 40);
            this.finishB.TabIndex = 35;
            this.finishB.Text = "Finish";
            this.finishB.UseVisualStyleBackColor = false;
            this.finishB.Click += new System.EventHandler(this.finishB_Click);
            // 
            // userPB
            // 
            this.userPB.Image = global::Application_CW1.Properties.Resources.users;
            this.userPB.Location = new System.Drawing.Point(9, 10);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(73, 34);
            this.userPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPB.TabIndex = 26;
            this.userPB.TabStop = false;
            // 
            // detailB
            // 
            this.detailB.BackColor = System.Drawing.SystemColors.Control;
            this.detailB.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.detailB.Location = new System.Drawing.Point(9, 290);
            this.detailB.Name = "detailB";
            this.detailB.Size = new System.Drawing.Size(200, 40);
            this.detailB.TabIndex = 36;
            this.detailB.Text = "Visitor Detail";
            this.detailB.UseVisualStyleBackColor = false;
            this.detailB.Click += new System.EventHandler(this.detailB_Click);
            // 
            // businessChart
            // 
            chartArea1.Name = "ChartArea1";
            this.businessChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.businessChart.Legends.Add(legend1);
            this.businessChart.Location = new System.Drawing.Point(277, 109);
            this.businessChart.Name = "businessChart";
            this.businessChart.Size = new System.Drawing.Size(603, 342);
            this.businessChart.TabIndex = 37;
            this.businessChart.Text = "chart1";
            title1.Name = "businessWeekT";
            title1.Text = "Business Of This Week";
            this.businessChart.Titles.Add(title1);
           // this.businessChart.Click += new System.EventHandler(this.businessChart_Click);
            // 
            // chartTitleB
            // 
            this.chartTitleB.BackColor = System.Drawing.Color.Blue;
            this.chartTitleB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartTitleB.ForeColor = System.Drawing.Color.White;
            this.chartTitleB.Location = new System.Drawing.Point(277, 55);
            this.chartTitleB.Name = "chartTitleB";
            this.chartTitleB.Size = new System.Drawing.Size(600, 40);
            this.chartTitleB.TabIndex = 38;
            this.chartTitleB.Text = "Business Report Of This Week";
            this.chartTitleB.UseVisualStyleBackColor = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.chartTitleB);
            this.Controls.Add(this.businessChart);
            this.Controls.Add(this.detailB);
            this.Controls.Add(this.finishB);
            this.Controls.Add(this.allReportB);
            this.Controls.Add(this.weeklyReportB);
            this.Controls.Add(this.dailyReportB);
            this.Controls.Add(this.reportL);
            this.Controls.Add(this.titleB);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.userPB);
            this.Controls.Add(this.logInB);
            this.Controls.Add(this.weekB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button titleB;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.Button logInB;
        private System.Windows.Forms.Button weekB;
        private System.Windows.Forms.Button reportL;
        private System.Windows.Forms.Button dailyReportB;
        private System.Windows.Forms.Button weeklyReportB;
        private System.Windows.Forms.Button allReportB;
        private System.Windows.Forms.Button finishB;
        private System.Windows.Forms.Button detailB;
        private System.Windows.Forms.DataVisualization.Charting.Chart businessChart;
        private System.Windows.Forms.Button chartTitleB;
    }
}