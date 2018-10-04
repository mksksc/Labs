using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ContactBook
{
    public class CallStorage
    {
        public event Action CallAdded;
        private List<Call> calllist;
        private object lock_obj;
        public CallStorage()
        {
            calllist = new List<Call>();
            lock_obj = new object();
        }

        public void AddCall(Call call)
        {
            lock(lock_obj)
            {
                calllist.Add(call);
                calllist.Sort();
            }
            
            CallAdded?.Invoke();
        }

        public void RemoveCall(Call call)
        {
            if (calllist.Contains(call))
            {
                lock (lock_obj)
                {
                    calllist.Remove(call);
                    calllist.Sort();
                }
            }
        }

        public IReadOnlyList<Call> GetCalls() => calllist.ToList();

        public IReadOnlyList<CallGrouped> GetCallGroupedList()
        {
            var groupedcalls = new List<CallGrouped>();
            lock (lock_obj)
            {
                foreach (var call in calllist)
                {
                    if (groupedcalls.Count()==0 || !groupedcalls.Last().Equals(call))
                    {
                        groupedcalls.Add(new CallGrouped(call));
                    }
                    else
                    {
                        groupedcalls.Last().UpdateCall(call);              
                    }
                }
            }
        
            return groupedcalls;
        }
    }
}
