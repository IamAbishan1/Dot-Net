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
    public partial class LogIn : Form
    {
       
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dayL.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            //check username and password
            if (UserTB.Text == "root" && PasswordTB.Text == "root")
            {
                //If valid username and password -> Set the user as admin
                GlobalValues.IsAdmin = true;

                //Close login form
               
                Hide();
                Main main = new Main();
                main.Show();

            }
            else
            {
                //If not valid -> show errror msg
                UPCheckL.Visible = true;
                

            }

        }

        private void SkipB_Click(object sender, EventArgs e)
        {
            //To close the login form
            Hide();

            Main main = new Main();
            main.Show();
        }

        private void UserTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateL.Text = DateTime.Now.ToString();
        }

        private void dateL_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
