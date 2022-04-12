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
    public partial class Main : Form
    {
        LogIn logIn;
        
        public Main()
        {
            InitializeComponent();
            this.Hide();
            setUser();



        }
        DateTime today = DateTime.Now.Date;


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

        private void Main_Load(object sender, EventArgs e)
        {
            ShowLogIn();
            
            //Set the proper ui design
            setUser();

            //Read the user not exited form
            Dictionary.ReadVisitorsCSV();

            //Read the users who have already exited
            Dictionary.ReadExitedVisitorsCSV();

            //Read csv file of ticket rate for weekday
            Dictionary.ReadTicketRatelCSV(GlobalValues.TicketRateWDCSVPath, GlobalValues.TicketRateListWD);

            //Read csv file of ticket rate for weekend
            Dictionary.ReadTicketRatelCSV(GlobalValues.TicketRateWECSVPath, GlobalValues.TicketRateListWE);

            Dictionary.IsWeekEnd();

            //Set today'time in the ui
            DayL.Text = DateTime.Now.DayOfWeek.ToString();

            
            

        }

       
        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            logIn = null;
           
        }

        private void ShowLogIn()
        {

            if (logIn == null)
            {
                logIn = new LogIn();
                logIn.FormClosed += LogIn_FormClosed;
                
                logIn.Show();
            }
            else
            {
                logIn.Activate();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTimeLabel.Text = DateTime.Now.ToString();
        }

        
        private void Entry_Click(object sender, EventArgs e)
        {
            VisitorEntry vs = new VisitorEntry();
            vs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorExit ve = new VisitorExit();
            ve.Show();
        }

        

        private void viewTicketRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketRateDisplay td = new TicketRateDisplay();
            td.Show();
        }

        private void updateTicketRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketRateDisplay td = new TicketRateDisplay();
            td.Show();
        }

    

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            reportForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            VisitorEntry vs = new VisitorEntry();
            vs.Show();
        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {
            VisitorExit ve = new VisitorExit();
            ve.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VisitorEntry vs = new VisitorEntry();
            vs.Show();
        }

        

        private void exitPB_Click(object sender, EventArgs e)
        {
            VisitorExit ve = new VisitorExit();
            ve.Show();
        }

        private void rateL_Click(object sender, EventArgs e)
        {
            TicketRateDisplay td = new TicketRateDisplay();
            td.Show();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TicketRateDisplay td = new TicketRateDisplay();
            td.Show();
        }

        
        private void logInB_Click(object sender, EventArgs e)
        {
            
            LogIn login = new LogIn();
            login.Show();
            
        }

        private void reportPB_Click(object sender, EventArgs e)
        {
            if (GlobalValues.IsAdmin)
            {
                Report report = new Report();
                report.Show();
            }
            else
            {
                MessageBox.Show("You are not permitted to nagivated this form." +
                   "\n" + "Requires Admin Privilege.");
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

            VisitorExit ve = new VisitorExit();
            ve.Show();
        }

        private void ratePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void reportL_Click(object sender, EventArgs e)
        {
            if (GlobalValues.IsAdmin)
            {
                Report report = new Report();
                report.Show();
            }
            else
            {
                MessageBox.Show("You are not permitted to nagivated this form." +
                   "\n" + "Requires Admin Privilege.");
            }
        }

    }
}
