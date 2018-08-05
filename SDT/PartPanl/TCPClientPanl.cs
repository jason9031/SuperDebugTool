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
    public partial class TCPClientPanl : UserControl
    {
        public TCPClientPanl()
        {
            InitializeComponent();
        }

        private bool TCPClient_dataSend_EventDataSend(byte[] data)
        {
            return TCPClient_Conf.SendData(data);
        }

        private void TCPClient_Conf_DataReceived(object sender, byte[] data)
        {
            TCPClient_tabDataReceive.AddData(sender.ToString(), data);
        }
/*
public override void ClearSelf()
{
  TCPClient_Conf.ClearSelf();
}
*/
    }
}
