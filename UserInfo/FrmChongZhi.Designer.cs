namespace InternetBar
{
    partial class FrmChongZhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChongZhi));
            this.label1 = new System.Windows.Forms.Label();
            this.btnChongZhi = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMoney = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQingKong = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员编号：";
            // 
            // btnChongZhi
            // 
            this.btnChongZhi.BackColor = System.Drawing.Color.Transparent;
            this.btnChongZhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChongZhi.Font = new System.Drawing.Font("宋体", 12F);
            this.btnChongZhi.ForeColor = System.Drawing.Color.Transparent;
            this.btnChongZhi.Location = new System.Drawing.Point(446, 362);
            this.btnChongZhi.Name = "btnChongZhi";
            this.btnChongZhi.Size = new System.Drawing.Size(86, 34);
            this.btnChongZhi.TabIndex = 1;
            this.btnChongZhi.Text = "充值";
            this.btnChongZhi.UseVisualStyleBackColor = false;
            this.btnChongZhi.Click += new System.EventHandler(this.btnChongZhi_Click);
            this.btnChongZhi.MouseLeave += new System.EventHandler(this.btnChongZhi_MouseLeave);
            this.btnChongZhi.MouseHover += new System.EventHandler(this.btnChongZhi_MouseHover);
            // 
            // txtNo
            // 
            this.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNo.Location = new System.Drawing.Point(456, 157);
            this.txtNo.Multiline = true;
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(180, 25);
            this.txtNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "会员姓名：";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(157, 225);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(167, 25);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "充值金额：";
            // 
            // cboMoney
            // 
            this.cboMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoney.FormattingEnabled = true;
            this.cboMoney.Items.AddRange(new object[] {
            "请选择充值金额",
            "1",
            "2",
            "5",
            "10",
            "15",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "200"});
            this.cboMoney.Location = new System.Drawing.Point(157, 297);
            this.cboMoney.Name = "cboMoney";
            this.cboMoney.Size = new System.Drawing.Size(167, 20);
            this.cboMoney.TabIndex = 3;
            this.cboMoney.TextChanged += new System.EventHandler(this.cboMoney_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 12F);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(551, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(356, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "上次余额：";
            // 
            // txtBalance
            // 
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Location = new System.Drawing.Point(456, 225);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(180, 25);
            this.txtBalance.TabIndex = 2;
            this.txtBalance.Leave += new System.EventHandler(this.txtBalance_Leave);
            // 
            // txtIdCard
            // 
            this.txtIdCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCard.Location = new System.Drawing.Point(157, 157);
            this.txtIdCard.MaxLength = 18;
            this.txtIdCard.Multiline = true;
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(167, 25);
            this.txtIdCard.TabIndex = 0;
            this.txtIdCard.Leave += new System.EventHandler(this.txtIdCard_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "身份证号：";
            // 
            // txtSum
            // 
            this.txtSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSum.Location = new System.Drawing.Point(456, 294);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(180, 25);
            this.txtSum.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(388, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "余额：";
            // 
            // btnQingKong
            // 
            this.btnQingKong.BackColor = System.Drawing.Color.Transparent;
            this.btnQingKong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQingKong.Font = new System.Drawing.Font("宋体", 12F);
            this.btnQingKong.ForeColor = System.Drawing.Color.Transparent;
            this.btnQingKong.Location = new System.Drawing.Point(344, 362);
            this.btnQingKong.Name = "btnQingKong";
            this.btnQingKong.Size = new System.Drawing.Size(84, 34);
            this.btnQingKong.TabIndex = 5;
            this.btnQingKong.Text = "清空";
            this.btnQingKong.UseVisualStyleBackColor = false;
            this.btnQingKong.Click += new System.EventHandler(this.btnQingKong_Click);
            this.btnQingKong.MouseLeave += new System.EventHandler(this.btnQingKong_MouseLeave);
            this.btnQingKong.MouseHover += new System.EventHandler(this.btnQingKong_MouseHover);
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
            this.btnMin.Location = new System.Drawing.Point(600, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 24;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.OldLace;
            this.label7.Location = new System.Drawing.Point(597, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "会员充值";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(646, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // FrmChongZhi
            // 
            this.AcceptButton = this.btnChongZhi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(688, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnQingKong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.cboMoney);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIdCard);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChongZhi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChongZhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员充值";
            this.Load += new System.EventHandler(this.FrmChongZhi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChongZhi;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMoney;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQingKong;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}