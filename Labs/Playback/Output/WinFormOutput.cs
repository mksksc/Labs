using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone.Output;

namespace Playback.Output
{
    class WinFormOutput : IOutput
    {
        private TextBox textBox;
        public WinFormOutput(TextBox textBox)
        {
            this.textBox = textBox;
        }
        public void Write(string text)
        {
            textBox.AppendText(text);
        }

        public void WriteLine(string text)
        {
            textBox.AppendText(text+'\n');
        }
    }
}
