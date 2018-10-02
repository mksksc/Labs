using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobilePhone.SMS
{
    public class SMSProviderThread : SMSProviderBase
    {
        Thread[] smsgenarators;

        public SMSProviderThread(IMessageStorage storage) : base(storage)
        {
            smsgenarators = new Thread[counrGenerators];
        }

        public override void StartGenerateSMS()
        {
            StopGenerateSMS();

            for (int i = 0; i < counrGenerators; i++)
            {
                smsgenarators[i] = CreateGenerator();
            }
        }

        private Thread CreateGenerator()
        {
            var generator = new Thread(()=>{
               while(true)
                {           
                    ReceiveSMS(CreateMessage());
                    Thread.Sleep(GetGeneratorDelay());
                }
            });
            generator.Start();
            return generator;
        }

        public override void StopGenerateSMS()
        {
            foreach (var genarator in smsgenarators)
            {
                if (genarator != null)
                {
                    genarator.Abort();
                }              
            }
        }
    }
}
