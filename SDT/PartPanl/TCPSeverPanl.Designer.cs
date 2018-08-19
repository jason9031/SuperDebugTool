namespace ZXBC.PartPanl
{
    partial class TCPSeverPanl
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
            this.TCPSever = new ZXBC.UC.TCPSever();
            this.TCPSever_dataSend = new ZXBC.UC.DataSend();
            this.TCPSever_tabDataReceive = new ZXBC.UC.TabDataReceive();
            this.SuspendLayout();
            // 
            // TCPSever
            // 
            this.TCPSever.Location = new System.Drawing.Point(3, 3);
            this.TCPSever.Name = "TCPSever";
            this.TCPSever.Size = new System.Drawing.Size(185, 208);
            this.TCPSever.TabIndex = 0;
            this.TCPSever.DataReceived += new ZXBC.Lib.ZxbcEvent.DataReceivedHandler(this.TCPSever_DataReceived);
            // 
            // TCPSever_dataSend
            // 
            this.TCPSever_dataSend.Location = new System.Drawing.Point(185, 3);
            this.TCPSever_dataSend.Name = "TCPSever_dataSend";
            this.TCPSever_dataSend.Size = new System.Drawing.Size(542, 208);
            this.TCPSever_dataSend.TabIndex = 1;
            this.TCPSever_dataSend.EventDataSend += new ZXBC.Lib.ZxbcEvent.DataSendHandler(this.TCPSever_dataSend_EventDataSend);
            // 
            // TCPSever_tabDataReceive
            // 
            this.TCPSever_tabDataReceive.Location = new System.Drawing.Point(12, 205);
            this.TCPSever_tabDataReceive.Name = "TCPSever_tabDataReceive";
            this.TCPSever_tabDataReceive.Size = new System.Drawing.Size(838, 317);
            this.TCPSever_tabDataReceive.TabIndex = 2;
            // 
            // TCPSeverPanl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCPSever_tabDataReceive);
            this.Controls.Add(this.TCPSever_dataSend);
            this.Controls.Add(this.TCPSever);
            this.Name = "TCPSeverPanl";
            this.Size = new System.Drawing.Size(895, 549);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.TCPSever TCPSever;
        private UC.DataSend TCPSever_dataSend;
        private UC.TabDataReceive TCPSever_tabDataReceive;
    }
}
