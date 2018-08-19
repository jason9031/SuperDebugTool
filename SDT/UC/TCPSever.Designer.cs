namespace ZXBC.UC
{
    partial class TCPSever
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
            this.TCPSever_comboBox = new System.Windows.Forms.ComboBox();
            this.TCPSever_nUD = new System.Windows.Forms.NumericUpDown();
            this.TCPSever_button = new System.Windows.Forms.Button();
            this.TCPSever_listBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TCPSever_nUD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本地：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // TCPSever_comboBox
            // 
            this.TCPSever_comboBox.FormattingEnabled = true;
            this.TCPSever_comboBox.Location = new System.Drawing.Point(40, 1);
            this.TCPSever_comboBox.Name = "TCPSever_comboBox";
            this.TCPSever_comboBox.Size = new System.Drawing.Size(131, 20);
            this.TCPSever_comboBox.TabIndex = 2;
            // 
            // TCPSever_nUD
            // 
            this.TCPSever_nUD.Location = new System.Drawing.Point(40, 27);
            this.TCPSever_nUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TCPSever_nUD.Name = "TCPSever_nUD";
            this.TCPSever_nUD.Size = new System.Drawing.Size(59, 21);
            this.TCPSever_nUD.TabIndex = 3;
            this.TCPSever_nUD.Value = new decimal(new int[] {
            5005,
            0,
            0,
            0});
            // 
            // TCPSever_button
            // 
            this.TCPSever_button.Location = new System.Drawing.Point(105, 27);
            this.TCPSever_button.Name = "TCPSever_button";
            this.TCPSever_button.Size = new System.Drawing.Size(66, 23);
            this.TCPSever_button.TabIndex = 4;
            this.TCPSever_button.Text = "监听";
            this.TCPSever_button.UseVisualStyleBackColor = true;
            this.TCPSever_button.Click += new System.EventHandler(this.TCPSever_button_Click);
            // 
            // TCPSever_listBox
            // 
            this.TCPSever_listBox.ContextMenuStrip = this.contextMenuStrip1;
            this.TCPSever_listBox.FormattingEnabled = true;
            this.TCPSever_listBox.ItemHeight = 12;
            this.TCPSever_listBox.Location = new System.Drawing.Point(6, 64);
            this.TCPSever_listBox.Name = "TCPSever_listBox";
            this.TCPSever_listBox.Size = new System.Drawing.Size(165, 136);
            this.TCPSever_listBox.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Size = new System.Drawing.Size(152, 22);
            this.MS_Delete.Text = "断开连接";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // TCPSever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCPSever_listBox);
            this.Controls.Add(this.TCPSever_button);
            this.Controls.Add(this.TCPSever_nUD);
            this.Controls.Add(this.TCPSever_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TCPSever";
            this.Size = new System.Drawing.Size(185, 208);
            ((System.ComponentModel.ISupportInitialize)(this.TCPSever_nUD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TCPSever_comboBox;
        private System.Windows.Forms.NumericUpDown TCPSever_nUD;
        private System.Windows.Forms.Button TCPSever_button;
        private System.Windows.Forms.ListBox TCPSever_listBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
    }
}
