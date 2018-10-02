using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.SMS
{
    public static class SMSProviderFactory
    {
        public static SMSProviderBase GetProvider(IMessageStorage storage, SMSProviderType type)
        {
            switch (type)
            {
                case SMSProviderType.Thread:
                    return new SMSProviderThread(storage);
                case SMSProviderType.Task:
                    return new SMSProviderTask(storage);
                default:
                    throw new NotImplementedException($"Not implemented logic for {type.ToString()} in {nameof(SMSProviderType)}");
            } 
        }     
    }
    public enum SMSProviderType { Thread, Task };
}
