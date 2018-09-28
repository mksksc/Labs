using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone;

namespace SMS.Formatter
{
    public static class MessageFormatter
    {
        public static string FormatNone(Message msg) => msg.Text;
        public static string FormatStartTime(Message msg) => $"[{msg.ReceivingTime}] {msg.Text}";
        public static string FormatEndTime(Message msg) => $"{msg.Text} [{msg.ReceivingTime}]";
        public static string FormatCustom(Message msg) => $"❤C#❤ {msg.Text} ❤C#❤";
        public static string FormatLowercase(Message msg) => msg.Text.ToLower();
        public static string FormatUppercase(Message msg) => msg.Text.ToUpper();
    }
}
