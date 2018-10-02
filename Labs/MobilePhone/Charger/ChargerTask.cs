using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Battery;
using System.Threading;

namespace MobilePhone.Charger
{
    public class ChargerTask : ChargerBase
    {
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;
        private Task charge;

        public ChargerTask(BatteryBase battery) : base(battery)
        {
            StartDischarging();
        }

        public override void StartChargind()
        {
            if (charge == null)
            {
                charge = Task.Run(async () => {
                    while (true)
                    {
                        if (token.IsCancellationRequested) return;
                        Charging();
                        await Task.Delay(chargeTick);
                    }
                });
            }
            isCharging = true;
        }

        public override void AbortCharger()
        {
            if (cancelTokenSource != null)
            {
                cancelTokenSource.Cancel();
            }
        }

        private void StartDischarging()
        {
            Task discharge = Task.Run(async () => {
                while (true)
                {
                    if (token.IsCancellationRequested) return;
                    Discharging();
                    await Task.Delay(dischargeTick);
                }
            });
        }

    }
}
