namespace InternetBar
{
    partial class FrmVipNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVipNote));
            this.dgvVip = new System.Windows.Forms.DataGridView();
            this.cmtUpdate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.充值记录查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVip = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colUserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVip)).BeginInit();
            this.cmtUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVip
            // 
            this.dgvVip.AllowUserToAddRows = false;
            this.dgvVip.AllowUserToDeleteRows = false;
            this.dgvVip.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvVip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVip.BackgroundColor = System.Drawing.Color.White;
            this.dgvVip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserNo,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgvVip.ContextMenuStrip = this.cmtUpdate;
            this.dgvVip.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvVip.Location = new System.Drawing.Point(61, 270);
            this.dgvVip.MultiSelect = false;
            this.dgvVip.Name = "dgvVip";
            this.dgvVip.ReadOnly = true;
            this.dgvVip.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVip.RowHeadersVisible = false;
            this.dgvVip.RowTemplate.Height = 23;
            this.dgvVip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVip.Size = new System.Drawing.Size(646, 361);
            this.dgvVip.TabIndex = 5;
            // 
            // cmtUpdate
            // 
            this.cmtUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.增加ToolStripMenuItem,
            this.充值记录查询ToolStripMenuItem});
            this.cmtUpdate.Name = "cmtUpdate";
            this.cmtUpdate.Size = new System.Drawing.Size(149, 70);
            this.cmtUpdate.Opening += new System.ComponentModel.CancelEventHandler(this.cmtUpdate_Opening);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改ToolStripMenuItem.Text = "修改会员信息";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.增加ToolStripMenuItem.Text = "新增会员信息";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // 充值记录查询ToolStripMenuItem
            // 
            this.充值记录查询ToolStripMenuItem.Name = "充值记录查询ToolStripMenuItem";
            this.充值记录查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.充值记录查询ToolStripMenuItem.Text = "充值记录查询";
            this.充值记录查询ToolStripMenuItem.Click += new System.EventHandler(this.充值记录查询ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtVip);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(61, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会员查询";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(523, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "会员编号：";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(350, 47);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 21);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtVip
            // 
            this.txtVip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVip.Location = new System.Drawing.Point(117, 47);
            this.txtVip.Multiline = true;
            this.txtVip.Name = "txtVip";
            this.txtVip.Size = new System.Drawing.Size(130, 21);
            this.txtVip.TabIndex = 9;
            this.txtVip.TextChanged += new System.EventHandler(this.txtVip_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(523, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Vip查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
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
            this.btnMin.Location = new System.Drawing.Point(685, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 30;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(648, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "会员管理";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(730, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 33;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnClose_Click);
            this.button2.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // colUserNo
            // 
            this.colUserNo.DataPropertyName = "UserNo";
            this.colUserNo.HeaderText = "会员Id";
            this.colUserNo.Name = "colUserNo";
            this.colUserNo.ReadOnly = true;
            this.colUserNo.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "会员姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IdCard";
            this.Column3.HeaderText = "身份证号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Balance";
            this.Column4.HeaderText = "余额";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FoundTime";
            this.Column6.HeaderText = "注册时间";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 108;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Remark";
            this.Column5.HeaderText = "备注";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 108;
            // 
            // FrmVipNote
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(772, 652);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVip);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVipNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员管理";
            this.Load += new System.EventHandler(this.FrmVip_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmVipNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmVipNote_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmVipNote_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVip)).EndInit();
            this.cmtUpdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVip;
        private System.Windows.Forms.ContextMenuStrip cmtUpdate;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtVip;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ToolStripMenuItem 充值记录查询ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}