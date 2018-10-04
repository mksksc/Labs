using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ContactBook
{
    public class Call : IComparable<Call>
    {
        public readonly Contact Contact;
        public DateTime Time { get; protected set; }
        public readonly CallDirection Direction;

        public Call(Contact contact, DateTime time, CallDirection directon)
        {
            this.Contact = contact;
            this.Time = time;
            this.Direction = directon;
        }

        public int CompareTo(Call other)
        {
            return Time.CompareTo(other.Time);
        }

        public override bool Equals(object obj)
        {
            var call = obj as Call;
            if (call == null) return false;
            if (object.ReferenceEquals(this, call)) return true;

            if (Contact.Equals(call.Contact) && Direction==call.Direction)
            {
                return true;
            }

            return false;
        }
    }

    public enum CallDirection { Incoming, Outcoming }
}
