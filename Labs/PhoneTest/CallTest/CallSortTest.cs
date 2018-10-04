using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.ContactBook;
using System.Collections.Generic;
using System.Linq;

namespace PhoneTest.CallTest
{
    [TestClass]
    public class CallSortTest
    {
        private List<Call> InitCalls()
        {
            return new List<Call>
            {
                new Call(new Contact("Daniel"),new DateTime(2018,10,1), CallDirection.Incoming),
                new Call(new Contact("Joshua"),new DateTime(2018,09,1), CallDirection.Outcoming),
                new Call(new Contact("Mark"),new DateTime(2018,10,10), CallDirection.Incoming),
                new Call(new Contact("Paul"),new DateTime(2018,08,1), CallDirection.Outcoming)
            };
        }

        [TestMethod]
        public void AddItemSortTest()
        {
            List<Call> calls = InitCalls();
            var storage = new CallStorage();
            storage.AddCall(calls[0]);
            storage.AddCall(calls[1]);
            storage.AddCall(calls[2]);
            storage.AddCall(calls[3]);

            IEnumerable<Call> exp_calls = new List<Call>
            {
                calls[3],calls[1],calls[0],calls[2]
            };

            Assert.IsTrue(Enumerable.SequenceEqual(exp_calls,storage.GetCalls()));
        }

        [TestMethod]
        public void RemoveItemSortTest()
        {
            List<Call> calls = InitCalls();
            var storage = new CallStorage();
            storage.AddCall(calls[0]);
            storage.AddCall(calls[1]);
            storage.AddCall(calls[2]);
            storage.AddCall(calls[3]);

            storage.RemoveCall(calls[1]);
            storage.RemoveCall(calls[2]);

            IEnumerable<Call> exp_calls = new List<Call>
            {
                calls[3],calls[0]
            };

            Assert.IsTrue(Enumerable.SequenceEqual(exp_calls, storage.GetCalls()));
        }
    }
}
