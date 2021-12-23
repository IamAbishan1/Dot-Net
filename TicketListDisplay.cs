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
    public partial class TicketListDisplay : Form
    {
        string filePath = "C:\\CSV_Project\\TicketRate.csv";
        public TicketListDisplay()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 public void showTicketRate()
        {
           List<TicketRate> TicketRateList = new List<TicketRate>();
            string[] RateList = File.ReadAllLines(filePath);
            foreach (string s in RateList)
            {
                string[] st = s.Split(',');
                
                TicketRate tr = new TicketRate();
                tr.title = st[0];
                tr.rateForOneHrs = Convert.ToInt32(st[1]);
                tr.rateForTwoHrs = Convert.ToInt32(st[2]);
                tr.rateForThreeHrs = Convert.ToInt32(st[3]);
                tr.rateForFourHrs = Convert.ToInt32(st[4]);
                tr.rateForWholeDay = Convert.ToInt32(st[5]);

                
                RateGridView.DataSource = TicketRateList;
                


            }
       
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
