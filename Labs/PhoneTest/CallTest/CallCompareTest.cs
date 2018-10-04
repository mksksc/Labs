using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.ContactBook;

namespace PhoneTest.CallTest
{
    [TestClass]
    public class CallCompareTest
    {
        [TestMethod]
        public void NotCallTest()
        {
            var contact = new Contact("Alex");
            contact.AddPhoneNumber("123");
            var call = new Call(contact, DateTime.Now, CallDirection.Incoming);
            var obj = new object();
            Assert.IsFalse(object.Equals(call,obj));
        }

        [TestMethod]
        public void SameCallTest()
        {
            var contact = new Contact("Alex");
            contact.AddPhoneNumber("123");
            var call = new Call(contact, DateTime.Now, CallDirection.Incoming);
            Assert.IsTrue(object.Equals(call, call));
        }

        [TestMethod]
        public void EqualTrueCallTest()
        {
            var contact = new Contact("Alex");
            contact.AddPhoneNumber("123");
            var call1 = new Call(contact, DateTime.Now, CallDirection.Incoming);
            var call2 = new Call(contact, DateTime.Now, CallDirection.Incoming);
            Assert.IsTrue(object.Equals(call1, call2));
        }


        [TestMethod]
        public void EqualFalseCallTest()
        {
            var contact1 = new Contact("Alex");
            contact1.AddPhoneNumber("123");
            var contact2 = new Contact("Bob");
            var call1 = new Call(contact1, DateTime.Now, CallDirection.Incoming);
            var call2 = new Call(contact2, DateTime.Now, CallDirection.Outcoming);
            Assert.IsFalse(object.Equals(call1, call2));
        }

        [TestMethod]
        public void OtherContactCallTest()
        {
            var contact1 = new Contact("Alex");
            contact1.AddPhoneNumber("123");
            var contact2 = new Contact("Bob");
            var call1 = new Call(contact1, DateTime.Now, CallDirection.Incoming);
            var call2 = new Call(contact2, DateTime.Now, CallDirection.Incoming);
            Assert.IsFalse(object.Equals(call1, call2));
        }

        [TestMethod]
        public void OtherDitectionCallTest()
        {
            var contact = new Contact("Alex");
            contact.AddPhoneNumber("123");
            var call1 = new Call(contact, DateTime.Now, CallDirection.Incoming);
            var call2 = new Call(contact, DateTime.Now, CallDirection.Outcoming);
            Assert.IsFalse(object.Equals(call1, call2));
        }
    }
}
