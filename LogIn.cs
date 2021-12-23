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

        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            //check username and password
            if (UserTB.Text == "Admin" && PasswordTB.Text == "Password")
            {
                //If valid username and password -> Set the user as admin
                GlobalValues.IsAdmin = true;
                //Close login form
                Close();

            }
            else
            {
                //If not valid -> show errror msg
                UPCheckL.Visible = true;

            }



            //Close the login form

        }

        private void SkipB_Click(object sender, EventArgs e)
        {
            //To close the login form
            Close();

            //Main main = new Main();
            //main.Show();
        }
        

        
    }
}
