using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXBC.Lib;

namespace ZXBC.PartPanl
{
    public partial class SerialPortComPanl : UserControl
    {
        public SerialPortComPanl()
        {
            InitializeComponent();
            this.Com_dataSend.EventDataSend += new ZXBC.Lib.ZxbcEvent.DataSendHandler(this.DataSender_EventDataSend);
            this.Com_serialPortCom.DataReceived += new ZXBC.Lib.ZxbcEvent.DataReceivedHandler(this.Configer_DataReceived);
        }
        private bool DataSender_EventDataSend(byte[] data)
        {
            return Com_serialPortCom.SendData(data);
        }
        private void Configer_DataReceived(object sender, byte[] data)
        {
            Com_dateReceive.AddData(data);
        }
    }
}
