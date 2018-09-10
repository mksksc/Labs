using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Battery
{
    public class LiIonBattery : MobileBattery
    {
        public LiIonBattery(double height, double width, double depth, double voltage, double maxCapacity) : base(height, width, depth, voltage, maxCapacity)
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
