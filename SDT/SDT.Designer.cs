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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.serialPortComPanl1 = new ZXBC.PartPanl.SerialPortComPanl();
            this.dateReceive1 = new ZXBC.UC.DateReceive();
            this.dataSend1 = new ZXBC.UC.DataSend();
            this.serialPortCom1 = new ZXBC.UC.SerialPortCom();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.serialPortComPanl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // serialPortComPanl1
            // 
            this.serialPortComPanl1.Location = new System.Drawing.Point(0, 0);
            this.serialPortComPanl1.Name = "serialPortComPanl1";
            this.serialPortComPanl1.Size = new System.Drawing.Size(805, 493);
            this.serialPortComPanl1.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(920, 575);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
    }
}

