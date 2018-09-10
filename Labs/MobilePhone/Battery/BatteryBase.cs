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
        public double Height { get; }
        public virtual double Width { get; }
        public double Depth { get; }
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


        protected BatteryBase(double height, double width, double depth, double voltage, double maxCapacity)
        {
            ArgChecker.Chech4Positive(height);
            ArgChecker.Chech4Positive(width);
            ArgChecker.Chech4Positive(depth);
            ArgChecker.Chech4Positive(voltage);
            ArgChecker.Chech4Positive(maxCapacity);
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
            this.Voltage = voltage;
            this.Capacity = this.MaxCapacity = maxCapacity;
        }
    }

}
