using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Simcard
{
    public abstract class SimcardBase
    {
        public string Number { get; }
        public abstract string GetCompanyName();

        protected SimcardBase(string number)
        {
            this.Number = number;
        }

        public override string ToString()
        {
            return $@"Simcard with number {Number} from company {GetCompanyName()}";
        }
    }
}
