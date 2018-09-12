using MobilePhone.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.PhoneJack
{
    public class PhoneSpeaker : HeadsetBase
    {
        public PhoneSpeaker(IOutput output) : base(output) { }

        public override void Play(object data)
        {
            output.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
