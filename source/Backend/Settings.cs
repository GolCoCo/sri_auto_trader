using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRI_AUTO_TRADER.Backend
{
    public class BrokerAPISetting : SettingsBase
    {
        public BrokerAPISetting()
        {
            _AM1Name = "";
            _AM2Name = "";
            _AM3Name = "";
            _AM1AccoutType = 0;
            _AM2AccoutType = 0;
            _AM3AccoutType = 0;
            _AM1APIKey = "";
            _AM2APIKey = "";
            _AM3APIKey = "";
            _AM1PAISecretKey = "";
            _AM2PAISecretKey = "";
            _AM3PAISecretKey = "";
        }

        public string _AM1Name { get;  set; }
        public string _AM2Name { get;  set; }
        public string _AM3Name { get;  set; }
        public int _AM1AccoutType { get;  set; }
        public int _AM2AccoutType { get;  set; }
        public int _AM3AccoutType { get;  set; }
        public string _AM1APIKey { get;  set; }
        public string _AM2APIKey { get;  set; }
        public string _AM3APIKey { get;  set; }
        public string _AM1PAISecretKey { get;  set; }
        public string _AM2PAISecretKey { get;  set; }
        public string _AM3PAISecretKey { get;  set; }
    }
    public class SignalSourceSetting : SettingsBase
    {
        public SignalSourceSetting()
        {
            _SignalReceivedDB = "";

            _IsPusher1Enable = false;
            _IsPusher2Enable = false;
            _IsPusher3Enable = false;
            _Pusher1Name = "";
            _Pusher2Name = "";
            _Pusher3Name = "";
            _Pusher1AppKey = "";
            _Pusher2AppKey = "";
            _Pusher3AppKey = "";
            _Pusher1Event = "";
            _Pusher2Event = "";
            _Pusher3Event = "";
            _Pusher1AppCluster = "";
            _Pusher2AppCluster = "";
            _Pusher3AppCluster = "";
            _Pusher1Channel = "";
            _Pusher2Channel = "";
            _Pusher3Channel = "";
            _Pusher1DefaultBroker = 0;
            _Pusher2DefaultBroker = 0;
            _Pusher3DefaultBroker = 0;

            _IsNetMQ1Enable = false;
            _IsNetMQ2Enable = false;
            _IsNetMQ3Enable = false;
            _NetMQ1Name = "";
            _NetMQ2Name = "";
            _NetMQ3Name = "";
            _NetMQ1IP = "";
            _NetMQ2IP = "";
            _NetMQ3IP = "";
            _NetMQ1Port = "";
            _NetMQ2Port = "";
            _NetMQ3Port = "";
            _NetMQ1Topic = "";
            _NetMQ2Topic = "";
            _NetMQ3Topic = "";
            _NetMQ1DefaultBroker = 0;
            _NetMQ2DefaultBroker = 0;
            _NetMQ3DefaultBroker = 0;
        }

        public string _SignalReceivedDB { get;  set; }
        public bool _IsPusher1Enable { get;  set; }
        public bool _IsPusher2Enable { get;  set; }
        public bool _IsPusher3Enable { get;  set; }
        public string _Pusher1Name { get;  set; }
        public string _Pusher2Name { get;  set; }
        public string _Pusher3Name { get;  set; }
        public string _Pusher1AppKey { get;  set; }
        public string _Pusher2AppKey { get;  set; }
        public string _Pusher3AppKey { get;  set; }
        public string _Pusher1Event { get;  set; }
        public string _Pusher2Event { get;  set; }
        public string _Pusher3Event { get;  set; }
        public string _Pusher1AppCluster { get;  set; }
        public string _Pusher2AppCluster { get;  set; }
        public string _Pusher3AppCluster { get;  set; }
        public string _Pusher1Channel { get;  set; }
        public string _Pusher2Channel { get;  set; }
        public string _Pusher3Channel { get;  set; }
        public int _Pusher1DefaultBroker { get;  set; }
        public int _Pusher2DefaultBroker { get;  set; }
        public int _Pusher3DefaultBroker { get;  set; }
        public bool _IsNetMQ1Enable { get;  set; }
        public bool _IsNetMQ2Enable { get;  set; }
        public bool _IsNetMQ3Enable { get;  set; }
        public string _NetMQ1Name { get;  set; }
        public string _NetMQ2Name { get;  set; }
        public string _NetMQ3Name { get;  set; }
        public string _NetMQ1IP { get;  set; }
        public string _NetMQ2IP { get;  set; }
        public string _NetMQ3IP { get;  set; }
        public string _NetMQ1Port { get;  set; }
        public string _NetMQ2Port { get;  set; }
        public string _NetMQ3Port { get;  set; }
        public string _NetMQ1Topic { get;  set; }
        public string _NetMQ2Topic { get;  set; }
        public string _NetMQ3Topic { get;  set; }
        public int _NetMQ1DefaultBroker { get;  set; }
        public int _NetMQ2DefaultBroker { get;  set; }
        public int _NetMQ3DefaultBroker { get;  set; }
    }
    public class AlpacaOrderSetting : SettingsBase
    {
        public AlpacaOrderSetting()
        {
            _AutoSendOrder = false;
            _DeleteSendNewOrder = false;
            _SendOrderType = 0;
            _DefaultQtyAmount = 10;
        }

        public bool _AutoSendOrder { get; set; }
        public bool _DeleteSendNewOrder { get; set; }
        public int _SendOrderType { get;  set; }
        public int _DefaultQtyAmount { get; set; }
    }


    public class PushOverSetting : SettingsBase
    {
        public PushOverSetting()
        {
            _StringSounds = new List<String>();
            _SendPushOverMsg = false;
            _SendSignalImage = false;
            _UserKey = "uQiRzpo4DXghDmr9QzzfQu27cmVRsG";
            _APIToken = "azGDORePK8gMaC0QOYAMyEEuzJnyUi";
            _Sound = 0;
            fillStringSounds();
        }
        public void fillStringSounds()
        {
            _StringSounds.Add("magic");
            _StringSounds.Add("incoming");
            _StringSounds.Add("cashregister");
            _StringSounds.Add("bike");
            _StringSounds.Add("none");

        }

        public List<String> _StringSounds = null;
        public bool _SendPushOverMsg { get; set; }
        public bool _SendSignalImage { get; set; }
        public string _UserKey { get; set; }
        public string _APIToken { get; set; }
        public int _Sound { get; set; }
    }


    public enum SignalScanModeEnum
    {
        Both,
        Buy,
        Sell
    }
    public class SettingsBase
    {
        public void Save()
        {

            using (StreamWriter writer = new StreamWriter(this.GetType().Name + ".xml"))
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
                xmlSerializer.Serialize(writer, this);
            }
        }

        public static T Load<T>() where T : SettingsBase
        {
            T result = null;
            if (File.Exists(typeof(T).Name + ".xml"))
            {
                using (StreamReader reader = new StreamReader(typeof(T).Name + ".xml"))
                {
                    System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                    result = (T)xmlSerializer.Deserialize(reader);
                }
            }
            return result;
        }

    }
}
