using MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMS.Filters
{
    public static class MsgFilter
    {
        public static IEnumerable<Message> ApplyFilter(MsgFilterObj filterObj)
        {
            if (filterObj.UseAndForCond)
            {
                return ApplyAndFilter(filterObj);
            }

            return ApplyOrFilter(filterObj);
        }

        private static IEnumerable<Message> ApplyOrFilter(MsgFilterObj filterObj)
        {
            return filterObj.Messages.Where(msg => CheckUser(msg, filterObj.User) ||
                    (filterObj.MessageText != null && filterObj.MessageText != string.Empty && msg.Text.Contains(filterObj.MessageText, StringComparison.OrdinalIgnoreCase)) ||
                    (filterObj.StartTime != null && filterObj.StartTime <= msg.ReceivingTime) ||
                    (filterObj.EndTime != null && filterObj.EndTime <= msg.ReceivingTime));
        }

        private static IEnumerable<Message> ApplyAndFilter(MsgFilterObj filterObj)
        {
            return filterObj.Messages.Where(msg => CheckUser(msg, filterObj.User) &&
                    (filterObj.MessageText == null || filterObj.MessageText == string.Empty || msg.Text.Contains(filterObj.MessageText, StringComparison.OrdinalIgnoreCase)) &&
                    (filterObj.StartTime == null || filterObj.StartTime <= msg.ReceivingTime) &&
                    (filterObj.EndTime == null || filterObj.EndTime >= msg.ReceivingTime));
        }

        public static bool CheckUser(Message message, string user)
        {
            return user == null || user == "All" || message.User == user;
        }

        private static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && (source.IndexOf(toCheck, comp) >= 0);
        }
    }
}
