using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone;
using System.Collections.Generic;
using System.Linq;

namespace PhoneTest.SMSPhoneTest
{
    [TestClass]
    public class MessageStorageTest
    {
        private List<Message> InitMessages()
        {
            return new List<Message>
            {
                new Message("+3804554845", "Hello World"),
                new Message("+3807771774", "Hi"),
                new Message("+3805578956", "Hello World"),
                new Message("+3801411141", "Hi")
            };
        }

        [TestMethod]
        public void AddTest()
        {
            List<Message> messages = InitMessages();
            var storage = new MessageStorage();
            messages.ForEach(x => storage.AddMessage(x));

            bool isSequenceEqual= Enumerable.SequenceEqual(messages, storage.GetMessages());
            Assert.IsTrue(isSequenceEqual);
        }

        [TestMethod]
        public void RemoveTest()
        {
            List<Message> messages = InitMessages();
            var storage = new MessageStorage();
            messages.ForEach(x=> storage.AddMessage(x));

            storage.RemoveMessage(messages[0]);
            storage.RemoveMessage(messages[1]);

            IEnumerable<Message> exp_msgs = new List<Message>
            {
                messages[2], messages[3]
            };

            bool isSequenceEqual = Enumerable.SequenceEqual(exp_msgs, storage.GetMessages());
            Assert.IsTrue(isSequenceEqual);
        }

        [TestMethod]
        public void AddEventTest()
        {
            var storage = new MessageStorage();
            int invokecount = 0;
            storage.MessageAdded += msg => invokecount++;

            storage.AddMessage(new Message("+3804554845", "Hello World"));
            Assert.AreEqual(1, invokecount);
        }

        [TestMethod]
        public void RemoveEventTest()
        {
            var message = new Message("+3804554845", "Hello World");
            var storage = new MessageStorage();
            int invokecount = 0;
            storage.MessageRemoved += msg => invokecount++;  
            storage.AddMessage(message);

            storage.RemoveMessage(new Message("+3801411141", "Hi"));
            Assert.AreEqual(0, invokecount);

            storage.RemoveMessage(message);
            Assert.AreEqual(1, invokecount);
        }
    }
}
