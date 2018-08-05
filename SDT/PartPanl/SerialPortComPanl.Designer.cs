namespace ZXBC.PartPanl
{
    partial class SerialPortComPanl
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
            this.Com_serialPortCom = new ZXBC.UC.SerialPortCom();
            this.Com_dataSend = new ZXBC.UC.DataSend();
            this.Com_dateReceive = new ZXBC.UC.DateReceive();
            this.SuspendLayout();
            // 
            // Com_serialPortCom
            // 
            this.Com_serialPortCom.Location = new System.Drawing.Point(3, 3);
            this.Com_serialPortCom.Name = "Com_serialPortCom";
            this.Com_serialPortCom.Size = new System.Drawing.Size(135, 217);
            this.Com_serialPortCom.TabIndex = 0;
            // 
            // Com_dataSend
            // 
            this.Com_dataSend.Location = new System.Drawing.Point(144, 3);
            this.Com_dataSend.Name = "Com_dataSend";
            this.Com_dataSend.Size = new System.Drawing.Size(657, 217);
            this.Com_dataSend.TabIndex = 1;
            // 
            // Com_dateReceive
            // 
            this.Com_dateReceive.Location = new System.Drawing.Point(3, 226);
            this.Com_dateReceive.Name = "Com_dateReceive";
            this.Com_dateReceive.Size = new System.Drawing.Size(798, 281);
            this.Com_dateReceive.TabIndex = 2;
            // 
            // SerialPortComPanl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Com_dateReceive);
            this.Controls.Add(this.Com_dataSend);
            this.Controls.Add(this.Com_serialPortCom);
            this.Name = "SerialPortComPanl";
            this.Size = new System.Drawing.Size(807, 548);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.SerialPortCom Com_serialPortCom;
        private UC.DataSend Com_dataSend;
        private UC.DateReceive Com_dateReceive;
    }
}
