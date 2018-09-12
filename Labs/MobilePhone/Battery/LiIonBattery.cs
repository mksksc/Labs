using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Battery
{
    public class LiIonBattery : MobileBattery
    {
        public LiIonBattery(double voltage, double maxCapacity) : base(voltage, maxCapacity)
        {
        }

        public override void StopCharging()
        {
            base.StopCharging();
            Console.WriteLine("Charging battery was stoped");
        }

        public override string ToString() => "Lithium-ion battery";
    }
}
