using MobilePhone.ContactBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallViewer
{
    public partial class CallViewerForm : Form
    {
        private CallStorage storage;
        private CallProvider callProvider;
        public CallViewerForm()
        {
            InitializeComponent();

            storage = new CallStorage();
            storage.CallAdded += RefreshCallListView;
            callProvider = new CallProvider(storage);
            callProvider.StartGenerateCalls();
        }

        private void RefreshCallListView()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshCallListView));
                return;
            }

            ShowCallListView(storage.GetCallGroupedList());
        }

        private void ShowCallListView(IEnumerable<CallGrouped> calllist)
        {
            CallListView.Items.Clear();

            foreach (var call in calllist)
            {
                CallListView.Items.Add(new ListViewItem(new[] { call.Contact.Name, call.Direction.ToString(), call.Time.ToString(), call.CallCount.ToString() }));
            }
        }
    }
}
