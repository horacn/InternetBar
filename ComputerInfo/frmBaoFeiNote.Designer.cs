namespace InternetBar
{
    partial class frmBaoFeiNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoFeiNote));
            this.dgvVip = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labSums = new System.Windows.Forms.Label();
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuYu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnTongJI = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVip)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVip
            // 
            this.dgvVip.AllowUserToAddRows = false;
            this.dgvVip.AllowUserToDeleteRows = false;
            this.dgvVip.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvVip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVip.BackgroundColor = System.Drawing.Color.White;
            this.dgvVip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNo,
            this.clmName,
            this.clmQuYu,
            this.clmIp});
            this.dgvVip.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvVip.Location = new System.Drawing.Point(25, 130);
            this.dgvVip.MultiSelect = false;
            this.dgvVip.Name = "dgvVip";
            this.dgvVip.ReadOnly = true;
            this.dgvVip.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVip.RowHeadersVisible = false;
            this.dgvVip.RowTemplate.Height = 23;
            this.dgvVip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVip.Size = new System.Drawing.Size(569, 294);
            this.dgvVip.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(262, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "电脑报废记录统计";
            // 
            // labSums
            // 
            this.labSums.AutoSize = true;
            this.labSums.BackColor = System.Drawing.Color.Transparent;
            this.labSums.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSums.ForeColor = System.Drawing.Color.OldLace;
            this.labSums.Location = new System.Drawing.Point(34, 94);
            this.labSums.Name = "labSums";
            this.labSums.Size = new System.Drawing.Size(102, 16);
            this.labSums.TabIndex = 32;
            this.labSums.Text = "报废总数量:";
            // 
            // clmNo
            // 
            this.clmNo.DataPropertyName = "ComputerId";
            this.clmNo.HeaderText = "电脑编号";
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "ComputerNo";
            this.clmName.HeaderText = "电脑名称";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmQuYu
            // 
            this.clmQuYu.DataPropertyName = "SectionName";
            this.clmQuYu.HeaderText = "所属区域";
            this.clmQuYu.Name = "clmQuYu";
            this.clmQuYu.ReadOnly = true;
            // 
            // clmIp
            // 
            this.clmIp.DataPropertyName = "IP";
            this.clmIp.HeaderText = "IP";
            this.clmIp.Name = "clmIp";
            this.clmIp.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(286, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "区域:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(351, 92);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(134, 20);
            this.cboType.TabIndex = 33;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // btnTongJI
            // 
            this.btnTongJI.BackColor = System.Drawing.Color.Transparent;
            this.btnTongJI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongJI.Font = new System.Drawing.Font("宋体", 12F);
            this.btnTongJI.ForeColor = System.Drawing.Color.Transparent;
            this.btnTongJI.Location = new System.Drawing.Point(513, 88);
            this.btnTongJI.Name = "btnTongJI";
            this.btnTongJI.Size = new System.Drawing.Size(81, 28);
            this.btnTongJI.TabIndex = 34;
            this.btnTongJI.Text = "统计";
            this.btnTongJI.UseVisualStyleBackColor = false;
            this.btnTongJI.Click += new System.EventHandler(this.btnTongJI_Click);
            this.btnTongJI.MouseLeave += new System.EventHandler(this.btnTongJI_MouseLeave);
            this.btnTongJI.MouseHover += new System.EventHandler(this.btnTongJI_MouseHover);
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
            this.button1.Location = new System.Drawing.Point(581, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
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
            this.btnMin.Location = new System.Drawing.Point(538, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 35;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // frmBaoFeiNote
            // 
            this.AcceptButton = this.btnTongJI;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(622, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnTongJI);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labSums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoFeiNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoFeiNote";
            this.Load += new System.EventHandler(this.frmBaoFeiNote_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSelectComputer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSelectComputer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSelectComputer_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuYu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnTongJI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}