using log4net;
using log4net.Config;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace SRI_AUTO_TRADER.Backend
{
    public class UtilFunctions
    {
        public static JObject GetJObjectFromPusherPayload(string msg)
        {

            string temp = msg.Substring(1, msg.Length - 1);
            StringBuilder sb = new StringBuilder();
            bool isflag = false;
            foreach (char s in temp)
            {
                if (s == '{')
                {
                    isflag = true;
                }

                if (s == '}')
                {
                    isflag = false;
                    sb.Append(s);
                    return JObject.Parse(sb.ToString());
                }
                if (isflag)
                {
                    sb.Append(s);
                }

            }
            return null;
        }

        public static SignalData GetSignalDataFromJson(JObject jobject)
        {
            if (jobject == null) return null;
            SignalData sd = new SignalData();
            sd._signalDate = jobject.GetValue("Date").ToString();
            sd._signalTime = jobject.GetValue("Time").ToString();
            sd._signalType = jobject.GetValue("SignalType").ToString();
            sd._signalPrice = jobject.GetValue("Price").ToString();
            sd._symbol = jobject.GetValue("Symbol").ToString();
            sd._signalHash = jobject.GetValue("Hash").ToString();
            return sd;
        }
    }
    public static class ControlExtensions
    {
        public static T InvokeIfRequired<T>(this T source, Action<T> action)
            where T : Control
        {
            try
            {
                if (!source.InvokeRequired)
                    action(source);
                else
                    source.Invoke(new Action(() => action(source)));
            }
            catch (Exception)
            {
            }
            return source;
        }
    }


    public static class Logger
    {
        private static ILog logger;
        static Logger()
        {
            XmlConfigurator.Configure();
            logger = LogManager.GetLogger("");
        }

        public static void WriteLog(string log)
        {
            logger.Info(log);
        }
    }
}
