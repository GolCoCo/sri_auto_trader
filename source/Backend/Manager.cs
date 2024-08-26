using Alpaca.Markets;
using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PusherServer;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using SRI_AUTO_TRADER.Backend;
using System.Windows.Forms;
using PusherClient;

namespace SRI_AUTO_TRADER.Backend
{
    public class SignalReceivedDBManager
    {
        // member
        private String _tableName = "SignalReceivedDB";
        private SQLiteConnection _dbconnection;
        private String _filename;
        public bool isUse;

        public SignalReceivedDBManager(String path, String filename)
        {
            this._filename = filename;
            FileInfo fl = new FileInfo(path + "\\" + _filename);
            isUse = true;
            if (fl.Exists)
            {
                _dbconnection = new SQLiteConnection("Data Source=" + path + "\\" + _filename + ";Version=3");
                _dbconnection.Open();
            }
            else
            {
                SQLiteConnection.CreateFile(path + "\\" + _filename);
                _dbconnection = new SQLiteConnection("Data Source=" + path + "\\" + _filename + ";Version=3");
                _dbconnection.Open();
                createTable();
            }

        }
        public void createTable()
        {
            string sqlForCreateTable = 
                            $"CREATE TABLE \"{_tableName}\" (" +
                            "    \"ID\"    INTEGER," +
                            "    \"ReceivedTIme\"    TEXT," +
                            "	\"SignalSource\"  TEXT," +
                            "	\"BrokerSent\"   TEXT," +
                            "	\"BrokerType\"   TEXT," +
                            "	\"SignalDate\"   TEXT," +
                            "	\"SingalTime\"   TEXT," +
                            "	\"SingalType\"   TEXT," +
                            "	\"SignalPrice\"   TEXT," +
                            "	\"Qty\"   TEXT," +
                            "	\"SignalHash\"   TEXT," +
                            "	PRIMARY KEY(\"ID\")); ";
            SQLiteCommand command = new SQLiteCommand(sqlForCreateTable, _dbconnection);
            command.ExecuteNonQuery();

        }

        // insert data
        public bool InsertSignalData(SignalData sd)
        {
            if (isExistence(sd)) return false;
            String sqlForInsertData = $"INSERT INTO {_tableName} (" +
                "ReceivedTIme, SignalSource, BrokerSent, " +
                "BrokerType, SignalDate, SingalTime, SingalType, SignalPrice, Qty, SignalHash)" +
                           "VALUES('"
                           + sd._receivedTime + "','"
                           + sd._signalSource + "', '"
                           + sd._brokerSent + "','"
                           + sd._brokerType + "','"
                           + sd._signalDate + "','"
                           + sd._signalTime + "','"
                           + sd._signalType + "','"
                           + sd._signalPrice + "','"
                           + sd._qty + "','"
                           + sd._signalHash + "');";
            SQLiteCommand command = new SQLiteCommand(sqlForInsertData, _dbconnection);
            command.ExecuteNonQuery();
            return true;
        }

        public bool isExistence(SignalData sd)
        {
            String sqlForInsertData = $"SELECT * FROM {_tableName}";
            SQLiteCommand command = new SQLiteCommand(sqlForInsertData, _dbconnection);

            SQLiteDataReader reader = command.ExecuteReader();
            if (reader == null)
            {
                return false;
            }
            while (reader.Read())
            {
                string hash = reader["SignalHash"].ToString();
                if (hash.Equals(sd._signalHash)) return true;
            }
            return false;
        }

        public void close()
        {
            this._dbconnection.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }

    public class ManagerNetMQV
    {
        private const int DISCONNECTED = -1;
        public delegate void MessageProcDelegate(string message);
        public MessageProcDelegate MessageProc;
        private SubscriberSocket subscriber;
        private int port;
        public ManagerNetMQV()
        {
            port = DISCONNECTED;
        }

        /// <summary>
        /// Start publisher on specified port
        /// </summary>
        /// <param name="port">Port to publish message</param>
        public void Start(string ip, int port, string subscribe)
        {
            try
            {
                this.port = port;
                subscriber = new SubscriberSocket();
                subscriber.Connect($"tcp://{ip}:{port}");
                subscriber.Subscribe(subscribe);
                Task.Run(() => ReceiveMessage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void ReceiveMessage()
        {
            while (port != DISCONNECTED)
            {
                string messageTopicReceived = "";
                if (subscriber.TryReceiveFrameString(out messageTopicReceived))
                {
                    string messageReceived = subscriber.ReceiveFrameString();
                    MessageProc?.Invoke(messageReceived);
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Send broadcast message
        /// </summary>
        /// <param name="msg">message to be sent</param>
        public void SendMessage(string msg)
        {
            lock (this)
            {
                if (port == DISCONNECTED)
                    return;
                subscriber.SendFrame(msg);
            }
        }

        /// <summary>
        /// Stop sending broadcast messsage
        /// </summary>
        public void Stop()
        {
            if (subscriber == null) return;
            subscriber.Close();
            port = DISCONNECTED;
        }

        /// <summary>
        /// Dispose and release all resource
        /// </summary>
        public void Dispose()
        {
            subscriber?.Dispose();
        }
    }

    public class AlpacaMarketAPIManager
    {
        // members
        public String _apiKey;
        public String _apiSecret;
        public int _type;
        public IAlpacaDataClient _client;

        // contructor
        public AlpacaMarketAPIManager(String apiKey, String apiSecret, int type)
        {

            this._apiKey = apiKey;
            this._apiSecret = apiSecret;
            this._type = type;
            this._client = null;
            openAPIConnectionAsync();

        }
        // open the API connection
        public void openAPIConnectionAsync()
        {
            if (this._type == 0)
            {
                _client = Environments.Live
                    .GetAlpacaDataClient(new SecretKey(this._apiKey, this._apiSecret));
            }
            else
            {
                _client = Environments.Paper
                .GetAlpacaDataClient(new SecretKey(this._apiKey, this._apiSecret));
            }

        }
        public void closeAPIConnectionAsync()
        {
            this._client.Dispose();
        }

        // get Snapshot by Symbol
        public async Task<Double> getSnapShotPriceAsync(String symbol)
        {
            ISnapshot snapshot = await _client.GetSnapshotAsync(symbol);
            return (Double)snapshot.Trade.Price;
        }

        // get Snapshots by Symbol (nultiple tickets)
        public async Task<Dictionary<String, Double>> getSnapShotPricesAsync(IEnumerable<String> symbols)
        {

            IReadOnlyDictionary<String, ISnapshot> snapshots = await _client.GetSnapshotsAsync(symbols);

            Dictionary<String, Double> rets = new Dictionary<String, Double>();

            foreach (var snapshot in snapshots)
            {
                String symbol = snapshot.Key;
                ISnapshot sdata = snapshot.Value;
                Double price = (Double)sdata.Trade.Price;
                rets.Add(symbol, price);
            }

            return rets;

        }
    }

    public class AlpacaMarketOrderAPIManager
    {
        // members
        public String _apiKey;
        public String _apiSecret;
        public int _type;
        public IAlpacaTradingClient _client;
        // contructor
        public AlpacaMarketOrderAPIManager(String apiKey, String apiSecret, int type)
        {

            this._apiKey = apiKey;
            this._apiSecret = apiSecret;
            this._type = type;
            this._client = null;
            openAPIConnectionAsync();

        }
        // open the API connection
        public void openAPIConnectionAsync()
        {
            if (this._type == 1)
            {
                _client = Environments.Paper
                    .GetAlpacaTradingClient(new SecretKey(_apiKey, _apiSecret));
            }
            else
            {
                _client = Environments.Live
                    .GetAlpacaTradingClient(new SecretKey(_apiKey, _apiSecret));
            }

        }
        // Get An Open Position for Symbol
        public async Task<IPosition> getPositionAsync(String symbol)
        {
            IPosition position = await _client.GetPositionAsync(symbol);

            return position;
        }

        // Close the Position for Symbol If Open Position for Symbol
        public async Task<IOrder> deletePositionAsync(String symbol)
        {
            IOrder order = await _client.DeletePositionAsync(new DeletePositionRequest(symbol));
            return order;
        }

        // Send New ORDER for Signal Symbol
        public async void sendNewOrderAsync(String symbol, String side, string price, AlpacaOrderSetting orderSetting)
        {
            try
            {
                if (orderSetting._DeleteSendNewOrder)
                {
                    Task<IOrder> order1 = deletePositionAsync(symbol);
                }

                int qty = orderSetting._DefaultQtyAmount;
                if (orderSetting._SendOrderType == 1)
                {
                    OrderSide orderSide = OrderSide.Buy;
                    if (side == "SELL")
                    {
                        orderSide = OrderSide.Sell;
                    }

                    OrderQuantity oq = OrderQuantity.Notional(qty);

                    IOrder order = await _client.PostOrderAsync(
                    new NewOrderRequest(symbol, oq, orderSide, OrderType.Market, TimeInForce.Day));

                }
                else
                {
                    int qtyno = (int)(qty / Math.Round(Double.Parse(price), 0));
                    if (side == "SELL")
                    {
                        IOrder order = await _client.PostOrderAsync(MarketOrder.Sell(symbol, qtyno).WithDuration(TimeInForce.Day));
                    }
                    else
                    {
                        IOrder order = await _client.PostOrderAsync(MarketOrder.Buy(symbol, qtyno).WithDuration(TimeInForce.Day));
                    }
                }
            }
            catch(Exception)
            {
                //MessageBox.Show(ex.ToString());
            }
        }


        public void closeAPIConnectionAsync()
        {
            this._client.Dispose();
        }
    }

    // Manager pushser for listening msg
    public class PusherListener
    {
        public delegate void MessageProcDelegate(string message);
        public MessageProcDelegate MessageProc;


        private string _channel = "";
        private string _event = "";
        private string _appkey = "";
        private string _cluster = "";
        public PusherClient.Pusher _pusher;
        private Channel _subscriber;

        // constructor
        public PusherListener(string appkey, string cluster, string channel, string mevent)
        {
            _event = mevent;
            _channel = channel;
            _appkey = appkey;
            _cluster = cluster;
        }
        // start
        public async void StartAsync()
        {
            try
            {
                // init pusherclient
                _pusher = new PusherClient.Pusher(_appkey, new PusherClient.PusherOptions()
                {
                    Cluster = _cluster,
                    Encrypted = true
                });

                _pusher.ConnectionStateChanged += _pusher_ConnectionStateChanged;
                _pusher.Error += _pusher_Error;
                _pusher.Connected += _pusher_Connected;

                // Setup private channel
                _subscriber = await _pusher.SubscribeAsync(_channel);
                _pusher.Subscribed += DayChannel_Subscribed;
                await _pusher.ConnectAsync();
                await Task.Run(() => ReceiveMessage());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DayChannel_Subscribed(object sender, Channel channel)
        {
            //MessageBox.Show("DayChannel_Subscribed");
        }

        private void _pusher_Error(object sender, PusherException error)
        {
            //MessageBox.Show("_pusher_Error");
        }

        private void _pusher_ConnectionStateChanged(object sender, ConnectionState state)
        {
            //MessageBox.Show($"{state.ToString()}");
        }

        private void _pusher_Subscribed(object sender, Channel channel)
        {
            //MessageBox.Show("Subscribed");
        }

        private void _pusher_Connected(object sender)
        {
            //MessageBox.Show("Connected");
        }

        // listener
        void ReceiveMessage()
        {
            if (_subscriber == null) return;
            _subscriber.Bind(_event, delegate (dynamic data)
            {
                string response = Convert.ToString(data);
                //MessageBox.Show($"{data}");
                MessageProc?.Invoke(response);
            });
        }

        public void Close()
        {
            _pusher.DisconnectAsync();
        }
    }


    public class PushOverMsgManager
    {
        private PushOverSetting _pos;
        private HttpClient _httpClient = null;
        private String BaseAPIURI = "https://api.pushover.net/1/messages.json";


        public PushOverMsgManager(PushOverSetting pos)
        {
            _pos = pos;
            _httpClient = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public async Task<bool> SendPushOverMessageAsync(SignalData sd)
        {
            if (!_pos._SendPushOverMsg)
            {
                return false;
            }
            string title = $"New Order Sent-{sd._symbol}-Qty-{sd._qty}";
            String message = sd._receivedTime + "-" + sd._signalSource + "-" +
                             sd._brokerSent + "-" + sd._brokerType + "-" +
                             sd._symbol + "-" + sd._signalType + "-" +
                             sd._qty + "-";
            String sound = _pos._StringSounds[_pos._Sound];
            try
            {
                if (!_pos._SendSignalImage)
                {
                    MultipartFormDataContent form = new MultipartFormDataContent();
                    form.Add(new StringContent(_pos._APIToken), "\"token\"");
                    form.Add(new StringContent(_pos._UserKey), "\"user\"");
                    form.Add(new StringContent(message), "\"message\"");
                    form.Add(new StringContent(title), "\"title\"");
                    form.Add(new StringContent(message), "\"sound\"");
                    HttpResponseMessage responseMessage = await _httpClient.PostAsync(BaseAPIURI, form);
                    if (responseMessage.IsSuccessStatusCode)
                        return true;
                }
                else
                {

                    MultipartFormDataContent form = new MultipartFormDataContent();
                    form.Add(new StringContent(_pos._APIToken), "\"token\"");
                    form.Add(new StringContent(_pos._UserKey), "\"user\"");
                    form.Add(new StringContent(message), "\"message\"");
                    form.Add(new StringContent(message), "\"sound\"");
                    HttpResponseMessage responseMessage = await _httpClient.PostAsync(BaseAPIURI, form);
                    if (responseMessage.IsSuccessStatusCode)
                        return true;
                }
            }
            catch (Exception)
            {

            }
            _pos.Save();
            return true;

        }

        public async Task<bool> SendPushOverMessageAsync(String symbol, String signalType, String patternType, String price, String imagePath)
        {
            if (!_pos._SendPushOverMsg)
            {
                return false;
            }
            String message = symbol + "-" + signalType + "-" +
                             patternType + "-" + price;
            String sound = _pos._StringSounds[_pos._Sound];
            try
            {
                if (!_pos._SendSignalImage)
                {
                    MultipartFormDataContent form = new MultipartFormDataContent();
                    form.Add(new StringContent(_pos._APIToken), "\"token\"");
                    form.Add(new StringContent(_pos._UserKey), "\"user\"");
                    form.Add(new StringContent(message), "\"message\"");
                    form.Add(new StringContent(message), "\"sound\"");
                    HttpResponseMessage responseMessage = await _httpClient.PostAsync(BaseAPIURI, form);
                    if (responseMessage.IsSuccessStatusCode)
                        return true;
                }
                else
                {

                    MultipartFormDataContent form = new MultipartFormDataContent();
                    form.Add(new StringContent(_pos._APIToken), "\"token\"");
                    form.Add(new StringContent(_pos._UserKey), "\"user\"");
                    form.Add(new StringContent(message), "\"message\"");
                    form.Add(new StringContent(message), "\"sound\"");

                    var imageParameter = new StreamContent(File.OpenRead(imagePath));
                    imageParameter.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
                    form.Add(imageParameter, "attachment", "image.png");
                    HttpResponseMessage responseMessage = await _httpClient.PostAsync(BaseAPIURI, form);
                    if (responseMessage.IsSuccessStatusCode)
                        return true;
                }
            }
            catch (Exception)
            {

            }
            _pos.Save();
            return true;

        }
        public void CloseClient()
        {
            _httpClient.Dispose();
        }
    }
}
