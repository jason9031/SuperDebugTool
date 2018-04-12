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
using ZXBC.UserForm;
using System.Threading;

namespace ZXBC.UC
{
    public partial class DataSend : UserControl
    {
        BindingList<ZXBC.Lib.CMD> lstCMD = new BindingList<ZXBC.Lib.CMD>();
        public event ZxbcEvent.DataSendHandler EventDataSend;

        /// <summary>
        /// 是否在自动循环发送状态
        /// </summary>
        bool AutoSend = false;

        public DataSend()
        {
            InitializeComponent();
            DS_dataGridView.AutoGenerateColumns = false;
            lstCMD.Add(new ZXBC.Lib.CMD(EnumType.DataEncode.ASCII, new ASCIIEncoding().GetBytes("Test!")));
            DS_dataGridView.DataSource = lstCMD;
        }

        /// <summary>
        /// 点击发送按钮
        /// </summary>
        private void DS_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {//点击了发送按钮 
                if (EventDataSend != null)
                {
                    if (EventDataSend(lstCMD[e.RowIndex].Bytes) == false)
                    {
                        StopAutoSend();
                    }
                    else
                    {
                        linkLb_sd_num.Invoke(new MethodInvoker(delegate
                        {
                            linkLb_sd_num.Text = (int.Parse(linkLb_sd_num.Text) + lstCMD[e.RowIndex].Bytes.Length).ToString();
                        }));
                    }
                }

            }
        }

        /// <summary>
        /// 停止循环发送
        /// </summary>
        private void StopAutoSend()
        {
            AutoSend = false;
            DS_AutoSend_btn.Text = "循环发送";
            DS_dataGridView.Enabled = true;
            SD_time.Enabled = true;
        }
        /// <summary>
        /// 单击统计个数
        /// </summary>
        private void linkLb_sd_num_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLb_sd_num.Text = "0";
        }
        /// <summary>
        /// 添加调试命令
        /// </summary>
        private void MS_Add_Click(object sender, EventArgs e)
        {
            CmdForm fCmd = new CmdForm();
            if (fCmd.ShowDialog() == DialogResult.OK)
            {
                lstCMD.Add(fCmd.NewCMD);
            }
        }
        /// <summary>
        /// 编辑调试命令
        /// </summary>
        private void MS_Edit_Click(object sender, EventArgs e)
        {
            if (DS_dataGridView.SelectedRows.Count > 0)
            {
                CmdForm fCmd = new CmdForm(lstCMD[DS_dataGridView.SelectedRows[0].Index]);
                if (fCmd.ShowDialog() == DialogResult.OK)
                {
                    lstCMD[DS_dataGridView.SelectedRows[0].Index] = fCmd.NewCMD;
                }
            }
        }
        /// <summary>
        /// 删除调试命令
        /// </summary>
        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (DS_dataGridView.SelectedRows.Count > 0)
            {
                lstCMD.RemoveAt(DS_dataGridView.SelectedRows[0].Index);
            }

        }

        /// <summary>
        /// 自动发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoSend_Click(object sender, EventArgs e)
        {
            if (AutoSend == false)
            {
                DS_AutoSend_btn.Text = "停止循环";
                DS_dataGridView.Enabled = false;
                SD_time.Enabled = false;
                AutoSend = true;
                Thread ThTestL = new Thread(new ParameterizedThreadStart(TAutoSend));
                ThTestL.IsBackground = true;
                ThTestL.Start(SD_time.Value);
            }
            else
            {
                StopAutoSend();
            }
        }

        /// <summary>
        /// 自动发送命令线程
        /// </summary>
        private void TAutoSend(object Interval)
        {
            try
            {
                object sendlock = new object();
                int SendInterval = Convert.ToInt32(Interval);
                while (AutoSend)
                {
                    for (int i = 0; i < lstCMD.Count; i++)
                    {
                        if (AutoSend)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                object cbxValue = DS_dataGridView.Rows[i].Cells[0].Value;
                                if (cbxValue is bool && cbxValue.Equals(true))
                                {
                                    if (EventDataSend != null)
                                    {
                                        if (EventDataSend(lstCMD[i].Bytes) == false)
                                        {
                                            StopAutoSend();
                                        }
                                        else
                                        {
                                            linkLb_sd_num.Invoke(new MethodInvoker(delegate
                                            {
                                                linkLb_sd_num.Text = (int.Parse(linkLb_sd_num.Text) + lstCMD[i].Bytes.Length).ToString();
                                            }));
                                        }
                                    }
                                }
                            }));
                            Thread.Sleep(SendInterval);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch { };
        }
    }
}
