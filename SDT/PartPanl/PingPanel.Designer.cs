namespace ZXBC.PartPanl
{
    partial class PingPanel
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Ping_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ping_IP_textBox = new System.Windows.Forms.TextBox();
            this.Ping_times_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Ping_inter_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MSI_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Ping_cmdTextBox = new ZXBC.CP.CMDTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ping_times_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ping_inter_numericUpDown)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ping_button
            // 
            this.Ping_button.Location = new System.Drawing.Point(682, 9);
            this.Ping_button.Name = "Ping_button";
            this.Ping_button.Size = new System.Drawing.Size(84, 25);
            this.Ping_button.TabIndex = 1;
            this.Ping_button.Text = "Ping";
            this.Ping_button.UseVisualStyleBackColor = true;
            this.Ping_button.Click += new System.EventHandler(this.Ping_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "目标IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(206, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ping次数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(395, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ping间隔";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(557, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "ms";
            // 
            // Ping_IP_textBox
            // 
            this.Ping_IP_textBox.Location = new System.Drawing.Point(68, 12);
            this.Ping_IP_textBox.Name = "Ping_IP_textBox";
            this.Ping_IP_textBox.Size = new System.Drawing.Size(100, 21);
            this.Ping_IP_textBox.TabIndex = 6;
            this.Ping_IP_textBox.Text = "www.baidu.com";
            // 
            // Ping_times_numericUpDown
            // 
            this.Ping_times_numericUpDown.Location = new System.Drawing.Point(275, 12);
            this.Ping_times_numericUpDown.Name = "Ping_times_numericUpDown";
            this.Ping_times_numericUpDown.Size = new System.Drawing.Size(65, 21);
            this.Ping_times_numericUpDown.TabIndex = 7;
            this.Ping_times_numericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Ping_inter_numericUpDown
            // 
            this.Ping_inter_numericUpDown.Location = new System.Drawing.Point(464, 12);
            this.Ping_inter_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Ping_inter_numericUpDown.Name = "Ping_inter_numericUpDown";
            this.Ping_inter_numericUpDown.Size = new System.Drawing.Size(87, 21);
            this.Ping_inter_numericUpDown.TabIndex = 8;
            this.Ping_inter_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_Clear});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // MSI_Clear
            // 
            this.MSI_Clear.Name = "MSI_Clear";
            this.MSI_Clear.Size = new System.Drawing.Size(100, 22);
            this.MSI_Clear.Text = "清空";
            this.MSI_Clear.Click += new System.EventHandler(this.MSI_Clear_Click);
            // 
            // Ping_cmdTextBox
            // 
            this.Ping_cmdTextBox.BackColor = System.Drawing.Color.Black;
            this.Ping_cmdTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.Ping_cmdTextBox.ForeColor = System.Drawing.Color.White;
            this.Ping_cmdTextBox.Location = new System.Drawing.Point(0, 34);
            this.Ping_cmdTextBox.Multiline = true;
            this.Ping_cmdTextBox.Name = "Ping_cmdTextBox";
            this.Ping_cmdTextBox.Size = new System.Drawing.Size(892, 540);
            this.Ping_cmdTextBox.TabIndex = 0;
            // 
            // PingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ping_inter_numericUpDown);
            this.Controls.Add(this.Ping_times_numericUpDown);
            this.Controls.Add(this.Ping_IP_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ping_button);
            this.Controls.Add(this.Ping_cmdTextBox);
            this.Name = "PingPanel";
            this.Size = new System.Drawing.Size(892, 574);
            ((System.ComponentModel.ISupportInitialize)(this.Ping_times_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ping_inter_numericUpDown)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CP.CMDTextBox Ping_cmdTextBox;
        private System.Windows.Forms.Button Ping_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ping_IP_textBox;
        private System.Windows.Forms.NumericUpDown Ping_times_numericUpDown;
        private System.Windows.Forms.NumericUpDown Ping_inter_numericUpDown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MSI_Clear;
    }
}
