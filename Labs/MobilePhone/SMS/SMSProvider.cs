using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(Message message);
        public event SMSReceivedDelegate SMSReceived;
        private IMessageStorage storage;

        public SMSProvider(IMessageStorage storage)
        {
            this.storage = storage;
        }

        public void ReceiveSMS(Message message)
        {
            storage.AddMessage(message);
            RaiseSMSReceivedEvent(message);
        }

        private void RaiseSMSReceivedEvent(Message message)
        {
            SMSReceived?.Invoke(message);
        }
    }
}
