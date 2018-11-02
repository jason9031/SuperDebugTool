namespace ZXBC.UC
{
    partial class TCPClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TCPClient_IP_textBox = new System.Windows.Forms.TextBox();
            this.TCPClient_Port_numericUD = new System.Windows.Forms.NumericUpDown();
            this.TCPClient_Connect_button = new System.Windows.Forms.Button();
            this.TCPClient_Connect_listBox = new System.Windows.Forms.ListBox();
            this.TCPClient_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TCPClient_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TCPClient_Port_numericUD)).BeginInit();
            this.TCPClient_CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务端";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端 口";
            // 
            // TCPClient_IP_textBox
            // 
            this.TCPClient_IP_textBox.Location = new System.Drawing.Point(51, 6);
            this.TCPClient_IP_textBox.Name = "TCPClient_IP_textBox";
            this.TCPClient_IP_textBox.Size = new System.Drawing.Size(119, 21);
            this.TCPClient_IP_textBox.TabIndex = 2;
            // 
            // TCPClient_Port_numericUD
            // 
            this.TCPClient_Port_numericUD.Location = new System.Drawing.Point(52, 33);
            this.TCPClient_Port_numericUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TCPClient_Port_numericUD.Name = "TCPClient_Port_numericUD";
            this.TCPClient_Port_numericUD.Size = new System.Drawing.Size(59, 21);
            this.TCPClient_Port_numericUD.TabIndex = 3;
            this.TCPClient_Port_numericUD.Value = new decimal(new int[] {
            5005,
            0,
            0,
            0});
            // 
            // TCPClient_Connect_button
            // 
            this.TCPClient_Connect_button.Location = new System.Drawing.Point(118, 30);
            this.TCPClient_Connect_button.Name = "TCPClient_Connect_button";
            this.TCPClient_Connect_button.Size = new System.Drawing.Size(53, 23);
            this.TCPClient_Connect_button.TabIndex = 4;
            this.TCPClient_Connect_button.Text = "连接";
            this.TCPClient_Connect_button.UseVisualStyleBackColor = true;
            this.TCPClient_Connect_button.Click += new System.EventHandler(this.TCP_Connect_button_Click);
            // 
            // TCPClient_Connect_listBox
            // 
            this.TCPClient_Connect_listBox.ContextMenuStrip = this.TCPClient_CMS;
            this.TCPClient_Connect_listBox.FormattingEnabled = true;
            this.TCPClient_Connect_listBox.ItemHeight = 12;
            this.TCPClient_Connect_listBox.Location = new System.Drawing.Point(6, 69);
            this.TCPClient_Connect_listBox.Name = "TCPClient_Connect_listBox";
            this.TCPClient_Connect_listBox.Size = new System.Drawing.Size(164, 124);
            this.TCPClient_Connect_listBox.TabIndex = 5;
            // 
            // TCPClient_CMS
            // 
            this.TCPClient_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TCPClient_Disconnect});
            this.TCPClient_CMS.Name = "TCPClient_CMS";
            this.TCPClient_CMS.Size = new System.Drawing.Size(125, 26);
            // 
            // TCPClient_Disconnect
            // 
            this.TCPClient_Disconnect.Name = "TCPClient_Disconnect";
            this.TCPClient_Disconnect.Size = new System.Drawing.Size(124, 22);
            this.TCPClient_Disconnect.Text = "断开链接";
            this.TCPClient_Disconnect.Click += new System.EventHandler(this.TCPClient_Disconnect_Click);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCPClient_Connect_listBox);
            this.Controls.Add(this.TCPClient_Connect_button);
            this.Controls.Add(this.TCPClient_Port_numericUD);
            this.Controls.Add(this.TCPClient_IP_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TCPClient";
            this.Size = new System.Drawing.Size(174, 204);
            ((System.ComponentModel.ISupportInitialize)(this.TCPClient_Port_numericUD)).EndInit();
            this.TCPClient_CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TCPClient_IP_textBox;
        private System.Windows.Forms.NumericUpDown TCPClient_Port_numericUD;
        private System.Windows.Forms.Button TCPClient_Connect_button;
        private System.Windows.Forms.ListBox TCPClient_Connect_listBox;
        private System.Windows.Forms.ContextMenuStrip TCPClient_CMS;
        private System.Windows.Forms.ToolStripMenuItem TCPClient_Disconnect;
    }
}
