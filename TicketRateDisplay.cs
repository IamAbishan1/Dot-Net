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
            List<TicketRate> TicketRateList = new List<TicketRate>();
            string[] RateList = File.ReadAllLines(filePath);
            foreach (string s in RateList)
            {
                string[] st = s.Split(',');
                if (st.Length != 6) continue;

                TicketRate tr = new TicketRate();
                tr.title = st[0];
                tr.rateForOneHrs = Convert.ToInt32(st[1]);
                tr.rateForTwoHrs = Convert.ToInt32(st[2]);
                tr.rateForThreeHrs = Convert.ToInt32(st[3]);
                tr.rateForFourHrs = Convert.ToInt32(st[4]);
                tr.rateForWholeDay = Convert.ToInt32(st[5]);
                TicketRateList.Add(tr);

            }
            ticketRateGV.DataSource = TicketRateList;



        }

        private void ticketRateGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TicketRateDisplay_Load(object sender, EventArgs e)
        {
            ticketRateCB.SelectedIndex = 0;
            showTicketRate();
        }

        private void UpdateRate_Click(object sender, EventArgs e)
        {
            //read data from gridview
            //write data to file (overwrite)
        }
    }
}
