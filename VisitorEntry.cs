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
    public partial class VisitorEntry : Form
    {
        
        string filePath2 = "C:\\CSV_Project\\Visitor.csv";
        public VisitorEntry()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void AddVisitorToCsv(int id, string tktType, int count, DateTime timeIn)
        {

            string newSt = "\n" + id + "," + tktType + "," + count + "," + timeIn;
            File.AppendAllText(filePath2, newSt);
        }

        private void entryB_Click(object sender, EventArgs e)
        {
            Visitor s = new Visitor();
            s.Id = 1;
            s.TktType = typeCB.Text;
            s.Count = Convert.ToInt32(countNUP.Text);
            s.TimeIn = DateTime.Now;

            AddVisitorToCsv(s.Id, s.TktType, s.Count, s.TimeIn);


            typeCB.Text = " ";
            countNUP.Text = " ";

        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
