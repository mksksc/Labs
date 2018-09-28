using MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Filters
{
    public class MsgFilterObj
    {
        public IEnumerable<Message> Messages { get; set; }
        public string User { get; set; }
        public string MessageText { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool UseAndForCond { get; set; }
    }
}
