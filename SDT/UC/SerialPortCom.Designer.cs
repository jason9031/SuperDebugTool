namespace ZXBC.UC
{
    partial class SerialPortCom
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
            this.SP_ComList = new System.Windows.Forms.ComboBox();
            this.SP_BaudRate = new System.Windows.Forms.ComboBox();
            this.SP_Parity = new System.Windows.Forms.ComboBox();
            this.SP_DataBits = new System.Windows.Forms.ComboBox();
            this.SP_StopBits = new System.Windows.Forms.ComboBox();
            this.lb_SP_Com = new System.Windows.Forms.Label();
            this.lb_SP_BaudRate = new System.Windows.Forms.Label();
            this.lb_SP_Parity = new System.Windows.Forms.Label();
            this.lb_SP_DataBits = new System.Windows.Forms.Label();
            this.lb_SP_StopBits = new System.Windows.Forms.Label();
            this.SP_btn = new System.Windows.Forms.Button();
            this.SP_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SP_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_ComList
            // 
            this.SP_ComList.FormattingEnabled = true;
            this.SP_ComList.Location = new System.Drawing.Point(48, 3);
            this.SP_ComList.Name = "SP_ComList";
            this.SP_ComList.Size = new System.Drawing.Size(79, 20);
            this.SP_ComList.TabIndex = 0;
            // 
            // SP_BaudRate
            // 
            this.SP_BaudRate.FormattingEnabled = true;
            this.SP_BaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.SP_BaudRate.Location = new System.Drawing.Point(48, 29);
            this.SP_BaudRate.Name = "SP_BaudRate";
            this.SP_BaudRate.Size = new System.Drawing.Size(79, 20);
            this.SP_BaudRate.TabIndex = 1;
            // 
            // SP_Parity
            // 
            this.SP_Parity.FormattingEnabled = true;
            this.SP_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.SP_Parity.Location = new System.Drawing.Point(48, 55);
            this.SP_Parity.Name = "SP_Parity";
            this.SP_Parity.Size = new System.Drawing.Size(79, 20);
            this.SP_Parity.TabIndex = 1;
            // 
            // SP_DataBits
            // 
            this.SP_DataBits.FormattingEnabled = true;
            this.SP_DataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.SP_DataBits.Location = new System.Drawing.Point(48, 81);
            this.SP_DataBits.Name = "SP_DataBits";
            this.SP_DataBits.Size = new System.Drawing.Size(79, 20);
            this.SP_DataBits.TabIndex = 1;
            // 
            // SP_StopBits
            // 
            this.SP_StopBits.FormattingEnabled = true;
            this.SP_StopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.SP_StopBits.Location = new System.Drawing.Point(48, 107);
            this.SP_StopBits.Name = "SP_StopBits";
            this.SP_StopBits.Size = new System.Drawing.Size(79, 20);
            this.SP_StopBits.TabIndex = 1;
            // 
            // lb_SP_Com
            // 
            this.lb_SP_Com.AutoSize = true;
            this.lb_SP_Com.Location = new System.Drawing.Point(3, 11);
            this.lb_SP_Com.Name = "lb_SP_Com";
            this.lb_SP_Com.Size = new System.Drawing.Size(29, 12);
            this.lb_SP_Com.TabIndex = 2;
            this.lb_SP_Com.Text = "串口";
            // 
            // lb_SP_BaudRate
            // 
            this.lb_SP_BaudRate.AutoSize = true;
            this.lb_SP_BaudRate.Location = new System.Drawing.Point(1, 36);
            this.lb_SP_BaudRate.Name = "lb_SP_BaudRate";
            this.lb_SP_BaudRate.Size = new System.Drawing.Size(41, 12);
            this.lb_SP_BaudRate.TabIndex = 3;
            this.lb_SP_BaudRate.Text = "波特率";
            // 
            // lb_SP_Parity
            // 
            this.lb_SP_Parity.AutoSize = true;
            this.lb_SP_Parity.Location = new System.Drawing.Point(3, 62);
            this.lb_SP_Parity.Name = "lb_SP_Parity";
            this.lb_SP_Parity.Size = new System.Drawing.Size(41, 12);
            this.lb_SP_Parity.TabIndex = 4;
            this.lb_SP_Parity.Text = "校验位";
            // 
            // lb_SP_DataBits
            // 
            this.lb_SP_DataBits.AutoSize = true;
            this.lb_SP_DataBits.Location = new System.Drawing.Point(3, 88);
            this.lb_SP_DataBits.Name = "lb_SP_DataBits";
            this.lb_SP_DataBits.Size = new System.Drawing.Size(41, 12);
            this.lb_SP_DataBits.TabIndex = 5;
            this.lb_SP_DataBits.Text = "数据位";
            // 
            // lb_SP_StopBits
            // 
            this.lb_SP_StopBits.AutoSize = true;
            this.lb_SP_StopBits.Location = new System.Drawing.Point(3, 114);
            this.lb_SP_StopBits.Name = "lb_SP_StopBits";
            this.lb_SP_StopBits.Size = new System.Drawing.Size(41, 12);
            this.lb_SP_StopBits.TabIndex = 6;
            this.lb_SP_StopBits.Text = "停止位";
            // 
            // SP_btn
            // 
            this.SP_btn.Location = new System.Drawing.Point(48, 135);
            this.SP_btn.Name = "SP_btn";
            this.SP_btn.Size = new System.Drawing.Size(75, 38);
            this.SP_btn.TabIndex = 7;
            this.SP_btn.Text = "打开串口";
            this.SP_btn.UseVisualStyleBackColor = true;
            this.SP_btn.Click += new System.EventHandler(this.SP_btn_Click);
            // 
            // SP_pictureBox
            // 
            this.SP_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SP_pictureBox.Location = new System.Drawing.Point(5, 135);
            this.SP_pictureBox.Name = "SP_pictureBox";
            this.SP_pictureBox.Size = new System.Drawing.Size(39, 38);
            this.SP_pictureBox.TabIndex = 8;
            this.SP_pictureBox.TabStop = false;
            // 
            // SerialPortCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SP_pictureBox);
            this.Controls.Add(this.SP_btn);
            this.Controls.Add(this.lb_SP_StopBits);
            this.Controls.Add(this.lb_SP_DataBits);
            this.Controls.Add(this.lb_SP_Parity);
            this.Controls.Add(this.lb_SP_BaudRate);
            this.Controls.Add(this.lb_SP_Com);
            this.Controls.Add(this.SP_StopBits);
            this.Controls.Add(this.SP_DataBits);
            this.Controls.Add(this.SP_Parity);
            this.Controls.Add(this.SP_BaudRate);
            this.Controls.Add(this.SP_ComList);
            this.Name = "SerialPortCom";
            this.Size = new System.Drawing.Size(135, 184);
            ((System.ComponentModel.ISupportInitialize)(this.SP_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SP_ComList;
        private System.Windows.Forms.ComboBox SP_BaudRate;
        private System.Windows.Forms.ComboBox SP_Parity;
        private System.Windows.Forms.ComboBox SP_DataBits;
        private System.Windows.Forms.ComboBox SP_StopBits;
        private System.Windows.Forms.Label lb_SP_Com;
        private System.Windows.Forms.Label lb_SP_BaudRate;
        private System.Windows.Forms.Label lb_SP_Parity;
        private System.Windows.Forms.Label lb_SP_DataBits;
        private System.Windows.Forms.Label lb_SP_StopBits;
        private System.Windows.Forms.Button SP_btn;
        private System.Windows.Forms.PictureBox SP_pictureBox;
    }
}
