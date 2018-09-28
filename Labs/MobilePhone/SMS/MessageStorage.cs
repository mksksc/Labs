using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class MessageStorage : IMessageStorage
    {
        public event Action<Message> MessageAdded;
        public event Action<Message> MessageRemoved;

        private List<Message> messages;

        public MessageStorage()
        {
            messages = new List<Message>();
        }


        public void AddMessage(Message message)
        {
            messages.Add(message);
            MessageAdded?.Invoke(message);
        }

        public void RemoveMessage(Message message)
        {
            if (messages.Contains(message))
            {
                messages.Remove(message);
                MessageRemoved?.Invoke(message);
            }
        }

        public IEnumerable<Message> GetMessages() => messages;
    }
}
