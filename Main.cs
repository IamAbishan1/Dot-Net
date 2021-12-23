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
        //VisitorEntry visitorEntry;
        Main main;
        public Main()
        {
            InitializeComponent();
            ShowLogIn();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // MenuStrip menuStrip = new MenuStrip();
            // menuStrip.Enabled = false;
            Menu.Enabled = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            logIn = null;
           

            Menu.Enabled = true;
            updateTicketRateMenu.Visible = GlobalValues.IsAdmin;

        }

        private void ShowLogIn()
        {

            if (logIn == null)
            {
                logIn = new LogIn();
                logIn.FormClosed += LogIn_FormClosed;
                logIn.MdiParent = this;
                logIn.Show();
            }
            else
            {
                logIn.Activate();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTimeL.Text = DateTime.Now.ToString();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void ticketRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketRateDisplay td = new TicketRateDisplay();
            td.Show();
        }

        private void viewTicketRateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateTicketRateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
