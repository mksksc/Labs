using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Microphone
{
    public class MobileMicrophone : MicrophoneBase
    {
        public override void StartFetchingSound() => Console.WriteLine("Start fetching sound");

        public override void StopFetchingSound() => Console.WriteLine("Stop fetching sound");

        public override string ToString() => "Mobile microphone";
    }
}
