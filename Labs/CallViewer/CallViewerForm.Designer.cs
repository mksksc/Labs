namespace CallViewer
{
    partial class CallViewerForm
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
            this.CallListView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CallDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CallTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountCalls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CallListView
            // 
            this.CallListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.CallDirection,
            this.CallTime,
            this.CountCalls});
            this.CallListView.Location = new System.Drawing.Point(12, 26);
            this.CallListView.Name = "CallListView";
            this.CallListView.Size = new System.Drawing.Size(684, 498);
            this.CallListView.TabIndex = 0;
            this.CallListView.UseCompatibleStateImageBehavior = false;
            this.CallListView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 204;
            // 
            // CallDirection
            // 
            this.CallDirection.Text = "Call Direction";
            this.CallDirection.Width = 152;
            // 
            // CallTime
            // 
            this.CallTime.Text = "Last Call Time";
            this.CallTime.Width = 163;
            // 
            // CountCalls
            // 
            this.CountCalls.Text = "Call Count ";
            this.CountCalls.Width = 161;
            // 
            // CallViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 536);
            this.Controls.Add(this.CallListView);
            this.Text = "Calls Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CallListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader CallDirection;
        private System.Windows.Forms.ColumnHeader CallTime;
        private System.Windows.Forms.ColumnHeader CountCalls;
    }
}

