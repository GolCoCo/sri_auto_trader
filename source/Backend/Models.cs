using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRI_AUTO_TRADER.Backend
{
    public class SignalData
    {
        public SignalData()
        {
            _receivedTime = DateTime.Now.ToString("HH:mm:ss");
            _signalSource = "";
            _brokerSent = "";
            _brokerType = "";
            _symbol = "";
            _signalDate = "";
            _signalTime = "";
            _signalType = "";
            _signalPrice = "";
            _qty = "";
            _signalHash = "";
            _signalSentStatus = "PENDING";
            _brokerStatus = "PENDING";
            _signalDBStatus = "SAVED";
        }

        public string _receivedTime { get;  set; }
        public string _signalSource { get;  set; }
        public string _brokerSent { get;  set; }
        public string _brokerType { get;  set; }
        public string _symbol { get;  set; }
        public string _signalDate { get;  set; }
        public string _signalTime { get;  set; }
        public string _signalType { get;  set; }
        public string _signalPrice { get;  set; }
        public string _qty { get;  set; }
        public string _signalHash { get;  set; }
        public string _signalSentStatus { get;  set; }
        public string _brokerStatus { get;  set; }
        public string _signalDBStatus { get;  set; }
    }
}
