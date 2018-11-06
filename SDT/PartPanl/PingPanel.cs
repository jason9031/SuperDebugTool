using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;

namespace ZXBC.PartPanl
{
    public partial class PingPanel : UserControl
    {
        bool IsPingAllow = false;
        int PingCount = 0;
        int Interval = 1000;
        public PingPanel()
        {
            InitializeComponent();
        }

        private void Ping_button_Click(object sender, EventArgs e)
        {
            if (IsPingAllow == false)
            {
                Ping_button.Text = "停止";
                PingCount = (int)Ping_times_numericUpDown.Value;
                Interval = (int)Ping_inter_numericUpDown.Value;
                IsPingAllow = true;
                Thread ThPing = new Thread(new ParameterizedThreadStart(PingThread));
                ThPing.IsBackground = true;
                ThPing.Start(Ping_IP_textBox.Text.Trim());
            }
            else
            {
                IsPingAllow = false;
                Ping_button.Enabled = false;
            }
        }

        private void PingThread(object ServerIP)
        {
            Ping_cmdTextBox.Invoke(new MethodInvoker(delegate
            {
                Ping_cmdTextBox.AppendText("正在 Ping " + ServerIP.ToString() + "：\r\n");
            }));
            Ping p = new Ping();
            int pcount = 0;
            long MinRT = -1;
            long MaxRT = -1;
            long AvgRT = -1;
            long TotalRT = 0;
            int SuccessRT = 0;
            while (pcount < PingCount || PingCount == 0)
            {
                PingReply pr = p.Send(ServerIP.ToString());
                Ping_cmdTextBox.Invoke(new MethodInvoker(delegate
                {
                    if (pr.Status == IPStatus.Success)
                    {
                        SuccessRT++;
                        Ping_cmdTextBox.AppendText("来自 " + pr.Address.ToString() + " 的答复：字节=" + pr.Buffer.Length + " 时间=" + pr.RoundtripTime + " TTL=" + pr.Options.Ttl + "\r\n");
                        if (MinRT == -1 || pr.RoundtripTime < MinRT)
                        {
                            MinRT = pr.RoundtripTime;
                        }
                        if (MaxRT == -1 || pr.RoundtripTime > MaxRT)
                        {
                            MaxRT = pr.RoundtripTime;
                        }
                        TotalRT += pr.RoundtripTime;
                        AvgRT = TotalRT / SuccessRT;
                    }
                    else
                    {
                        Ping_cmdTextBox.AppendText(pr.Status.ToString() + "\r\n");
                    }
                }));
                pcount++;
                if (IsPingAllow == false)
                {
                    break;
                }
                Thread.Sleep(Interval);
            }
            this.Invoke(new MethodInvoker(delegate
            {
                Ping_cmdTextBox.AppendText("Ping统计信息：\r\n");
                Ping_cmdTextBox.AppendText("数据包：已发送 = " + pcount + ",已接收 = " + SuccessRT + ",丢失 = " + (pcount - SuccessRT) + " <" + (int)((1 - (float)SuccessRT / (float)pcount) * 100) + "%丢失>\r\n");
                Ping_cmdTextBox.AppendText("往返行程估计时间：最短 = " + MinRT + "ms,最长 = " + MaxRT + "ms,平均 = " + AvgRT + "ms\r\n\r\n");
                Ping_button.Enabled = true;
                Ping_button.Text = "Ping";
            }));
            IsPingAllow = false;
        }

        private void MSI_Clear_Click(object sender, EventArgs e)
        {
            Ping_cmdTextBox.Clear();
        }
    }
}
