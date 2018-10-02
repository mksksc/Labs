using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobilePhone.Battery;

namespace MobilePhone.Charger
{
    public class ChargerThread : ChargerBase
    {
        private Thread charge;
        private Thread discharge;

        public ChargerThread(BatteryBase battery) : base(battery)
        {
            StartDischarging();
        }

        public override void StartChargind()
        {
            if(charge == null)
            {
                charge = new Thread(() => {
                    while (true)
                    {
                        Charging();
                        Thread.Sleep(chargeTick);
                    }
                });
                charge.Name = "Charge";
                charge.Start();
            }
            isCharging = true;
        }

        public override void AbortCharger()
        {
            if (charge != null) charge.Abort();
            if (discharge != null) discharge.Abort();
        }

        private void StartDischarging()
        {
            discharge = new Thread(()=> {
                while (true)
                {
                    Discharging();
                    Thread.Sleep(dischargeTick);
                }
            });
            discharge.Name = "Discharge";
            discharge.Start();
        }

    }
}
