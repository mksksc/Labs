using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Dynamic
{
    public abstract class Speaker
    {
        public byte Volume { get; set; }

        protected Speaker()
        {
            Volume = Byte.MaxValue;
        }
    }
}
