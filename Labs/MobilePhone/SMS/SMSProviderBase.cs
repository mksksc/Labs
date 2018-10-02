using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobilePhone.SMS
{
    public abstract class SMSProviderBase
    {
        protected readonly int counrGenerators = 3;
        protected readonly int minTimeForSMS = 1000;
        protected readonly int maxTimeForSMS = 5000;
        private IMessageStorage storage;
        private int counter;
        private object lock_obj;
        private string[] users;
        private Random usersIndexRnd;
        private Random generatorDelaRnd;

        public abstract void StartGenerateSMS();
        public abstract void StopGenerateSMS();

        public SMSProviderBase(IMessageStorage storage)
        {
            this.storage = storage;
            lock_obj = new object();
            users = new string[]
            {
                "+308751566825",
                "+308865211124",
                "+301111111111",
                "+307777777777",
                "+308333333333",
            };
            usersIndexRnd = new Random();
            generatorDelaRnd = new Random();
        }

        protected void ReceiveSMS(Message message)
        {
            storage.AddMessage(message);
        }

        protected Message CreateMessage()
        { 
            lock(lock_obj)
            {
               return new Message(GetRandomUser(), $"Message #{counter++} received");
            }     
        }

        private string GetRandomUser()
        {
            int index = usersIndexRnd.Next(users.Length);
            return users[index];
        }

        protected int GetGeneratorDelay()
        {
            lock (lock_obj)
            {
                return generatorDelaRnd.Next(minTimeForSMS, maxTimeForSMS);
            }
        }
    }
}
