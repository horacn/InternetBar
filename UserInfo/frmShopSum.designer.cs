namespace InternetBar
{
    partial class frmShopSum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShopSum));
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvMoney = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtimeStart = new System.Windows.Forms.DateTimePicker();
            this.cboxMonth = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtimeEnd = new System.Windows.Forms.DateTimePicker();
            this.cboxTime = new System.Windows.Forms.CheckBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLongTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDisCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboUserType
            // 
            this.cboUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUserType.BackColor = System.Drawing.Color.White;
            this.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserType.ForeColor = System.Drawing.Color.Tomato;
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Location = new System.Drawing.Point(189, 210);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(180, 20);
            this.cboUserType.TabIndex = 3;
            this.cboUserType.SelectedIndexChanged += new System.EventHandler(this.cboUserType_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(856, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "开始统计";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // dgvMoney
            // 
            this.dgvMoney.AllowUserToAddRows = false;
            this.dgvMoney.AllowUserToDeleteRows = false;
            this.dgvMoney.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvMoney.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMoney.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoney.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoney.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNo,
            this.Column3,
            this.Column4,
            this.Column5,
            this.clmStartTime,
            this.clmEndTime,
            this.clmLongTime,
            this.Column6,
            this.clmDisCount,
            this.Column1,
            this.Column2});
            this.dgvMoney.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMoney.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMoney.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvMoney.Location = new System.Drawing.Point(36, 254);
            this.dgvMoney.MultiSelect = false;
            this.dgvMoney.Name = "dgvMoney";
            this.dgvMoney.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoney.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMoney.RowHeadersVisible = false;
            this.dgvMoney.RowTemplate.Height = 23;
            this.dgvMoney.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMoney.Size = new System.Drawing.Size(962, 415);
            this.dgvMoney.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除ToolStripMenuItem.Text = "删除消费记录";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "网吧区域：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 15F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(399, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "顾客账号：";
            // 
            // dtimeStart
            // 
            this.dtimeStart.Location = new System.Drawing.Point(189, 162);
            this.dtimeStart.Name = "dtimeStart";
            this.dtimeStart.Size = new System.Drawing.Size(180, 21);
            this.dtimeStart.TabIndex = 9;
            this.dtimeStart.ValueChanged += new System.EventHandler(this.dtimeStart_ValueChanged);
            // 
            // cboxMonth
            // 
            this.cboxMonth.AutoSize = true;
            this.cboxMonth.BackColor = System.Drawing.Color.Transparent;
            this.cboxMonth.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxMonth.ForeColor = System.Drawing.Color.Transparent;
            this.cboxMonth.Location = new System.Drawing.Point(693, 189);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(123, 20);
            this.cboxMonth.TabIndex = 10;
            this.cboxMonth.Text = "最近一月记录";
            this.cboxMonth.UseVisualStyleBackColor = false;
            this.cboxMonth.CheckedChanged += new System.EventHandler(this.cboxMonth_CheckedChanged);
            this.cboxMonth.MouseLeave += new System.EventHandler(this.cboxMonth_MouseLeave);
            this.cboxMonth.MouseHover += new System.EventHandler(this.cboxMonth_MouseHover);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(509, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 21);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(399, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "到";
            // 
            // dtimeEnd
            // 
            this.dtimeEnd.Location = new System.Drawing.Point(465, 162);
            this.dtimeEnd.Name = "dtimeEnd";
            this.dtimeEnd.Size = new System.Drawing.Size(199, 21);
            this.dtimeEnd.TabIndex = 9;
            this.dtimeEnd.ValueChanged += new System.EventHandler(this.dtimeEnd_ValueChanged);
            // 
            // cboxTime
            // 
            this.cboxTime.AutoSize = true;
            this.cboxTime.BackColor = System.Drawing.Color.Transparent;
            this.cboxTime.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxTime.ForeColor = System.Drawing.Color.Transparent;
            this.cboxTime.Location = new System.Drawing.Point(57, 161);
            this.cboxTime.Name = "cboxTime";
            this.cboxTime.Size = new System.Drawing.Size(126, 22);
            this.cboxTime.TabIndex = 10;
            this.cboxTime.Text = "按时间查询:";
            this.cboxTime.UseVisualStyleBackColor = false;
            this.cboxTime.CheckedChanged += new System.EventHandler(this.cboxTime_CheckedChanged);
            this.cboxTime.MouseLeave += new System.EventHandler(this.cboxTime_MouseLeave);
            this.cboxTime.MouseHover += new System.EventHandler(this.cboxTime_MouseHover);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.Red;
            this.btnMin.Location = new System.Drawing.Point(947, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 30;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(913, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "消费记录统计";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(993, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // clmNo
            // 
            this.clmNo.DataPropertyName = "ComputerNo";
            this.clmNo.HeaderText = "机号";
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            this.clmNo.Width = 75;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UserName";
            this.Column3.HeaderText = "会员姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UserNo";
            this.Column4.HeaderText = "会员卡号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SectionName";
            this.Column5.HeaderText = "区域";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // clmStartTime
            // 
            this.clmStartTime.DataPropertyName = "BeginTime";
            this.clmStartTime.HeaderText = "开机时间";
            this.clmStartTime.Name = "clmStartTime";
            this.clmStartTime.ReadOnly = true;
            this.clmStartTime.Width = 118;
            // 
            // clmEndTime
            // 
            this.clmEndTime.DataPropertyName = "EndTime";
            this.clmEndTime.HeaderText = "下机时间";
            this.clmEndTime.Name = "clmEndTime";
            this.clmEndTime.ReadOnly = true;
            this.clmEndTime.Width = 118;
            // 
            // clmLongTime
            // 
            this.clmLongTime.DataPropertyName = "LongTime";
            this.clmLongTime.HeaderText = "小时";
            this.clmLongTime.Name = "clmLongTime";
            this.clmLongTime.ReadOnly = true;
            this.clmLongTime.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SmallTime";
            this.Column6.HeaderText = "分钟";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // clmDisCount
            // 
            this.clmDisCount.DataPropertyName = "Discount";
            this.clmDisCount.HeaderText = "费率";
            this.clmDisCount.Name = "clmDisCount";
            this.clmDisCount.ReadOnly = true;
            this.clmDisCount.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HowMoney";
            this.Column1.HeaderText = "上机费用";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Remark";
            this.Column2.HeaderText = "备注";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // frmShopSum
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1035, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboxTime);
            this.Controls.Add(this.cboxMonth);
            this.Controls.Add(this.dtimeEnd);
            this.Controls.Add(this.dtimeStart);
            this.Controls.Add(this.dgvMoney);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboUserType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(902, 529);
            this.Name = "frmShopSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消费统计记录";
            this.Load += new System.EventHandler(this.frmShopSum_Load);
            this.Enter += new System.EventHandler(this.frmShopSum_Enter);
            this.Leave += new System.EventHandler(this.frmShopSum_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmShopSum_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmShopSum_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmShopSum_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView dgvMoney;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtimeStart;
        private System.Windows.Forms.CheckBox cboxMonth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtimeEnd;
        private System.Windows.Forms.CheckBox cboxTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLongTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDisCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

	}
}