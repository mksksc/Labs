using MobilePhone.Battery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Charger
{
    public abstract class ChargerBase
    {
        public readonly int dischargeTick = 2000;
        public readonly int chargeTick = 1000;
        private BatteryBase battery;
        protected bool isCharging;
        private object lock_obj;

        public abstract void StartChargind();
        public abstract void AbortCharger();
        public void StopChargind()
        {
            isCharging = false;
        }

        public ChargerBase(BatteryBase battery)
        {
            this.battery = battery;
            lock_obj = new object();
        }

        protected void Discharging()
        {
            lock (lock_obj)
            {
                battery.Charge--;
            }
        }

        protected void Charging()
        {
            lock (lock_obj)
            {
                if (isCharging)
                {
                    battery.Charge++;
                }
            }
        }
    }
}
