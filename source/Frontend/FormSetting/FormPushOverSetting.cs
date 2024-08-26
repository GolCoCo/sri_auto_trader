using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRI_AUTO_TRADER.Backend;
using Syncfusion.Windows.Forms;

namespace SRI_AUTO_TRADER
{
    public partial class FormPushOverSetting : MetroForm
    {
        private PushOverSetting _pos = null;
        private FormPushOverSetting _pof = null;
        public FormPushOverSetting()
        {
            InitializeComponent();
            _pof = this;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _pos.Save();
            _pof.Close();
        }

        private void PushOverSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _pos.Save();

        }

        private void SoundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pos._Sound = SoundComboBox.SelectedIndex;
        }

        private void UserKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            _pos._UserKey = UserKeyTextBox.Text;
        }

        private void SendPushoverMsgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _pos._SendPushOverMsg = SendPushoverMsgCheckBox.Checked;
        }

        private void PushOverSettingForm_Load(object sender, EventArgs e)
        {
            _pos = PushOverSetting.Load<PushOverSetting>();
            if (_pos == null )
            {
                _pos = new PushOverSetting();
            }
            SendPushoverMsgCheckBox.Checked = _pos._SendPushOverMsg;
            UserKeyTextBox.Text = _pos._UserKey;
            SoundComboBox.SelectedIndex = _pos._Sound;
            APITokenTextBox.Text = _pos._APIToken;
        }

        private void APITokenTextBox_TextChanged(object sender, EventArgs e)
        {
            _pos._APIToken =  APITokenTextBox.Text;
        }
    }
}
