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
            this.serialPortCom2 = new ZXBC.UC.SerialPortCom();
            this.dataSend2 = new ZXBC.UC.DataSend();
            this.dateReceive1 = new ZXBC.UC.DateReceive();
            this.dataSend1 = new ZXBC.UC.DataSend();
            this.serialPortCom1 = new ZXBC.UC.SerialPortCom();
            this.dateReceive2 = new ZXBC.UC.DateReceive();
            this.SuspendLayout();
            // 
            // serialPortCom2
            // 
            this.serialPortCom2.Location = new System.Drawing.Point(27, 27);
            this.serialPortCom2.Name = "serialPortCom2";
            this.serialPortCom2.Size = new System.Drawing.Size(135, 184);
            this.serialPortCom2.TabIndex = 1;
            // 
            // dataSend2
            // 
            this.dataSend2.Location = new System.Drawing.Point(236, 12);
            this.dataSend2.Name = "dataSend2";
            this.dataSend2.Size = new System.Drawing.Size(542, 217);
            this.dataSend2.TabIndex = 0;
            // 
            // dateReceive2
            // 
            this.dateReceive2.Location = new System.Drawing.Point(47, 246);
            this.dateReceive2.Name = "dateReceive2";
            this.dateReceive2.Size = new System.Drawing.Size(498, 264);
            this.dateReceive2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 546);
            this.Controls.Add(this.dateReceive2);
            this.Controls.Add(this.serialPortCom2);
            this.Controls.Add(this.dataSend2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ZXBC.UC.SerialPortCom serialPortCom1;
        private ZXBC.UC.DataSend dataSend1;
        private ZXBC.UC.DateReceive dateReceive1;
        private ZXBC.UC.DataSend dataSend2;
        private ZXBC.UC.SerialPortCom serialPortCom2;
        private ZXBC.UC.DateReceive dateReceive2;
    }
}

