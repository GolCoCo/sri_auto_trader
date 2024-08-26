using System;
using System.Windows.Forms;
using SRI_AUTO_TRADER.Backend;
using Syncfusion.Windows.Forms;

namespace SRI_AUTO_TRADER
{
    public partial class FormBrokerAPISetting : MetroForm
    {
        private BrokerAPISetting _bs = null;
        private FormBrokerAPISetting _form;
        public FormBrokerAPISetting()
        {
            InitializeComponent();
            _form = this;
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _bs.Save();
            _form.Close();
        }

        private void AlpacaOrder_Load(object sender, EventArgs e)
        {
            _bs = BrokerAPISetting.Load<BrokerAPISetting>();

            if (_bs == null)
            {
                _bs = new BrokerAPISetting();
            }

            this.AM1NameTextBox.Text = _bs._AM1Name;
            this.AM2NameTextBox.Text = _bs._AM2Name;
            this.AM3NameTextBox.Text = _bs._AM3Name;

            this.AM1AccountTypeComboBox.SelectedIndex = _bs._AM1AccoutType;
            this.AM2AccountTypeComboBox.SelectedIndex = _bs._AM2AccoutType;
            this.AM3AccountTypeComboBox.SelectedIndex = _bs._AM3AccoutType;

            this.AM1AppKeyTexBox.Text = _bs._AM1APIKey;
            this.AM2AppKeyTexBox.Text = _bs._AM2APIKey;
            this.AM3AppKeyTexBox.Text = _bs._AM3APIKey;

            this.AM1AppSecretTextBox.Text = _bs._AM1PAISecretKey;
            this.AM2AppSecretTextBox.Text = _bs._AM2PAISecretKey;
            this.AM3AppSecretTextBox.Text = _bs._AM3PAISecretKey;
        }

        private void AM1NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM1Name = this.AM1NameTextBox.Text;
        }

        private void AM2NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM2Name = this.AM2NameTextBox.Text;
        }

        private void AM3NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM3Name = this.AM3NameTextBox.Text;
        }

        private void AM1AccountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bs._AM1AccoutType = this.AM1AccountTypeComboBox.SelectedIndex;
        }

        private void AM2AccountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bs._AM2AccoutType = this.AM2AccountTypeComboBox.SelectedIndex;
        }

        private void AM3AccountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bs._AM3AccoutType = this.AM3AccountTypeComboBox.SelectedIndex;
        }

        private void AM1AppKeyTexBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM1APIKey = this.AM1AppKeyTexBox.Text;
        }

        private void AM2AppKeyTexBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM2APIKey = this.AM2AppKeyTexBox.Text;
        }

        private void AM3AppKeyTexBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM3APIKey = this.AM3AppKeyTexBox.Text;
        }

        private void AM1AppSecretTextBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM1PAISecretKey = this.AM1AppSecretTextBox.Text;
        }

        private void AM2AppSecretTextBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM2PAISecretKey = this.AM2AppSecretTextBox.Text;
        }

        private void AM3AppSecretTextBox_TextChanged(object sender, EventArgs e)
        {
            _bs._AM3PAISecretKey = this.AM3AppSecretTextBox.Text;
        }
    }
}
