using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Battery
{
    public interface IPoverUnit
    {
        event EventHandler OnCharging;
        event EventHandler OnStopCharging;
        event EventHandler OnCharged;

        void StartCharging();
        void StopCharging();
    }
}
