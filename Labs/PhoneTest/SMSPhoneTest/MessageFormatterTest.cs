using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMS.Formatter;

namespace PhoneTest.SMSPhoneTest
{
    [TestClass]
    public class MessageFormatterTest
    {
        [TestMethod]
        public void FormatNoneTest()
        {
            string testmsg = "Message #1 received";
            string formmsg= MessageFormatter.FormatNone(testmsg);
            Assert.AreEqual(testmsg, formmsg);
        }

        [TestMethod]
        public void FormatStartTimeTest()
        {
            string testmsg = "Message #1 received";
            string formmsg = MessageFormatter.FormatStartTime(testmsg);
            Assert.AreEqual($"[{DateTime.Now}] {testmsg}", formmsg);
        }

        [TestMethod]
        public void FormatEndTimeTest()
        {
            string testmsg = "Message #1 received";
            string formmsg = MessageFormatter.FormatEndTime(testmsg);
            Assert.AreEqual($"{testmsg} [{DateTime.Now}]", formmsg);
        }

        [TestMethod]
        public void FormatCustomTest()
        {
            string testmsg = "Message #1 received";
            string formmsg = MessageFormatter.FormatCustom(testmsg);
            Assert.AreEqual($"❤C#❤ {testmsg} ❤C#❤", formmsg);
        }

        [TestMethod]
        public void FormatLowercaseTest()
        {
            string testmsg = "Message #1 received";
            string formmsg = MessageFormatter.FormatLowercase(testmsg);
            Assert.AreEqual(testmsg.ToLower(), formmsg);
        }

        [TestMethod]
        public void FormatUppercaseTest()
        {
            string testmsg = "Message #1 received";
            string formmsg = MessageFormatter.FormatUppercase(testmsg);
            Assert.AreEqual(testmsg.ToUpper(), formmsg);
        }
    }
}
