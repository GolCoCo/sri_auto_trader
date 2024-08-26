namespace SRI_AUTO_TRADER
{
    partial class FormOrderSendSetting
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
            this.SendOrderTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SendDeleteOrderBeforeNewOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.DefaultAmountPerOrderNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoSendNewOrderCheck = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultAmountPerOrderNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SendOrderTypeComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SendDeleteOrderBeforeNewOrderCheckBox);
            this.panel1.Controls.Add(this.DefaultAmountPerOrderNumUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AutoSendNewOrderCheck);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 178);
            this.panel1.TabIndex = 0;
            // 
            // SendOrderTypeComboBox
            // 
            this.SendOrderTypeComboBox.FormattingEnabled = true;
            this.SendOrderTypeComboBox.Items.AddRange(new object[] {
            "Calculated Qty",
            "Send Notional Qty"});
            this.SendOrderTypeComboBox.Location = new System.Drawing.Point(119, 108);
            this.SendOrderTypeComboBox.Name = "SendOrderTypeComboBox";
            this.SendOrderTypeComboBox.Size = new System.Drawing.Size(180, 23);
            this.SendOrderTypeComboBox.TabIndex = 28;
            this.SendOrderTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SendOrderTypeComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Send Order Type:";
            // 
            // SendDeleteOrderBeforeNewOrderCheckBox
            // 
            this.SendDeleteOrderBeforeNewOrderCheckBox.AutoSize = true;
            this.SendDeleteOrderBeforeNewOrderCheckBox.Location = new System.Drawing.Point(15, 78);
            this.SendDeleteOrderBeforeNewOrderCheckBox.Name = "SendDeleteOrderBeforeNewOrderCheckBox";
            this.SendDeleteOrderBeforeNewOrderCheckBox.Size = new System.Drawing.Size(229, 19);
            this.SendDeleteOrderBeforeNewOrderCheckBox.TabIndex = 4;
            this.SendDeleteOrderBeforeNewOrderCheckBox.Text = "Send Delete Order Before New Order";
            this.SendDeleteOrderBeforeNewOrderCheckBox.UseVisualStyleBackColor = true;
            this.SendDeleteOrderBeforeNewOrderCheckBox.CheckedChanged += new System.EventHandler(this.SendNotionalQtyCheckBox_CheckedChanged);
            // 
            // DefaultAmountPerOrderNumUpDown
            // 
            this.DefaultAmountPerOrderNumUpDown.Location = new System.Drawing.Point(165, 16);
            this.DefaultAmountPerOrderNumUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DefaultAmountPerOrderNumUpDown.Name = "DefaultAmountPerOrderNumUpDown";
            this.DefaultAmountPerOrderNumUpDown.Size = new System.Drawing.Size(134, 21);
            this.DefaultAmountPerOrderNumUpDown.TabIndex = 3;
            this.DefaultAmountPerOrderNumUpDown.ValueChanged += new System.EventHandler(this.DefaultQtyAmountNumUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Default Amount Per Order: ";
            // 
            // AutoSendNewOrderCheck
            // 
            this.AutoSendNewOrderCheck.AutoSize = true;
            this.AutoSendNewOrderCheck.Location = new System.Drawing.Point(15, 49);
            this.AutoSendNewOrderCheck.Name = "AutoSendNewOrderCheck";
            this.AutoSendNewOrderCheck.Size = new System.Drawing.Size(144, 19);
            this.AutoSendNewOrderCheck.TabIndex = 1;
            this.AutoSendNewOrderCheck.Text = "Auto Send New Order";
            this.AutoSendNewOrderCheck.UseVisualStyleBackColor = true;
            this.AutoSendNewOrderCheck.CheckedChanged += new System.EventHandler(this.AutoSendOrdersCheck_CheckedChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(229, 138);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(70, 25);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FormOrderSendSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.Color.Silver;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(313, 178);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormOrderSendSetting";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Send Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlpacaOrderForm_FormClosed);
            this.Load += new System.EventHandler(this.AlpacaOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultAmountPerOrderNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown DefaultAmountPerOrderNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AutoSendNewOrderCheck;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox SendDeleteOrderBeforeNewOrderCheckBox;
        private System.Windows.Forms.ComboBox SendOrderTypeComboBox;
        private System.Windows.Forms.Label label5;
    }
}