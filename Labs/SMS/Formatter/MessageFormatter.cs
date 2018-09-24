using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Formatter
{
    public static class MessageFormatter
    {
        public static string FormatNone(string msg) => msg;
        public static string FormatStartTime(string msg) => $"[{DateTime.Now}] {msg}";
        public static string FormatEndTime(string msg) => $"{msg} [{DateTime.Now}]";
        public static string FormatCustom(string msg) => $"❤C#❤ {msg} ❤C#❤";
        public static string FormatLowercase(string msg) => msg.ToLower();
        public static string FormatUppercase(string msg) => msg.ToUpper();
    }
}
