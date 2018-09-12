using MobilePhone.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTest.PhoneJackTest
{
    class OutputTest : IOutput
    {
        public string Outputtxt { get; private set; }
        public OutputTest()
        {
            Outputtxt = String.Empty;
        }
        public void Write(string text)
        {
            Outputtxt += text;
        }

        public void WriteLine(string text)
        {
            Outputtxt += text + '\n';
        }
    }
}
