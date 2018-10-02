using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobilePhone.SMS
{
    public class SMSProviderTask : SMSProviderBase
    {
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;

        public SMSProviderTask(IMessageStorage storage) : base(storage)
        {
        }

        public override void StartGenerateSMS()
        {
            StopGenerateSMS();

            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;

            for (int i = 0; i < counrGenerators; i++)
            {
                CreateGenerator();
            }

        }

        private void CreateGenerator()
        {
            var generator = Task.Run(async () => {
                while (true)
                {
                    if (token.IsCancellationRequested) return;
                    ReceiveSMS(CreateMessage());
                    await Task.Delay(GetGeneratorDelay());
                }
            });
        }

        public override void StopGenerateSMS()
        {
            if (cancelTokenSource != null)
            {
                cancelTokenSource.Cancel();
            }
        }
    }
}
