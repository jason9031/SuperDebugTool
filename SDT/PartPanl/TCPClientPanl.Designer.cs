namespace ZXBC.PartPanl
{
    partial class TCPClientPanl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TCPClient_tabDataReceive = new ZXBC.UC.TabDataReceive();
            this.TCPClient_dataSend = new ZXBC.UC.DataSend();
            this.TCPClient_Conf = new ZXBC.UC.TCPClient();
            this.SuspendLayout();
            // 
            // TCPClient_tabDataReceive
            // 
            this.TCPClient_tabDataReceive.Location = new System.Drawing.Point(0, 210);
            this.TCPClient_tabDataReceive.Name = "TCPClient_tabDataReceive";
            this.TCPClient_tabDataReceive.Size = new System.Drawing.Size(892, 364);
            this.TCPClient_tabDataReceive.TabIndex = 2;
            // 
            // TCPClient_dataSend
            // 
            this.TCPClient_dataSend.Location = new System.Drawing.Point(180, 0);
            this.TCPClient_dataSend.Name = "TCPClient_dataSend";
            this.TCPClient_dataSend.Size = new System.Drawing.Size(712, 210);
            this.TCPClient_dataSend.TabIndex = 1;
            this.TCPClient_dataSend.EventDataSend += new ZXBC.Lib.ZxbcEvent.DataSendHandler(this.TCPClient_dataSend_EventDataSend);
            // 
            // TCPClient_Conf
            // 
            this.TCPClient_Conf.Location = new System.Drawing.Point(0, 0);
            this.TCPClient_Conf.Name = "TCPClient_Conf";
            this.TCPClient_Conf.Size = new System.Drawing.Size(180, 210);
            this.TCPClient_Conf.TabIndex = 0;
            this.TCPClient_Conf.DataReceived += new ZXBC.Lib.ZxbcEvent.DataReceivedHandler(this.TCPClient_Conf_DataReceived);
            // 
            // TCPClientPanl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCPClient_tabDataReceive);
            this.Controls.Add(this.TCPClient_dataSend);
            this.Controls.Add(this.TCPClient_Conf);
            this.Name = "TCPClientPanl";
            this.Size = new System.Drawing.Size(892, 574);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.TCPClient TCPClient_Conf;
        private UC.DataSend TCPClient_dataSend;
        private UC.TabDataReceive TCPClient_tabDataReceive;
    }
}
