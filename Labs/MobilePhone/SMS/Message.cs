using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Message
    {
        public string User { get; private set; }
        public string Text { get; private set; }
        public DateTime ReceivingTime { get; private set; }

        public Message(string user, string text)
        {
            this.User = user;
            this.Text = text;
            this.ReceivingTime = DateTime.Now;
        }

        public Message(string user, string text, DateTime time)
        {
            this.User = user;
            this.Text = text;
            this.ReceivingTime = time;
        }

        public override bool Equals(object obj)
        {
            var message = obj as Message;
            if (message == null) return false;
            if (object.ReferenceEquals(obj, this)) return true;

            return this.User == message.User && this.Text == message.Text && this.ReceivingTime == message.ReceivingTime;
        }
    }
}
