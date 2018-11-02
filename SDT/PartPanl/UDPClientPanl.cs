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
    public partial class UDPClientPanl : UserControl
    {
        public UDPClientPanl()
        {
            InitializeComponent();
        }

        private bool UDPClient_dataSend_EventDataSend(byte[] data)
        {
            return UDPClient.SendData(data);
        }

        private void UDPClient_DataReceived(object sender, byte[] data)
        {
            UDPClient_tabDataReceive.AddData(sender.ToString(), data);
        }
        /*
        public override void ClearSelf()
        {
            Configer.ClearSelf();
        }*/
    }
}
