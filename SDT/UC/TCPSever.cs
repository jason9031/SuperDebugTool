using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using ZXBC.Lib;
using System.Net;

namespace ZXBC.UC
{
    public partial class TCPSever : UserControl
    {
        /// <summary>
        /// TCP服务端监听
        /// </summary>
        TcpListener tcpsever = null;
        /// <summary>
        /// 监听状态
        /// </summary>
        bool isListen = false;

        public event Lib.ZxbcEvent.DataReceivedHandler DataReceived;

        /// <summary>
        /// 当前已连接客户端集合
        /// </summary>
        public BindingList<ZXBC_TCPClient> lstClient = new BindingList<ZXBC_TCPClient>();
        public TCPSever()
        {
            InitializeComponent();
            if (this.DesignMode == false)
            {
                //TCPSever_comboBox.SelectedIndex = 0;
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {//筛选IPV4
                        TCPSever_comboBox.Items.Add(ip.ToString());
                    }
                }
            }
        }


        /// <summary>
        /// 绑定客户端列表
        /// </summary>
        private void BindLstClient()
        {
            TCPSever_listBox.Invoke(new MethodInvoker(delegate {
                TCPSever_listBox.DataSource = null;
                TCPSever_listBox.DataSource = lstClient;
                TCPSever_listBox.DisplayMember = "Name";
            }));
        }

        /// <summary>
        /// 开启TCP监听
        /// </summary>
        /// <returns></returns>
        private void StartTCPServer()
        {
            try
            {
                if (TCPSever_comboBox.SelectedIndex == 0)
                {
                    tcpsever = new TcpListener(IPAddress.Any, (int)TCPSever_nUD.Value);
                }
                else
                {
                    tcpsever = new TcpListener(IPAddress.Parse(TCPSever_comboBox.SelectedItem.ToString()), (int)TCPSever_nUD.Value);
                }
                tcpsever.Start();
                tcpsever.BeginAcceptTcpClient(new AsyncCallback(Acceptor), tcpsever);
                isListen = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 停止TCP监听
        /// </summary>
        /// <returns></returns>
        private void StopTCPServer()
        {
            tcpsever.Stop();
            isListen = false;
        }

        /// <summary>
        /// 客户端连接初始化
        /// </summary>
        /// <param name="o"></param>
        private void Acceptor(IAsyncResult o)
        {
            TcpListener server = o.AsyncState as TcpListener;
            try
            {
                //初始化连接的客户端
                ZXBC_TCPClient newClient = new ZXBC_TCPClient();
                newClient.NetWork = server.EndAcceptTcpClient(o);
                lstClient.Add(newClient);
                BindLstClient();
                newClient.NetWork.GetStream().BeginRead(newClient.buffer, 0, newClient.buffer.Length, new AsyncCallback(TCPCallBack), newClient);
                server.BeginAcceptTcpClient(new AsyncCallback(Acceptor), server);//继续监听客户端连接
            }
            catch (ObjectDisposedException ex)
            { //监听被关闭
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 对当前选中的客户端发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public bool SendData(byte[] data)
        {
            if (TCPSever_listBox.SelectedItems.Count > 0)
            {
                for (int i = 0; i < TCPSever_listBox.SelectedItems.Count; i++)
                {
                    ZXBC_TCPClient selClient = (ZXBC_TCPClient)TCPSever_listBox.SelectedItems[i];
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
                MessageBox.Show("无可用客户端", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 客户端通讯回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void TCPCallBack(IAsyncResult ar)
        {
            ZXBC_TCPClient client = (ZXBC_TCPClient)ar.AsyncState;
            if (client.NetWork.Connected)
            {
                try
                {
                    NetworkStream ns = client.NetWork.GetStream();
                    byte[] recdata = new byte[ns.EndRead(ar)];
                    if (recdata.Length > 0)
                    {
                        Array.Copy(client.buffer, recdata, recdata.Length);
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

        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (TCPSever_listBox.SelectedItems.Count > 0)
            {
                if (TCPSever_listBox.SelectedItems.Count > 0)
                {
                    List<ZXBC_TCPClient> WaitRemove = new List<ZXBC_TCPClient>();
                    for (int i = 0; i < TCPSever_listBox.SelectedItems.Count; i++)
                    {
                        WaitRemove.Add((ZXBC_TCPClient)TCPSever_listBox.SelectedItems[i]);
                    }
                    foreach (ZXBC_TCPClient client in WaitRemove)
                    {
                        client.DisConnect();
                        lstClient.Remove(client);
                    }
                }
            }
        }

        /// <summary>
        /// 清理
        /// </summary>
        public void ClearSelf()
        {
            foreach (ZXBC_TCPClient client in lstClient)
            {
                client.DisConnect();
            }
            lstClient.Clear();
            if (tcpsever != null)
            {
                tcpsever.Stop();
            }
        }

        private void TCPSever_button_Click(object sender, EventArgs e)
        {
            if (isListen == false)
            {//监听已停止
                StartTCPServer();
            }
            else
            {//监听已开启
                StopTCPServer();
            }
            TCPSever_comboBox.Enabled = !isListen;
            TCPSever_nUD.Enabled = !isListen;
            if (isListen)
            {
                TCPSever_button.Text = "停止";
            }
            else
            {
                TCPSever_button.Text = "监听";
            }
        }
    }
}
