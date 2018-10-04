using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobilePhone.ContactBook
{
    public class CallProvider
    {
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;
        private CallStorage storage;
        private Contact[] contacts;
        private Random contactIndexRnd;


        public CallProvider(CallStorage storage)
        {
            this.storage = storage;
            contactIndexRnd = new Random();
            contacts = new Contact[]
            {
                new Contact("Sophia"),
                new Contact("John"),
  //               new Contact("Daniel"),
            };
        }

        public void StartGenerateCalls()
        {
            StopGenerateCalls();

            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;

            Task.Run(async ()=>
            {         
                while (true)
                {
                    if (token.IsCancellationRequested) return;
                    var call = new Call(GetRandomContact(),DateTime.Now, GetRandomDirecton());
                    storage.AddCall(call);
                    await Task.Delay(1000);
                }
            });

        }

        public void StopGenerateCalls()
        {
            if (cancelTokenSource != null)
            {
                cancelTokenSource.Cancel();
            }
        }

        private Contact GetRandomContact()
        {
            int index = contactIndexRnd.Next(contacts.Length);
            return contacts[index];
        }

        private CallDirection GetRandomDirecton()
        {
            return (CallDirection)contactIndexRnd.Next((int)CallDirection.Incoming, (int)CallDirection.Outcoming+1);

        }
    }
}
