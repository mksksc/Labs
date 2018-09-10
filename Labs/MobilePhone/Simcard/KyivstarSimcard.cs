using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Simcard
{
    public class KyivstarSimcard : SimcardBase
    {
        public KyivstarSimcard(string number) : base(number)
        {
        }

        public override string GetCompanyName() => "Kyivstar";
    }
}
