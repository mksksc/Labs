namespace Playback
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhoneSpeakerRB = new System.Windows.Forms.RadioButton();
            this.UnofficialiPhoneHeadsetRB = new System.Windows.Forms.RadioButton();
            this.SamsungHeadsetRB = new System.Windows.Forms.RadioButton();
            this.iPhoneHeadsetRB = new System.Windows.Forms.RadioButton();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhoneSpeakerRB);
            this.groupBox1.Controls.Add(this.UnofficialiPhoneHeadsetRB);
            this.groupBox1.Controls.Add(this.SamsungHeadsetRB);
            this.groupBox1.Controls.Add(this.iPhoneHeadsetRB);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select playback component:";
            // 
            // PhoneSpeakerRB
            // 
            this.PhoneSpeakerRB.AutoSize = true;
            this.PhoneSpeakerRB.Location = new System.Drawing.Point(18, 148);
            this.PhoneSpeakerRB.Name = "PhoneSpeakerRB";
            this.PhoneSpeakerRB.Size = new System.Drawing.Size(96, 17);
            this.PhoneSpeakerRB.TabIndex = 3;
            this.PhoneSpeakerRB.TabStop = true;
            this.PhoneSpeakerRB.Text = "PhoneSpeaker";
            this.PhoneSpeakerRB.UseVisualStyleBackColor = true;
            this.PhoneSpeakerRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // UnofficialiPhoneHeadsetRB
            // 
            this.UnofficialiPhoneHeadsetRB.AutoSize = true;
            this.UnofficialiPhoneHeadsetRB.Location = new System.Drawing.Point(18, 111);
            this.UnofficialiPhoneHeadsetRB.Name = "UnofficialiPhoneHeadsetRB";
            this.UnofficialiPhoneHeadsetRB.Size = new System.Drawing.Size(142, 17);
            this.UnofficialiPhoneHeadsetRB.TabIndex = 2;
            this.UnofficialiPhoneHeadsetRB.TabStop = true;
            this.UnofficialiPhoneHeadsetRB.Text = "UnofficialiPhoneHeadset";
            this.UnofficialiPhoneHeadsetRB.UseVisualStyleBackColor = true;
            this.UnofficialiPhoneHeadsetRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // SamsungHeadsetRB
            // 
            this.SamsungHeadsetRB.AutoSize = true;
            this.SamsungHeadsetRB.Location = new System.Drawing.Point(18, 73);
            this.SamsungHeadsetRB.Name = "SamsungHeadsetRB";
            this.SamsungHeadsetRB.Size = new System.Drawing.Size(109, 17);
            this.SamsungHeadsetRB.TabIndex = 1;
            this.SamsungHeadsetRB.TabStop = true;
            this.SamsungHeadsetRB.Text = "SamsungHeadset";
            this.SamsungHeadsetRB.UseVisualStyleBackColor = true;
            this.SamsungHeadsetRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // iPhoneHeadsetRB
            // 
            this.iPhoneHeadsetRB.AutoSize = true;
            this.iPhoneHeadsetRB.Location = new System.Drawing.Point(18, 38);
            this.iPhoneHeadsetRB.Name = "iPhoneHeadsetRB";
            this.iPhoneHeadsetRB.Size = new System.Drawing.Size(98, 17);
            this.iPhoneHeadsetRB.TabIndex = 0;
            this.iPhoneHeadsetRB.TabStop = true;
            this.iPhoneHeadsetRB.Text = "iPhoneHeadset";
            this.iPhoneHeadsetRB.UseVisualStyleBackColor = true;
            this.iPhoneHeadsetRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(75, 234);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(75, 23);
            this.ApplyBtn.TabIndex = 1;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(499, 224);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 281);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PhoneSpeakerRB;
        private System.Windows.Forms.RadioButton UnofficialiPhoneHeadsetRB;
        private System.Windows.Forms.RadioButton SamsungHeadsetRB;
        private System.Windows.Forms.RadioButton iPhoneHeadsetRB;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

