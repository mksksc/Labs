namespace SMS
{
    partial class SMSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MessageFormatCB = new System.Windows.Forms.ComboBox();
            this.SMSSendTimer = new System.Windows.Forms.Timer(this.components);
            this.MessageListView = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsersComboBox = new System.Windows.Forms.ComboBox();
            this.MsgSearchTextBox = new System.Windows.Forms.TextBox();
            this.MsgStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.MsgEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.UseAndCheckBox = new System.Windows.Forms.CheckBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MessageFormatCB
            // 
            this.MessageFormatCB.FormattingEnabled = true;
            this.MessageFormatCB.Location = new System.Drawing.Point(12, 12);
            this.MessageFormatCB.Name = "MessageFormatCB";
            this.MessageFormatCB.Size = new System.Drawing.Size(242, 21);
            this.MessageFormatCB.TabIndex = 0;
            this.MessageFormatCB.Text = "Select Formatting";
            this.MessageFormatCB.SelectedIndexChanged += new System.EventHandler(this.MessageFormatCB_SelectedIndexChanged);
            // 
            // SMSSendTimer
            // 
            this.SMSSendTimer.Enabled = true;
            this.SMSSendTimer.Interval = 2000;
            this.SMSSendTimer.Tick += new System.EventHandler(this.SMSSendTimer_Tick);
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Message});
            this.MessageListView.Location = new System.Drawing.Point(12, 122);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(675, 430);
            this.MessageListView.TabIndex = 1;
            this.MessageListView.TileSize = new System.Drawing.Size(675, 30);
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Tile;
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Location = new System.Drawing.Point(374, 12);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Size = new System.Drawing.Size(313, 21);
            this.UsersComboBox.TabIndex = 2;
            this.UsersComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchField_Changed);
            // 
            // MsgSearchTextBox
            // 
            this.MsgSearchTextBox.Location = new System.Drawing.Point(374, 39);
            this.MsgSearchTextBox.Name = "MsgSearchTextBox";
            this.MsgSearchTextBox.Size = new System.Drawing.Size(313, 20);
            this.MsgSearchTextBox.TabIndex = 3;
            this.MsgSearchTextBox.TextChanged += new System.EventHandler(this.SearchField_Changed);
            // 
            // MsgStartDateTime
            // 
            this.MsgStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.MsgStartDateTime.Location = new System.Drawing.Point(374, 65);
            this.MsgStartDateTime.Name = "MsgStartDateTime";
            this.MsgStartDateTime.ShowCheckBox = true;
            this.MsgStartDateTime.Size = new System.Drawing.Size(141, 20);
            this.MsgStartDateTime.TabIndex = 4;
            this.MsgStartDateTime.ValueChanged += new System.EventHandler(this.SearchField_Changed);
            // 
            // MsgEndDateTime
            // 
            this.MsgEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.MsgEndDateTime.Location = new System.Drawing.Point(546, 65);
            this.MsgEndDateTime.Name = "MsgEndDateTime";
            this.MsgEndDateTime.ShowCheckBox = true;
            this.MsgEndDateTime.Size = new System.Drawing.Size(141, 20);
            this.MsgEndDateTime.TabIndex = 5;
            this.MsgEndDateTime.ValueChanged += new System.EventHandler(this.SearchField_Changed);
            // 
            // UseAndCheckBox
            // 
            this.UseAndCheckBox.AutoSize = true;
            this.UseAndCheckBox.Location = new System.Drawing.Point(374, 91);
            this.UseAndCheckBox.Name = "UseAndCheckBox";
            this.UseAndCheckBox.Size = new System.Drawing.Size(121, 17);
            this.UseAndCheckBox.TabIndex = 6;
            this.UseAndCheckBox.Text = "Use AND for search";
            this.UseAndCheckBox.UseVisualStyleBackColor = true;
            this.UseAndCheckBox.CheckedChanged += new System.EventHandler(this.SearchField_Changed);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // SMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 564);
            this.Controls.Add(this.UseAndCheckBox);
            this.Controls.Add(this.MsgEndDateTime);
            this.Controls.Add(this.MsgStartDateTime);
            this.Controls.Add(this.MsgSearchTextBox);
            this.Controls.Add(this.UsersComboBox);
            this.Controls.Add(this.MessageListView);
            this.Controls.Add(this.MessageFormatCB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SMSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MessageFormatCB;
        private System.Windows.Forms.Timer SMSSendTimer;
        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ComboBox UsersComboBox;
        private System.Windows.Forms.TextBox MsgSearchTextBox;
        private System.Windows.Forms.DateTimePicker MsgStartDateTime;
        private System.Windows.Forms.DateTimePicker MsgEndDateTime;
        private System.Windows.Forms.CheckBox UseAndCheckBox;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}

