using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Output;

namespace MobilePhone.PhoneJack
{
    public abstract class HeadsetBase : IPlayback
    {
        protected IOutput output;
        public abstract void Play(object data);

        protected HeadsetBase(IOutput output)
        {
            this.output = output;
        }
    }
}
