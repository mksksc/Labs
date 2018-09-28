using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MobilePhone;
using SMS.Filters;
using System.Linq;

namespace PhoneTest.SMSPhoneTest
{
    [TestClass]
    public class MsgFilterTest
    {
        DateTime now = DateTime.Now;
        private List<Message> InitMessages()
        {
            
            return new List<Message>
            {
                new Message("+3804554845", "Hello World",now),
                new Message("+3804554845", "Hi",now ),
                new Message("+3805578956", "Hello World",now),
                new Message("+3801411141", "Hi",now )
            };
        }

        [TestMethod]
        public void AndCondTest()
        {
            List<Message> messages = InitMessages();
            var filterObj = new MsgFilterObj()
            {
                Messages = messages,
                User = "+3804554845",
                MessageText = "H",
                StartTime = now,
                EndTime = now,
                UseAndForCond = true
            };

            IEnumerable<Message> exp_msgs = new List<Message>
            {
                messages[0],messages[1]
            };
            IEnumerable<Message> act_msgs = MsgFilter.ApplyFilter(filterObj);
            bool isSequenceEqual = Enumerable.SequenceEqual(exp_msgs, act_msgs);
            Assert.IsTrue(isSequenceEqual);
        }

    [TestMethod]
        public void OrCondTest()
        {
            List<Message> messages = InitMessages();
            var filterObj = new MsgFilterObj()
            {
                Messages = messages,
                User = "+3804554845",
                MessageText = "Some text",
                StartTime = null,
                EndTime = null,
                UseAndForCond = false
            };

            IEnumerable<Message> exp_msgs = new List<Message>
            {
                messages[0],messages[1]
            };
            IEnumerable<Message> act_msgs = MsgFilter.ApplyFilter(filterObj);
            bool isSequenceEqual = Enumerable.SequenceEqual(exp_msgs, act_msgs);
            Assert.IsTrue(isSequenceEqual);
        }
    }
}
