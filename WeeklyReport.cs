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
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            makeCalculation(GlobalValues.VisitorExitedList,today);
            dateL.Text = (DateTime.Now).ToString()+ "," +(DateTime.Now.DayOfWeek).ToString();
        }
        DateTime today = DateTime.Now.Date;
        
        private void generateWeeklyReport()
        {
            DateTime date = datePicker.Value.Date;
            makeCalculation(GlobalValues.VisitorExitedList, date);
        }
        
        //make the calculation of bill and count of visitor of everyday of the week
        private void makeCalculation(List<Visitor> list,DateTime today)
        {

            try
            {
            int[,] billList = new int[7, 3];

            int[,] countList = new int[7, 3];

            int[] billHere = new int[3];
            int[] countHere = new int[3];


            int totalCount = 0;
            int totalBill = 0;
                foreach (Visitor vs in list)
                {
                    int day = Math.Abs(Convert.ToInt32((today - vs.TimeOut).Days));
                
                    if (day < 7)
                    {
                        if (String.Equals("Child", vs.TktType))
                        {
                            countList[day, 0] += vs.Count;
                            billList[day, 0] += vs.Bill;
                            billHere[0] += vs.Bill;
                            countHere[0] += vs.Count;
                            totalCount += vs.Count;
                            totalBill += vs.Bill;
                        }
                        else if (String.Equals("Adult", vs.TktType))
                        {
                            countList[day, 1] += vs.Count;
                            billList[day, 1] += vs.Bill;
                            billHere[1] += vs.Bill;
                            countHere[1] += vs.Count;
                            totalCount += vs.Count;
                            totalBill += vs.Bill;
                    }

                        else
                        {
                            countList[day, 2] += vs.Count;
                            billList[day, 2] += vs.Bill;
                            billHere[2] += vs.Bill;
                            countHere[2] += vs.Count;
                            totalCount += vs.Count;
                            totalBill += vs.Bill;
                    }
                    }
                    else continue;
                    
                   

                }

               

              for(int i = 0; i < 7; i++)
                {
                    //set values to the chart
                    weekChart.Series["Child Count"].Points.AddXY(i + 1, countList[i,0]);
                    weekChart.Series["Adult Count"].Points.AddXY(i + 1, countList[i,1]);
                    weekChart.Series["Group Count"].Points.AddXY(i + 1, countList[i,2]);
                }

                childCountL.Text = countHere[0].ToString();
                adultCountL.Text = countHere[1].ToString();
                G5CountL.Text = countHere[2].ToString();
                totalCountL.Text = totalCount.ToString();

                childBillL.Text = billHere[0].ToString();
                adultBillL.Text = billHere[1].ToString();
                G5BillL.Text = billHere[2].ToString();
                totalBillL.Text = totalBill.ToString();

           }
            catch (Exception exception)
            {
                MessageBox.Show("Looks like you there is no visitor today!");
            }
        }


        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finishB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateWeeklyReport();
        }

        private void weekChart_Click(object sender, EventArgs e)
        {

        }
    }
}
