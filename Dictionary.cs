using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Diagnostics;

namespace Application_CW1
{
    //Class with the generic methods 
    class Dictionary
    {
        //Check if the woking day is weekend or weekday
        public static void IsWeekEnd()
        {

            DayOfWeek dayToday = DateTime.Now.DayOfWeek;

            if ((dayToday == DayOfWeek.Saturday) || (dayToday == DayOfWeek.Sunday)) GlobalValues.IsWeekEnd = true;
        }

        //Method to read the csv file with ticketrate
        public static void ReadTicketRatelCSV(string filepath,List<TicketRate> ticketRateList)
        {
            try
            {
                ticketRateList.Clear();
                string[] RateList = File.ReadAllLines(filepath);
                foreach (string s in RateList)
                {
                    string[] st = s.Split(',');
                    //check for invalid ticket rate
                    if (st.Length != 6) continue;

                    TicketRate tr = new TicketRate();
                    tr.title = st[0];
                    tr.rateForOneHrs = Convert.ToInt32(st[1]);
                    tr.rateForTwoHrs = Convert.ToInt32(st[2]);
                    tr.rateForThreeHrs = Convert.ToInt32(st[3]);
                    tr.rateForFourHrs = Convert.ToInt32(st[4]);
                    tr.rateForWholeDay = Convert.ToInt32(st[5]);
                    ticketRateList.Add(tr);

                }
            }
            
            catch(Exception exception)
            {
                MessageBox.Show("Some unknow error while opening the file.");
            }
  
        }

        //Read the csv file with the record of visitor who have entry the system but not exited
        public static void ReadVisitorsCSV()
        {
            try
            {
                int maxid = 0;
                string[] VisitorList = File.ReadAllLines(GlobalValues.VisitorCSVPath);
                foreach (string s in VisitorList)
                {
                    string[] st = s.Split(',');
                    if (st.Length != 4) continue;
                    else
                    {
                        Visitor vs = new Visitor();
                        vs.Id = Convert.ToInt32(st[0]);
                        vs.TktType = st[1];
                        vs.Count = Convert.ToInt32(st[2]);
                        vs.TimeIn = Convert.ToDateTime(st[3]);

                        GlobalValues.VisitorList.Add(vs);
                        maxid = vs.Id;
                    }
                    //Make the auto incremented userId to avoid conflict
                    GlobalValues.UserId = maxid+1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your Visiter CSV file is empty.");
            }
        }

        //Read the file CSV with record of data of visitors who have exited the system
            public static void ReadExitedVisitorsCSV()
            {
                try
                {
                    string[] VisitorList = File.ReadAllLines(GlobalValues.ExitedVisitorsCSVPath);
                    foreach (string s in VisitorList)
                    {
                        string[] st = s.Split(',');
                        if (st.Length != 6) continue;
                        else
                        {
                            Visitor vs = new Visitor();
                            vs.Id = Convert.ToInt32(st[0]);
                            vs.TktType = st[1];
                            vs.Count = Convert.ToInt32(st[2]);
                            vs.TimeIn = Convert.ToDateTime(st[3]);
                            vs.TimeOut = Convert.ToDateTime(st[4]);
                            vs.Bill = Convert.ToInt32(st[5]);

                        GlobalValues.VisitorExitedList.Add(vs);
                        
                           
                        }
                        
                    }
                GlobalValues.UserId = GlobalValues.VisitorExitedList.Count();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Some unkonwn error occured while opening file.");
                }
            }

       
        
        //Method for deserialization of the list
        public static void DeSerializeVisitData()
        {
            try
            {
                //check whether file exist
                if (File.Exists(GlobalValues.SerializedFilePath))
                {
                    Stream stream = File.Open(GlobalValues.SerializedFilePath, FileMode.Open);
                    if (stream != null && stream.Length > 0)
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();

                        //Reading Visit List Information
                        GlobalValues.VisitorCollectionList = (VisitorCollection)binaryFormatter.Deserialize(stream);
                        MessageBox.Show("Successfully Retrieved Visit Details from file!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    stream.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Not able to get visit data. Please try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        //Serialization
        private void SerializeVisitData(List<Visitor> visits)
        {
            VisitorCollection vc = new VisitorCollection();
            vc.VisitorList = visits;
            //seriialize the visit data
            Stream str = File.Open(GlobalValues.SerializedFilePath, FileMode.Create);
            BinaryFormatter bF = new BinaryFormatter();
            bF.Serialize(str, vc);
            str.Flush();
            str.Close();
            MessageBox.Show("Succesfully saved Visit Details to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
       
        public void SaveVisitor(List<Visitor> visits)
        {
            SerializeVisitData(visits);
        }

        public static void swap(Visitor[] arr, int i, int j)
        {
            Visitor temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        //Make partition on the basis of Bill for recursive function sortH2L
        public static int partitionForHigherToLower(Visitor[] arr, int low, int high)
        {
            int pivot = arr[high].Bill;

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j].Bill > pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }
        //Make partition on the basis of count for SortH2LCount
        public static int partitionForHigherToLowerCount(Visitor[] arr, int low, int high)
        {
            int pivot = arr[high].Count;

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j].Count > pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }
        public static int partitionForLowerToHigher(Visitor[] arr, int low, int high)
        {
            int pivot = arr[high].Bill;

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j].Bill < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }

        public static int partitionForLowerToHigherCount(Visitor[] arr, int low, int high)
        {
            int pivot = arr[high].Count;

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j].Count < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }
        //Sort function to sort the array in decreasing order
        public static void quickSortH2LCount(Visitor[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionForHigherToLowerCount(arr, low, high);
                quickSortH2LCount(arr, low, pi - 1);
                quickSortH2LCount(arr, pi + 1, high);
            }
        }
        public static void quickSortH2L(Visitor[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionForHigherToLower(arr, low, high);
                quickSortH2L(arr, low, pi - 1);
                quickSortH2L(arr, pi + 1, high);
            }
        }
        public static void quickSortL2H(Visitor[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionForLowerToHigher(arr, low, high);
                quickSortL2H(arr, low, pi - 1);
                quickSortL2H(arr, pi + 1, high);
            }
        }
        public static void quickSortL2HCount(Visitor[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionForLowerToHigherCount(arr, low, high);
                quickSortL2HCount(arr, low, pi - 1);
                quickSortL2HCount(arr, pi + 1, high);
            }
        }


    }
    }



