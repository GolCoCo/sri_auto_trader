using CsvHelper;
using CsvHelper.Configuration;
using SRI_AUTO_TRADER.Backend;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SRI_AUTO_TRADER
{
    public partial class FormApp : MetroForm
    {
        public FormApp _form;
        public FormApp()
        {
            InitializeComponent();
            _form = this;
        }

        private void SignalSourceSettingBtn_Click(object sender, EventArgs e)
        {
            FormSignalSourceSetting form = new FormSignalSourceSetting();
            form.Show();
        }

        private void BrokerAPISettingBtn_Click(object sender, EventArgs e)
        {
            FormBrokerAPISetting form = new FormBrokerAPISetting();
            form.Show();

        }

        private void OrderSendSettingBtn_Click(object sender, EventArgs e)
        {
            FormOrderSendSetting form = new FormOrderSendSetting();
            form.Show();
        }

        private void PushOverSettingBtn_Click(object sender, EventArgs e)
        {
            FormPushOverSetting form = new FormPushOverSetting();
            form.Show();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            FormOrderReceivedScreen form = new FormOrderReceivedScreen();
            form.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            _form.Close();
        }

        private void FormApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
