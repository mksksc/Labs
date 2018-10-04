using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ContactBook
{
    public class CallGrouped: Call 
    {
        public int CallCount { get; private set; }

        public CallGrouped(Call call): base(call.Contact,call.Time,call.Direction)
        {
            CallCount = 1;
        }

        public void UpdateCall(Call call)
        {
            if(call.Time>Time)
            {
                Time = call.Time;
            }         
            CallCount++;
        }
    }
}
