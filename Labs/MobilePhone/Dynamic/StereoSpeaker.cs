using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Dynamic
{
    public class StereoSpeaker : MonoSpeaker
    {
        public sbyte Balance { get; set; }

        public override string ToString() => "Stereophonic speaker";

        public StereoSpeaker() : base()
        {
            Balance = 0;
        }
    }
}
