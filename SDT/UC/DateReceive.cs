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
using System.Text.RegularExpressions;

namespace ZXBC.UC
{
    public partial class DateReceive : UserControl
    {
        private EnumType.DataEncode EncodeType = EnumType.DataEncode.Hex;

        public DateReceive()
        {
            InitializeComponent();
        }

        #region 公有方法
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="data">字节数组</param>
        public void AddData(byte[] data)
        {
            switch (EncodeType)
            {
                case EnumType.DataEncode.Hex:
                    //16进制显示
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < data.Length; i++)
                    {
                        sb.AppendFormat("{0:x2}" + " ", data[i]);
                    }
                    AddContent(sb.ToString().ToUpper());
                    break;
                case EnumType.DataEncode.ASCII:
                    //ASCII码显示
                    AddContent(new ASCIIEncoding().GetString(data));
                    break;
                case EnumType.DataEncode.GB2312:
                    //GB2312显示
                    AddContent(Encoding.GetEncoding("GB2312").GetString(data));
                    break;
            }
            DR_datanum_lLb.Invoke(new MethodInvoker(delegate
            {
                DR_datanum_lLb.Text = (int.Parse(DR_datanum_lLb.Text) + data.Length).ToString();
            }));
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 添加文本内容
        /// </summary>
        /// <param name="content"></param>
        private void AddContent(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if (DR_AutoLine_chB.Checked && DR_textBox.Text.Length > 0)
                {
                    DR_textBox.AppendText("\r\n");
                }
                DR_textBox.AppendText(content);
            }));
        }
        private void DR_datanum_lLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DR_datanum_lLb.Text = "0";
        }
        #endregion
        private void DR_CMS_VisibleChanged(object sender, EventArgs e)
        {
            if (DR_CMS.Visible == true)
            {//菜单被显示
                string[] SelectData = DR_textBox.SelectedText.TrimEnd().TrimStart().Split(' ');//获取选中部分文本
                foreach (string data in SelectData)
                {
                    if (Regex.IsMatch(data, "^[0-9A-Fa-f]+$"))
                    {
                        continue;
                    }
                    else
                    {
                        MS_ToInt.Enabled = false;
                        MS_ToFloat.Enabled = false;
                        MS_ToDouble.Enabled = false;
                        return;
                    }
                }
                if (SelectData.Length == 2)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 4)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToFloat.Enabled = true;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 8)
                {
                    MS_ToInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = true;
                }
                else
                {
                    MS_ToInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
            }
            else
            {
                MS_ToInt.Enabled = false;
                MS_ToFloat.Enabled = false;
                MS_ToDouble.Enabled = false;
            }
        }

        private void MS_Clear_Click(object sender, EventArgs e)
        {
            DR_textBox.Clear();
        }

        /// <summary>
        /// 16进制字符串数组转byte数组
        /// </summary>
        /// <param name="B"></param>
        /// <returns></returns>
        private byte[] StringsToBytes(string[] B)
        {
            byte[] BToInt32 = new byte[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                if (!string.IsNullOrEmpty(B[i]))
                {
                    BToInt32[i] = (byte)Convert.ToInt32(B[i], 16);
                }
            }
            return BToInt32;
        }
        private void MS_ToInt_Click(object sender, EventArgs e)
        {
            string[] SelectData = DR_textBox.SelectedText.Trim().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            if (IntByte.Length == 2)
            {
                MessageBox.Show(BitConverter.ToInt16(IntByte, 0).ToString(), "整数值");
            }
            else
            {
                MessageBox.Show(BitConverter.ToInt32(IntByte, 0).ToString(), "整数值");
            }
        }

        private void MS_ToFloat_Click(object sender, EventArgs e)
        {
            string[] SelectData = DR_textBox.SelectedText.Trim().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            MessageBox.Show(BitConverter.ToSingle(IntByte, 0).ToString(), "单精度浮点数值");
        }

        private void MS_ToDouble_Click(object sender, EventArgs e)
        {
            string[] SelectData = DR_textBox.SelectedText.Trim().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            MessageBox.Show(BitConverter.ToDouble(IntByte, 0).ToString(), "双精度浮点数值");
        }

        private void DR_Hex_rB_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_Hex_rB.Checked)
            {
                EncodeType = EnumType.DataEncode.Hex;
            }
        }

        private void DR_ASCII_rB_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_ASCII_rB.Checked)
            {
                EncodeType = EnumType.DataEncode.ASCII;
            }
        }

        private void DR_GB2312_rB_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_GB2312_rB.Checked)
            {
                EncodeType = EnumType.DataEncode.GB2312;
            }
        }

        private void DR_datanum_lLb_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DR_datanum_lLb.Text = "0";
        }
    }
}
