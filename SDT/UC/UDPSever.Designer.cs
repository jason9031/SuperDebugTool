namespace ZXBC.UC
{
    partial class UDPSever
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
            this.UDPSever_IP_comboBox = new System.Windows.Forms.ComboBox();
            this.UDPClient_Port_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UDPClient_Connect_button = new System.Windows.Forms.Button();
            this.UDPSever_listBox = new System.Windows.Forms.ListBox();
            this.UDPSever_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UDPClient_Port_numericUpDown)).BeginInit();
            this.UDPSever_CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本地";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口";
            // 
            // UDPSever_IP_comboBox
            // 
            this.UDPSever_IP_comboBox.FormattingEnabled = true;
            this.UDPSever_IP_comboBox.Items.AddRange(new object[] {
            "Any"});
            this.UDPSever_IP_comboBox.Location = new System.Drawing.Point(40, 4);
            this.UDPSever_IP_comboBox.Name = "UDPSever_IP_comboBox";
            this.UDPSever_IP_comboBox.Size = new System.Drawing.Size(130, 20);
            this.UDPSever_IP_comboBox.TabIndex = 2;
            // 
            // UDPClient_Port_numericUpDown
            // 
            this.UDPClient_Port_numericUpDown.Location = new System.Drawing.Point(40, 31);
            this.UDPClient_Port_numericUpDown.Name = "UDPClient_Port_numericUpDown";
            this.UDPClient_Port_numericUpDown.Size = new System.Drawing.Size(67, 21);
            this.UDPClient_Port_numericUpDown.TabIndex = 3;
            // 
            // UDPClient_Connect_button
            // 
            this.UDPClient_Connect_button.Location = new System.Drawing.Point(113, 30);
            this.UDPClient_Connect_button.Name = "UDPClient_Connect_button";
            this.UDPClient_Connect_button.Size = new System.Drawing.Size(57, 23);
            this.UDPClient_Connect_button.TabIndex = 4;
            this.UDPClient_Connect_button.Text = "监听";
            this.UDPClient_Connect_button.UseVisualStyleBackColor = true;
            this.UDPClient_Connect_button.Click += new System.EventHandler(this.UDPClient_Connect_button_Click);
            // 
            // UDPSever_listBox
            // 
            this.UDPSever_listBox.FormattingEnabled = true;
            this.UDPSever_listBox.ItemHeight = 12;
            this.UDPSever_listBox.Location = new System.Drawing.Point(7, 65);
            this.UDPSever_listBox.Name = "UDPSever_listBox";
            this.UDPSever_listBox.Size = new System.Drawing.Size(163, 136);
            this.UDPSever_listBox.TabIndex = 5;
            // 
            // UDPSever_CMS
            // 
            this.UDPSever_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Delete});
            this.UDPSever_CMS.Name = "UDPSever_CMS";
            this.UDPSever_CMS.Size = new System.Drawing.Size(101, 26);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Size = new System.Drawing.Size(100, 22);
            this.MS_Delete.Text = "删除";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // UDPSever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UDPSever_listBox);
            this.Controls.Add(this.UDPClient_Connect_button);
            this.Controls.Add(this.UDPClient_Port_numericUpDown);
            this.Controls.Add(this.UDPSever_IP_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UDPSever";
            this.Size = new System.Drawing.Size(180, 210);
            ((System.ComponentModel.ISupportInitialize)(this.UDPClient_Port_numericUpDown)).EndInit();
            this.UDPSever_CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UDPSever_IP_comboBox;
        private System.Windows.Forms.NumericUpDown UDPClient_Port_numericUpDown;
        private System.Windows.Forms.Button UDPClient_Connect_button;
        private System.Windows.Forms.ListBox UDPSever_listBox;
        private System.Windows.Forms.ContextMenuStrip UDPSever_CMS;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
    }
}
