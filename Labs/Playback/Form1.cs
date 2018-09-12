using MobilePhone.PhoneJack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone.Output;
using MobilePhone.Phone;
using Playback.Output;

namespace Playback
{
    public partial class Form1 : Form
    {
        private IPlayback Playback;
        private IOutput Output;
        private MobilePhoneBase MobilePhone;

        public Form1()
        {
            InitializeComponent();
            Output= new WinFormOutput(textBox1);
            MobilePhone = new SimCorpPhone();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (!radioButton.Checked)
            {
                return;
            }

            switch (radioButton.Name)
            {
                case nameof(iPhoneHeadsetRB):
                    Playback = new iPhoneHeadset(Output);
                    break;
                case nameof(SamsungHeadsetRB):
                    Playback = new SamsungHeadset(Output);
                    break;
                case nameof(UnofficialiPhoneHeadsetRB):
                    Playback = new UnofficialiPhoneHeadset(Output);
                    break;
                case nameof(PhoneSpeakerRB):
                    Playback = new SamsungHeadset(Output);
                    break;
                default:
                    throw new ArgumentException();
            }

            Output.WriteLine(radioButton.Name + " playback selected");
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Output.WriteLine("Set playback to Mobile...");
            MobilePhone.PlaybackComponent = Playback;
            Output.WriteLine("Play sound in Mobile:");
            MobilePhone.Play(null);

        }
    }
}
