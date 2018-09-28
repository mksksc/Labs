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
using MobilePhone;
using SMS.Formatter;
using SMS.Filters;

namespace SMS
{
    public partial class SMSForm : Form
    {
        private delegate string FormatDelegate(MobilePhone.Message text);
        private FormatDelegate Formatter;
        private MobilePhoneBase Mobile;
        private int counter;

        public SMSForm()
        {
            Mobile = new SimCorpPhone();

            InitializeComponent();
            MessageFormatCB.Items.AddRange(GetMessageFormatCBItems());
            MessageFormatCB.SelectedItem = MessageFormatCB.Items[0];
            UsersComboBox.Items.Add("All");
            UsersComboBox.SelectedItem = UsersComboBox.Items[0];
            Mobile.MessageStorage.MessageAdded += OnSMSReceiver;
        }

        private void OnSMSReceiver(MobilePhone.Message message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<MobilePhone.Message>(OnSMSReceiver), message);
                return;
            }

            CheckIfNewUser(message);
        }

        private void CheckIfNewUser(MobilePhone.Message message)
        {
            if (!UsersComboBox.Items.Contains(message.User))
            {
                UsersComboBox.Items.Add(message.User);
            }
        }

        private void MessageFormatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (ItemMessageFormatCB)MessageFormatCB.SelectedItem;
            Formatter = item.Formatter;
            RefreshMessagesView();
        }

        private void SearchField_Changed(object sender, EventArgs e)
        {
            RefreshMessagesView();
        }

        private void RefreshMessagesView()
        {
            var filterObj = new MsgFilterObj()
            {
                Messages = Mobile.MessageStorage.GetMessages(),
                User = UsersComboBox.SelectedItem as string,
                MessageText = MsgSearchTextBox.Text,
                StartTime = null,
                EndTime = null,
                UseAndForCond = UseAndCheckBox.Checked
            };

            if (MsgStartDateTime.Checked) filterObj.StartTime = MsgStartDateTime.Value;
            if (MsgEndDateTime.Checked) filterObj.EndTime = MsgEndDateTime.Value;

            ShowMessages(MsgFilter.ApplyFilter(filterObj));
        }

        private void ShowMessages(IEnumerable<MobilePhone.Message> messages)
        {
            MessageListView.Items.Clear();

            foreach (var message in messages)
            {
                MessageListView.Items.Add(new ListViewItem(new[] { message.User, Formatter(message) }));
            }
        }

        private void SMSSendTimer_Tick(object sender, EventArgs e)
        {
            var msg = new MobilePhone.Message(GetRandomUser(), $"Message #{counter++} received");
            Mobile.ReceiveSMS(msg);
        }

        private string GetRandomUser()
        {
            var users = new string[]
            {
                "+308751566825",
                "+308865211124",
                "+301111111111",
                "+307777777777",
                "+308333333333",
            };
            int index = new Random().Next(users.Length);
            return users[index];
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

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshMessagesView();
        }
    }
}
