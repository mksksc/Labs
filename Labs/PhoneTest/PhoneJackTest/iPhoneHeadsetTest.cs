using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.PhoneJack;

namespace PhoneTest.PhoneJackTest
{
    [TestClass]
    public class iPhoneHeadsetTest
    {
        [TestMethod]
        public void P1layTest()
        {
            var output = new OutputTest();
            var iphoneheadset = new iPhoneHeadset(output);
            Assert.AreEqual(String.Empty, output.Outputtxt);
            iphoneheadset.Play(null);
            Assert.AreEqual($"{nameof(iPhoneHeadset)} sound\n", output.Outputtxt);
        }
    }
}
