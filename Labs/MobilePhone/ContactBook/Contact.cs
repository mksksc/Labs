using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ContactBook
{
    public class Contact
    {
        public string Name { get; private set; }
        private List<string> phoneNumbers;

        public Contact(string name)
        {
            this.Name = name;
            phoneNumbers = new List<string>();
        }

        public void AddPhoneNumber(string number)=> phoneNumbers.Add(number);

        public void RemovePhoneNumber(string number)
        {
            if (phoneNumbers.Contains(number))
            {
                phoneNumbers.Remove(number);
            }          
        }

        public IReadOnlyList<string> GetPhoneNumbers() => phoneNumbers.ToList();

        public override bool Equals(object obj)
        {
            var contact = obj as Contact;
            if (contact == null) return false;
            if (object.ReferenceEquals(this, contact)) return true;

            if(Name == contact.Name && Enumerable.SequenceEqual(phoneNumbers, contact.phoneNumbers))
            {
                return true;
            }

            return false;
        }

    }
}
