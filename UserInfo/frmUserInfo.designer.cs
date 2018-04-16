namespace InternetBar
{
	partial class frmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpUserInfo = new System.Windows.Forms.TabControl();
            this.tpSeach = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShopSum = new System.Windows.Forms.ToolStripMenuItem();
            this.cboTypeBySeach = new System.Windows.Forms.ComboBox();
            this.btnUpdateBySeach = new System.Windows.Forms.Button();
            this.btnDeleteBySeach = new System.Windows.Forms.Button();
            this.btnScachBySeach = new System.Windows.Forms.Button();
            this.lable2 = new System.Windows.Forms.Label();
            this.txtNameBySeach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.dtFindTimeByUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnCancelByUpdate = new System.Windows.Forms.Button();
            this.btnClearByUpdate = new System.Windows.Forms.Button();
            this.btnUpdateByUpdate = new System.Windows.Forms.Button();
            this.cboTypeByUpdate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lable12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemarkByUpdate = new System.Windows.Forms.TextBox();
            this.txtMoneyByUpdate = new System.Windows.Forms.TextBox();
            this.txtIdCardByUpdate = new System.Windows.Forms.TextBox();
            this.txtUserNoByUpdate = new System.Windows.Forms.TextBox();
            this.txtNameByUpdate = new System.Windows.Forms.TextBox();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.dtFindTimeByAdd = new System.Windows.Forms.DateTimePicker();
            this.btnClearByAdd = new System.Windows.Forms.Button();
            this.btnCancelByAdd = new System.Windows.Forms.Button();
            this.btnSaveByAdd = new System.Windows.Forms.Button();
            this.cboTypeByAdd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRemarkByAdd = new System.Windows.Forms.TextBox();
            this.txtMoneyByAdd = new System.Windows.Forms.TextBox();
            this.txtIdCardBuAdd = new System.Windows.Forms.TextBox();
            this.txtUserNoByAdd = new System.Windows.Forms.TextBox();
            this.txtNameByAdd = new System.Windows.Forms.TextBox();
            this.clmRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMin = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            this.tpSeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tpUserInfo);
            this.panel1.Location = new System.Drawing.Point(43, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 485);
            this.panel1.TabIndex = 0;
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tpUserInfo.Controls.Add(this.tpSeach);
            this.tpUserInfo.Controls.Add(this.tpUpdate);
            this.tpUserInfo.Controls.Add(this.tpAdd);
            this.tpUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpUserInfo.HotTrack = true;
            this.tpUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tpUserInfo.MinimumSize = new System.Drawing.Size(800, 485);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.SelectedIndex = 0;
            this.tpUserInfo.Size = new System.Drawing.Size(800, 485);
            this.tpUserInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tpUserInfo.TabIndex = 13;
            // 
            // tpSeach
            // 
            this.tpSeach.BackColor = System.Drawing.Color.Transparent;
            this.tpSeach.Controls.Add(this.label17);
            this.tpSeach.Controls.Add(this.label16);
            this.tpSeach.Controls.Add(this.dgvUserInfo);
            this.tpSeach.Controls.Add(this.cboTypeBySeach);
            this.tpSeach.Controls.Add(this.btnUpdateBySeach);
            this.tpSeach.Controls.Add(this.btnDeleteBySeach);
            this.tpSeach.Controls.Add(this.btnScachBySeach);
            this.tpSeach.Controls.Add(this.lable2);
            this.tpSeach.Controls.Add(this.txtNameBySeach);
            this.tpSeach.Controls.Add(this.label1);
            this.tpSeach.Location = new System.Drawing.Point(4, 25);
            this.tpSeach.Name = "tpSeach";
            this.tpSeach.Padding = new System.Windows.Forms.Padding(3);
            this.tpSeach.Size = new System.Drawing.Size(792, 456);
            this.tpSeach.TabIndex = 0;
            this.tpSeach.Text = "查询";
            this.tpSeach.Enter += new System.EventHandler(this.tpSeach_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "状态：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 22;
            this.label16.Text = "账号：";
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            this.dgvUserInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvUserInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName,
            this.clNo,
            this.clIdCard,
            this.clMoney,
            this.clTime,
            this.clType,
            this.clRemark});
            this.dgvUserInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUserInfo.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvUserInfo.Location = new System.Drawing.Point(-2, 50);
            this.dgvUserInfo.MultiSelect = false;
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            this.dgvUserInfo.RowHeadersVisible = false;
            this.dgvUserInfo.RowTemplate.Height = 23;
            this.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.Size = new System.Drawing.Size(794, 410);
            this.dgvUserInfo.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate,
            this.tsmiDelete,
            this.tsmiAdd,
            this.tsmiShopSum});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(148, 22);
            this.tsmiUpdate.Text = "修改用户信息";
            this.tsmiUpdate.Click += new System.EventHandler(this.btnUpdateBySeach_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(148, 22);
            this.tsmiDelete.Text = "删除用户信息";
            this.tsmiDelete.Click += new System.EventHandler(this.btnDeleteBySeach_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(148, 22);
            this.tsmiAdd.Text = "新增用户信息";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiShopSum
            // 
            this.tsmiShopSum.Name = "tsmiShopSum";
            this.tsmiShopSum.Size = new System.Drawing.Size(148, 22);
            this.tsmiShopSum.Text = "消费记录统计";
            this.tsmiShopSum.Click += new System.EventHandler(this.tsmiShopSum_Click);
            // 
            // cboTypeBySeach
            // 
            this.cboTypeBySeach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTypeBySeach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeBySeach.ForeColor = System.Drawing.Color.OrangeRed;
            this.cboTypeBySeach.FormattingEnabled = true;
            this.cboTypeBySeach.Items.AddRange(new object[] {
            "请选择",
            "普通用户",
            "会员用户"});
            this.cboTypeBySeach.Location = new System.Drawing.Point(274, 17);
            this.cboTypeBySeach.Name = "cboTypeBySeach";
            this.cboTypeBySeach.Size = new System.Drawing.Size(120, 20);
            this.cboTypeBySeach.TabIndex = 20;
            this.cboTypeBySeach.SelectedIndexChanged += new System.EventHandler(this.cboTypeBySeach_SelectedIndexChanged);
            // 
            // btnUpdateBySeach
            // 
            this.btnUpdateBySeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateBySeach.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBySeach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateBySeach.BackgroundImage")));
            this.btnUpdateBySeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateBySeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBySeach.Font = new System.Drawing.Font("宋体", 12F);
            this.btnUpdateBySeach.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnUpdateBySeach.Location = new System.Drawing.Point(564, 8);
            this.btnUpdateBySeach.Name = "btnUpdateBySeach";
            this.btnUpdateBySeach.Size = new System.Drawing.Size(93, 36);
            this.btnUpdateBySeach.TabIndex = 19;
            this.btnUpdateBySeach.Text = "修改";
            this.btnUpdateBySeach.UseVisualStyleBackColor = false;
            this.btnUpdateBySeach.Click += new System.EventHandler(this.btnUpdateBySeach_Click);
            this.btnUpdateBySeach.MouseLeave += new System.EventHandler(this.btnUpdateBySeach_MouseLeave);
            this.btnUpdateBySeach.MouseHover += new System.EventHandler(this.btnUpdateBySeach_MouseHover);
            // 
            // btnDeleteBySeach
            // 
            this.btnDeleteBySeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBySeach.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBySeach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteBySeach.BackgroundImage")));
            this.btnDeleteBySeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteBySeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBySeach.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDeleteBySeach.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteBySeach.Location = new System.Drawing.Point(679, 8);
            this.btnDeleteBySeach.Name = "btnDeleteBySeach";
            this.btnDeleteBySeach.Size = new System.Drawing.Size(93, 36);
            this.btnDeleteBySeach.TabIndex = 19;
            this.btnDeleteBySeach.Text = "删除";
            this.btnDeleteBySeach.UseVisualStyleBackColor = false;
            this.btnDeleteBySeach.Click += new System.EventHandler(this.btnDeleteBySeach_Click);
            this.btnDeleteBySeach.MouseLeave += new System.EventHandler(this.btnDeleteBySeach_MouseLeave);
            this.btnDeleteBySeach.MouseHover += new System.EventHandler(this.btnDeleteBySeach_MouseHover);
            // 
            // btnScachBySeach
            // 
            this.btnScachBySeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScachBySeach.BackColor = System.Drawing.Color.Transparent;
            this.btnScachBySeach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScachBySeach.BackgroundImage")));
            this.btnScachBySeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScachBySeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScachBySeach.Font = new System.Drawing.Font("宋体", 12F);
            this.btnScachBySeach.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnScachBySeach.Location = new System.Drawing.Point(450, 8);
            this.btnScachBySeach.Name = "btnScachBySeach";
            this.btnScachBySeach.Size = new System.Drawing.Size(93, 36);
            this.btnScachBySeach.TabIndex = 19;
            this.btnScachBySeach.Text = "查询";
            this.btnScachBySeach.UseVisualStyleBackColor = false;
            this.btnScachBySeach.Click += new System.EventHandler(this.btnScach_Click);
            this.btnScachBySeach.MouseLeave += new System.EventHandler(this.btnScachBySeach_MouseLeave);
            this.btnScachBySeach.MouseHover += new System.EventHandler(this.btnScachBySeach_MouseHover);
            // 
            // lable2
            // 
            this.lable2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(212, 20);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(0, 12);
            this.lable2.TabIndex = 14;
            // 
            // txtNameBySeach
            // 
            this.txtNameBySeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNameBySeach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameBySeach.Location = new System.Drawing.Point(67, 16);
            this.txtNameBySeach.Name = "txtNameBySeach";
            this.txtNameBySeach.Size = new System.Drawing.Size(114, 21);
            this.txtNameBySeach.TabIndex = 16;
            this.txtNameBySeach.TextChanged += new System.EventHandler(this.txtNameBySeach_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 15;
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpUpdate.BackgroundImage")));
            this.tpUpdate.Controls.Add(this.dtFindTimeByUpdate);
            this.tpUpdate.Controls.Add(this.btnCancelByUpdate);
            this.tpUpdate.Controls.Add(this.btnClearByUpdate);
            this.tpUpdate.Controls.Add(this.btnUpdateByUpdate);
            this.tpUpdate.Controls.Add(this.cboTypeByUpdate);
            this.tpUpdate.Controls.Add(this.label7);
            this.tpUpdate.Controls.Add(this.label8);
            this.tpUpdate.Controls.Add(this.label6);
            this.tpUpdate.Controls.Add(this.label5);
            this.tpUpdate.Controls.Add(this.label4);
            this.tpUpdate.Controls.Add(this.label19);
            this.tpUpdate.Controls.Add(this.label15);
            this.tpUpdate.Controls.Add(this.lable12);
            this.tpUpdate.Controls.Add(this.label2);
            this.tpUpdate.Controls.Add(this.txtRemarkByUpdate);
            this.tpUpdate.Controls.Add(this.txtMoneyByUpdate);
            this.tpUpdate.Controls.Add(this.txtIdCardByUpdate);
            this.tpUpdate.Controls.Add(this.txtUserNoByUpdate);
            this.tpUpdate.Controls.Add(this.txtNameByUpdate);
            this.tpUpdate.Location = new System.Drawing.Point(4, 25);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(792, 456);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "修改";
            this.tpUpdate.UseVisualStyleBackColor = true;
            this.tpUpdate.Enter += new System.EventHandler(this.tpUpdate_Enter);
            // 
            // dtFindTimeByUpdate
            // 
            this.dtFindTimeByUpdate.Enabled = false;
            this.dtFindTimeByUpdate.Location = new System.Drawing.Point(252, 201);
            this.dtFindTimeByUpdate.Name = "dtFindTimeByUpdate";
            this.dtFindTimeByUpdate.Size = new System.Drawing.Size(260, 21);
            this.dtFindTimeByUpdate.TabIndex = 4;
            this.dtFindTimeByUpdate.ValueChanged += new System.EventHandler(this.dtFindTimeByUpdate_ValueChanged);
            // 
            // btnCancelByUpdate
            // 
            this.btnCancelByUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelByUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelByUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelByUpdate.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelByUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelByUpdate.Location = new System.Drawing.Point(463, 402);
            this.btnCancelByUpdate.Name = "btnCancelByUpdate";
            this.btnCancelByUpdate.Size = new System.Drawing.Size(97, 35);
            this.btnCancelByUpdate.TabIndex = 9;
            this.btnCancelByUpdate.Text = "取消";
            this.btnCancelByUpdate.UseVisualStyleBackColor = false;
            this.btnCancelByUpdate.Click += new System.EventHandler(this.btnCancelByUpdate_Click);
            this.btnCancelByUpdate.MouseLeave += new System.EventHandler(this.btnCancelByUpdate_MouseLeave);
            this.btnCancelByUpdate.MouseHover += new System.EventHandler(this.btnCancelByUpdate_MouseHover);
            // 
            // btnClearByUpdate
            // 
            this.btnClearByUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnClearByUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearByUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearByUpdate.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearByUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnClearByUpdate.Location = new System.Drawing.Point(222, 402);
            this.btnClearByUpdate.Name = "btnClearByUpdate";
            this.btnClearByUpdate.Size = new System.Drawing.Size(97, 35);
            this.btnClearByUpdate.TabIndex = 8;
            this.btnClearByUpdate.Text = "清空";
            this.btnClearByUpdate.UseVisualStyleBackColor = false;
            this.btnClearByUpdate.Click += new System.EventHandler(this.btnClearByUpdate_Click);
            this.btnClearByUpdate.MouseLeave += new System.EventHandler(this.btnClearByUpdate_MouseLeave);
            this.btnClearByUpdate.MouseHover += new System.EventHandler(this.btnClearByUpdate_MouseHover);
            // 
            // btnUpdateByUpdate
            // 
            this.btnUpdateByUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateByUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateByUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateByUpdate.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateByUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateByUpdate.Location = new System.Drawing.Point(343, 402);
            this.btnUpdateByUpdate.Name = "btnUpdateByUpdate";
            this.btnUpdateByUpdate.Size = new System.Drawing.Size(97, 35);
            this.btnUpdateByUpdate.TabIndex = 7;
            this.btnUpdateByUpdate.Text = "修改";
            this.btnUpdateByUpdate.UseVisualStyleBackColor = false;
            this.btnUpdateByUpdate.Click += new System.EventHandler(this.btnUpdateByUpdate_Click);
            this.btnUpdateByUpdate.MouseLeave += new System.EventHandler(this.btnUpdateByUpdate_MouseLeave);
            this.btnUpdateByUpdate.MouseHover += new System.EventHandler(this.btnUpdateByUpdate_MouseHover);
            // 
            // cboTypeByUpdate
            // 
            this.cboTypeByUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeByUpdate.ForeColor = System.Drawing.Color.OrangeRed;
            this.cboTypeByUpdate.FormattingEnabled = true;
            this.cboTypeByUpdate.Items.AddRange(new object[] {
            "普通用户",
            "会员用户"});
            this.cboTypeByUpdate.Location = new System.Drawing.Point(252, 163);
            this.cboTypeByUpdate.Name = "cboTypeByUpdate";
            this.cboTypeByUpdate.Size = new System.Drawing.Size(134, 20);
            this.cboTypeByUpdate.TabIndex = 5;
            this.cboTypeByUpdate.SelectedIndexChanged += new System.EventHandler(this.cboTypeByUpdate_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(137, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "注册时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(175, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(175, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(175, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "资金：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(137, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "身份证号：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("楷体", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(563, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "(身份证号不能修改)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("楷体", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(563, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "(用户账号不能修改)";
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.BackColor = System.Drawing.Color.Transparent;
            this.lable12.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable12.ForeColor = System.Drawing.Color.White;
            this.lable12.Location = new System.Drawing.Point(137, 32);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(103, 18);
            this.lable12.TabIndex = 1;
            this.lable12.Text = "用户账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // txtRemarkByUpdate
            // 
            this.txtRemarkByUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarkByUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemarkByUpdate.Location = new System.Drawing.Point(252, 291);
            this.txtRemarkByUpdate.Multiline = true;
            this.txtRemarkByUpdate.Name = "txtRemarkByUpdate";
            this.txtRemarkByUpdate.Size = new System.Drawing.Size(301, 82);
            this.txtRemarkByUpdate.TabIndex = 6;
            // 
            // txtMoneyByUpdate
            // 
            this.txtMoneyByUpdate.BackColor = System.Drawing.Color.White;
            this.txtMoneyByUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyByUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoneyByUpdate.Location = new System.Drawing.Point(252, 241);
            this.txtMoneyByUpdate.Multiline = true;
            this.txtMoneyByUpdate.Name = "txtMoneyByUpdate";
            this.txtMoneyByUpdate.ReadOnly = true;
            this.txtMoneyByUpdate.Size = new System.Drawing.Size(176, 31);
            this.txtMoneyByUpdate.TabIndex = 3;
            this.txtMoneyByUpdate.Leave += new System.EventHandler(this.txtMoneyByUpdate_Leave);
            // 
            // txtIdCardByUpdate
            // 
            this.txtIdCardByUpdate.BackColor = System.Drawing.Color.White;
            this.txtIdCardByUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCardByUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIdCardByUpdate.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtIdCardByUpdate.Location = new System.Drawing.Point(252, 70);
            this.txtIdCardByUpdate.Multiline = true;
            this.txtIdCardByUpdate.Name = "txtIdCardByUpdate";
            this.txtIdCardByUpdate.ReadOnly = true;
            this.txtIdCardByUpdate.Size = new System.Drawing.Size(301, 31);
            this.txtIdCardByUpdate.TabIndex = 2;
            // 
            // txtUserNoByUpdate
            // 
            this.txtUserNoByUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserNoByUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNoByUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserNoByUpdate.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtUserNoByUpdate.Location = new System.Drawing.Point(252, 24);
            this.txtUserNoByUpdate.Multiline = true;
            this.txtUserNoByUpdate.Name = "txtUserNoByUpdate";
            this.txtUserNoByUpdate.ReadOnly = true;
            this.txtUserNoByUpdate.Size = new System.Drawing.Size(301, 31);
            this.txtUserNoByUpdate.TabIndex = 0;
            // 
            // txtNameByUpdate
            // 
            this.txtNameByUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameByUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNameByUpdate.Location = new System.Drawing.Point(252, 115);
            this.txtNameByUpdate.Multiline = true;
            this.txtNameByUpdate.Name = "txtNameByUpdate";
            this.txtNameByUpdate.Size = new System.Drawing.Size(176, 31);
            this.txtNameByUpdate.TabIndex = 1;
            // 
            // tpAdd
            // 
            this.tpAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpAdd.BackgroundImage")));
            this.tpAdd.Controls.Add(this.dtFindTimeByAdd);
            this.tpAdd.Controls.Add(this.btnClearByAdd);
            this.tpAdd.Controls.Add(this.btnCancelByAdd);
            this.tpAdd.Controls.Add(this.btnSaveByAdd);
            this.tpAdd.Controls.Add(this.cboTypeByAdd);
            this.tpAdd.Controls.Add(this.label3);
            this.tpAdd.Controls.Add(this.label9);
            this.tpAdd.Controls.Add(this.label10);
            this.tpAdd.Controls.Add(this.label11);
            this.tpAdd.Controls.Add(this.label12);
            this.tpAdd.Controls.Add(this.label13);
            this.tpAdd.Controls.Add(this.label14);
            this.tpAdd.Controls.Add(this.txtRemarkByAdd);
            this.tpAdd.Controls.Add(this.txtMoneyByAdd);
            this.tpAdd.Controls.Add(this.txtIdCardBuAdd);
            this.tpAdd.Controls.Add(this.txtUserNoByAdd);
            this.tpAdd.Controls.Add(this.txtNameByAdd);
            this.tpAdd.Location = new System.Drawing.Point(4, 25);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(792, 456);
            this.tpAdd.TabIndex = 2;
            this.tpAdd.Text = "新增";
            this.tpAdd.UseVisualStyleBackColor = true;
            this.tpAdd.Enter += new System.EventHandler(this.tpAdd_Enter);
            // 
            // dtFindTimeByAdd
            // 
            this.dtFindTimeByAdd.Location = new System.Drawing.Point(252, 205);
            this.dtFindTimeByAdd.Name = "dtFindTimeByAdd";
            this.dtFindTimeByAdd.Size = new System.Drawing.Size(260, 21);
            this.dtFindTimeByAdd.TabIndex = 15;
            this.dtFindTimeByAdd.ValueChanged += new System.EventHandler(this.dtFindTimeByAdd_ValueChanged);
            this.dtFindTimeByAdd.Leave += new System.EventHandler(this.dtFindTimeByAdd_Leave);
            // 
            // btnClearByAdd
            // 
            this.btnClearByAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnClearByAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearByAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearByAdd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearByAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnClearByAdd.Location = new System.Drawing.Point(218, 404);
            this.btnClearByAdd.Name = "btnClearByAdd";
            this.btnClearByAdd.Size = new System.Drawing.Size(97, 35);
            this.btnClearByAdd.TabIndex = 19;
            this.btnClearByAdd.Text = "清空";
            this.btnClearByAdd.UseVisualStyleBackColor = false;
            this.btnClearByAdd.Click += new System.EventHandler(this.btnClearByAdd_Click);
            this.btnClearByAdd.MouseLeave += new System.EventHandler(this.btnClearByAdd_MouseLeave);
            this.btnClearByAdd.MouseHover += new System.EventHandler(this.btnClearByAdd_MouseHover);
            // 
            // btnCancelByAdd
            // 
            this.btnCancelByAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelByAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelByAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelByAdd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelByAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelByAdd.Location = new System.Drawing.Point(463, 404);
            this.btnCancelByAdd.Name = "btnCancelByAdd";
            this.btnCancelByAdd.Size = new System.Drawing.Size(97, 35);
            this.btnCancelByAdd.TabIndex = 20;
            this.btnCancelByAdd.Text = "取消";
            this.btnCancelByAdd.UseVisualStyleBackColor = false;
            this.btnCancelByAdd.Click += new System.EventHandler(this.btnCancelByAdd_Click);
            this.btnCancelByAdd.MouseLeave += new System.EventHandler(this.btnCancelByAdd_MouseLeave);
            this.btnCancelByAdd.MouseHover += new System.EventHandler(this.btnCancelByAdd_MouseHover);
            // 
            // btnSaveByAdd
            // 
            this.btnSaveByAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveByAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveByAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveByAdd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveByAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveByAdd.Location = new System.Drawing.Point(340, 404);
            this.btnSaveByAdd.Name = "btnSaveByAdd";
            this.btnSaveByAdd.Size = new System.Drawing.Size(97, 35);
            this.btnSaveByAdd.TabIndex = 18;
            this.btnSaveByAdd.Text = "保存";
            this.btnSaveByAdd.UseVisualStyleBackColor = false;
            this.btnSaveByAdd.Click += new System.EventHandler(this.btnSaveByAdd_Click);
            this.btnSaveByAdd.MouseLeave += new System.EventHandler(this.btnSaveByAdd_MouseLeave);
            this.btnSaveByAdd.MouseHover += new System.EventHandler(this.btnSaveByAdd_MouseHover);
            // 
            // cboTypeByAdd
            // 
            this.cboTypeByAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeByAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.cboTypeByAdd.FormattingEnabled = true;
            this.cboTypeByAdd.Items.AddRange(new object[] {
            "普通用户",
            "会员用户"});
            this.cboTypeByAdd.Location = new System.Drawing.Point(252, 169);
            this.cboTypeByAdd.Name = "cboTypeByAdd";
            this.cboTypeByAdd.Size = new System.Drawing.Size(134, 20);
            this.cboTypeByAdd.TabIndex = 16;
            this.cboTypeByAdd.SelectedIndexChanged += new System.EventHandler(this.cboTypeByAdd_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "注册时间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(174, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "状态：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(174, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(174, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "资金：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(136, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "身份证号：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(136, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 18);
            this.label13.TabIndex = 33;
            this.label13.Text = "用户账号：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(174, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 18);
            this.label14.TabIndex = 34;
            this.label14.Text = "姓名：";
            // 
            // txtRemarkByAdd
            // 
            this.txtRemarkByAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarkByAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemarkByAdd.Location = new System.Drawing.Point(252, 299);
            this.txtRemarkByAdd.Multiline = true;
            this.txtRemarkByAdd.Name = "txtRemarkByAdd";
            this.txtRemarkByAdd.Size = new System.Drawing.Size(301, 82);
            this.txtRemarkByAdd.TabIndex = 17;
            // 
            // txtMoneyByAdd
            // 
            this.txtMoneyByAdd.BackColor = System.Drawing.Color.White;
            this.txtMoneyByAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyByAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoneyByAdd.ForeColor = System.Drawing.Color.Red;
            this.txtMoneyByAdd.Location = new System.Drawing.Point(252, 246);
            this.txtMoneyByAdd.Multiline = true;
            this.txtMoneyByAdd.Name = "txtMoneyByAdd";
            this.txtMoneyByAdd.ReadOnly = true;
            this.txtMoneyByAdd.Size = new System.Drawing.Size(176, 31);
            this.txtMoneyByAdd.TabIndex = 14;
            this.txtMoneyByAdd.Text = "0";
            this.txtMoneyByAdd.Leave += new System.EventHandler(this.txtMoneyByAdd_Leave_1);
            // 
            // txtIdCardBuAdd
            // 
            this.txtIdCardBuAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCardBuAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIdCardBuAdd.Location = new System.Drawing.Point(252, 75);
            this.txtIdCardBuAdd.Multiline = true;
            this.txtIdCardBuAdd.Name = "txtIdCardBuAdd";
            this.txtIdCardBuAdd.Size = new System.Drawing.Size(301, 31);
            this.txtIdCardBuAdd.TabIndex = 12;
            this.txtIdCardBuAdd.Leave += new System.EventHandler(this.txtIdCardBuAdd_Leave);
            // 
            // txtUserNoByAdd
            // 
            this.txtUserNoByAdd.BackColor = System.Drawing.Color.White;
            this.txtUserNoByAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNoByAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserNoByAdd.Location = new System.Drawing.Point(252, 121);
            this.txtUserNoByAdd.Multiline = true;
            this.txtUserNoByAdd.Name = "txtUserNoByAdd";
            this.txtUserNoByAdd.ReadOnly = true;
            this.txtUserNoByAdd.Size = new System.Drawing.Size(301, 31);
            this.txtUserNoByAdd.TabIndex = 13;
            // 
            // txtNameByAdd
            // 
            this.txtNameByAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameByAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNameByAdd.Location = new System.Drawing.Point(252, 28);
            this.txtNameByAdd.Multiline = true;
            this.txtNameByAdd.Name = "txtNameByAdd";
            this.txtNameByAdd.Size = new System.Drawing.Size(176, 31);
            this.txtNameByAdd.TabIndex = 11;
            // 
            // clmRemark
            // 
            this.clmRemark.DataPropertyName = "Remark";
            this.clmRemark.HeaderText = "备注";
            this.clmRemark.Name = "clmRemark";
            this.clmRemark.ReadOnly = true;
            this.clmRemark.Width = 120;
            // 
            // clmType
            // 
            this.clmType.DataPropertyName = "Name";
            this.clmType.HeaderText = "状态";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Width = 70;
            // 
            // clmTime
            // 
            this.clmTime.DataPropertyName = "FoundTime";
            this.clmTime.HeaderText = "注册时间";
            this.clmTime.Name = "clmTime";
            this.clmTime.ReadOnly = true;
            this.clmTime.Width = 120;
            // 
            // clmMoney
            // 
            this.clmMoney.DataPropertyName = "Balance";
            this.clmMoney.HeaderText = "资金";
            this.clmMoney.Name = "clmMoney";
            this.clmMoney.ReadOnly = true;
            // 
            // clmIdCard
            // 
            this.clmIdCard.DataPropertyName = "IdCard";
            this.clmIdCard.HeaderText = "身份证号";
            this.clmIdCard.Name = "clmIdCard";
            this.clmIdCard.ReadOnly = true;
            this.clmIdCard.Width = 160;
            // 
            // clmNo
            // 
            this.clmNo.DataPropertyName = "UserNo";
            this.clmNo.HeaderText = "用户账号";
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            this.clmNo.Width = 120;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "UserName";
            this.clmName.HeaderText = "姓名";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 90;
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
            this.btnMin.Location = new System.Drawing.Point(791, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 30;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.OldLace;
            this.label20.Location = new System.Drawing.Point(743, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 16);
            this.label20.TabIndex = 32;
            this.label20.Text = "用户管理";
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
            this.button1.Location = new System.Drawing.Point(836, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // clName
            // 
            this.clName.DataPropertyName = "UserName";
            this.clName.FillWeight = 19.06562F;
            this.clName.HeaderText = "姓名";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 98;
            // 
            // clNo
            // 
            this.clNo.DataPropertyName = "UserNo";
            this.clNo.FillWeight = 426.396F;
            this.clNo.HeaderText = "用户账号";
            this.clNo.Name = "clNo";
            this.clNo.ReadOnly = true;
            this.clNo.Width = 130;
            // 
            // clIdCard
            // 
            this.clIdCard.DataPropertyName = "IdCard";
            this.clIdCard.FillWeight = 178.2759F;
            this.clIdCard.HeaderText = "身份证号";
            this.clIdCard.Name = "clIdCard";
            this.clIdCard.ReadOnly = true;
            this.clIdCard.Width = 130;
            // 
            // clMoney
            // 
            this.clMoney.DataPropertyName = "Balance";
            this.clMoney.FillWeight = 19.06562F;
            this.clMoney.HeaderText = "资金";
            this.clMoney.Name = "clMoney";
            this.clMoney.ReadOnly = true;
            // 
            // clTime
            // 
            this.clTime.DataPropertyName = "FoundTime";
            this.clTime.FillWeight = 19.06562F;
            this.clTime.HeaderText = "注册时间";
            this.clTime.Name = "clTime";
            this.clTime.ReadOnly = true;
            this.clTime.Width = 120;
            // 
            // clType
            // 
            this.clType.DataPropertyName = "Name";
            this.clType.FillWeight = 19.06562F;
            this.clType.HeaderText = "状态";
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            this.clType.Width = 80;
            // 
            // clRemark
            // 
            this.clRemark.DataPropertyName = "Remark";
            this.clRemark.FillWeight = 19.06562F;
            this.clRemark.HeaderText = "备注";
            this.clRemark.Name = "clRemark";
            this.clRemark.ReadOnly = true;
            this.clRemark.Width = 118;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(877, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUserInfo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUserInfo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmUserInfo_MouseUp);
            this.panel1.ResumeLayout(false);
            this.tpUserInfo.ResumeLayout(false);
            this.tpSeach.ResumeLayout(false);
            this.tpSeach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tpUserInfo;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.Button btnCancelByUpdate;
        private System.Windows.Forms.Button btnUpdateByUpdate;
        private System.Windows.Forms.ComboBox cboTypeByUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemarkByUpdate;
        private System.Windows.Forms.TextBox txtMoneyByUpdate;
        private System.Windows.Forms.TextBox txtIdCardByUpdate;
        private System.Windows.Forms.TextBox txtNameByUpdate;
        private System.Windows.Forms.Button btnCancelByAdd;
        private System.Windows.Forms.Button btnSaveByAdd;
        private System.Windows.Forms.ComboBox cboTypeByAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRemarkByAdd;
        private System.Windows.Forms.TextBox txtMoneyByAdd;
        private System.Windows.Forms.TextBox txtIdCardBuAdd;
        private System.Windows.Forms.TextBox txtUserNoByAdd;
        private System.Windows.Forms.TextBox txtNameByAdd;
        private System.Windows.Forms.Button btnClearByUpdate;
        private System.Windows.Forms.Button btnClearByAdd;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.TextBox txtUserNoByUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtFindTimeByAdd;
        private System.Windows.Forms.DateTimePicker dtFindTimeByUpdate;
        private System.Windows.Forms.TabPage tpSeach;
        private System.Windows.Forms.ComboBox cboTypeBySeach;
        private System.Windows.Forms.Button btnUpdateBySeach;
        private System.Windows.Forms.Button btnDeleteBySeach;
        private System.Windows.Forms.Button btnScachBySeach;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox txtNameBySeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvUserInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStripMenuItem tsmiShopSum;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRemark;
	}
}