using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using SRI_AUTO_TRADER.Backend;
using Syncfusion.Windows.Forms;

namespace SRI_AUTO_TRADER
{
    public partial class FormOrderReceivedScreen : MetroForm
    {
        private FormOrderReceivedScreen _form;
        private SignalSourceSetting _signalSourceSetting;
        private BrokerAPISetting _brokerAPISetting;
        private PushOverSetting _pusherOverSetting;
        private AlpacaOrderSetting _orderSendSetting;
        private PusherListener _pusherListenter1 = null;
        private PusherListener _pusherListenter2 = null;
        private PusherListener _pusherListenter3 = null;
        private SignalReceivedDBManager _sqliteManager = null;
        private PushOverMsgManager _pushOverManager = null;
        private AlpacaMarketOrderAPIManager _alpacaOrderManager1 = null;
        private AlpacaMarketOrderAPIManager _alpacaOrderManager2 = null;
        private AlpacaMarketOrderAPIManager _alpacaOrderManager3 = null;
        private AlpacaMarketAPIManager _alpacaMarketAPIManager1 = null;
        private AlpacaMarketAPIManager _alpacaMarketAPIManager2 = null;
        private AlpacaMarketAPIManager _alpacaMarketAPIManager3 = null;
        public FormOrderReceivedScreen()
        {
            InitializeComponent();
            _form = this;
        }

        private void FormOrderReceivedScreen_Load(object sender, EventArgs e)
        {
            LoadSettings();
            SetStyleDataGridView();

            _sqliteManager = new SignalReceivedDBManager(_signalSourceSetting._SignalReceivedDB, "signal_received.db");
            //RunTestThread();
            
            Thread t1 = new Thread(() =>
            {
                UpdateProgressBar();
            });
            t1.Start();

            _pushOverManager = new PushOverMsgManager(_pusherOverSetting);
            _alpacaOrderManager1 = new AlpacaMarketOrderAPIManager(_brokerAPISetting._AM1APIKey, _brokerAPISetting._AM1PAISecretKey, _brokerAPISetting._AM1AccoutType);
            _alpacaOrderManager2 = new AlpacaMarketOrderAPIManager(_brokerAPISetting._AM2APIKey, _brokerAPISetting._AM2PAISecretKey, _brokerAPISetting._AM2AccoutType);
            _alpacaOrderManager3 = new AlpacaMarketOrderAPIManager(_brokerAPISetting._AM3APIKey, _brokerAPISetting._AM3PAISecretKey, _brokerAPISetting._AM3AccoutType);

            DoProcessReceivingMsg();
        }

        private void LoadSettings()
        {
            _signalSourceSetting = SignalSourceSetting.Load<SignalSourceSetting>();
            if (_signalSourceSetting == null) _signalSourceSetting = new SignalSourceSetting();

            _brokerAPISetting = BrokerAPISetting.Load<BrokerAPISetting>();
            if (_brokerAPISetting == null) _brokerAPISetting = new BrokerAPISetting();

            _pusherOverSetting = PushOverSetting.Load<PushOverSetting>();
            if (_pusherOverSetting == null) _pusherOverSetting = new PushOverSetting();

            _orderSendSetting = AlpacaOrderSetting.Load<AlpacaOrderSetting>();
            if (_orderSendSetting == null) _orderSendSetting = new AlpacaOrderSetting();
        }

        int value = 5;
        System.Timers.Timer _testMarkettimer = null;
        public void UpdateProgressBar()
        {
            _testMarkettimer = new System.Timers.Timer();
            _testMarkettimer.Elapsed += new ElapsedEventHandler(OnTestMarketAPI);
            _testMarkettimer.Interval = 100;
            _testMarkettimer.Enabled = true;
            _testMarkettimer.Start();
        }
        private void OnTestMarketAPI(object sender, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.SignalProgressBar.Value = (value) % 100;
                value = value + 5;
            });
        }

        private void RunTestThread()
        {
            Thread t1 = new Thread(() =>
            {
                string[] files = Directory.GetFiles("D:\\MYTEST");
                foreach (string file in files)
                {
                    string response = File.ReadAllText(@file);
                    JObject jObject = UtilFunctions.GetJObjectFromPusherPayload(response);
                    if (jObject == null) return;
                    SignalData sd = UtilFunctions.GetSignalDataFromJson(jObject);
                    sd._signalSource = _signalSourceSetting._Pusher1Name;
                    if (_signalSourceSetting._Pusher1DefaultBroker == 0)
                    {
                        sd._brokerSent = _brokerAPISetting._AM1Name;
                    }
                    bool isret = _sqliteManager.InsertSignalData(sd);

                    if (!isret)
                    {
                        sd._signalSentStatus = "DUPLICATE";
                        sd._brokerStatus = "NOT SENT";
                        sd._signalDBStatus = "EXISTING";
                        this.Invoke((MethodInvoker)delegate
                        {
                            AddDataGridViewRow(sd);
                        });
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            AddDataGridViewRow(sd);
                            Thread.Sleep(300);
                            UpdateDataGridView(sd._receivedTime, sd._signalHash);
                        });
                    }

                }
            });
            t1.IsBackground = true;
            t1.Start();
        }

        private void DoProcessReceivingMsg()
        {

                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += new DoWorkEventHandler(bw_DoWorkReceivingMsg);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_DoWorkCompletedReceivingMsg);
                bw.RunWorkerAsync();
            
        }

        private void bw_DoWorkCompletedReceivingMsg(object sender, RunWorkerCompletedEventArgs e)
        {

        }


        private void bw_DoWorkReceivingMsg(object sender, DoWorkEventArgs e)
        {
            if (_signalSourceSetting._IsPusher1Enable)
            {
                string appkey = _signalSourceSetting._Pusher1AppKey;
                string channel = _signalSourceSetting._Pusher1Channel;
                string cluster = _signalSourceSetting._Pusher1AppCluster;
                string eventname = _signalSourceSetting._Pusher1Event;
                _pusherListenter1 = new PusherListener(appkey, cluster, channel, eventname);
                StartPusherMsgListnerAsync(_pusherListenter1);
            }
            if (_signalSourceSetting._IsPusher2Enable)
            {
                string appkey = _signalSourceSetting._Pusher2AppKey;
                string channel = _signalSourceSetting._Pusher2Channel;
                string cluster = _signalSourceSetting._Pusher2AppCluster;
                string eventname = _signalSourceSetting._Pusher2Event;
                _pusherListenter2 = new PusherListener(appkey, cluster, channel, eventname);
                StartPusherMsgListnerAsync(_pusherListenter2);
            }
            if (_signalSourceSetting._IsPusher3Enable)
            {
                string appkey = _signalSourceSetting._Pusher3AppKey;
                string channel = _signalSourceSetting._Pusher3Channel;
                string cluster = _signalSourceSetting._Pusher3AppCluster;
                string eventname = _signalSourceSetting._Pusher3Event;
                _pusherListenter3 = new PusherListener(appkey, cluster, channel, eventname);
                StartPusherMsgListnerAsync(_pusherListenter3);
            }
        }

        private void StartPusherMsgListnerAsync(PusherListener pusherListner)
        {
            try
            {
                pusherListner.StartAsync();
                pusherListner.MessageProc = MessageProcForPusher1;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private async void SendMsgViaPusherOverAsync(SignalData sd)
        {
            if (_pusherOverSetting._SendPushOverMsg)
            {
                await _pushOverManager.SendPushOverMessageAsync(sd);
            }
        }

        void MessageProcForPusher1(dynamic msg)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    this.Invoke((MethodInvoker) delegate
                    {
                        JObject jObject = UtilFunctions.GetJObjectFromPusherPayload(msg);
                        if (jObject == null) return;
                        SignalData sd = UtilFunctions.GetSignalDataFromJson(jObject);
                        sd._signalSource = _signalSourceSetting._Pusher1Name;
                        SetBrokerSetting(sd, _signalSourceSetting._Pusher1DefaultBroker);
                        bool isret = _sqliteManager.InsertSignalData(sd);
                        sd._qty = $"{_orderSendSetting._DefaultQtyAmount}";
                        if(!isret)
                        {
                            sd._signalSentStatus = "DUPLICATE";
                            sd._brokerStatus = "NOT SENT";
                            sd._signalDBStatus = "EXISTING";
                            AddDataGridViewRow(sd);
                        }
                        else
                        {
                            AddDataGridViewRow(sd);
                            SendNewOrderViaAlpaca(_signalSourceSetting._Pusher1DefaultBroker, sd);
                            UpdateDataGridView(sd._receivedTime, sd._signalHash);
                            SendMsgViaPusherOverAsync(sd);
                        }

                    });
                }));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void SetBrokerSetting(SignalData sd, int broker)
        {
            switch (_signalSourceSetting._Pusher2DefaultBroker)
            {
                case 0:
                    sd._brokerSent = _brokerAPISetting._AM1Name;
                    sd._brokerType = "Alpaca";
                    break;
                case 1:
                    sd._brokerSent = _brokerAPISetting._AM2Name;
                    sd._brokerType = "Alpaca";
                    break;
                case 2:
                    sd._brokerSent = _brokerAPISetting._AM3Name;
                    sd._brokerType = "Alpaca";
                    break;
                case 3:
                    sd._brokerSent = _brokerAPISetting._AM1Name;
                    sd._brokerType = "Alpaca";
                    break;
                case 4:
                    sd._brokerSent = _brokerAPISetting._AM1Name;
                    sd._brokerType = "Alpaca";
                    break;
                case 5:
                    sd._brokerSent = _brokerAPISetting._AM1Name;
                    sd._brokerType = "Alpaca";
                    break;
            }
        }

        void MessageProcForPusher2(dynamic msg)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        JObject jObject = UtilFunctions.GetJObjectFromPusherPayload(msg);
                        if (jObject == null) return;
                        SignalData sd = UtilFunctions.GetSignalDataFromJson(jObject);
                        sd._signalSource = _signalSourceSetting._Pusher1Name;

                        SetBrokerSetting(sd, _signalSourceSetting._Pusher2DefaultBroker);

                        bool isret = _sqliteManager.InsertSignalData(sd);
                        sd._qty = $"{_orderSendSetting._DefaultQtyAmount}";
                        if (!isret)
                        {
                            sd._signalSentStatus = "DUPLICATE";
                            sd._brokerStatus = "NOT SENT";
                            sd._signalDBStatus = "EXISTING";
                            AddDataGridViewRow(sd);
                            return;
                        }
                        AddDataGridViewRow(sd);
                        SendNewOrderViaAlpaca(_signalSourceSetting._Pusher2DefaultBroker, sd);
                        UpdateDataGridView(sd._receivedTime, sd._signalHash);
                        SendMsgViaPusherOverAsync(sd);
                    });
                }));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        void UpdateDataGridView(string receivetime, string hash)
        {
            foreach(DataGridViewRow row in this.SignalDataGridView.Rows)
            {
                if(row.Cells[0].Value.ToString()==receivetime && row.Cells[10].Value.ToString() == hash)
                {
                    row.Cells[11].Value = "SENT";
                    row.Cells[12].Value = "FILLED";
                }
            }
        }

        void MessageProcForPusher3(dynamic msg)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        JObject jObject = UtilFunctions.GetJObjectFromPusherPayload(msg);
                        if (jObject == null) return;
                        SignalData sd = UtilFunctions.GetSignalDataFromJson(jObject);
                        sd._signalSource = _signalSourceSetting._Pusher3Name;
                        SetBrokerSetting(sd, _signalSourceSetting._Pusher3DefaultBroker);
                        bool isret = _sqliteManager.InsertSignalData(sd);
                        sd._qty = $"{_orderSendSetting._DefaultQtyAmount}";
                        if (!isret)
                        {
                            sd._signalSentStatus = "DUPLICATE";
                            sd._brokerStatus = "NOT SENT";
                            sd._signalDBStatus = "EXISTING";
                            AddDataGridViewRow(sd);
                            return;
                        }
                        AddDataGridViewRow(sd);
                        SendNewOrderViaAlpaca(_signalSourceSetting._Pusher3DefaultBroker, sd);
                        UpdateDataGridView(sd._receivedTime, sd._signalHash);
                        SendMsgViaPusherOverAsync(sd);

                    });
                }));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void SendNewOrderViaAlpaca(int broker, SignalData sd)
        {
            if (broker == 0){
                _alpacaOrderManager1.sendNewOrderAsync(sd._symbol, sd._signalType, sd._signalPrice, _orderSendSetting);
            }
            else if (broker == 1){
                _alpacaOrderManager2.sendNewOrderAsync(sd._symbol, sd._signalType, sd._signalPrice, _orderSendSetting);
            }
            else{
                _alpacaOrderManager3.sendNewOrderAsync(sd._symbol, sd._signalType, sd._signalPrice, _orderSendSetting);
            }
        }

        private void AddDataGridViewRow(SignalData sd)
        {
            Color backcolor = Color.Black;
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._receivedTime, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._signalSource, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._brokerSent, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._brokerType, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._symbol, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._signalDate, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._signalTime, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._signalType, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._signalPrice, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._qty, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._signalHash, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._signalSentStatus, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._brokerStatus, backcolor));
            row.Cells.Add(GetDataGridViewTextBoxCell(sd._signalDBStatus, backcolor));
            this.SignalDataGridView.Rows.Add(row);
        }

        private DataGridViewTextBoxCell GetDataGridViewTextBoxCell(String text, Color backcolor)
        {
            DataGridViewTextBoxCell cell;
            cell = new DataGridViewTextBoxCell() { Value = text };
            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (text == "BUY")
            {
                cell.Style.BackColor = Color.DarkGreen;
            }
            else if(text == "SELL")
            {
                cell.Style.BackColor = Color.DarkRed;
            }
            else
            {
                cell.Style.BackColor = backcolor;
            }
            return cell;
        }

        private void SetStyleDataGridView()
        {
            this.SignalDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SignalDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 
                10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignalDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            this.SignalDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.SignalDataGridView.EnableHeadersVisualStyles = false;
        }

        private void FormOrderReceivedScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_pusherListenter1 != null) _pusherListenter1.Close();
            if (_pusherListenter2 != null) _pusherListenter2.Close();
            if (_pusherListenter3 != null) _pusherListenter3.Close();
            if (_testMarkettimer != null) _testMarkettimer.Close();
            if (_alpacaMarketAPIManager1 != null) _alpacaMarketAPIManager1.closeAPIConnectionAsync();
            if (_alpacaMarketAPIManager2 != null) _alpacaMarketAPIManager2.closeAPIConnectionAsync();
            if (_alpacaMarketAPIManager3 != null) _alpacaMarketAPIManager3.closeAPIConnectionAsync();
        }
    }
}
