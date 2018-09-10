using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Keyboard
{
    public abstract class KeyboardBase
    {
        public char[] Figures { get; protected set; }
        public char[] Letters { get; protected set; }
    }
}
