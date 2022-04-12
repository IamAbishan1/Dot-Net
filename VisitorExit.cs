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
using System.Runtime.Serialization.Formatters.Binary;

namespace Application_CW1
{
    public partial class VisitorExit : Form
    {
        
        public VisitorExit()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        Visitor visitorToExit;

        int totalcost = 0;
        int cost;
        

        /// <summary>
        /// Method to calculate the price
        /// </summary>
        /// <param name="durationHr"></param>
        /// <param name="durationMin"></param>
        /// <param name="TicketRateList"></param>
        public void CalculateCost(int durationHr, int durationMin, List<TicketRate> TicketRateList)
        {
            
            foreach (TicketRate tr in TicketRateList)
            {
                
                if (String.Equals(exitTypeTB.Text, tr.title))
                  
                {
                    if (durationHr == 0) cost = ((durationMin%60) * tr.rateForOneHrs)/100;
                    else if (durationHr == 1) cost = (durationHr * tr.rateForOneHrs) + ((durationMin%60) * tr.rateForTwoHrs)/100;
                    else if (durationHr == 2) cost = (durationHr * tr.rateForTwoHrs) + ((durationMin%60) * tr.rateForThreeHrs)/100;
                    else if (durationHr == 3) cost = (durationHr * tr.rateForThreeHrs) + ((durationMin%60) * tr.rateForFourHrs)/100;
                    else if (durationHr == 4) cost = (durationHr * tr.rateForFourHrs) + ((durationMin%60) * tr.rateForFourHrs)/100;
                    else cost = tr.rateForWholeDay;
                    MessageBox.Show(cost.ToString());

                 }
                totalcost = Convert.ToInt32(exitCountTB.Text) * cost;
                MessageBox.Show(totalcost.ToString());
                break;
              
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            try
            {
                foreach (Visitor visitor in GlobalValues.VisitorList)
                {
                    if (exitNUD.Value == visitor.Id)
                    {
                        exitTypeTB.Text = visitor.TktType;
                        exitCountTB.Text = Convert.ToString(visitor.Count);
                        exitEntryTimeTB.Text = Convert.ToString(visitor.TimeIn);
                        
                        found = true;
                        break;
                    }
                    
                }
                if (!found)
                {
                    MessageBox.Show("Visitor with given id not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The id doesenot exist.");
            }

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

        private void VisitorExit_Load(object sender, EventArgs e)
        {
            setUser();
            setWeekType();
        }
        private void AddVisitorToCsv(int id, string tktType, int count, DateTime timeIn,DateTime timeOut,int cost)
        {

            string newSt = id + "," + tktType + "," + count + "," + timeIn + ","+ timeOut + ", "+ cost + "\n";
            File.AppendAllText(GlobalValues.ExitedVisitorsCSVPath, newSt);
        }

        public  bool exited = false;
        public bool VisitorAlreadyExited()
        {
            foreach (Visitor visitor in GlobalValues.VisitorList)
            {
                if (visitor.Id == exitNUD.Value) exited = true;
                break;
            }
            
            return exited;
        }

        //check if the visitor has alreay exited or not
        private bool isVisitorExited(int id)
        {
            bool flag = false;
            //MessageBox.Show("Count: " + GlobalValues.VisitorExitedList.Count);
            foreach (Visitor visitor in GlobalValues.VisitorExitedList)
            {
                if (id == visitor.Id)
                {
                    flag = true;
                    break;
                }
            }

                return flag;
        }
        Visitor v1 = new Visitor();
        private void Exit_Click(object sender, EventArgs e)
        {

            if (exitNUD.Value == 0 || String.IsNullOrEmpty(exitTypeTB.Text) || String.IsNullOrEmpty(exitCountTB.Text)) MessageBox.Show("Looks like you have not given complete information.");
           // else
           // {
                v1.Id = (int)exitNUD.Value;
                v1.TktType = exitTypeTB.Text;
                v1.Count =Convert.ToInt32(exitCountTB.Text);
                v1.TimeIn = Convert.ToDateTime(exitEntryTimeTB.Text);
               
                        exitTimeTB.Text = (DateTime.Now).ToString();

                        v1.TimeOut = DateTime.Now;

                        int durationHr = (v1.TimeOut - v1.TimeIn).Hours;
                        int durationMin = (v1.TimeOut - v1.TimeIn).Minutes;
                        durationTB.Text = durationHr + "Hrs" + durationMin + "Mins";

                        if (GlobalValues.IsWeekEnd) CalculateCost(durationHr, durationMin, GlobalValues.TicketRateListWE);
                        else CalculateCost(durationHr, durationMin, GlobalValues.TicketRateListWD);

               // MessageBox.Show(totalcost.ToString());

                        priceTB.Text = totalcost.ToString();
            v1.Bill = totalcost;

                        
              //  }
            }

        private void AddVisitorToCsv(int id, string tktType, int count, DateTime timeIn)
        {

            string newSt = "\n" + v1.Id + "," +  v1.TktType + "," + v1.Count + "," + v1.TimeIn + ","+ v1.TimeOut + "," + v1.Bill;
            File.AppendAllText(GlobalValues.ExitedVisitorsCSVPath, newSt);
        }

        private void finishB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInB_Click(object sender, EventArgs e)
        {
            if(String.Equals(logInB.Text,"Log In"))
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

        private void confirmB_Click(object sender, EventArgs e)
        {
            if (exitNUD.Value == 0 || String.IsNullOrEmpty(exitTypeTB.Text) || String.IsNullOrEmpty(exitCountTB.Text) || String.IsNullOrEmpty(durationTB.Text)) MessageBox.Show("Looks like you have not given complete information.");

            else
            {
                bool exited = isVisitorExited((int)exitNUD.Value);
               
                if (isVisitorExited((int)exitNUD.Value))
                {
                    MessageBox.Show("This visitor has already exited.");

                }
                else
                {
                    MessageBox.Show("Visitor successfully exited.");
                    AddVisitorToCsv(v1.Id, v1.TktType, v1.Count, v1.TimeIn, v1.TimeOut, totalcost);
                    GlobalValues.VisitorExitedList.Add(v1);
                }

                //set all textboxes to empty
                exitNUD.Value = 0;
                exitTypeTB.Text = " ";
                exitCountTB.Text = " ";
                exitEntryTimeTB.Text = " ";
                exitTimeTB.Text = " ";
                durationTB.Text = " ";
                priceTB.Text = " ";
            }
        }

    }
}
