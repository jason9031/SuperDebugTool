using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using ZXBC.Lib;

namespace ZXBC.UC
{
    public partial class TCPClient : UserControl
    {
        /// <summary>
        /// 当前已连接客户端集合
        /// </summary>
        public BindingList<ZXBC_TCPClient> lstClient = new BindingList<ZXBC_TCPClient>();

        public event Lib.ZxbcEvent.DataReceivedHandler DataReceived;
        public TCPClient()
        {
            InitializeComponent();
            if (this.DesignMode == false)
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {//筛选IPV4
                        TCPClient_IP_textBox.Text = ip.ToString();
                    }
                }
            }
        }


        /// <summary>
        /// 绑定客户端列表
        /// </summary>
        private void BindLstClient()
        {
            TCPClient_Connect_listBox.Invoke(new MethodInvoker(delegate
            {
                TCPClient_Connect_listBox.DataSource = null;
                TCPClient_Connect_listBox.DataSource = lstClient;
                TCPClient_Connect_listBox.DisplayMember = "Name";
            }));
        }


        /// <summary>
        /// 连接新的服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TCP_Connect_button_Click(object sender, EventArgs e)
        {
            ZXBC_TCPClient client = new ZXBC_TCPClient();
            try
            {
                client.NetWork = new TcpClient();
                client.NetWork.Connect(TCPClient_IP_textBox.Text.Trim(), (int)TCPClient_Port_numericUD.Value);//连接服务端
                client.SetName();
                client.NetWork.GetStream().BeginRead(client.buffer, 0, client.buffer.Length, new AsyncCallback(TCPCallBack), client);
                lstClient.Add(client);
                BindLstClient();
            }
            catch (Exception ex)
            {
                client.DisConnect();
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// 回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void TCPCallBack(IAsyncResult ar)
        {
            ZXBC_TCPClient client = (ZXBC_TCPClient)ar.AsyncState;
            if (client.NetWork.Connected)
            {
                NetworkStream ns = client.NetWork.GetStream();
                try
                {
                    byte[] recdata = new byte[ns.EndRead(ar)];
                    Array.Copy(client.buffer, recdata, recdata.Length);
                    if (recdata.Length > 0)
                    {
                        if (DataReceived != null)
                        {
                            DataReceived.BeginInvoke(client.Name, recdata, null, null);//异步输出数据
                        }
                        ns.BeginRead(client.buffer, 0, client.buffer.Length, new AsyncCallback(TCPCallBack), client);
                    }
                    else
                    {
                        client.DisConnect();
                        lstClient.Remove(client);
                        BindLstClient();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    client.DisConnect();
                    lstClient.Remove(client);
                    BindLstClient();
                }
            }
        }


        public bool SendData(byte[] data)
        {
            if (TCPClient_Connect_listBox.SelectedItems.Count > 0)
            {
                for (int i = 0; i < TCPClient_Connect_listBox.SelectedItems.Count; i++)
                {
                    ZXBC_TCPClient selClient = (ZXBC_TCPClient)TCPClient_Connect_listBox.SelectedItems[i];
                    try
                    {
                        selClient.NetWork.GetStream().Write(data, 0, data.Length);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(selClient.Name + ":" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("无可用连接", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 关闭所有连接
        /// </summary>
        public void ClearSelf()
        {
            foreach (ZXBC_TCPClient client in lstClient)
            {
                client.DisConnect();
            }
            lstClient.Clear();
            BindLstClient();
        }

        private void TCPClient_Disconnect_Click(object sender, EventArgs e)
        {
            if (TCPClient_Connect_listBox.SelectedItems.Count > 0)
            {
                List<ZXBC_TCPClient> WaitRemove = new List<ZXBC_TCPClient>();
                for (int i = 0; i < TCPClient_Connect_listBox.SelectedItems.Count; i++)
                {
                    WaitRemove.Add((ZXBC_TCPClient)TCPClient_Connect_listBox.SelectedItems[i]);
                }
                foreach (ZXBC_TCPClient client in WaitRemove)
                {
                    client.DisConnect();
                    lstClient.Remove(client);
                }
            }
        }
    }
}
