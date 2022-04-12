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
    public partial class OverAllReport : Form
    {
        public OverAllReport()
        {
            InitializeComponent();
        }

        private void OverAllReport_Load(object sender, EventArgs e)
        {
            makeCount();
            makeChart();
            visitorListGV.DataSource = GlobalValues.VisitorExitedList;
        }
        private void makeChart()
        {
            countChart.Series["Count"].Points.AddXY("Child", childNo);
            countChart.Series["Count"].Points.AddXY("Adult", adultNo);
            countChart.Series["Count"].Points.AddXY("Group of 5", group5);
            countChart.Series["Count"].Points.AddXY("Group of 10", group10);
            countChart.Series["Count"].Points.AddXY("Group of 25", group25);


            revenueChart.Series["Income"].Points.AddXY("Child", earningFromChild);
            revenueChart.Series["Income"].Points.AddXY("Adult", earningFromAdult);
            revenueChart.Series["Income"].Points.AddXY("Group of 5", earningFromGroup5);
            revenueChart.Series["Income"].Points.AddXY("Group of 10", earingFromGroup10);
            revenueChart.Series["Income"].Points.AddXY("Group fo 25", earningFromGroup25);
        }
        int childNo = 0, earningFromChild = 0;
        int group5 = 0, earningFromGroup5 = 0;
        int adultNo = 0, earningFromAdult = 0;
        int group10 = 0, earingFromGroup10 = 0;
        int group25 = 0, earningFromGroup25 = 0;

        private void backPB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
        

        private void makeCount()
        {
            
            Dictionary.DeSerializeVisitData();
            foreach (Visitor vs in GlobalValues.VisitorCollectionList.VisitorList)
            {
                if (String.Equals("Child", vs.TktType))
                {
                    childNo += vs.Count;
                    earningFromChild += vs.Bill;

                }
                else if (String.Equals("Adult", vs.TktType))
                {
                    adultNo += vs.Count;
                    earningFromAdult += vs.Bill;
                }
                else if (String.Equals("Group of 5", vs.TktType))
                {
                    group5 += vs.Count;
                    earningFromGroup5 += vs.Bill;
                }
                else if (String.Equals("Group of 10", vs.TktType))
                {
                    group10 += vs.Count;
                    earingFromGroup10 += vs.Bill;
                }
                else
                {
                    group25 += vs.Count;
                    earningFromGroup25 += vs.Bill;
                }
            }
        }

        private void countChart_Click(object sender, EventArgs e)
        {

        }

        private void visitorListGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
