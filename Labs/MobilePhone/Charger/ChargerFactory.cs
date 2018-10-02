using MobilePhone.Battery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Charger
{
    public static class ChargerFactory
    {
        public static ChargerBase GetCharger(BatteryBase battery, ChargerType type)
        {
            switch (type)
            {
                case ChargerType.Theard:
                    return new ChargerThread(battery);
                case ChargerType.Task:
                    return new ChargerTask(battery);
                default:
                    throw new NotImplementedException($"Not implemented logic for {type.ToString()} in {nameof(ChargerType)}");
            }   
        }
    }
    public enum ChargerType { Theard, Task}
}
