using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXBC.Lib;

namespace SDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataSend2.EventDataSend += new ZXBC.Lib.ZxbcEvent.DataSendHandler(this.DataSender_EventDataSend);
            this.serialPortCom2.DataReceived += new ZXBC.Lib.ZxbcEvent.DataReceivedHandler(this.Configer_DataReceived);
        }
        private bool DataSender_EventDataSend(byte[] data)
        {
            return serialPortCom2.SendData(data);
        }
        private void Configer_DataReceived(object sender, byte[] data)
        {
            dateReceive2.AddData(data);
        }
    }
}
