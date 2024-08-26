using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetMQ;
using NetMQ.Sockets;
using SRI_AUTO_TRADER.Backend;

namespace SRI_AUTO_TRADER
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormSplash frm = new FormSplash();
            frm.ShowDialog();
            frm.InvokeIfRequired(p => p.Close());
            Application.Run(new FormApp());
        }
    }
}
