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
    public partial class TicketRateDisplay : Form
    {
        string filePath = "C:\\CSV_Project\\TicketRate.csv";
        public TicketRateDisplay()
        {
            InitializeComponent();
           showTicketRate();
        }

        public void showTicketRate()
        {
            ticketRateGV.DataSource = null;
            if(GlobalValues.IsWeekEnd) ticketRateGV.DataSource = GlobalValues.TicketRateListWE;
            else ticketRateGV.DataSource = GlobalValues.TicketRateListWD;

        }

        private void ticketRateGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void setWeekType()
        {
            if (GlobalValues.IsWeekEnd) weekB.Text = "WeekEnd";
            else weekB.Text = "WeekDay";


        }
        private void TicketRateDisplay_Load(object sender, EventArgs e)
        {
            setWeekType();
            setUser();
        }

        private void UpdateRate_Click(object sender, EventArgs e)
        {
            if (GlobalValues.IsAdmin)
            {

                TextWriter writer = new StreamWriter(filePath);
                for (int i = 0; i < ticketRateGV.Rows.Count; i++)
                {
                    for (int j = 0; j < ticketRateGV.Columns.Count; j++)
                    {
                        writer.Write(ticketRateGV.Rows[i].Cells[j].Value.ToString());
                        if (j < ticketRateGV.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine("");
                }
                writer.Close();
                MessageBox.Show("The ticketRate has been updated.");
            }
            else
            {
                MessageBox.Show("You do not have permission to make update here.");
            }
        }

        private void finishB_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ticketRateGV.DataSource = GlobalValues.TicketRateListWD;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ticketRateGV.DataSource = GlobalValues.TicketRateListWE;
        }
    }
}
