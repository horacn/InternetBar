namespace InternetBar
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeaech = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.cmtAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiUpdateAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAddAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.修改上机价格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.cmtAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSeaech);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnSeaech
            // 
            this.btnSeaech.BackColor = System.Drawing.Color.Transparent;
            this.btnSeaech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeaech.ForeColor = System.Drawing.Color.Transparent;
            this.btnSeaech.Location = new System.Drawing.Point(423, 38);
            this.btnSeaech.Name = "btnSeaech";
            this.btnSeaech.Size = new System.Drawing.Size(83, 26);
            this.btnSeaech.TabIndex = 2;
            this.btnSeaech.Text = "查询";
            this.btnSeaech.UseVisualStyleBackColor = false;
            this.btnSeaech.Click += new System.EventHandler(this.btnSeaech_Click);
            this.btnSeaech.MouseLeave += new System.EventHandler(this.btnSeaech_MouseLeave);
            this.btnSeaech.MouseHover += new System.EventHandler(this.btnSeaech_MouseHover);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(129, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员帐号：";
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmPwd,
            this.clmPhone,
            this.clmId});
            this.dgvAdmin.ContextMenuStrip = this.cmtAdmin;
            this.dgvAdmin.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAdmin.Location = new System.Drawing.Point(30, 175);
            this.dgvAdmin.MultiSelect = false;
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdmin.RowHeadersVisible = false;
            this.dgvAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdmin.RowTemplate.Height = 23;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(553, 231);
            this.dgvAdmin.TabIndex = 1;
            // 
            // cmtAdmin
            // 
            this.cmtAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiUpdateAdmin,
            this.msiAddAdmin,
            this.修改上机价格ToolStripMenuItem});
            this.cmtAdmin.Name = "cmtAdmin";
            this.cmtAdmin.Size = new System.Drawing.Size(161, 70);
            this.cmtAdmin.Opening += new System.ComponentModel.CancelEventHandler(this.cmtAdmin_Opening);
            // 
            // smiUpdateAdmin
            // 
            this.smiUpdateAdmin.Name = "smiUpdateAdmin";
            this.smiUpdateAdmin.Size = new System.Drawing.Size(160, 22);
            this.smiUpdateAdmin.Text = "修改管理员信息";
            this.smiUpdateAdmin.Click += new System.EventHandler(this.smiUpdateAdmin_Click);
            // 
            // msiAddAdmin
            // 
            this.msiAddAdmin.Name = "msiAddAdmin";
            this.msiAddAdmin.Size = new System.Drawing.Size(160, 22);
            this.msiAddAdmin.Text = "增加管理员信息";
            this.msiAddAdmin.Click += new System.EventHandler(this.msiAddAdmin_Click);
            // 
            // 修改上机价格ToolStripMenuItem
            // 
            this.修改上机价格ToolStripMenuItem.Name = "修改上机价格ToolStripMenuItem";
            this.修改上机价格ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.修改上机价格ToolStripMenuItem.Text = "修改上机价格";
            this.修改上机价格ToolStripMenuItem.Click += new System.EventHandler(this.修改上机价格ToolStripMenuItem_Click);
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
            this.btnMin.Location = new System.Drawing.Point(531, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 26;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(302, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "管理员设置";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(577, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "adminName";
            this.clmName.FillWeight = 68.92583F;
            this.clmName.HeaderText = "账号";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmPwd
            // 
            this.clmPwd.DataPropertyName = "adminPwd";
            this.clmPwd.FillWeight = 78.78989F;
            this.clmPwd.HeaderText = "密码";
            this.clmPwd.Name = "clmPwd";
            this.clmPwd.ReadOnly = true;
            this.clmPwd.Visible = false;
            // 
            // clmPhone
            // 
            this.clmPhone.DataPropertyName = "Phone";
            this.clmPhone.FillWeight = 152.2843F;
            this.clmPhone.HeaderText = "联系方式";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "AdminId";
            this.clmId.HeaderText = "编号";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // frmAdmin
            // 
            this.AcceptButton = this.btnSeaech;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员查询";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAdmin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAdmin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAdmin_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.cmtAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeaech;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmtAdmin;
        private System.Windows.Forms.ToolStripMenuItem smiUpdateAdmin;
        private System.Windows.Forms.ToolStripMenuItem msiAddAdmin;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ToolStripMenuItem 修改上机价格ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
    }
}