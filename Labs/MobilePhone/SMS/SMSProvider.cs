using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.SMS
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(string message);

        public event SMSReceivedDelegate SMSReceived;

        public void ReceiveSMS(string message)
        {
            RaiseSMSReceivedEvent(message);
        }

        private void RaiseSMSReceivedEvent(string message)
        {
            SMSReceived?.Invoke(message);
        }
    }
}
