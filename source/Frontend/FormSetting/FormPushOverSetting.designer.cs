namespace SRI_AUTO_TRADER
{
    partial class FormPushOverSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.APITokenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoundComboBox = new System.Windows.Forms.ComboBox();
            this.UserKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendPushoverMsgCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.APITokenTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SoundComboBox);
            this.panel1.Controls.Add(this.UserKeyTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SendPushoverMsgCheckBox);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 190);
            this.panel1.TabIndex = 0;
            // 
            // APITokenTextBox
            // 
            this.APITokenTextBox.Location = new System.Drawing.Point(77, 64);
            this.APITokenTextBox.Name = "APITokenTextBox";
            this.APITokenTextBox.Size = new System.Drawing.Size(196, 21);
            this.APITokenTextBox.TabIndex = 8;
            this.APITokenTextBox.TextChanged += new System.EventHandler(this.APITokenTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "API Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sound:";
            // 
            // SoundComboBox
            // 
            this.SoundComboBox.FormattingEnabled = true;
            this.SoundComboBox.Items.AddRange(new object[] {
            "magic",
            "incoming",
            "cashregister",
            "bike",
            "none"});
            this.SoundComboBox.Location = new System.Drawing.Point(77, 118);
            this.SoundComboBox.Name = "SoundComboBox";
            this.SoundComboBox.Size = new System.Drawing.Size(196, 23);
            this.SoundComboBox.TabIndex = 5;
            this.SoundComboBox.SelectedIndexChanged += new System.EventHandler(this.SoundComboBox_SelectedIndexChanged);
            // 
            // UserKeyTextBox
            // 
            this.UserKeyTextBox.Location = new System.Drawing.Point(77, 91);
            this.UserKeyTextBox.Name = "UserKeyTextBox";
            this.UserKeyTextBox.Size = new System.Drawing.Size(196, 21);
            this.UserKeyTextBox.TabIndex = 4;
            this.UserKeyTextBox.TextChanged += new System.EventHandler(this.UserKeyTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Key:";
            // 
            // SendPushoverMsgCheckBox
            // 
            this.SendPushoverMsgCheckBox.AutoSize = true;
            this.SendPushoverMsgCheckBox.Location = new System.Drawing.Point(17, 23);
            this.SendPushoverMsgCheckBox.Name = "SendPushoverMsgCheckBox";
            this.SendPushoverMsgCheckBox.Size = new System.Drawing.Size(170, 19);
            this.SendPushoverMsgCheckBox.TabIndex = 1;
            this.SendPushoverMsgCheckBox.Text = "Send Order Pushover Msg";
            this.SendPushoverMsgCheckBox.UseVisualStyleBackColor = true;
            this.SendPushoverMsgCheckBox.CheckedChanged += new System.EventHandler(this.SendPushoverMsgCheckBox_CheckedChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(178, 153);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(87, 25);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FormPushOverSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.Color.Silver;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(292, 190);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPushOverSetting";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PushOver Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PushOverSettingForm_FormClosing);
            this.Load += new System.EventHandler(this.PushOverSettingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SoundComboBox;
        private System.Windows.Forms.TextBox UserKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SendPushoverMsgCheckBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox APITokenTextBox;
        private System.Windows.Forms.Label label3;
    }
}