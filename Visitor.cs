using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Application_CW1
{
    [Serializable]
    class Visitor
    {
        public int Id { get; set; }
        public String TktType { get; set; }
        public int Count { get; set; }
        public DateTime TimeIn{ get; set; }
        public DateTime TimeOut { get; set; }

     
        public int Bill { get; set; }

        //needed for serialization
        public static string KEY = "VisitorID";
        public static string KEY1 = "TktType";
        public static string KEY2 = "Count";
        public static string KEY3 = "TimeIn";
        public static string KEY4 = "TimeOut";
        public static string KEY5 = "Bill";

        //default constructor
        public Visitor() { }

        //Deserialization constructor.
        public Visitor(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties

            Id = (int)serial.GetValue(KEY, typeof(int));
            TktType = (string)serial.GetValue(KEY1, typeof(string));
            Count = (int)serial.GetValue(KEY2, typeof(int));
            TimeIn = (DateTime)serial.GetValue(KEY3, typeof(DateTime));
            TimeOut = (DateTime)serial.GetValue(KEY4, typeof(DateTime));
            Bill = (int)serial.GetValue(KEY5, typeof(int));
        }

        //needed for serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue(KEY, Id);
            info.AddValue(KEY1, TktType);
            info.AddValue(KEY2, Count);
            info.AddValue(KEY3, TimeIn);
            info.AddValue(KEY4, TimeOut);
            info.AddValue(KEY5, Bill);
        }

        public double CalculateTotalDuration()
        {
            return (int)TimeOut.Subtract(TimeIn).TotalMinutes;
        }

        
    }
}
