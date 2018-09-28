using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Battery;
using MobilePhone.Dynamic;
using MobilePhone.Keyboard;
using MobilePhone.Microphone;
using MobilePhone.Screen;
using MobilePhone.SimCard;

namespace MobilePhone.Phone
{
    public class SimCorpPhone : MobilePhoneBase
    {
        public override BatteryBase Battery { get; protected set; }
        public override Speaker Speaker { get; protected set; }
        public override KeyboardBase Keyboard { get; protected set; }
        public override MicrophoneBase Microphone { get; protected set; }
        public override ScreenBase Screen { get; protected set; }
        public override Simcard Simcard { get; protected set; }

        public SimCorpPhone()
        {
            Battery = new LiIonBattery(3.81, 2716);
            Speaker = new StereoSpeaker();
            Keyboard = new CallKeyboard();
            Microphone = new MobileMicrophone();
            Screen = new TouchScreen(new TouchManager(), 143.6, 70.9, 2436, 1125,TouchScreenType.MultiTouch);
            Simcard = new Simcard("+380879879455","Life");
            MessageStorage = new MessageStorage();
            SMSProvider = new SMSProvider(MessageStorage);
        }
    }
}
