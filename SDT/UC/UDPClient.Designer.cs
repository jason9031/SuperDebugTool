namespace ZXBC.UC
{
    partial class UDPClient
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
            this.UDPClient_IP_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UDPClient_port_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UDPClient_add_button = new System.Windows.Forms.Button();
            this.UDPClient_Connect_listBox = new System.Windows.Forms.ListBox();
            this.UDPClient_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UDPClient_port_numericUpDown)).BeginInit();
            this.UDPClient_CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务端";
            // 
            // UDPClient_IP_textBox
            // 
            this.UDPClient_IP_textBox.Location = new System.Drawing.Point(51, 11);
            this.UDPClient_IP_textBox.Name = "UDPClient_IP_textBox";
            this.UDPClient_IP_textBox.Size = new System.Drawing.Size(127, 21);
            this.UDPClient_IP_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口";
            // 
            // UDPClient_port_numericUpDown
            // 
            this.UDPClient_port_numericUpDown.Location = new System.Drawing.Point(51, 45);
            this.UDPClient_port_numericUpDown.Name = "UDPClient_port_numericUpDown";
            this.UDPClient_port_numericUpDown.Size = new System.Drawing.Size(64, 21);
            this.UDPClient_port_numericUpDown.TabIndex = 3;
            // 
            // UDPClient_add_button
            // 
            this.UDPClient_add_button.Location = new System.Drawing.Point(121, 42);
            this.UDPClient_add_button.Name = "UDPClient_add_button";
            this.UDPClient_add_button.Size = new System.Drawing.Size(57, 23);
            this.UDPClient_add_button.TabIndex = 4;
            this.UDPClient_add_button.Text = "添加";
            this.UDPClient_add_button.UseVisualStyleBackColor = true;
            this.UDPClient_add_button.Click += new System.EventHandler(this.UDPClient_add_button_Click);
            // 
            // UDPClient_Connect_listBox
            // 
            this.UDPClient_Connect_listBox.FormattingEnabled = true;
            this.UDPClient_Connect_listBox.ItemHeight = 12;
            this.UDPClient_Connect_listBox.Location = new System.Drawing.Point(5, 71);
            this.UDPClient_Connect_listBox.Name = "UDPClient_Connect_listBox";
            this.UDPClient_Connect_listBox.Size = new System.Drawing.Size(173, 148);
            this.UDPClient_Connect_listBox.TabIndex = 5;
            // 
            // UDPClient_CMS
            // 
            this.UDPClient_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Delete});
            this.UDPClient_CMS.Name = "UDPClient_CMS";
            this.UDPClient_CMS.Size = new System.Drawing.Size(101, 26);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Size = new System.Drawing.Size(152, 22);
            this.MS_Delete.Text = "删除";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UDPClient_Connect_listBox);
            this.Controls.Add(this.UDPClient_add_button);
            this.Controls.Add(this.UDPClient_port_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UDPClient_IP_textBox);
            this.Controls.Add(this.label1);
            this.Name = "UDPClient";
            this.Size = new System.Drawing.Size(188, 232);
            ((System.ComponentModel.ISupportInitialize)(this.UDPClient_port_numericUpDown)).EndInit();
            this.UDPClient_CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UDPClient_IP_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UDPClient_port_numericUpDown;
        private System.Windows.Forms.Button UDPClient_add_button;
        private System.Windows.Forms.ListBox UDPClient_Connect_listBox;
        private System.Windows.Forms.ContextMenuStrip UDPClient_CMS;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
    }
}
