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
    public partial class VisitorDetail : Form
    {
        public VisitorDetail()
        {
            InitializeComponent();
        }

        List<Visitor> listToShow = GlobalValues.VisitorExitedList;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisitorDetail_Load(object sender, EventArgs e)
        {
            visitorListGV.DataSource = listToShow;

        }
        
        //filter the visitor on the basis of given ticket type
        private void searchVisitors(String ticketType)
        {
            List<Visitor> searchedList = new List<Visitor>(); 
            if (GlobalValues.VisitorExitedList.Count == 0) MessageBox.Show("There are no data make search.");
            
            foreach(Visitor vs in GlobalValues.VisitorExitedList)
            {
                if (String.Equals(ticketType, vs.TktType)){
                    searchedList.Add(vs);
                }
            }
            
            if (searchedList.Count == 0) MessageBox.Show("There is no visitors with given ticket type.");
            listToShow = searchedList;

            //show the visitor of the given ticket list in the gridview
            visitorListGV.DataSource = listToShow;

        }

        private void childSearchB_Click(object sender, EventArgs e)
        {
            searchVisitors(childSearchB.Text);
        }

        private void adultSearchB_Click(object sender, EventArgs e)
        {
            searchVisitors(adultSearchB.Text);
        }

        private void G5searchB_Click(object sender, EventArgs e)
        {
            searchVisitors(G5searchB.Text);
        }

        private void G10searchB_Click(object sender, EventArgs e)
        {
            searchVisitors(G10searchB.Text);
        }

        private void G25searchB_Click(object sender, EventArgs e)
        {
            searchVisitors(G25searchB.Text);
        }
        private void sortB_Click(object sender, EventArgs e)
        {
            
            Visitor[] listToSort = listToShow.ToArray();
            int n = listToSort.Length;
            Dictionary.quickSortH2L(listToSort, 0, n-1);
            visitorListGV.DataSource = listToSort;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visitor[] listToSort = listToShow.ToArray();
            int n = listToSort.Length;
            Dictionary.quickSortL2H(listToSort, 0, n - 1);
            visitorListGV.DataSource = listToSort;
        }

        private void exportB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\\";      
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // textBox1.Text = saveFileDialog1.FileName;
            }
        }
    }
}
