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

namespace ZXBC.UserForm
{
    public partial class CmdForm : Form
    {
        public Lib.CMD NewCMD = null;

        public CmdForm(Lib.CMD cmd)
        {
            InitializeComponent();
            CMD_bytesBox.SetCMD(cmd);
            SetType(CMD_bytesBox.EncodeType);
        }

        public CmdForm()
        {
            InitializeComponent();
            SetType(EnumType.DataEncode.Hex);
        }

        private void CMD_Save_btn_Click(object sender, EventArgs e)
        {
            NewCMD = CMD_bytesBox.GetCMD();
            if (NewCMD != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CMD_Cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SetType(EnumType.DataEncode EncodeType)
        {
            switch (EncodeType)
            {
                case EnumType.DataEncode.Hex:
                    MSI_Hex.Checked = true;
                    CM_Check.Enabled = true;

                    MSI_ASCII.Enabled = true;
                    MSI_GB2312.Enabled = true;

                    MSI_ASCII.Checked = false;
                    MSI_GB2312.Checked = false;
                    break;
                case EnumType.DataEncode.ASCII:
                    MSI_ASCII.Enabled = false;
                    MSI_GB2312.Enabled = false;
                    CM_Check.Enabled = false;

                    MSI_Hex.Checked = false;
                    MSI_ASCII.Checked = true;
                    break;
                case EnumType.DataEncode.GB2312:
                    MSI_ASCII.Enabled = false;
                    MSI_GB2312.Enabled = false;
                    CM_Check.Enabled = false;

                    MSI_Hex.Checked = false;
                    MSI_GB2312.Checked = true;
                    break;
            }
            CMD_bytesBox.EncodeType = EncodeType;
        }


        #region 菜单操作
        private void MSI_Hex_Click(object sender, EventArgs e)
        {
            SetType(EnumType.DataEncode.Hex);
        }

        private void MSI_ASCII_Click(object sender, EventArgs e)
        {
            SetType(EnumType.DataEncode.ASCII);
        }

        private void MSI_GB2312_Click(object sender, EventArgs e)
        {
            SetType(EnumType.DataEncode.GB2312);
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CM_Clear_Click(object sender, EventArgs e)
        {
            CMD_bytesBox.Clear();
        }
        #endregion

        #region 校验码计算
        /// <summary>
        /// 校验和
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CheckSum_Click(object sender, EventArgs e)
        {
            Lib.CMD cmd = CMD_bytesBox.GetCMD();
            if (cmd != null)
            {
                byte check = Lib.BytesCheck.GetXOR(cmd.Bytes);
                CMD_bytesBox.AppendText(Convert.ToString(check, 16).PadLeft(2, '0'));
            }
        }

        private void MS_CRCPoly_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 多项式CRC16 低位在前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void MS_CRCPolyL_Click(object sender, EventArgs e)
        //{
        //    Lib.CMD cmd = CMD_bytesBox.GetCMD();
        //    if (cmd != null)
        //    {
        //        frmPoly fpoly = new frmPoly();
        //        if (fpoly.ShowDialog() == DialogResult.OK)
        //        {
        //            AppendToContent(Lib.BytesCheck.GetCRC16ByPoly(cmd.Bytes, fpoly.Poly, false));
        //        }
        //    }
        //}

        private void AppendToContent(byte[] check)
        {
            foreach (byte b in check)
            {
                CMD_bytesBox.AppendText(string.Format("{0:X2}", b));
            }
        }
        #endregion
    }
}
