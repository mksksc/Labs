using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Keyboard
{
    public class CallKeyboard : KeyboardBase
    {
        public CallKeyboard()
        {
            Letters = new char[] {'+','*','#'};
            Figures = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

        public override string ToString() => "Call number keyboard";
    }
}
