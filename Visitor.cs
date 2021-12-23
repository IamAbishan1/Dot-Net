using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_CW1
{
    class Visitor
    {
        public int Id { get; set; }
        public String TktType { get; set; }
        public int Count { get; set; }
        public DateTime TimeIn{ get; set; }
        public DateTime TimeOut { get; set; }
        public float Bill { get; set; }
    }
}
