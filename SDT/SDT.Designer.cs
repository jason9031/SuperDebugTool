namespace SDT
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.serialPortComPanl1 = new ZXBC.PartPanl.SerialPortComPanl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcpClientPanl1 = new ZXBC.PartPanl.TCPClientPanl();
            this.dateReceive1 = new ZXBC.UC.DateReceive();
            this.dataSend1 = new ZXBC.UC.DataSend();
            this.serialPortCom1 = new ZXBC.UC.SerialPortCom();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tcpSeverPanl1 = new ZXBC.PartPanl.TCPSeverPanl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.serialPortComPanl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // serialPortComPanl1
            // 
            this.serialPortComPanl1.Location = new System.Drawing.Point(0, 0);
            this.serialPortComPanl1.Name = "serialPortComPanl1";
            this.serialPortComPanl1.Size = new System.Drawing.Size(805, 493);
            this.serialPortComPanl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tcpClientPanl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCPClient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tcpClientPanl1
            // 
            this.tcpClientPanl1.Location = new System.Drawing.Point(0, 6);
            this.tcpClientPanl1.Name = "tcpClientPanl1";
            this.tcpClientPanl1.Size = new System.Drawing.Size(852, 522);
            this.tcpClientPanl1.TabIndex = 0;
            // 
            // dateReceive1
            // 
            this.dateReceive1.Location = new System.Drawing.Point(0, 0);
            this.dateReceive1.Name = "dateReceive1";
            this.dateReceive1.Size = new System.Drawing.Size(498, 264);
            this.dateReceive1.TabIndex = 0;
            // 
            // dataSend1
            // 
            this.dataSend1.Location = new System.Drawing.Point(0, 0);
            this.dataSend1.Name = "dataSend1";
            this.dataSend1.Size = new System.Drawing.Size(542, 217);
            this.dataSend1.TabIndex = 0;
            // 
            // serialPortCom1
            // 
            this.serialPortCom1.Location = new System.Drawing.Point(0, 0);
            this.serialPortCom1.Name = "serialPortCom1";
            this.serialPortCom1.Size = new System.Drawing.Size(135, 184);
            this.serialPortCom1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tcpSeverPanl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(899, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TCPSever";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tcpSeverPanl1
            // 
            this.tcpSeverPanl1.Location = new System.Drawing.Point(7, 6);
            this.tcpSeverPanl1.Name = "tcpSeverPanl1";
            this.tcpSeverPanl1.Size = new System.Drawing.Size(895, 549);
            this.tcpSeverPanl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 590);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ZXBC.UC.SerialPortCom serialPortCom1;
        private ZXBC.UC.DataSend dataSend1;
        private ZXBC.UC.DateReceive dateReceive1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZXBC.PartPanl.SerialPortComPanl serialPortComPanl1;
        private ZXBC.PartPanl.TCPClientPanl tcpClientPanl1;
        private System.Windows.Forms.TabPage tabPage3;
        private ZXBC.PartPanl.TCPSeverPanl tcpSeverPanl1;
    }
}

