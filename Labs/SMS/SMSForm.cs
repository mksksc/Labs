using MobilePhone.Phone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone.SMS;
using SMS.Formatter;

namespace SMS
{
    public partial class SMSForm : Form
    {
        private delegate string FormatDelegate(string text);
        private FormatDelegate Formatter;
        private MobilePhoneBase MobilePhone;
        private int counter;

        public SMSForm()
        {
            InitializeComponent();
            MessageFormatCB.Items.AddRange(GetMessageFormatCBItems());
            MessageFormatCB.SelectedItem = MessageFormatCB.Items[0];
            MobilePhone = new SimCorpPhone();
            MobilePhone.SMSProvider.SMSReceived += OnSMSReceiver;
        }

        private void SMSSendTimer_Tick(object sender, EventArgs e)
        {
            MobilePhone.ReceiveSMS($"Message #{counter++} received");
        }

        private void OnSMSReceiver(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnSMSReceiver), message);
                return;
            }

            string formattedMessage = Formatter(message);
            MessagesRichTextBox.AppendText(formattedMessage + Environment.NewLine);
        }

        private void MessageFormatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (ItemMessageFormatCB)MessageFormatCB.SelectedItem;
            Formatter = item.Formatter;

        }

        private ItemMessageFormatCB[] GetMessageFormatCBItems()
        {
            var items = new ItemMessageFormatCB[]
            {
                new ItemMessageFormatCB("None", MessageFormatter.FormatNone),
                new ItemMessageFormatCB("Start with DateTime", MessageFormatter.FormatStartTime),
                new ItemMessageFormatCB("End with DateTime", MessageFormatter.FormatEndTime),
                new ItemMessageFormatCB("Custom", MessageFormatter.FormatCustom),
                new ItemMessageFormatCB("Lowercase", MessageFormatter.FormatLowercase),
                new ItemMessageFormatCB("Uppercase", MessageFormatter.FormatUppercase),
            };
            return items;
        }

        private class ItemMessageFormatCB
        {
            public readonly string Name;
            public readonly FormatDelegate Formatter;

            public ItemMessageFormatCB(string name, FormatDelegate formatter)
            {
                this.Name = name;
                this.Formatter = formatter;
            }

            public override string ToString() => Name;
        }
    }
}
