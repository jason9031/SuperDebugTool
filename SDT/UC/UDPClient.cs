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
using System.Net;
using System.Net.Sockets;

namespace ZXBC.UC
{
    public partial class UDPClient : UserControl
    {
        /// <summary>
        /// 当前已连接客户端集合
        /// </summary>
        BindingList<ZXBC_UDPClient> lstClient = new BindingList<ZXBC_UDPClient>();
        public event Lib.ZxbcEvent.DataReceivedHandler DataReceived;

        public UDPClient()
        {
            InitializeComponent();
            InitializeComponent();
            if (this.DesignMode == false)
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {//筛选IPV4
                        UDPClient_IP_textBox.Text = ip.ToString();
                    }
                }
            }
        }
        /// <summary>
        /// 绑定客户端列表
        /// </summary>
        private void BindLstClient()
        {
            UDPClient_Connect_listBox.Invoke(new MethodInvoker(delegate
            {
                UDPClient_Connect_listBox.DataSource = null;
                UDPClient_Connect_listBox.DataSource = lstClient;
                UDPClient_Connect_listBox.DisplayMember = "Name";
            }));
        }
        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (UDPClient_Connect_listBox.SelectedItems.Count > 0)
            {
                List<ZXBC_UDPClient> WaitRemove = new List<ZXBC_UDPClient>();
                for (int i = 0; i < UDPClient_Connect_listBox.SelectedItems.Count; i++)
                {
                    WaitRemove.Add((ZXBC_UDPClient)UDPClient_Connect_listBox.SelectedItems[i]);
                }
                foreach (ZXBC_UDPClient client in WaitRemove)
                {
                    client.NetWork.Close();
                    lstClient.Remove(client);
                }
            }
        }

        private void UDPClient_add_button_Click(object sender, EventArgs e)
        {
            try
            {
                ZXBC_UDPClient client = new ZXBC_UDPClient();
                client.NetWork = new UdpClient();
                client.NetWork.Connect(UDPClient_IP_textBox.Text.Trim(), (int)UDPClient_port_numericUpDown.Value);
                client.ipLocalEndPoint = (IPEndPoint)client.NetWork.Client.LocalEndPoint;
                client.Name = client.ipLocalEndPoint.Port + "->" + client.NetWork.Client.RemoteEndPoint.ToString();
                client.NetWork.BeginReceive(new AsyncCallback(ReceiveCallback), client);//继续异步接收数据
                lstClient.Add(client);
                BindLstClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 接收到数据
        /// </summary>
        /// <param name="ar"></param>
        public void ReceiveCallback(IAsyncResult ar)
        {
            ZXBC_UDPClient uclient = (ZXBC_UDPClient)ar.AsyncState;
            try
            {
                if (uclient.NetWork.Client != null && uclient.NetWork.Client.Connected)
                {
                    IPEndPoint fclient = uclient.ipLocalEndPoint;
                    Byte[] recdata = uclient.NetWork.EndReceive(ar, ref fclient);
                    string ConnName = uclient.ipLocalEndPoint.Port + "->" + fclient.ToString();
                    if (DataReceived != null)
                    {
                        DataReceived.BeginInvoke(ConnName, recdata, null, null);//异步输出数据
                    }
                    uclient.NetWork.BeginReceive(new AsyncCallback(ReceiveCallback), uclient);//继续异步接收数据
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SendData(byte[] data)
        {
            if (UDPClient_Connect_listBox.SelectedItems.Count > 0)
            {
                for (int i = 0; i < UDPClient_Connect_listBox.SelectedItems.Count; i++)
                {
                    try
                    {
                        ZXBC_UDPClient client = (ZXBC_UDPClient)UDPClient_Connect_listBox.SelectedItems[i];
                        client.NetWork.Send(data, data.Length);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("无可用客户端", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 清理
        /// </summary>
        public void ClearSelf()
        {
            foreach (ZXBC_UDPClient client in lstClient)
            {
                client.Close();
            }
            lstClient.Clear();
        }

    }
}
