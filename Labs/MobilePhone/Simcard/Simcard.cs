using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.SimCard
{
    public class Simcard
    {
        public string Number { get; }
        public string Company { get; }
        public SimcardType SimType { get; }

        public Simcard(string number, string company)
        {
            this.Number = number;
            this.Company = company;
            this.SimType = SimcardType.Nano;
        }

        public override string ToString()
        {
            return $@"Simcard with number {Number} from company {Company}";
        }

        public enum SimcardType
        {
           Nano,Micro,Mini 
        }

        
    }
}
