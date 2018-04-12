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
            this.serialPortCom1 = new ZXBC.UC.SerialPortCom();
            this.dataSend1 = new ZXBC.UC.DataSend();
            this.SuspendLayout();
            // 
            // serialPortCom1
            // 
            this.serialPortCom1.Location = new System.Drawing.Point(12, 12);
            this.serialPortCom1.Name = "serialPortCom1";
            this.serialPortCom1.Size = new System.Drawing.Size(135, 184);
            this.serialPortCom1.TabIndex = 0;
            // 
            // dataSend1
            // 
            this.dataSend1.Location = new System.Drawing.Point(167, 12);
            this.dataSend1.Name = "dataSend1";
            this.dataSend1.Size = new System.Drawing.Size(542, 217);
            this.dataSend1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 356);
            this.Controls.Add(this.dataSend1);
            this.Controls.Add(this.serialPortCom1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ZXBC.UC.SerialPortCom serialPortCom1;
        private ZXBC.UC.DataSend dataSend1;
    }
}

