namespace SRI_AUTO_TRADER
{
    partial class FormApp
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
            this.ProcessGroup = new System.Windows.Forms.GroupBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SettingGroup = new System.Windows.Forms.GroupBox();
            this.BrokerAPISettingBtn = new System.Windows.Forms.Button();
            this.OrderSendSettingBtn = new System.Windows.Forms.Button();
            this.SignalSourceSettingBtn = new System.Windows.Forms.Button();
            this.PushOverSettingBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ProcessGroup.SuspendLayout();
            this.SettingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ProcessGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 166);
            this.panel1.TabIndex = 0;
            // 
            // ProcessGroup
            // 
            this.ProcessGroup.Controls.Add(this.StartBtn);
            this.ProcessGroup.Controls.Add(this.ExitBtn);
            this.ProcessGroup.Location = new System.Drawing.Point(12, 90);
            this.ProcessGroup.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessGroup.Name = "ProcessGroup";
            this.ProcessGroup.Padding = new System.Windows.Forms.Padding(4);
            this.ProcessGroup.Size = new System.Drawing.Size(659, 63);
            this.ProcessGroup.TabIndex = 3;
            this.ProcessGroup.TabStop = false;
            this.ProcessGroup.Text = "Process";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(11, 24);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(117, 28);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(530, 26);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(117, 28);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SettingGroup
            // 
            this.SettingGroup.Controls.Add(this.BrokerAPISettingBtn);
            this.SettingGroup.Controls.Add(this.OrderSendSettingBtn);
            this.SettingGroup.Controls.Add(this.SignalSourceSettingBtn);
            this.SettingGroup.Controls.Add(this.PushOverSettingBtn);
            this.SettingGroup.Location = new System.Drawing.Point(13, 10);
            this.SettingGroup.Margin = new System.Windows.Forms.Padding(4);
            this.SettingGroup.Name = "SettingGroup";
            this.SettingGroup.Padding = new System.Windows.Forms.Padding(4);
            this.SettingGroup.Size = new System.Drawing.Size(659, 73);
            this.SettingGroup.TabIndex = 2;
            this.SettingGroup.TabStop = false;
            this.SettingGroup.Text = "Setting";
            // 
            // BrokerAPISettingBtn
            // 
            this.BrokerAPISettingBtn.Location = new System.Drawing.Point(170, 26);
            this.BrokerAPISettingBtn.Name = "BrokerAPISettingBtn";
            this.BrokerAPISettingBtn.Size = new System.Drawing.Size(153, 28);
            this.BrokerAPISettingBtn.TabIndex = 46;
            this.BrokerAPISettingBtn.Text = "Broker API Setting";
            this.BrokerAPISettingBtn.UseVisualStyleBackColor = true;
            this.BrokerAPISettingBtn.Click += new System.EventHandler(this.BrokerAPISettingBtn_Click);
            // 
            // OrderSendSettingBtn
            // 
            this.OrderSendSettingBtn.Location = new System.Drawing.Point(333, 26);
            this.OrderSendSettingBtn.Name = "OrderSendSettingBtn";
            this.OrderSendSettingBtn.Size = new System.Drawing.Size(153, 28);
            this.OrderSendSettingBtn.TabIndex = 43;
            this.OrderSendSettingBtn.Text = "Order Send Setting";
            this.OrderSendSettingBtn.UseVisualStyleBackColor = true;
            this.OrderSendSettingBtn.Click += new System.EventHandler(this.OrderSendSettingBtn_Click);
            // 
            // SignalSourceSettingBtn
            // 
            this.SignalSourceSettingBtn.Location = new System.Drawing.Point(7, 26);
            this.SignalSourceSettingBtn.Name = "SignalSourceSettingBtn";
            this.SignalSourceSettingBtn.Size = new System.Drawing.Size(153, 28);
            this.SignalSourceSettingBtn.TabIndex = 24;
            this.SignalSourceSettingBtn.Text = "Signal Source Setting";
            this.SignalSourceSettingBtn.UseVisualStyleBackColor = true;
            this.SignalSourceSettingBtn.Click += new System.EventHandler(this.SignalSourceSettingBtn_Click);
            // 
            // PushOverSettingBtn
            // 
            this.PushOverSettingBtn.Location = new System.Drawing.Point(496, 26);
            this.PushOverSettingBtn.Name = "PushOverSettingBtn";
            this.PushOverSettingBtn.Size = new System.Drawing.Size(153, 28);
            this.PushOverSettingBtn.TabIndex = 15;
            this.PushOverSettingBtn.Text = "PushOver Setting";
            this.PushOverSettingBtn.UseVisualStyleBackColor = true;
            this.PushOverSettingBtn.Click += new System.EventHandler(this.PushOverSettingBtn_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.Color.Silver;
            this.CaptionButtonColor = System.Drawing.Color.Gray;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Cooper Std Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(685, 166);
            this.Controls.Add(this.SettingGroup);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRI  AUTO TRADER V1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormApp_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ProcessGroup.ResumeLayout(false);
            this.SettingGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ProcessGroup;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.GroupBox SettingGroup;
        private System.Windows.Forms.Button BrokerAPISettingBtn;
        private System.Windows.Forms.Button OrderSendSettingBtn;
        private System.Windows.Forms.Button SignalSourceSettingBtn;
        private System.Windows.Forms.Button PushOverSettingBtn;
    }
}