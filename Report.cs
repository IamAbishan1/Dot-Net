using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Application_CW1
{
    public partial class Report : Form
    {
        
        public Report()
        {
            InitializeComponent();
            
        }

        DateTime today = DateTime.Now.Date;
       

        int[] billList = new int[20];
        //calculate the earning of each day
        private void makeCount()
        {
            foreach (Visitor vs in GlobalValues.VisitorExitedList)
            {
                int day = Convert.ToInt32((today - vs.TimeIn).Days);
                if(day<20) billList[day] += vs.Bill;
                else continue;
            }
            

        }
        //Maje progress bar
        private void generateBusinessChart()
        {
            var objChart = businessChart.ChartAreas[0];

            //Week days
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 20;
            //earnings
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
           

            businessChart.Series.Clear();

            Random random = new Random();

            businessChart.Series.Add("Earning");
            businessChart.Series["Earning"].Color = Color.Green;
            businessChart.Series["Earning"].Legend = "Legend1";

            businessChart.Series["Earning"].ChartArea = "ChartArea1";
            businessChart.Series["Earning"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for(int i=0;i<20;i++)
                businessChart.Series["Earning"].Points.AddXY(i+1,billList[i]);

        }



        private void setWeekType()
        {
            if (GlobalValues.IsWeekEnd) weekB.Text = "WeekEnd";
            else weekB.Text = "WeekDay";


        }

        public void setUser()
        {
            if (GlobalValues.IsAdmin)
            {
                userL.Text = "Admin";
                logInB.Text = "Log Out";
                
            }

            else
            {
                userL.Text = "Staff";
                logInB.Text = "Log In";
            }

        }

        private void logInB_Click(object sender, EventArgs e)
        {
            if (String.Equals(logInB.Text, "Log In"))
            {
                LogIn login = new LogIn();
                this.Close();
                login.Show();
            }
            else
            {
                this.Close();
                GlobalValues.IsAdmin = false;
            }

        }

        private void finishB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_Load_1(object sender, EventArgs e)
        {
            makeCount();
            generateBusinessChart();
            setUser();
            setWeekType();
        }

        private void dailyReportB_Click(object sender, EventArgs e)
        {
            DailyReport dailyReport = new DailyReport();
            dailyReport.Show();

        }

        private void importB_Click(object sender, EventArgs e)
        {

        }

        private void allReportB_Click(object sender, EventArgs e)
        {
            OverAllReport overAllReport = new OverAllReport();
            overAllReport.Show();
        }
        

        private void detailB_Click(object sender, EventArgs e)
        {
            VisitorDetail visitorDetail = new VisitorDetail();
            visitorDetail.Show();
        }

        private void weeklyReportB_Click(object sender, EventArgs e)
        {
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.Show();
        }
    }
}
