using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Simcard
{
    public class LifeSimcard : SimcardBase
    {
        public LifeSimcard(string number) : base(number)
        {
        }

        public override string GetCompanyName() =>"Life";
    }
}
