using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Battery
{
    public abstract class MobileBattery : BatteryBase, IPoverUnit
    {
        public virtual event EventHandler OnCharged;
        public virtual event EventHandler OnCharging;
        public virtual event EventHandler OnStopCharging;

        public virtual void StartCharging()
        {
            if (MaxCapacity>Capacity)
            {
                OnCharging?.Invoke(this, EventArgs.Empty);
                return;
            }

            OnCharged?.Invoke(this,EventArgs.Empty);  
        }

        public virtual void StopCharging()
        {
            OnStopCharging?.Invoke(this,EventArgs.Empty);
        }

        protected MobileBattery(double voltage, double maxCapacity) : base(voltage, maxCapacity)
        {
        }
    }
}
