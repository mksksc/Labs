using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone;

namespace PhoneTest.SMSPhoneTest
{
    [TestClass]
    public class SMSProviderTest
    {
        [TestMethod]
        public void SMSReceivedTest()
        {
            var storage = new MessageStorage();
            var  provider = new SMSProvider(storage);
            int invokecounter = 0;
            provider.SMSReceived += msg => invokecounter++;
            provider.ReceiveSMS(new Message("9379992", "Wait for me!"));
            Assert.AreEqual(1, invokecounter);
        }
    }
}
