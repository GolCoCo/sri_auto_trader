using System;
using System.Windows.Forms;
using SRI_AUTO_TRADER.Backend;
using Syncfusion.Windows.Forms;

namespace SRI_AUTO_TRADER
{
    public partial class FormOrderSendSetting : MetroForm
    {
        private AlpacaOrderSetting _aos = null;
        private FormOrderSendSetting _aof;
        public FormOrderSendSetting()
        {
            InitializeComponent();
            _aof = this;
        }

        private void AutoSendOrdersCheck_CheckedChanged(object sender, EventArgs e)
        {
            _aos._AutoSendOrder = this.AutoSendNewOrderCheck.Checked;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _aos.Save();
            _aof.Close();
        }

        private void AlpacaOrder_Load(object sender, EventArgs e)
        {
            _aos = AlpacaOrderSetting.Load<AlpacaOrderSetting>();

            if (_aos == null)
            {
                _aos = new AlpacaOrderSetting();
            }
            this.AutoSendNewOrderCheck.Checked = _aos._AutoSendOrder;
            this.DefaultAmountPerOrderNumUpDown.Value = _aos._DefaultQtyAmount;
            this.SendDeleteOrderBeforeNewOrderCheckBox.Checked = _aos._DeleteSendNewOrder;
            this.SendOrderTypeComboBox.SelectedIndex = _aos._SendOrderType;
        }

        private void DefaultQtyAmountNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            _aos._DefaultQtyAmount = (int)this.DefaultAmountPerOrderNumUpDown.Value;
        }

        private void SendNotionalQtyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _aos._DeleteSendNewOrder =  this.SendDeleteOrderBeforeNewOrderCheckBox.Checked;
        }

        private void AlpacaOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _aos.Save();
        }

        private void SendOrderTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _aos._SendOrderType = this.SendOrderTypeComboBox.SelectedIndex;
        }
    }
}
