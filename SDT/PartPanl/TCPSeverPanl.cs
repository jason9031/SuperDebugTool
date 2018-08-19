using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZXBC.PartPanl
{
    public partial class TCPSeverPanl : UserControl
    {
        public TCPSeverPanl()
        {
            InitializeComponent();
        }

        private bool TCPSever_dataSend_EventDataSend(byte[] data)
        {
            return TCPSever.SendData(data);
        }

        private void TCPSever_DataReceived(object sender, byte[] data)
        {
            TCPSever_tabDataReceive.AddData(sender.ToString(),data);
        }
    }
}
