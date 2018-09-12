using MobilePhone.Battery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Charger
{
    public class iPhoneCharger : ICharger
    {
        public void Charge(IPoverUnit poverUnit)
        {
            poverUnit.OnCharged += StopCharge;
            poverUnit.StartCharging();
        }

        private void StopCharge(object sender, EventArgs e)
        {
            IPoverUnit poverUnit = sender as IPoverUnit;
            if (poverUnit != null)
            {
                poverUnit.OnCharged -= StopCharge;
                poverUnit.StopCharging();
            }
        }
    }
}
