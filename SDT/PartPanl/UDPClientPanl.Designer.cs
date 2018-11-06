namespace ZXBC.PartPanl
{
    partial class UDPClientPanl
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
            this.UDPClient = new ZXBC.UC.UDPClient();
            this.UDPClient_dataSend = new ZXBC.UC.DataSend();
            this.UDPClient_tabDataReceive = new ZXBC.UC.TabDataReceive();
            this.SuspendLayout();
            // 
            // UDPClient
            // 
            this.UDPClient.Location = new System.Drawing.Point(0, 0);
            this.UDPClient.Name = "UDPClient";
            this.UDPClient.Size = new System.Drawing.Size(180, 210);
            this.UDPClient.TabIndex = 0;
            this.UDPClient.DataReceived += new ZXBC.Lib.ZxbcEvent.DataReceivedHandler(this.UDPClient_DataReceived);
            // 
            // UDPClient_dataSend
            // 
            this.UDPClient_dataSend.Location = new System.Drawing.Point(180, 0);
            this.UDPClient_dataSend.Name = "UDPClient_dataSend";
            this.UDPClient_dataSend.Size = new System.Drawing.Size(712, 210);
            this.UDPClient_dataSend.TabIndex = 1;
            this.UDPClient_dataSend.EventDataSend += new ZXBC.Lib.ZxbcEvent.DataSendHandler(this.UDPClient_dataSend_EventDataSend);
            // 
            // UDPClient_tabDataReceive
            // 
            this.UDPClient_tabDataReceive.Location = new System.Drawing.Point(0, 210);
            this.UDPClient_tabDataReceive.Name = "UDPClient_tabDataReceive";
            this.UDPClient_tabDataReceive.Size = new System.Drawing.Size(892, 364);
            this.UDPClient_tabDataReceive.TabIndex = 2;
            // 
            // UDPClientPanl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UDPClient_tabDataReceive);
            this.Controls.Add(this.UDPClient_dataSend);
            this.Controls.Add(this.UDPClient);
            this.Name = "UDPClientPanl";
            this.Size = new System.Drawing.Size(892, 574);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UDPClient UDPClient;
        private UC.DataSend UDPClient_dataSend;
        private UC.TabDataReceive UDPClient_tabDataReceive;
    }
}
