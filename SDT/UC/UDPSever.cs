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
    public partial class UDPSever : UserControl
    {
        /// <summary>
        /// UDP服务端监听
        /// </summary>
        ZXBC_UDPClient udpserver = new ZXBC_UDPClient();

        BindingList<string> lstClient = new BindingList<string>();

        public event Lib.ZxbcEvent.DataReceivedHandler DataReceived;

        /// <summary>
        /// 监听状态
        /// </summary>
        bool isListen = false;

        public UDPSever()
        {
            InitializeComponent();
            UDPSever_IP_comboBox.SelectedIndex = 0;
            if (this.DesignMode == false)
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {//筛选IPV4
                        UDPSever_IP_comboBox.Items.Add(ip.ToString());
                    }
                }
            }
        }
        /// <summary>
        /// 绑定客户端列表
        /// </summary>
        private void BindLstClient()
        {
            UDPSever_listBox.Invoke(new MethodInvoker(delegate
            {
                UDPSever_listBox.DataSource = null;
                UDPSever_listBox.DataSource = lstClient;
            }));
        }

        /// <summary>
        /// 开启UDP监听
        /// </summary>
        /// <returns></returns>
        private void StartUDPServer()
        {
            try
            {
                IPEndPoint ipLocalEndPoint;
                if (UDPSever_IP_comboBox.SelectedIndex == 0)
                {
                    ipLocalEndPoint = new IPEndPoint(IPAddress.Any, (int)UDPClient_Port_numericUpDown.Value);
                }
                else
                {
                    ipLocalEndPoint = new IPEndPoint(IPAddress.Parse(UDPSever_IP_comboBox.SelectedItem.ToString()), (int)UDPClient_Port_numericUpDown.Value);
                }
                udpserver.NetWork = new UdpClient(ipLocalEndPoint);
                udpserver.ipLocalEndPoint = ipLocalEndPoint;
                udpserver.NetWork.BeginReceive(new AsyncCallback(ReceiveCallback), udpserver);
                isListen = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 停止UDP监听
        /// </summary>
        /// <returns></returns>
        private void StopUDPServer()
        {
            udpserver.NetWork.Close();
            lstClient.Clear();
            isListen = false;
        }

        /// <summary>
        /// TCP/UDP监听开启/停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UDPClient_Connect_button_Click(object sender, EventArgs e)
        {
            if (isListen == false)
            {//监听已停止
                StartUDPServer();
            }
            else
            {//监听已开启
                StopUDPServer();
            }
            UDPSever_IP_comboBox.Enabled = !isListen;
            UDPClient_Port_numericUpDown.Enabled = !isListen;
            if (isListen)
            {
                UDPClient_Connect_button.Text = "停止";
            }
            else
            {
                UDPClient_Connect_button.Text = "监听";
            }
        }


        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public bool SendData(byte[] data)
        {
            if (UDPSever_listBox.SelectedItems.Count > 0)
            {
                for (int i = 0; i < UDPSever_listBox.SelectedItems.Count; i++)
                {
                    string[] ClientInfor = UDPSever_listBox.SelectedItems[i].ToString().Split('>');
                    string[] IPAddress = ClientInfor[1].Split(':');
                    try
                    {
                        udpserver.NetWork.Send(data, data.Length, IPAddress[0], int.Parse(IPAddress[1]));
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
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (UDPSever_listBox.SelectedItems.Count > 0)
            {
                if (UDPSever_listBox.SelectedItems.Count > 0)
                {
                    List<string> WaitRemove = new List<string>();
                    for (int i = 0; i < UDPSever_listBox.SelectedItems.Count; i++)
                    {
                        WaitRemove.Add((string)UDPSever_listBox.SelectedItems[i]);
                    }
                    foreach (string client in WaitRemove)
                    {
                        lstClient.Remove(client);
                    }
                    BindLstClient();
                }
            }
        }

        /// <summary>
        /// 接收到数据
        /// </summary>
        /// <param name="ar"></param>
        public void ReceiveCallback(IAsyncResult ar)
        {
            ZXBC_UDPClient userver = (ZXBC_UDPClient)ar.AsyncState;
            string ConnName = "";
            try
            {
                if (userver.NetWork.Client != null)
                {
                    IPEndPoint fclient = userver.ipLocalEndPoint;
                    Byte[] recdata = userver.NetWork.EndReceive(ar, ref fclient);
                    ConnName = userver.ipLocalEndPoint.Port + "->" + fclient.ToString();
                    if (DataReceived != null)
                    {
                        DataReceived.BeginInvoke(ConnName, recdata, null, null);//异步输出数据
                    }
                    if (lstClient.Contains(ConnName) == false)
                    {//新的客户端
                        lstClient.Add(ConnName);
                        BindLstClient();
                    }
                }
            }
            catch (ObjectDisposedException ex) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (userver.NetWork.Client != null)
                {
                    userver.NetWork.BeginReceive(new AsyncCallback(ReceiveCallback), userver);//继续异步接收数据
                }
            }
        }

        /// <summary>
        /// 清理
        /// </summary>
        public void ClearSelf()
        {
            if (udpserver.NetWork != null)
            {
                udpserver.NetWork.Close();
            }
        }


    }
}
