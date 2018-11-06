namespace ZXBC.UC
{
    partial class DataSend
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DS_dataGridView = new System.Windows.Forms.DataGridView();
            this.IsAutoSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DS_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.DS_AutoSend_btn = new System.Windows.Forms.Button();
            this.lb_sd_time = new System.Windows.Forms.Label();
            this.SD_time = new System.Windows.Forms.NumericUpDown();
            this.lb_time_unit = new System.Windows.Forms.Label();
            this.lb_sd_num = new System.Windows.Forms.Label();
            this.linkLb_sd_num = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DS_dataGridView)).BeginInit();
            this.DS_CMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SD_time)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_dataGridView
            // 
            this.DS_dataGridView.AllowUserToAddRows = false;
            this.DS_dataGridView.AllowUserToDeleteRows = false;
            this.DS_dataGridView.AllowUserToResizeRows = false;
            this.DS_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DS_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DS_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsAutoSend,
            this.CType,
            this.CMDText,
            this.btnSend});
            this.DS_dataGridView.ContextMenuStrip = this.DS_CMS;
            this.DS_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.DS_dataGridView.MultiSelect = false;
            this.DS_dataGridView.Name = "DS_dataGridView";
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DS_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DS_dataGridView.RowHeadersVisible = false;
            this.DS_dataGridView.RowTemplate.Height = 23;
            this.DS_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DS_dataGridView.Size = new System.Drawing.Size(705, 199);
            this.DS_dataGridView.TabIndex = 0;
            this.DS_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_dataGridView_CellContentClick);
            // 
            // IsAutoSend
            // 
            this.IsAutoSend.HeaderText = "参与循环";
            this.IsAutoSend.Name = "IsAutoSend";
            this.IsAutoSend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAutoSend.Width = 60;
            // 
            // CType
            // 
            this.CType.DataPropertyName = "ContentTypeName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CType.DefaultCellStyle = dataGridViewCellStyle7;
            this.CType.HeaderText = "类型";
            this.CType.Name = "CType";
            this.CType.ReadOnly = true;
            this.CType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CType.Width = 60;
            // 
            // CMDText
            // 
            this.CMDText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMDText.DataPropertyName = "Text";
            this.CMDText.HeaderText = "命令";
            this.CMDText.Name = "CMDText";
            this.CMDText.ReadOnly = true;
            // 
            // btnSend
            // 
            this.btnSend.HeaderText = "发送";
            this.btnSend.Name = "btnSend";
            this.btnSend.ReadOnly = true;
            this.btnSend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSend.Text = "发送";
            this.btnSend.UseColumnTextForButtonValue = true;
            this.btnSend.Width = 60;
            // 
            // DS_CMS
            // 
            this.DS_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Add,
            this.MS_Edit,
            this.MS_Delete});
            this.DS_CMS.Name = "DS_CMS";
            this.DS_CMS.Size = new System.Drawing.Size(101, 70);
            // 
            // MS_Add
            // 
            this.MS_Add.Name = "MS_Add";
            this.MS_Add.Size = new System.Drawing.Size(100, 22);
            this.MS_Add.Text = "添加";
            this.MS_Add.Click += new System.EventHandler(this.MS_Add_Click);
            // 
            // MS_Edit
            // 
            this.MS_Edit.Name = "MS_Edit";
            this.MS_Edit.Size = new System.Drawing.Size(100, 22);
            this.MS_Edit.Text = "编辑";
            this.MS_Edit.Click += new System.EventHandler(this.MS_Edit_Click);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Size = new System.Drawing.Size(100, 22);
            this.MS_Delete.Text = "删除";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // DS_AutoSend_btn
            // 
            this.DS_AutoSend_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DS_AutoSend_btn.Location = new System.Drawing.Point(3, 208);
            this.DS_AutoSend_btn.Name = "DS_AutoSend_btn";
            this.DS_AutoSend_btn.Size = new System.Drawing.Size(83, 28);
            this.DS_AutoSend_btn.TabIndex = 2;
            this.DS_AutoSend_btn.Text = "循环发送";
            this.DS_AutoSend_btn.UseVisualStyleBackColor = true;
            this.DS_AutoSend_btn.Click += new System.EventHandler(this.DS_AutoSend_btn_Click);
            // 
            // lb_sd_time
            // 
            this.lb_sd_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_sd_time.AutoSize = true;
            this.lb_sd_time.Location = new System.Drawing.Point(104, 216);
            this.lb_sd_time.Name = "lb_sd_time";
            this.lb_sd_time.Size = new System.Drawing.Size(65, 12);
            this.lb_sd_time.TabIndex = 3;
            this.lb_sd_time.Text = "发送间隔：";
            // 
            // SD_time
            // 
            this.SD_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SD_time.Location = new System.Drawing.Point(175, 208);
            this.SD_time.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SD_time.Name = "SD_time";
            this.SD_time.Size = new System.Drawing.Size(62, 21);
            this.SD_time.TabIndex = 4;
            this.SD_time.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lb_time_unit
            // 
            this.lb_time_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_time_unit.AutoSize = true;
            this.lb_time_unit.Location = new System.Drawing.Point(243, 216);
            this.lb_time_unit.Name = "lb_time_unit";
            this.lb_time_unit.Size = new System.Drawing.Size(29, 12);
            this.lb_time_unit.TabIndex = 5;
            this.lb_time_unit.Text = "毫秒";
            // 
            // lb_sd_num
            // 
            this.lb_sd_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_sd_num.AutoSize = true;
            this.lb_sd_num.Location = new System.Drawing.Point(290, 216);
            this.lb_sd_num.Name = "lb_sd_num";
            this.lb_sd_num.Size = new System.Drawing.Size(77, 12);
            this.lb_sd_num.TabIndex = 6;
            this.lb_sd_num.Text = "发送字节数：";
            // 
            // linkLb_sd_num
            // 
            this.linkLb_sd_num.AutoSize = true;
            this.linkLb_sd_num.Location = new System.Drawing.Point(370, 190);
            this.linkLb_sd_num.Name = "linkLb_sd_num";
            this.linkLb_sd_num.Size = new System.Drawing.Size(11, 12);
            this.linkLb_sd_num.TabIndex = 7;
            this.linkLb_sd_num.TabStop = true;
            this.linkLb_sd_num.Text = "0";
            this.linkLb_sd_num.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLb_sd_num_LinkClicked);
            // 
            // DataSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLb_sd_num);
            this.Controls.Add(this.lb_sd_num);
            this.Controls.Add(this.lb_time_unit);
            this.Controls.Add(this.SD_time);
            this.Controls.Add(this.lb_sd_time);
            this.Controls.Add(this.DS_AutoSend_btn);
            this.Controls.Add(this.DS_dataGridView);
            this.Name = "DataSend";
            this.Size = new System.Drawing.Size(712, 240);
            ((System.ComponentModel.ISupportInitialize)(this.DS_dataGridView)).EndInit();
            this.DS_CMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SD_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DS_dataGridView;
        private System.Windows.Forms.ContextMenuStrip DS_CMS;
        private System.Windows.Forms.ToolStripMenuItem MS_Add;
        private System.Windows.Forms.ToolStripMenuItem MS_Edit;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private System.Windows.Forms.Button DS_AutoSend_btn;
        private System.Windows.Forms.Label lb_sd_time;
        private System.Windows.Forms.NumericUpDown SD_time;
        private System.Windows.Forms.Label lb_time_unit;
        private System.Windows.Forms.Label lb_sd_num;
        private System.Windows.Forms.LinkLabel linkLb_sd_num;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAutoSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDText;
        private System.Windows.Forms.DataGridViewButtonColumn btnSend;
    }
}
