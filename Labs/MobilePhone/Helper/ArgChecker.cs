using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Helper
{
    internal static class ArgChecker
    {
        public static void Chech4Positive(double num)
        {
            if (num<=0)
            {
                throw new ArgumentException("Number must be positive");
            }
        }
    }
}
