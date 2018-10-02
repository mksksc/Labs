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
        public event Action<sbyte> ChargeChanged;
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

        private sbyte charge;
        public sbyte Charge
        {
            get { return charge; }
            set
            {
                if (value < 0) { charge = 0; }
                else if (value > 100) { charge = 100; }
                else { charge = value; }
                ChargeChanged?.Invoke(charge);
            }
        }


        protected BatteryBase(double voltage, double maxCapacity)
        {
            ArgChecker.Chech4Positive(voltage);
            ArgChecker.Chech4Positive(maxCapacity);
            this.Voltage = voltage;
            this.Capacity = this.MaxCapacity = maxCapacity;
            this.Charge = 100;
        }
    }

}
