using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Battery;

namespace PhoneTest.ChargerTest
{

    [TestClass]
    public class BatteryTest
    {
        [TestMethod]
        public void CreatedFullChargeTest()
        {
            BatteryBase Battery = new LiIonBattery(3.81, 2716);
            Assert.AreEqual(100, Battery.Charge);
        }

        [TestMethod]
        public void MaxChargeSetTest()
        {
            BatteryBase Battery = new LiIonBattery(3.81, 2716);
            Battery.Charge = 101;
            Assert.AreEqual(100, Battery.Charge);
        }

        [TestMethod]
        public void MinChargeSetTest()
        {
            BatteryBase Battery = new LiIonBattery(3.81, 2716);
            Battery.Charge = -1;
            Assert.AreEqual(0, Battery.Charge);
        }

        [TestMethod]
        public void NormalChargeSeTest()
        {
            BatteryBase Battery = new LiIonBattery(3.81, 2716);
            sbyte charge = (sbyte) new Random().Next(0,100);
            Battery.Charge = charge;
            Assert.AreEqual(charge, Battery.Charge);
        }
    }
}
