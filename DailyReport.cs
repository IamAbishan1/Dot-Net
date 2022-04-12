using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_CW1
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }

        DateTime today = DateTime.Now.Date;
        List<Visitor> todayVisitor = new List<Visitor>();

        //make calculation of count and bill and store in array
        private void makeCalculation(List<Visitor> list)
        {
            try
            {
                int[] countList = new int[5];
                int[] billList = new int[5];

                int totalCount = 0;
                int totalBill = 0;
                foreach (Visitor vs in list)
                {
                    if ((vs.TktType).Equals("Child")) 
                    {
                        countList[0] += vs.Count;
                        billList[0] += vs.Bill;
                    }
                    else if (String.Equals("Adult", vs.TktType))
                    {
                        countList[1] += vs.Count;
                        billList[1] += vs.Bill;
                    }
                    else if (String.Equals("Group of 5", vs.TktType))
                    {
                        countList[2] += vs.Count;
                        billList[2] += vs.Bill;
                    }
                    else if (String.Equals("Group of 10", vs.TktType))
                    {
                        countList[3] += vs.Count;
                        billList[3] += vs.Bill;
                    }
                    else
                    {
                        countList[4] += vs.Count;
                        billList[4] += vs.Bill;
                    }
                    totalCount += vs.Count;
                    totalBill += vs.Bill;

                }

                childCountL.Text = countList[0].ToString();
                adultCountL.Text = countList[1].ToString();
                G5CountL.Text = countList[2].ToString();
                G10CountL.Text = countList[3].ToString();
                G25CountL.Text = countList[4].ToString();
                totalCountL.Text = totalCount.ToString();

                childBillL.Text = billList[0].ToString();
                adultBillL.Text = billList[1].ToString();
                G5BillL.Text = billList[2].ToString();
                G10BillL.Text = billList[3].ToString();
                G25BillL.Text = billList[4].ToString();
                totalBillL.Text = totalBill.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Looks like you there is no visitor today!");
            }
            




        }


        private void reportToday()
        {
            
            foreach (Visitor vs in GlobalValues.VisitorExitedList)
            {
                if (vs.TimeOut.Date == today)
                {
                    todayVisitor.Add(vs);
                }
            }
            dailyReportGrid.DataSource = todayVisitor;
            if (todayVisitor.Count==0) MessageBox.Show("Looks like no visitors have visited today!!!");
            
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void finishB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            reportToday();
            makeCalculation(todayVisitor);
            
        }
        
        //return the list of visitor who have visited on given date
        private List<Visitor> todayList()
        {
            List<Visitor> todayVisitorList = new List<Visitor>();
            foreach (Visitor vs in GlobalValues.VisitorExitedList)
            {
                if (vs.TimeOut.Date == pickDate.Value.Date)
                {
                    todayVisitorList.Add(vs);
                }
            }
            return todayVisitorList;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            dailyReportGrid.DataSource = todayList();
            if (todayList().Count==0)
            {
                //set to all the text of label to n/a
                childCountL.Text = "n/a";
                adultCountL.Text = "n/a";
                G5CountL.Text = "n/a";
                G10CountL.Text = "n/a";
                G25CountL.Text = "n/a";
                totalCountL.Text = "n/a";

                childBillL.Text = "n/a";
                adultBillL.Text = "n/a";
                G5BillL.Text = "n/a";
                G10BillL.Text = "n/a";
                G25BillL.Text = "n/a";
                totalBillL.Text = "n/a";
                MessageBox.Show("There are no visitors in this date.");


            }


            else makeCalculation(todayList());
            
        }

        private void todayTime_Tick(object sender, EventArgs e)
        {
            dateL.Text = DateTime.Now.ToString();
        }

        private void dateL_Click(object sender, EventArgs e)
        {

        }

        private void sortHTL_Click(object sender, EventArgs e)
        {
            Visitor[] workOn = todayList().ToArray();
            int n = workOn.Length;
            Dictionary.quickSortH2L(workOn, 0, n - 1);
            dailyReportGrid.DataSource = workOn;
        }
        
        private void sortLTHP_Click(object sender, EventArgs e)
        {
            Visitor[] workOn = todayList().ToArray();
            int n = workOn.Length;
            Dictionary.quickSortL2H(workOn,0,n-1);
            dailyReportGrid.DataSource = workOn;
        }

        private void sortHTLC_Click(object sender, EventArgs e)
        {
            Visitor[] workOn = todayList().ToArray();
            int n = workOn.Length;
            Dictionary.quickSortH2LCount(workOn, 0, n - 1);
            dailyReportGrid.DataSource = workOn;
        }

        private void sortLTHC_Click(object sender, EventArgs e)
        {
            Visitor[] workOn = todayList().ToArray();
            int n = workOn.Length;
            Dictionary.quickSortL2HCount(workOn, 0, n - 1);
            dailyReportGrid.DataSource = workOn;

        }
    }
}