using System;
using System.Windows.Forms;
using SRI_AUTO_TRADER.Backend;
using Syncfusion.Windows.Forms;

namespace SRI_AUTO_TRADER
{
    public partial class FormSignalSourceSetting : MetroForm
    {
        private SignalSourceSetting _ss = null;
        private FormSignalSourceSetting _form;
        public FormSignalSourceSetting()
        {
            InitializeComponent();
            _form = this;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _ss.Save();
            _form.Close();
        }

        private void AlpacaOrder_Load(object sender, EventArgs e)
        {
            _ss = SignalSourceSetting.Load<SignalSourceSetting>();

            if (_ss == null)
            {
                _ss = new SignalSourceSetting();
            }

            InitializeUISettings();
        }

        private void InitializeUISettings()
        {
            this.SignalReceivedDBTextBox.Text = this._ss._SignalReceivedDB;

            // pusher settings
            this.Pusher1DefaultBrokerComboBox.SelectedIndex = _ss._Pusher1DefaultBroker;
            this.Pusher2DefaultBrokerComboBox.SelectedIndex = _ss._Pusher2DefaultBroker;
            this.Pusher3DefaultBrokerComboBox.SelectedIndex = _ss._Pusher3DefaultBroker;

            this.Pusher1ChannelTextBox.Text = _ss._Pusher1Channel;
            this.Pusher2ChannelTextBox.Text = _ss._Pusher2Channel;
            this.Pusher3ChannelTextBox.Text = _ss._Pusher3Channel;

            this.Pusher1AppSecretTextBox.Text = _ss._Pusher1AppCluster;
            this.Pusher2AppSecretTextBox.Text = _ss._Pusher2AppCluster;
            this.Pusher3AppSecretTextBox.Text = _ss._Pusher3AppCluster;

            this.Pusher1AppKeyTexBox.Text = _ss._Pusher1AppKey;
            this.Pusher2AppKeyTextBox.Text = _ss._Pusher2AppKey;
            this.Pusher3AppKeyTextBox.Text = _ss._Pusher3AppKey;

            this.Pusher1EventTextBox.Text = _ss._Pusher1Event;
            this.Pusher2EventTextBox.Text = _ss._Pusher2Event;
            this.Pusher3EventTextBox.Text = _ss._Pusher3Event;

            this.Pusher1NameTextBox.Text = _ss._Pusher1Name;
            this.Pusher2NameTextBox.Text = _ss._Pusher2Name;
            this.Pusher3NameTextBox.Text = _ss._Pusher3Name;

            this.Pusher1CheckBox.Checked = _ss._IsPusher1Enable;
            this.Pusher1GroupBox.Enabled = _ss._IsPusher1Enable;
            this.Pusher2CheckBox.Checked = _ss._IsPusher2Enable;
            this.Pusher2GroupBox.Enabled = _ss._IsPusher2Enable;
            this.Pusher3CheckBox.Checked = _ss._IsPusher3Enable;
            this.Pusher3GroupBox.Enabled = _ss._IsPusher3Enable;

            // netmq settings
            //this.NetMQ1NameTextBox.Text = _ss._NetMQ1Name;
            //this.NetMQ2NameTextBox.Text = _ss._NetMQ2Name;
            //this.NetMQ3NameTextBox.Text = _ss._NetMQ3Name;

            //this.NetMQ1IPTextBox.Text = _ss._NetMQ1IP;
            //this.NetMQ2IPTextBox.Text = _ss._NetMQ2IP;
            //this.NetMQ3IPTextBox.Text = _ss._NetMQ3IP;

            //this.NetMQ1PortTextBox.Text = _ss._NetMQ1Port;
            //this.NetMQ2PortTextBox.Text = _ss._NetMQ2Port;
            //this.NetMQ3PortTextBox.Text = _ss._NetMQ3Port;

            //this.NetMQ1TopicTextBox.Text = _ss._NetMQ1Topic;
            //this.NetMQ2TopicTextBox.Text = _ss._NetMQ2Topic;
            //this.NetMQ3TopicTextBox.Text = _ss._NetMQ3Topic;

            //this.NetMQ1DefaultBrokerComboBox.SelectedIndex = _ss._NetMQ1DefaultBroker;
            //this.NetMQ2DefaultBrokerComboBox.SelectedIndex = _ss._NetMQ2DefaultBroker;
            //this.NetMQ3DefaultBrokerComboBox.SelectedIndex = _ss._NetMQ3DefaultBroker;

            //this.NetMQ1CheckBox.Checked = _ss._IsNetMQ1Enable;
            //this.NetMQ1GroupBox.Enabled = _ss._IsNetMQ1Enable;
            //this.NetMQ2CheckBox.Checked = _ss._IsNetMQ2Enable;
            //this.NetMQ2GroupBox.Enabled = _ss._IsNetMQ2Enable;
            //this.NetMQ3CheckBox.Checked = _ss._IsNetMQ3Enable;
            //this.NetMQ3GroupBox.Enabled = _ss._IsNetMQ3Enable;
        }

        private void AlpacaOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void SignalReceivedDBtn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbDlg = new FolderBrowserDialog();
            DialogResult ret = fbDlg.ShowDialog();
            if (ret == DialogResult.OK && !string.IsNullOrWhiteSpace(fbDlg.SelectedPath))
            {
                this._ss._SignalReceivedDB = fbDlg.SelectedPath;
                this.SignalReceivedDBTextBox.Text = this._ss._SignalReceivedDB;
            }
        }

        private void Pusher1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _ss._IsPusher1Enable = this.Pusher1CheckBox.Checked;
            this.Pusher1GroupBox.Enabled = _ss._IsPusher1Enable;
        }

        private void Pusher2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _ss._IsPusher2Enable = this.Pusher2CheckBox.Checked;
            this.Pusher2GroupBox.Enabled = _ss._IsPusher2Enable;
        }

        private void Pusher3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _ss._IsPusher3Enable = this.Pusher3CheckBox.Checked;
            this.Pusher3GroupBox.Enabled = _ss._IsPusher3Enable;
        }

        //private void NetMQ3CheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    _ss._IsNetMQ3Enable = this.NetMQ3CheckBox.Checked;
        //    this.NetMQ3GroupBox.Enabled = _ss._IsNetMQ3Enable;
        //}

        //private void NetMQ2CheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    _ss._IsNetMQ1Enable = this.NetMQ1CheckBox.Checked;
        //    this.NetMQ1GroupBox.Enabled = _ss._IsNetMQ1Enable;
        //}

        //private void NetMQ1CheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    _ss._IsNetMQ1Enable = this.NetMQ1CheckBox.Checked;
        //    this.NetMQ1GroupBox.Enabled = _ss._IsNetMQ1Enable;
        //}

        private void Pusher1NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher1Name = this.Pusher1NameTextBox.Text;
        }

        private void Pusher2NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher2Name = this.Pusher2NameTextBox.Text;
        }

        private void Pusher3NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher3Name = this.Pusher3NameTextBox.Text;
        }

        private void Pusher1AppKeyTexBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher1AppKey = this.Pusher1AppKeyTexBox.Text;
        }

        private void Pusher2AppKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher2AppKey = this.Pusher2AppKeyTextBox.Text;
        }

        private void Pusher3AppKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher3AppKey = this.Pusher3AppKeyTextBox.Text;
        }

        private void Pusher1AppSecretTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher1AppCluster = this.Pusher1AppSecretTextBox.Text;
        }

        private void Pusher2AppSecretTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher2AppCluster = this.Pusher2AppSecretTextBox.Text;
        }

        private void Pusher3AppSecretTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher3AppCluster = this.Pusher3AppSecretTextBox.Text;
        }

        private void Pusher1ChannelTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher1Channel = this.Pusher1ChannelTextBox.Text;
        }

        private void Pusher2ChannelTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher2Channel = this.Pusher2ChannelTextBox.Text;
        }

        private void Pusher3ChannelTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher3Channel = this.Pusher3ChannelTextBox.Text;
        }

        private void Pusher1DefaultBrokerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ss._Pusher1DefaultBroker = this.Pusher1DefaultBrokerComboBox.SelectedIndex;
        }

        private void Pusher2DefaultBrokerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ss._Pusher2DefaultBroker = this.Pusher2DefaultBrokerComboBox.SelectedIndex;
        }

        private void Pusher3DefaultBrokerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ss._Pusher3DefaultBroker = this.Pusher3DefaultBrokerComboBox.SelectedIndex;
        }

        private void Pusher1EventTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher1Event = this.Pusher1EventTextBox.Text;
        }

        private void Pusher2EventTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher2Event = this.Pusher2EventTextBox.Text;
        }

        private void Pusher3EventTextBox_TextChanged(object sender, EventArgs e)
        {
            _ss._Pusher3Event = this.Pusher3EventTextBox.Text;
        }

        private void Pusher4EventTextBox_TextChanged(object sender, EventArgs e)
        {
            //_ss._Pusher3Event = this.Pusher4EventTextBox.Text;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //private void NetMQ1NameTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ1Name = this.NetMQ1NameTextBox.Text;
        //}

        //private void NetMQ2NameTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ2Name = this.NetMQ2NameTextBox.Text;
        //}

        //private void NetMQ3NameTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ3Name = this.NetMQ3NameTextBox.Text;
        //}

        //private void NetMQ1IPTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ1IP = this.NetMQ1IPTextBox.Text;
        //}

        //private void NetMQ2IPTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ2IP = this.NetMQ2IPTextBox.Text;
        //}

        //private void NetMQ3IPTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ3IP = this.NetMQ3IPTextBox.Text;
        //}

        //private void NetMQ1PortTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ1Port = this.NetMQ1PortTextBox.Text;
        //}

        //private void NetMQ2PortTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ2Port = this.NetMQ2PortTextBox.Text;
        //}

        //private void NetMQ3PortTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ3Port = this.NetMQ3PortTextBox.Text;
        //}

        //private void NetMQ1TopicTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ1Topic = this.NetMQ1TopicTextBox.Text;
        //}

        //private void NetMQ2TopicTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ2Topic = this.NetMQ2TopicTextBox.Text;
        //}

        //private void NetMQ3TopicTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ3Topic = this.NetMQ3TopicTextBox.Text;
        //}

        //private void NetMQ1DefaultBrokerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ1DefaultBroker = this.NetMQ1DefaultBrokerComboBox.SelectedIndex;
        //}

        //private void NetMQ2DefaultBrokerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ2DefaultBroker = this.NetMQ2DefaultBrokerComboBox.SelectedIndex;
        //}

        //private void NetMQ3DefaultBrokerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _ss._NetMQ3DefaultBroker = this.NetMQ3DefaultBrokerComboBox.SelectedIndex;
        //}
    }
}
