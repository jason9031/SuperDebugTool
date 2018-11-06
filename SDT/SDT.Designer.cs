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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.serialPortComPanl1 = new ZXBC.PartPanl.SerialPortComPanl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcpClientPanl1 = new ZXBC.PartPanl.TCPClientPanl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tcpSeverPanl1 = new ZXBC.PartPanl.TCPSeverPanl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.udpSeverPanl1 = new ZXBC.PartPanl.UDPSeverPanl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.udpClientPanl1 = new ZXBC.PartPanl.UDPClientPanl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pingPanel1 = new ZXBC.PartPanl.PingPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.calc_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_Debug_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_Com_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_TCPClient_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_TCPSever_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_UDPSever_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_UDPPClient_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_Ping_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateReceive1 = new ZXBC.UC.DateReceive();
            this.dataSend1 = new ZXBC.UC.DataSend();
            this.serialPortCom1 = new ZXBC.UC.SerialPortCom();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.serialPortComPanl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // serialPortComPanl1
            // 
            this.serialPortComPanl1.Location = new System.Drawing.Point(0, 0);
            this.serialPortComPanl1.Name = "serialPortComPanl1";
            this.serialPortComPanl1.Size = new System.Drawing.Size(892, 574);
            this.serialPortComPanl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tcpClientPanl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCPClient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tcpClientPanl1
            // 
            this.tcpClientPanl1.Location = new System.Drawing.Point(0, 0);
            this.tcpClientPanl1.Name = "tcpClientPanl1";
            this.tcpClientPanl1.Size = new System.Drawing.Size(892, 574);
            this.tcpClientPanl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tcpSeverPanl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(887, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TCPSever";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tcpSeverPanl1
            // 
            this.tcpSeverPanl1.Location = new System.Drawing.Point(0, 0);
            this.tcpSeverPanl1.Name = "tcpSeverPanl1";
            this.tcpSeverPanl1.Size = new System.Drawing.Size(892, 574);
            this.tcpSeverPanl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.udpSeverPanl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(887, 570);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "UDPSever";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // udpSeverPanl1
            // 
            this.udpSeverPanl1.Location = new System.Drawing.Point(0, 0);
            this.udpSeverPanl1.Name = "udpSeverPanl1";
            this.udpSeverPanl1.Size = new System.Drawing.Size(906, 572);
            this.udpSeverPanl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.udpClientPanl1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(887, 570);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "UDPClient";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // udpClientPanl1
            // 
            this.udpClientPanl1.Location = new System.Drawing.Point(0, 0);
            this.udpClientPanl1.Name = "udpClientPanl1";
            this.udpClientPanl1.Size = new System.Drawing.Size(892, 574);
            this.udpClientPanl1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.pingPanel1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(887, 570);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ping";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // pingPanel1
            // 
            this.pingPanel1.Location = new System.Drawing.Point(0, 0);
            this.pingPanel1.Name = "pingPanel1";
            this.pingPanel1.Size = new System.Drawing.Size(892, 574);
            this.pingPanel1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calc_toolStripMenuItem,
            this.New_Debug_toolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(917, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // calc_toolStripMenuItem
            // 
            this.calc_toolStripMenuItem.Image = global::ZXBC.Properties.Resources.calculator;
            this.calc_toolStripMenuItem.Name = "calc_toolStripMenuItem";
            this.calc_toolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.calc_toolStripMenuItem.Text = "计算器";
            this.calc_toolStripMenuItem.Click += new System.EventHandler(this.calc_toolStripMenuItem_Click);
            // 
            // New_Debug_toolStripMenuItem
            // 
            this.New_Debug_toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Debug_Com_toolStripMenuItem,
            this.Debug_TCPClient_toolStripMenuItem,
            this.Debug_TCPSever_toolStripMenuItem,
            this.Debug_UDPSever_toolStripMenuItem,
            this.Debug_UDPPClient_toolStripMenuItem,
            this.Debug_Ping_toolStripMenuItem});
            this.New_Debug_toolStripMenuItem.Image = global::ZXBC.Properties.Resources.com;
            this.New_Debug_toolStripMenuItem.Name = "New_Debug_toolStripMenuItem";
            this.New_Debug_toolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.New_Debug_toolStripMenuItem.Text = "新的调试";
            // 
            // Debug_Com_toolStripMenuItem
            // 
            this.Debug_Com_toolStripMenuItem.Image = global::ZXBC.Properties.Resources.com;
            this.Debug_Com_toolStripMenuItem.Name = "Debug_Com_toolStripMenuItem";
            this.Debug_Com_toolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.Debug_Com_toolStripMenuItem.Text = "串口";
            this.Debug_Com_toolStripMenuItem.Click += new System.EventHandler(this.Debug_Com_toolStripMenuItem_Click);
            // 
            // Debug_TCPClient_toolStripMenuItem
            // 
            this.Debug_TCPClient_toolStripMenuItem.Image = global::ZXBC.Properties.Resources.tcp;
            this.Debug_TCPClient_toolStripMenuItem.Name = "Debug_TCPClient_toolStripMenuItem";
            this.Debug_TCPClient_toolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.Debug_TCPClient_toolStripMenuItem.Text = "TCP Srever";
            this.Debug_TCPClient_toolStripMenuItem.Click += new System.EventHandler(this.Debug_TCPClient_toolStripMenuItem_Click);
            // 
            // Debug_TCPSever_toolStripMenuItem
            // 
            this.Debug_TCPSever_toolStripMenuItem.Image = global::ZXBC.Properties.Resources.tcp;
            this.Debug_TCPSever_toolStripMenuItem.Name = "Debug_TCPSever_toolStripMenuItem";
            this.Debug_TCPSever_toolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.Debug_TCPSever_toolStripMenuItem.Text = "TCP Client";
            this.Debug_TCPSever_toolStripMenuItem.Click += new System.EventHandler(this.Debug_TCPSever_toolStripMenuItem_Click);
            // 
            // Debug_UDPSever_toolStripMenuItem
            // 
            this.Debug_UDPSever_toolStripMenuItem.Image = global::ZXBC.Properties.Resources.udp;
            this.Debug_UDPSever_toolStripMenuItem.Name = "Debug_UDPSever_toolStripMenuItem";
            this.Debug_UDPSever_toolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.Debug_UDPSever_toolStripMenuItem.Text = "UDP Server";
            this.Debug_UDPSever_toolStripMenuItem.Click += new System.EventHandler(this.Debug_UDPSever_toolStripMenuItem_Click);
            // 
            // Debug_UDPPClient_toolStripMenuItem
            // 
            this.Debug_UDPPClient_toolStripMenuItem.Image = global::ZXBC.Properties.Resources.udp;
            this.Debug_UDPPClient_toolStripMenuItem.Name = "Debug_UDPPClient_toolStripMenuItem";
            this.Debug_UDPPClient_toolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.Debug_UDPPClient_toolStripMenuItem.Text = "UDP Client";
            this.Debug_UDPPClient_toolStripMenuItem.Click += new System.EventHandler(this.Debug_UDPPClient_toolStripMenuItem_Click);
            // 
            // Debug_Ping_toolStripMenuItem
            // 
            this.Debug_Ping_toolStripMenuItem.Image = global::ZXBC.Properties.Resources.tcp;
            this.Debug_Ping_toolStripMenuItem.Name = "Debug_Ping_toolStripMenuItem";
            this.Debug_Ping_toolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.Debug_Ping_toolStripMenuItem.Text = "Png Panel";
            this.Debug_Ping_toolStripMenuItem.Click += new System.EventHandler(this.Debug_Ping_toolStripMenuItem_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 637);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Super Debug Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage tabPage4;
        private ZXBC.PartPanl.UDPSeverPanl udpSeverPanl1;
        private System.Windows.Forms.TabPage tabPage5;
        private ZXBC.PartPanl.UDPClientPanl udpClientPanl1;
        private System.Windows.Forms.TabPage tabPage6;
        private ZXBC.PartPanl.PingPanel pingPanel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem New_Debug_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_Com_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_TCPClient_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_TCPSever_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_UDPSever_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_UDPPClient_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_Ping_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calc_toolStripMenuItem;
    }
}

