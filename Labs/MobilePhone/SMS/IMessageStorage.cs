using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public interface IMessageStorage
    {
        event Action<Message> MessageAdded;
        event Action<Message> MessageRemoved;

        void AddMessage(Message message);
        void RemoveMessage(Message message);
        IEnumerable<Message> GetMessages();
    }
}
