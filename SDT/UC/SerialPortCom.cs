using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ZXBC.UC
{
    public partial class SerialPortCom : UserControl
    {
        private SerialPort ComDevice = new SerialPort();

        public SerialPortCom()
        {
            InitializeComponent();
            SP_ComList.Items.AddRange(SerialPort.GetPortNames());
            if (SP_ComList.Items.Count > 0)
            {
                SP_ComList.SelectedIndex = 0;
                SP_btn.Enabled = true;
            }
            SP_BaudRate.SelectedIndex = 5;
            SP_Parity.SelectedIndex = 0;
            SP_DataBits.SelectedIndex = 0;
            SP_StopBits.SelectedIndex = 0;
            SP_pictureBox.BackgroundImage = Resource.picture.SP_Redlight;
            ComDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
        }
        /// <summary>
        /// 从串口接收数据
        /// </summary>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
        }

        /// <summary>
        /// 点击打开串口按钮
        /// </summary>
        private void SP_btn_Click(object sender, EventArgs e)
        {
            if (ComDevice.IsOpen == false)
            {
                ComDevice.PortName = SP_ComList.SelectedItem.ToString();
                ComDevice.BaudRate = Convert.ToInt32(SP_BaudRate.SelectedItem.ToString());
                ComDevice.Parity = (Parity)Convert.ToInt32(SP_Parity.SelectedIndex.ToString());
                ComDevice.DataBits = Convert.ToInt32(SP_DataBits.SelectedItem.ToString());
                ComDevice.StopBits = (StopBits)Convert.ToInt32(SP_StopBits.SelectedItem.ToString());
                try
                {
                    ComDevice.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SP_btn.Text = "关闭串口";
                SP_pictureBox.BackgroundImage = Resource.picture.SP_Greenlight;
            }
            else
            {
                try
                {
                    ComDevice.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SP_btn.Text = "打开串口";
                SP_pictureBox.BackgroundImage = Resource.picture.SP_Redlight;
            }

            SP_ComList.Enabled = !ComDevice.IsOpen;
            SP_BaudRate.Enabled = !ComDevice.IsOpen;
            SP_Parity.Enabled = !ComDevice.IsOpen;
            SP_DataBits.Enabled = !ComDevice.IsOpen;
            SP_StopBits.Enabled = !ComDevice.IsOpen;
        }

        /// <summary>
        /// 串口发送数据
        /// </summary>
        /// <param name="data">串口发送的数据</param>
        public bool SendData(byte[] data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    ComDevice.Write(data, 0, data.Length);//发送数据
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
