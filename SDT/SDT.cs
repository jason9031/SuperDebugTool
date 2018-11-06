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
using ZXBC.PartPanl;
using ZXBC.Properties;

namespace SDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 调试窗口

        private void CreateNewTest(object p, string title, Icon icon)
        {
            Form frm = new Form();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Icon = icon;
            frm.Controls.Add((Control)p);
            frm.Width = 800;
            frm.Height = 500;
            frm.ShowIcon = true;
            frm.Text = title;
            //frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);
            frm.Show();
        }
        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Close();
            ZXBC.PartPanl.BasePanel bp = (ZXBC.PartPanl.BasePanel)frm.Controls[0];
            bp.ClearSelf();
        }
        private void Debug_Com_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialPortComPanl tp = new SerialPortComPanl();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "串口[" + DateTime.Now.ToString("HHmmss") + "]", Resources.ucom);
        }
        

        private void Debug_TCPClient_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCPClientPanl nwin = new TCPClientPanl();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "TCP Client[" + DateTime.Now.ToString("HHmmss") + "]", Resources.utcp);
        }

        private void Debug_TCPSever_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCPSeverPanl nwin = new TCPSeverPanl();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "TCP Server[" + DateTime.Now.ToString("HHmmss") + "]", Resources.utcp);
        }

        private void Debug_UDPSever_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            UDPSeverPanl nwin = new UDPSeverPanl();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "UDP Server[" + DateTime.Now.ToString("HHmmss") + "]", Resources.uudp);
        }

        private void Debug_UDPPClient_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            UDPClientPanl nwin = new UDPClientPanl();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "UDP Client[" + DateTime.Now.ToString("HHmmss") + "]", Resources.uudp);
        }

        private void Debug_Ping_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            PingPanel nwin = new PingPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "Ping Panel[" + DateTime.Now.ToString("HHmmss") + "]",Resources.utcp);
        }
        #endregion
        #region 调试窗口
        private void calc_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "calc.exe ";//"calc.exe"为计算器，"notepad.exe"为记事本
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
        }
        #endregion
    }
}
