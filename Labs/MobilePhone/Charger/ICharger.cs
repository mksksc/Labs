using MobilePhone.Battery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Charger
{
    public interface ICharger
    {
        void Charge(IPoverUnit poverUnit);
    }
}
