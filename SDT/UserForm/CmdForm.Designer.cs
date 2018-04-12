namespace ZXBC.UserForm
{
    partial class CmdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_cmd_text = new System.Windows.Forms.Label();
            this.lb_Warn_inf = new System.Windows.Forms.Label();
            this.CMD_Save_btn = new System.Windows.Forms.Button();
            this.CMD_Cancel_btn = new System.Windows.Forms.Button();
            this.CMD_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MSI_Hex = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_ASCII = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_GB2312 = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CheckSum = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPoly = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_bytesBox = new ZXBC.CP.BytesBox();
            this.CMD_CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_cmd_text
            // 
            this.lb_cmd_text.AutoSize = true;
            this.lb_cmd_text.Location = new System.Drawing.Point(2, 1);
            this.lb_cmd_text.Name = "lb_cmd_text";
            this.lb_cmd_text.Size = new System.Drawing.Size(65, 12);
            this.lb_cmd_text.TabIndex = 0;
            this.lb_cmd_text.Text = "命令内容：";
            // 
            // lb_Warn_inf
            // 
            this.lb_Warn_inf.AutoSize = true;
            this.lb_Warn_inf.ForeColor = System.Drawing.Color.Red;
            this.lb_Warn_inf.Location = new System.Drawing.Point(2, 111);
            this.lb_Warn_inf.Name = "lb_Warn_inf";
            this.lb_Warn_inf.Size = new System.Drawing.Size(209, 12);
            this.lb_Warn_inf.TabIndex = 2;
            this.lb_Warn_inf.Text = "提示：右键切换编码格式及计算校验码";
            // 
            // CMD_Save_btn
            // 
            this.CMD_Save_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CMD_Save_btn.Location = new System.Drawing.Point(234, 106);
            this.CMD_Save_btn.Name = "CMD_Save_btn";
            this.CMD_Save_btn.Size = new System.Drawing.Size(70, 23);
            this.CMD_Save_btn.TabIndex = 3;
            this.CMD_Save_btn.Text = "保存";
            this.CMD_Save_btn.UseVisualStyleBackColor = true;
            this.CMD_Save_btn.Click += new System.EventHandler(this.CMD_Save_btn_Click);
            // 
            // CMD_Cancel_btn
            // 
            this.CMD_Cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CMD_Cancel_btn.Location = new System.Drawing.Point(320, 106);
            this.CMD_Cancel_btn.Name = "CMD_Cancel_btn";
            this.CMD_Cancel_btn.Size = new System.Drawing.Size(70, 23);
            this.CMD_Cancel_btn.TabIndex = 3;
            this.CMD_Cancel_btn.Text = "取消";
            this.CMD_Cancel_btn.UseVisualStyleBackColor = true;
            this.CMD_Cancel_btn.Click += new System.EventHandler(this.CMD_Cancel_btn_Click);
            // 
            // CMD_CMS
            // 
            this.CMD_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_Hex,
            this.MSI_ASCII,
            this.MSI_GB2312,
            this.CM_Check,
            this.CM_Clear});
            this.CMD_CMS.Name = "CMD_CMS";
            this.CMD_CMS.ShowCheckMargin = true;
            this.CMD_CMS.ShowImageMargin = false;
            this.CMD_CMS.Size = new System.Drawing.Size(153, 136);
            // 
            // MSI_Hex
            // 
            this.MSI_Hex.Name = "MSI_Hex";
            this.MSI_Hex.Size = new System.Drawing.Size(152, 22);
            this.MSI_Hex.Text = "Hex";
            this.MSI_Hex.Click += new System.EventHandler(this.MSI_Hex_Click);
            // 
            // MSI_ASCII
            // 
            this.MSI_ASCII.Name = "MSI_ASCII";
            this.MSI_ASCII.Size = new System.Drawing.Size(152, 22);
            this.MSI_ASCII.Text = "ASCII";
            this.MSI_ASCII.Click += new System.EventHandler(this.MSI_ASCII_Click);
            // 
            // MSI_GB2312
            // 
            this.MSI_GB2312.Name = "MSI_GB2312";
            this.MSI_GB2312.Size = new System.Drawing.Size(152, 22);
            this.MSI_GB2312.Text = "GB2312";
            this.MSI_GB2312.Click += new System.EventHandler(this.MSI_GB2312_Click);
            // 
            // CM_Check
            // 
            this.CM_Check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_CheckSum,
            this.MS_CRCPoly});
            this.CM_Check.Name = "CM_Check";
            this.CM_Check.Size = new System.Drawing.Size(136, 22);
            this.CM_Check.Text = "计算校验码";
            // 
            // MS_CheckSum
            // 
            this.MS_CheckSum.Name = "MS_CheckSum";
            this.MS_CheckSum.Size = new System.Drawing.Size(114, 22);
            this.MS_CheckSum.Text = "校验和";
            this.MS_CheckSum.Click += new System.EventHandler(this.MS_CheckSum_Click);
            // 
            // MS_CRCPoly
            // 
            this.MS_CRCPoly.Name = "MS_CRCPoly";
            this.MS_CRCPoly.Size = new System.Drawing.Size(114, 22);
            this.MS_CRCPoly.Text = "CRC16";
            this.MS_CRCPoly.Click += new System.EventHandler(this.MS_CRCPoly_Click);
            // 
            // CM_Clear
            // 
            this.CM_Clear.Name = "CM_Clear";
            this.CM_Clear.Size = new System.Drawing.Size(152, 22);
            this.CM_Clear.Text = "清空";
            this.CM_Clear.Click += new System.EventHandler(this.CM_Clear_Click);
            // 
            // CMD_bytesBox
            // 
            this.CMD_bytesBox.ContextMenuStrip = this.CMD_CMS;
            this.CMD_bytesBox.Location = new System.Drawing.Point(4, 16);
            this.CMD_bytesBox.Multiline = true;
            this.CMD_bytesBox.Name = "CMD_bytesBox";
            this.CMD_bytesBox.Size = new System.Drawing.Size(386, 84);
            this.CMD_bytesBox.TabIndex = 4;
            // 
            // CmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 133);
            this.Controls.Add(this.CMD_bytesBox);
            this.Controls.Add(this.CMD_Cancel_btn);
            this.Controls.Add(this.CMD_Save_btn);
            this.Controls.Add(this.lb_Warn_inf);
            this.Controls.Add(this.lb_cmd_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CmdForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "命令配置";
            this.CMD_CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cmd_text;
        private System.Windows.Forms.Label lb_Warn_inf;
        private System.Windows.Forms.Button CMD_Save_btn;
        private System.Windows.Forms.Button CMD_Cancel_btn;
        private System.Windows.Forms.ContextMenuStrip CMD_CMS;
        private System.Windows.Forms.ToolStripMenuItem MSI_Hex;
        private System.Windows.Forms.ToolStripMenuItem MSI_ASCII;
        private System.Windows.Forms.ToolStripMenuItem MSI_GB2312;
        private System.Windows.Forms.ToolStripMenuItem CM_Check;
        private System.Windows.Forms.ToolStripMenuItem MS_CheckSum;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPoly;
        private System.Windows.Forms.ToolStripMenuItem CM_Clear;
        private CP.BytesBox CMD_bytesBox;
    }
}