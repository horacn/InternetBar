namespace InternetBar
{
    partial class frmUpdateMoneyBySection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMoneyBySection));
            this.dgvXGPrice = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuYu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXGPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXGPrice
            // 
            this.dgvXGPrice.AllowUserToAddRows = false;
            this.dgvXGPrice.AllowUserToDeleteRows = false;
            this.dgvXGPrice.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvXGPrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXGPrice.BackgroundColor = System.Drawing.Color.White;
            this.dgvXGPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXGPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColPrice,
            this.ClmId});
            this.dgvXGPrice.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvXGPrice.Location = new System.Drawing.Point(36, 114);
            this.dgvXGPrice.MultiSelect = false;
            this.dgvXGPrice.Name = "dgvXGPrice";
            this.dgvXGPrice.ReadOnly = true;
            this.dgvXGPrice.RowHeadersVisible = false;
            this.dgvXGPrice.RowTemplate.Height = 23;
            this.dgvXGPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXGPrice.Size = new System.Drawing.Size(519, 223);
            this.dgvXGPrice.TabIndex = 80;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "SectionName";
            this.ColName.HeaderText = "区域名称";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 235;
            // 
            // ColPrice
            // 
            this.ColPrice.DataPropertyName = "SectionPrice";
            this.ColPrice.HeaderText = "价格";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 280;
            // 
            // ClmId
            // 
            this.ClmId.DataPropertyName = "SectionId";
            this.ClmId.HeaderText = "ID";
            this.ClmId.Name = "ClmId";
            this.ClmId.ReadOnly = true;
            this.ClmId.Visible = false;
            // 
            // txtQuYu
            // 
            this.txtQuYu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuYu.Location = new System.Drawing.Point(281, 359);
            this.txtQuYu.Multiline = true;
            this.txtQuYu.Name = "txtQuYu";
            this.txtQuYu.Size = new System.Drawing.Size(134, 27);
            this.txtQuYu.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(220, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "价格：";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(462, 361);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 25);
            this.btnLogin.TabIndex = 84;
            this.btnLogin.Text = "修改";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
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
            this.btnMin.Location = new System.Drawing.Point(500, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 86;
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
            this.label2.Location = new System.Drawing.Point(278, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "修改上机价格";
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
            this.button1.Location = new System.Drawing.Point(546, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 88;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // frmUpdateMoneyBySection
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(586, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtQuYu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvXGPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateMoneyBySection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改上机价格";
            this.Load += new System.EventHandler(this.frmUpdateMoneyBySection_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUpdateAdmin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUpdateAdmin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmUpdateAdmin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXGPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXGPrice;
        private System.Windows.Forms.TextBox txtQuYu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}