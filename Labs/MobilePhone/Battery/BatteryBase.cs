using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Helper;

namespace MobilePhone.Battery
{
    public abstract class BatteryBase
    {
        public double Voltage { get; }
        public double MaxCapacity { get; }

        private double capacity;
        public virtual double Capacity {
            get { return capacity; }
            protected set
            {
                ArgChecker.Chech4Positive(value);
                capacity = value;
            }
        }


        protected BatteryBase(double voltage, double maxCapacity)
        {
            ArgChecker.Chech4Positive(voltage);
            ArgChecker.Chech4Positive(maxCapacity);
            this.Voltage = voltage;
            this.Capacity = this.MaxCapacity = maxCapacity;
        }
    }

}
