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
    public partial class VisitorEntry : Form
    {
        public VisitorEntry()
        {
            InitializeComponent();
        }

        private Dictionary dict = new Dictionary();
        //private BindingSource BindingSource = new BindingSource();
        private void loadVisitor()
        {
            visitorListGrid.DataSource = GlobalValues.VisitorExitedList;
        }

       

        private void AddVisitorToCsv(int id, string tktType, int count, DateTime timeIn)
        {

            string newSt = "\n" + id + "," + tktType + "," + count + "," + timeIn;
            File.AppendAllText(GlobalValues.VisitorCSVPath, newSt);
        }

        private void entryB_Click(object sender, EventArgs e)
        {
            if (countNUP.Value == 0)
            {
                MessageBox.Show("Looks like you havenot given count number.");

            }
            //Make validation
            else if ((visitorTypeCB.SelectedItem=="Child" && countNUP.Value>5) || (visitorTypeCB.SelectedItem == "Adult" && countNUP.Value > 5))
            {
                MessageBox.Show("This visitor type belongs to group.");
            }
            else if((visitorTypeCB.SelectedItem == "Group of 5" && countNUP.Value < 5) || (visitorTypeCB.SelectedItem == "Group of 5" && countNUP.Value > 10))
            {
                MessageBox.Show("Looks like, Numbers of visitors in group is not valid.");
            }
            else if ((visitorTypeCB.SelectedItem == "Group of 10" && countNUP.Value < 10) || (visitorTypeCB.SelectedItem == "Group of 10" && countNUP.Value > 25))
            {
                MessageBox.Show("Looks like, Numbers of visitors in group is not valid.");
            }
            else if ((visitorTypeCB.SelectedItem == "Group of 25" && countNUP.Value < 25))
            {
                MessageBox.Show("Looks like, Numbers of visitors in group is not valid.");
            }
            else
            {
                Visitor s = new Visitor();
                s.Id = GlobalValues.UserId;
                s.TktType = visitorTypeCB.Text;
                s.Count = Convert.ToInt32(countNUP.Text);
                s.TimeIn = DateTime.Now;

                AddVisitorToCsv(s.Id, s.TktType, s.Count, s.TimeIn);
                GlobalValues.VisitorList.Add(s);

                countNUP.Value = 0;

                //Increase the value of Global userId
                GlobalValues.UserId++;
                IdL.Text = GlobalValues.UserId.ToString();
                MessageBox.Show("A new entry has been made successfully.");
               
               
            }
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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



        private void VisitorEntry_Load(object sender, EventArgs e)
        {
            
            setWeekType();
            setUser();
            loadVisitor();
            Dictionary.ReadVisitorsCSV();
            visitorTypeCB.SelectedIndex = 0;
            timeInTB.Text = Convert.ToString(DateTime.Now);
            GlobalValues.UserId = GlobalValues.VisitorExitedList.Count()+1;
           
            IdL.Text = Convert.ToString(GlobalValues.UserId);
            
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
           
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


        private void serializationB_Click(object sender, EventArgs e)
        {
            dict.SaveVisitor(GlobalValues.VisitorExitedList);
           
        }

    }
}
