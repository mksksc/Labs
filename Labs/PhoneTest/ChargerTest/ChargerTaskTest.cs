using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Battery;
using MobilePhone.Charger;
using System.Threading;

namespace PhoneTest.ChargerTest
{
    [TestClass]
    public class ChargerTaskTest
    {
        [TestMethod]
        public void DischargeTaskTest()
        {
            BatteryBase Battery = new LiIonBattery(3.81, 2716);
            var Charger = ChargerFactory.GetCharger(Battery, ChargerType.Task);
            Thread.Sleep(Charger.dischargeTick);
            Assert.IsTrue(Battery.Charge < 100);
        }

        [TestMethod]
        public void ChargeTaskTest()
        {
            BatteryBase Battery = new LiIonBattery(3.81, 2716);
            var Charger = ChargerFactory.GetCharger(Battery, ChargerType.Task);
            Charger.StartChargind();
            Thread.Sleep(Charger.dischargeTick * 2);
            Assert.IsTrue(Battery.Charge >= 99);
        }
    }
}
