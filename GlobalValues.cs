using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_CW1
{
    class GlobalValues
    {
        //userid for user id
        public static int UserId;

        public static bool IsAdmin;
        public static bool IsWeekEnd;

        //File paths
        public static string VisitorCSVPath = "Visitor.csv";
        public static string ExitedVisitorsCSVPath = "ExitedVisitors.csv";
        public static string TicketRateWDCSVPath = "TicketRateWD.csv";
        public static string TicketRateWECSVPath = "TicketRateWE.csv";
        public static string SerializedFilePath = "Visitor.save";

        //Lists
        public static List<TicketRate> TicketRateListWD = new List<TicketRate>();
        public static List<TicketRate> TicketRateListWE = new List<TicketRate>();
        public static List<Visitor> VisitorList = new List<Visitor>();
        public static List<Visitor> VisitorExitedList = new List<Visitor>();
        public static List<Visitor> DeserializedVisitorList = new List<Visitor>();
        public static VisitorCollection VisitorCollectionList;
    }
}
