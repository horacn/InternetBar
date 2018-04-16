namespace InternetBar
{
    partial class frmUserNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserNote));
            this.dgvUserNote = new System.Windows.Forms.DataGridView();
            this.btnMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ColUserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComputerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubmitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserNote)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserNote
            // 
            this.dgvUserNote.AllowUserToAddRows = false;
            this.dgvUserNote.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvUserNote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserNote.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUserNo,
            this.ColComputerID,
            this.ColBeginTime,
            this.ColEndTime,
            this.ColSubmitPrice,
            this.Column1,
            this.ColRemark,
            this.ColID,
            this.Column2});
            this.dgvUserNote.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvUserNote.Location = new System.Drawing.Point(42, 145);
            this.dgvUserNote.MultiSelect = false;
            this.dgvUserNote.Name = "dgvUserNote";
            this.dgvUserNote.ReadOnly = true;
            this.dgvUserNote.RowHeadersVisible = false;
            this.dgvUserNote.RowTemplate.Height = 23;
            this.dgvUserNote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserNote.Size = new System.Drawing.Size(687, 340);
            this.dgvUserNote.TabIndex = 0;
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
            this.btnMin.Location = new System.Drawing.Point(675, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 30;
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
            this.label2.Location = new System.Drawing.Point(598, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "充值记录";
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
            this.button1.Location = new System.Drawing.Point(720, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // ColUserNo
            // 
            this.ColUserNo.DataPropertyName = "UserNo";
            this.ColUserNo.HeaderText = "用户编号";
            this.ColUserNo.Name = "ColUserNo";
            this.ColUserNo.ReadOnly = true;
            this.ColUserNo.Width = 120;
            // 
            // ColComputerID
            // 
            this.ColComputerID.DataPropertyName = "ComputerID";
            this.ColComputerID.HeaderText = "电脑编号";
            this.ColComputerID.Name = "ColComputerID";
            this.ColComputerID.ReadOnly = true;
            this.ColComputerID.Width = 80;
            // 
            // ColBeginTime
            // 
            this.ColBeginTime.DataPropertyName = "BeginTime";
            this.ColBeginTime.HeaderText = "上机时间";
            this.ColBeginTime.Name = "ColBeginTime";
            this.ColBeginTime.ReadOnly = true;
            this.ColBeginTime.Width = 98;
            // 
            // ColEndTime
            // 
            this.ColEndTime.DataPropertyName = "EndTime";
            this.ColEndTime.HeaderText = "下机时间";
            this.ColEndTime.Name = "ColEndTime";
            this.ColEndTime.ReadOnly = true;
            this.ColEndTime.Width = 98;
            // 
            // ColSubmitPrice
            // 
            this.ColSubmitPrice.DataPropertyName = "SubmitPrice";
            this.ColSubmitPrice.HeaderText = "预交金额";
            this.ColSubmitPrice.Name = "ColSubmitPrice";
            this.ColSubmitPrice.ReadOnly = true;
            this.ColSubmitPrice.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Addprice";
            this.Column1.HeaderText = "续费金额";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // ColRemark
            // 
            this.ColRemark.DataPropertyName = "Remark";
            this.ColRemark.HeaderText = "备注";
            this.ColRemark.Name = "ColRemark";
            this.ColRemark.ReadOnly = true;
            this.ColRemark.Width = 110;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "编号";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ActualPrice";
            this.Column2.HeaderText = "实收金额";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 50;
            // 
            // frmUserNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(761, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.dgvUserNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "充值记录查询";
            this.Load += new System.EventHandler(this.frmUserNote_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUserNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUserNote_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmUserNote_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserNote;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComputerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubmitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}