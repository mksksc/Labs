using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.SMS;

namespace PhoneTest.SMSPhoneTest
{
    [TestClass]
    public class SMSProviderTest
    {
        [TestMethod]
        public void SMSReceivedTest()
        {
            var  provider = new SMSProvider();
            int invokecounter = 0;
            provider.SMSReceived += msg => invokecounter++;
            provider.ReceiveSMS("Message #1 received");
            Assert.AreEqual(1, invokecounter);
        }
    }
}
