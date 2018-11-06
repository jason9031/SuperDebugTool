namespace ZXBC.UC
{
    partial class DateReceive
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
            this.DR_AutoLine_chB = new System.Windows.Forms.CheckBox();
            this.DR_Hex_rB = new System.Windows.Forms.RadioButton();
            this.DR_GB2312_rB = new System.Windows.Forms.RadioButton();
            this.DR_textBox = new System.Windows.Forms.TextBox();
            this.DR_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.DR_datanum_lb = new System.Windows.Forms.Label();
            this.DR_datanum_lLb = new System.Windows.Forms.LinkLabel();
            this.DR_mes_lb = new System.Windows.Forms.Label();
            this.DR_ASCII_rB = new System.Windows.Forms.RadioButton();
            this.DR_CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // DR_AutoLine_chB
            // 
            this.DR_AutoLine_chB.AutoSize = true;
            this.DR_AutoLine_chB.Location = new System.Drawing.Point(4, 4);
            this.DR_AutoLine_chB.Name = "DR_AutoLine_chB";
            this.DR_AutoLine_chB.Size = new System.Drawing.Size(72, 16);
            this.DR_AutoLine_chB.TabIndex = 0;
            this.DR_AutoLine_chB.Text = "自动换行";
            this.DR_AutoLine_chB.UseVisualStyleBackColor = true;
            // 
            // DR_Hex_rB
            // 
            this.DR_Hex_rB.AutoSize = true;
            this.DR_Hex_rB.Checked = true;
            this.DR_Hex_rB.Location = new System.Drawing.Point(83, 4);
            this.DR_Hex_rB.Name = "DR_Hex_rB";
            this.DR_Hex_rB.Size = new System.Drawing.Size(41, 16);
            this.DR_Hex_rB.TabIndex = 1;
            this.DR_Hex_rB.TabStop = true;
            this.DR_Hex_rB.Text = "Hex";
            this.DR_Hex_rB.UseVisualStyleBackColor = true;
            this.DR_Hex_rB.CheckedChanged += new System.EventHandler(this.DR_Hex_rB_CheckedChanged);
            // 
            // DR_GB2312_rB
            // 
            this.DR_GB2312_rB.AutoSize = true;
            this.DR_GB2312_rB.Location = new System.Drawing.Point(192, 5);
            this.DR_GB2312_rB.Name = "DR_GB2312_rB";
            this.DR_GB2312_rB.Size = new System.Drawing.Size(59, 16);
            this.DR_GB2312_rB.TabIndex = 2;
            this.DR_GB2312_rB.Text = "GB2312";
            this.DR_GB2312_rB.UseVisualStyleBackColor = true;
            this.DR_GB2312_rB.CheckedChanged += new System.EventHandler(this.DR_GB2312_rB_CheckedChanged);
            // 
            // DR_textBox
            // 
            this.DR_textBox.ContextMenuStrip = this.DR_CMS;
            this.DR_textBox.Location = new System.Drawing.Point(4, 27);
            this.DR_textBox.Multiline = true;
            this.DR_textBox.Name = "DR_textBox";
            this.DR_textBox.ReadOnly = true;
            this.DR_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DR_textBox.Size = new System.Drawing.Size(876, 311);
            this.DR_textBox.TabIndex = 3;
            // 
            // DR_CMS
            // 
            this.DR_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Clear,
            this.MS_ToInt,
            this.MS_ToFloat,
            this.MS_ToDouble});
            this.DR_CMS.Name = "DR_CMS";
            this.DR_CMS.Size = new System.Drawing.Size(199, 92);
            this.DR_CMS.VisibleChanged += new System.EventHandler(this.DR_CMS_VisibleChanged);
            // 
            // MS_Clear
            // 
            this.MS_Clear.Name = "MS_Clear";
            this.MS_Clear.Size = new System.Drawing.Size(198, 22);
            this.MS_Clear.Text = "清空";
            this.MS_Clear.Click += new System.EventHandler(this.MS_Clear_Click);
            // 
            // MS_ToInt
            // 
            this.MS_ToInt.Name = "MS_ToInt";
            this.MS_ToInt.Size = new System.Drawing.Size(198, 22);
            this.MS_ToInt.Text = "转换为整数(Int)";
            this.MS_ToInt.Click += new System.EventHandler(this.MS_ToInt_Click);
            // 
            // MS_ToFloat
            // 
            this.MS_ToFloat.Name = "MS_ToFloat";
            this.MS_ToFloat.Size = new System.Drawing.Size(198, 22);
            this.MS_ToFloat.Text = "转换为浮点数(Float)";
            this.MS_ToFloat.Click += new System.EventHandler(this.MS_ToFloat_Click);
            // 
            // MS_ToDouble
            // 
            this.MS_ToDouble.Name = "MS_ToDouble";
            this.MS_ToDouble.Size = new System.Drawing.Size(198, 22);
            this.MS_ToDouble.Text = "转换为浮点数(Double)";
            this.MS_ToDouble.Click += new System.EventHandler(this.MS_ToDouble_Click);
            // 
            // DR_datanum_lb
            // 
            this.DR_datanum_lb.AutoSize = true;
            this.DR_datanum_lb.Location = new System.Drawing.Point(2, 341);
            this.DR_datanum_lb.Name = "DR_datanum_lb";
            this.DR_datanum_lb.Size = new System.Drawing.Size(77, 12);
            this.DR_datanum_lb.TabIndex = 4;
            this.DR_datanum_lb.Text = "接收字节数：";
            // 
            // DR_datanum_lLb
            // 
            this.DR_datanum_lLb.AutoSize = true;
            this.DR_datanum_lLb.Location = new System.Drawing.Point(81, 341);
            this.DR_datanum_lLb.Name = "DR_datanum_lLb";
            this.DR_datanum_lLb.Size = new System.Drawing.Size(11, 12);
            this.DR_datanum_lLb.TabIndex = 5;
            this.DR_datanum_lLb.TabStop = true;
            this.DR_datanum_lLb.Text = "0";
            this.DR_datanum_lLb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DR_datanum_lLb_LinkClicked_1);
            // 
            // DR_mes_lb
            // 
            this.DR_mes_lb.AutoSize = true;
            this.DR_mes_lb.ForeColor = System.Drawing.Color.Red;
            this.DR_mes_lb.Location = new System.Drawing.Point(749, 341);
            this.DR_mes_lb.Name = "DR_mes_lb";
            this.DR_mes_lb.Size = new System.Drawing.Size(131, 12);
            this.DR_mes_lb.TabIndex = 6;
            this.DR_mes_lb.Text = "提示：右键Hes计算数值";
            // 
            // DR_ASCII_rB
            // 
            this.DR_ASCII_rB.AutoSize = true;
            this.DR_ASCII_rB.Location = new System.Drawing.Point(130, 5);
            this.DR_ASCII_rB.Name = "DR_ASCII_rB";
            this.DR_ASCII_rB.Size = new System.Drawing.Size(53, 16);
            this.DR_ASCII_rB.TabIndex = 8;
            this.DR_ASCII_rB.Text = "ASCII";
            this.DR_ASCII_rB.UseVisualStyleBackColor = true;
            this.DR_ASCII_rB.CheckedChanged += new System.EventHandler(this.DR_ASCII_rB_CheckedChanged);
            // 
            // DateReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DR_ASCII_rB);
            this.Controls.Add(this.DR_mes_lb);
            this.Controls.Add(this.DR_datanum_lLb);
            this.Controls.Add(this.DR_datanum_lb);
            this.Controls.Add(this.DR_textBox);
            this.Controls.Add(this.DR_GB2312_rB);
            this.Controls.Add(this.DR_Hex_rB);
            this.Controls.Add(this.DR_AutoLine_chB);
            this.Name = "DateReceive";
            this.Size = new System.Drawing.Size(892, 364);
            this.DR_CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DR_AutoLine_chB;
        private System.Windows.Forms.RadioButton DR_Hex_rB;
        private System.Windows.Forms.RadioButton DR_GB2312_rB;
        private System.Windows.Forms.TextBox DR_textBox;
        private System.Windows.Forms.Label DR_datanum_lb;
        private System.Windows.Forms.LinkLabel DR_datanum_lLb;
        private System.Windows.Forms.Label DR_mes_lb;
        private System.Windows.Forms.ContextMenuStrip DR_CMS;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_ToInt;
        private System.Windows.Forms.ToolStripMenuItem MS_ToFloat;
        private System.Windows.Forms.ToolStripMenuItem MS_ToDouble;
        private System.Windows.Forms.RadioButton DR_ASCII_rB;
    }
}
