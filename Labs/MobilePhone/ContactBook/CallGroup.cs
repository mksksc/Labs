using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ContactBook
{
    public class CallGroup
    {
        private List<Call> calls;
        public int Length { get; private set; }
        public CallGroup()
        {
            Length = 0;
            calls = new List<Call>();
        }

        public CallGroup(IEnumerable<Call> calls)
        {
            this.calls = new List<Call>();

            foreach (var call in calls)
            {
                AddCall(call);
            }

            this.calls.Sort();
            Length = calls.Count();
        }

        public bool CanBeAdded(Call call)
        {
            if (Length==0) return true;

            return calls[0].Equals(call);
        }

        public void AddCall(Call call)
        {
            if (!CanBeAdded(call)) throw new ArgumentException("Call cannot be added to group");
            calls.Add(call);
            calls.Sort();
            Length++;
        }
    }
}
