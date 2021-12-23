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
        
        int totalcost;
        int cost;
        string filePath = "C:\\CSV_Project\\Visitor.csv";
        string filePath2 = "C:\\CSV_Project\\TicketRate.csv";

        public void calculateCost(int durationHr, int durationMin)
        {
            
            List<TicketRate> TicketRateList = new List<TicketRate>();
            string[] RateList = File.ReadAllLines(filePath2);
            foreach (string s in RateList)
            {
                string[] st = s.Split(',');
                if (String.Equals(exitCB.Text, st[0]))
                   MessageBox.Show("");
                {
                    if (durationHr == 0) {cost = durationMin * Convert.ToInt32(st[2]);
                    
                    MessageBox.Show(cost.ToString());
                }

                else if (durationHr == 1) cost = durationHr * Convert.ToInt32(st[2]) + ((durationMin * Convert.ToInt32(st[3])) / 60);
                else if (durationHr == 2) cost = durationHr * Convert.ToInt32(st[2]) + durationMin * Convert.ToInt32(st[3]);
                else if (durationHr == 3) cost = durationHr * Convert.ToInt32(st[3]) + durationMin * Convert.ToInt32(st[4]);
                else if (durationHr == 4) cost = durationHr * Convert.ToInt32(st[4]) + durationMin * Convert.ToInt32(st[4]);
                else cost = Convert.ToInt32(st[5]);


                 }
                totalcost = (int)exitCountNUD.Value * cost;
                //MessageBox.Show(totalcost.ToString());
                break;
             
             
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            try
            {
                
               
                string[] VisitorList = File.ReadAllLines(filePath);
                foreach (string s in VisitorList)
                {
                    string[] st = s.Split(',');

                    if (exitNUD.Value == Convert.ToInt32(st[0]))
                    {
                        exitCB.Text = st[1];
                        exitCountNUD.Value = Convert.ToInt32(st[2]);
                        exitEntryTimeTB.Text = st[3];
                        exitTimeTB.Text = (DateTime.Now).ToString();

                        visitorToExit = new Visitor();
                        visitorToExit.TimeIn = Convert.ToDateTime(exitEntryTimeTB.Text);
                        visitorToExit.TimeOut = DateTime.Now;

                        int durationHr = (visitorToExit.TimeOut - visitorToExit.TimeIn).Hours;
                        int durationMin = (visitorToExit.TimeOut - visitorToExit.TimeIn).Minutes;
                        durationTB.Text = durationHr + "Hrs" + durationMin + "Mins";

                        calculateCost(durationHr, durationMin);
                        priceTB.Text = totalcost.ToString();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisitorExit_Load(object sender, EventArgs e)
        {

        }
    }
}
