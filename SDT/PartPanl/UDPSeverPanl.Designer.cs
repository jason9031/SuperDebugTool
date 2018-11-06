namespace ZXBC.PartPanl
{
    partial class UDPSeverPanl
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
            this.UDPSever = new ZXBC.UC.UDPSever();
            this.UDPSever_dataSend = new ZXBC.UC.DataSend();
            this.UDPSever_tabDataReceive = new ZXBC.UC.TabDataReceive();
            this.SuspendLayout();
            // 
            // UDPSever
            // 
            this.UDPSever.Location = new System.Drawing.Point(0, 0);
            this.UDPSever.Name = "UDPSever";
            this.UDPSever.Size = new System.Drawing.Size(180, 210);
            this.UDPSever.TabIndex = 0;
            this.UDPSever.DataReceived += new ZXBC.Lib.ZxbcEvent.DataReceivedHandler(this.UDPSever_DataReceived);
            // 
            // UDPSever_dataSend
            // 
            this.UDPSever_dataSend.Location = new System.Drawing.Point(180, 0);
            this.UDPSever_dataSend.Name = "UDPSever_dataSend";
            this.UDPSever_dataSend.Size = new System.Drawing.Size(712, 210);
            this.UDPSever_dataSend.TabIndex = 1;
            this.UDPSever_dataSend.EventDataSend += new ZXBC.Lib.ZxbcEvent.DataSendHandler(this.UDPSever_dataSend_EventDataSend);
            // 
            // UDPSever_tabDataReceive
            // 
            this.UDPSever_tabDataReceive.Location = new System.Drawing.Point(0, 210);
            this.UDPSever_tabDataReceive.Name = "UDPSever_tabDataReceive";
            this.UDPSever_tabDataReceive.Size = new System.Drawing.Size(892, 364);
            this.UDPSever_tabDataReceive.TabIndex = 2;
            // 
            // UDPSeverPanl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UDPSever_tabDataReceive);
            this.Controls.Add(this.UDPSever_dataSend);
            this.Controls.Add(this.UDPSever);
            this.Name = "UDPSeverPanl";
            this.Size = new System.Drawing.Size(892, 574);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UDPSever UDPSever;
        private UC.DataSend UDPSever_dataSend;
        private UC.TabDataReceive UDPSever_tabDataReceive;
    }
}
