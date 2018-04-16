namespace InternetBar
{
    partial class frmSelectComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectComputer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnInster = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdata = new System.Windows.Forms.ToolStripButton();
            this.tbtndel = new System.Windows.Forms.ToolStripButton();
            this.tbtnExit = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnMin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ColComputerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComputerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSectionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSectionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报废记录统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电脑显示";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInster,
            this.tsbtnUpdata,
            this.tbtndel,
            this.tbtnExit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(86, 368);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnInster
            // 
            this.tsbtnInster.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInster.Image")));
            this.tsbtnInster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInster.Margin = new System.Windows.Forms.Padding(18, 25, 18, 1);
            this.tsbtnInster.Name = "tsbtnInster";
            this.tsbtnInster.Size = new System.Drawing.Size(49, 66);
            this.tsbtnInster.Text = "新增";
            this.tsbtnInster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnInster.Click += new System.EventHandler(this.tsbtnInster_Click);
            // 
            // tsbtnUpdata
            // 
            this.tsbtnUpdata.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdata.Image")));
            this.tsbtnUpdata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdata.Margin = new System.Windows.Forms.Padding(18, 25, 18, 1);
            this.tsbtnUpdata.Name = "tsbtnUpdata";
            this.tsbtnUpdata.Size = new System.Drawing.Size(49, 66);
            this.tsbtnUpdata.Text = "修改";
            this.tsbtnUpdata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnUpdata.Click += new System.EventHandler(this.tsbtnUpdata_Click);
            // 
            // tbtndel
            // 
            this.tbtndel.Image = ((System.Drawing.Image)(resources.GetObject("tbtndel.Image")));
            this.tbtndel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtndel.Margin = new System.Windows.Forms.Padding(18, 25, 18, 1);
            this.tbtndel.Name = "tbtndel";
            this.tbtndel.Size = new System.Drawing.Size(49, 66);
            this.tbtndel.Text = "报废";
            this.tbtndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtndel.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tbtnExit
            // 
            this.tbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExit.Image")));
            this.tbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExit.Margin = new System.Windows.Forms.Padding(18, 25, 18, 1);
            this.tbtnExit.Name = "tbtnExit";
            this.tbtnExit.Size = new System.Drawing.Size(49, 66);
            this.tbtnExit.Text = "退出";
            this.tbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnExit.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColComputerID,
            this.ColComputerNo,
            this.ColTypeId,
            this.ColType,
            this.ColSectionId,
            this.ColSectionName,
            this.ColSectionPrice,
            this.ColIP});
            this.dgv.GridColor = System.Drawing.Color.SeaGreen;
            this.dgv.Location = new System.Drawing.Point(168, 141);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(694, 379);
            this.dgv.TabIndex = 1;
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
            this.btnMin.Location = new System.Drawing.Point(812, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 30;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.增加ToolStripMenuItem,
            this.报废记录统计ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改ToolStripMenuItem.Text = "修改电脑信息";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.tsbtnUpdata_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除ToolStripMenuItem.Text = "电脑报废";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.增加ToolStripMenuItem.Text = "新增电脑信息";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.tsbtnInster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(797, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "电脑管理";
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
            this.button1.Location = new System.Drawing.Point(858, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // ColComputerID
            // 
            this.ColComputerID.DataPropertyName = "ComputerId";
            this.ColComputerID.HeaderText = "电脑ID";
            this.ColComputerID.Name = "ColComputerID";
            this.ColComputerID.ReadOnly = true;
            this.ColComputerID.Width = 90;
            // 
            // ColComputerNo
            // 
            this.ColComputerNo.DataPropertyName = "ComputerNo";
            this.ColComputerNo.HeaderText = "电脑号码";
            this.ColComputerNo.Name = "ColComputerNo";
            this.ColComputerNo.ReadOnly = true;
            // 
            // ColTypeId
            // 
            this.ColTypeId.DataPropertyName = "TypeId";
            this.ColTypeId.HeaderText = "电脑状态ID";
            this.ColTypeId.Name = "ColTypeId";
            this.ColTypeId.ReadOnly = true;
            this.ColTypeId.Visible = false;
            // 
            // ColType
            // 
            this.ColType.DataPropertyName = "TypeName";
            this.ColType.HeaderText = "电脑状态";
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            // 
            // ColSectionId
            // 
            this.ColSectionId.DataPropertyName = "SectionId";
            this.ColSectionId.HeaderText = "电脑区域编号";
            this.ColSectionId.Name = "ColSectionId";
            this.ColSectionId.ReadOnly = true;
            this.ColSectionId.Visible = false;
            // 
            // ColSectionName
            // 
            this.ColSectionName.DataPropertyName = "SectionName";
            this.ColSectionName.HeaderText = "电脑所属区域";
            this.ColSectionName.Name = "ColSectionName";
            this.ColSectionName.ReadOnly = true;
            this.ColSectionName.Width = 120;
            // 
            // ColSectionPrice
            // 
            this.ColSectionPrice.DataPropertyName = "SectionPrice";
            this.ColSectionPrice.HeaderText = "电脑区域价格/小时";
            this.ColSectionPrice.Name = "ColSectionPrice";
            this.ColSectionPrice.ReadOnly = true;
            this.ColSectionPrice.Width = 135;
            // 
            // ColIP
            // 
            this.ColIP.DataPropertyName = "IP";
            this.ColIP.HeaderText = "电脑IP地址";
            this.ColIP.Name = "ColIP";
            this.ColIP.ReadOnly = true;
            this.ColIP.Width = 125;
            // 
            // 报废记录统计ToolStripMenuItem
            // 
            this.报废记录统计ToolStripMenuItem.Name = "报废记录统计ToolStripMenuItem";
            this.报废记录统计ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.报废记录统计ToolStripMenuItem.Text = "报废记录统计";
            this.报废记录统计ToolStripMenuItem.Click += new System.EventHandler(this.报废记录统计ToolStripMenuItem_Click);
            // 
            // frmSelectComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(898, 548);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmSelectComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电脑管理";
            this.Load += new System.EventHandler(this.frmSelectComputer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSelectComputer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSelectComputer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSelectComputer_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnInster;
        private System.Windows.Forms.ToolStripButton tsbtnUpdata;
        private System.Windows.Forms.ToolStripButton tbtndel;
        private System.Windows.Forms.ToolStripButton tbtnExit;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComputerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSectionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSectionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIP;
        private System.Windows.Forms.ToolStripMenuItem 报废记录统计ToolStripMenuItem;
    }
}