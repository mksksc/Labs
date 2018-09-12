using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Microphone
{
    public abstract class MicrophoneBase
    {
        public byte Volume { get; set; }
        public abstract void StartFetchingSound();
        public abstract void StopFetchingSound();

        protected MicrophoneBase()
        {
            Volume = Byte.MaxValue;
        }
    }
}
