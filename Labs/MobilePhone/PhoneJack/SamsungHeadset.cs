using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Output;

namespace MobilePhone.PhoneJack
{
    public class SamsungHeadset : HeadsetBase
    {
        public SamsungHeadset(IOutput output) : base(output) {}

        public override void Play(object data)
        {
            output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}
