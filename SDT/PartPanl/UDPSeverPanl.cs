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
    public partial class UDPSeverPanl : UserControl
    {
        public UDPSeverPanl()
        {
            InitializeComponent();
        }

        private bool UDPSever_dataSend_EventDataSend(byte[] data)
        {
            return UDPSever.SendData(data);
        }

        private void UDPSever_DataReceived(object sender, byte[] data)
        {
            UDPSever_tabDataReceive.AddData(sender.ToString(), data);
        }
        /*
        public override void ClearSelf()
        {
            UDPSever.ClearSelf();
        }
        */
    }
}
