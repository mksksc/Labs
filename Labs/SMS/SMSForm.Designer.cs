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
            this.MessagesRichTextBox = new System.Windows.Forms.RichTextBox();
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
            this.SMSSendTimer.Interval = 1000;
            this.SMSSendTimer.Tick += new System.EventHandler(this.SMSSendTimer_Tick);
            // 
            // MessagesRichTextBox
            // 
            this.MessagesRichTextBox.Location = new System.Drawing.Point(12, 52);
            this.MessagesRichTextBox.Name = "MessagesRichTextBox";
            this.MessagesRichTextBox.Size = new System.Drawing.Size(528, 393);
            this.MessagesRichTextBox.TabIndex = 1;
            this.MessagesRichTextBox.Text = "";
            // 
            // SMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 457);
            this.Controls.Add(this.MessagesRichTextBox);
            this.Controls.Add(this.MessageFormatCB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SMSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SMS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox MessageFormatCB;
        private System.Windows.Forms.Timer SMSSendTimer;
        private System.Windows.Forms.RichTextBox MessagesRichTextBox;
    }
}

