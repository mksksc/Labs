using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMS.Formatter;
using MobilePhone;

namespace PhoneTest.SMSPhoneTest
{
    [TestClass]
    public class MessageFormatterTest
    {
        [TestMethod]
        public void FormatNoneTest()
        {
            string testmsg = "Message #1 received";
            var message = new Message("111", testmsg);         
            string formmsg= MessageFormatter.FormatNone(message);
            Assert.AreEqual(testmsg, formmsg);
        }

        [TestMethod]
        public void FormatStartTimeTest()
        {
            string testmsg = "Message #1 received";
            var message = new Message("111", testmsg);
            string formmsg = MessageFormatter.FormatStartTime(message);
            Assert.AreEqual($"[{message.ReceivingTime}] {testmsg}", formmsg);
        }

        [TestMethod]
        public void FormatEndTimeTest()
        {
            string testmsg = "Message #1 received";
            var message = new Message("111", testmsg);
            string formmsg = MessageFormatter.FormatEndTime(message);
            Assert.AreEqual($"{testmsg} [{message.ReceivingTime}]", formmsg);
        }

        [TestMethod]
        public void FormatCustomTest()
        {
            string testmsg = "Message #1 received";
            var message = new Message("111", testmsg);
            string formmsg = MessageFormatter.FormatCustom(message);
            Assert.AreEqual($"❤C#❤ {testmsg} ❤C#❤", formmsg);
        }

        [TestMethod]
        public void FormatLowercaseTest()
        {
            string testmsg = "Message #1 received";
            var message = new Message("111", testmsg);
            string formmsg = MessageFormatter.FormatLowercase(message);
            Assert.AreEqual(testmsg.ToLower(), formmsg);
        }

        [TestMethod]
        public void FormatUppercaseTest()
        {
            string testmsg = "Message #1 received";
            var message = new Message("111", testmsg);
            string formmsg = MessageFormatter.FormatUppercase(message);
            Assert.AreEqual(testmsg.ToUpper(), formmsg);
        }
    }
}
