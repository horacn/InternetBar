namespace InternetBar
{
    partial class frmUpdateComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateComputer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtComputerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComputerIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBaofei = new System.Windows.Forms.RadioButton();
            this.rbtnWeixiu = new System.Windows.Forms.RadioButton();
            this.rbtnKeYong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnMZPWQ = new System.Windows.Forms.RadioButton();
            this.rbtnSPZQ = new System.Windows.Forms.RadioButton();
            this.rbtnQLBJ = new System.Windows.Forms.RadioButton();
            this.rbtnXYQ = new System.Windows.Forms.RadioButton();
            this.rbtnYXQ = new System.Windows.Forms.RadioButton();
            this.rbtnPTQ = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNO = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClearByAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "电脑名称";
            // 
            // txtComputerID
            // 
            this.txtComputerID.BackColor = System.Drawing.SystemColors.Window;
            this.txtComputerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComputerID.Location = new System.Drawing.Point(172, 181);
            this.txtComputerID.Name = "txtComputerID";
            this.txtComputerID.Size = new System.Drawing.Size(233, 21);
            this.txtComputerID.TabIndex = 1;
            this.txtComputerID.Leave += new System.EventHandler(this.txtComputerID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "电脑IP地址";
            // 
            // txtComputerIP
            // 
            this.txtComputerIP.BackColor = System.Drawing.SystemColors.Window;
            this.txtComputerIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComputerIP.Location = new System.Drawing.Point(176, 434);
            this.txtComputerIP.Name = "txtComputerIP";
            this.txtComputerIP.Size = new System.Drawing.Size(229, 21);
            this.txtComputerIP.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtnBaofei);
            this.groupBox1.Controls.Add(this.rbtnWeixiu);
            this.groupBox1.Controls.Add(this.rbtnKeYong);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(85, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电脑状态";
            // 
            // rbtnBaofei
            // 
            this.rbtnBaofei.AutoSize = true;
            this.rbtnBaofei.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnBaofei.Location = new System.Drawing.Point(262, 32);
            this.rbtnBaofei.Name = "rbtnBaofei";
            this.rbtnBaofei.Size = new System.Drawing.Size(58, 20);
            this.rbtnBaofei.TabIndex = 0;
            this.rbtnBaofei.TabStop = true;
            this.rbtnBaofei.Text = "报废";
            this.rbtnBaofei.UseVisualStyleBackColor = true;
            // 
            // rbtnWeixiu
            // 
            this.rbtnWeixiu.AutoSize = true;
            this.rbtnWeixiu.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnWeixiu.Location = new System.Drawing.Point(134, 32);
            this.rbtnWeixiu.Name = "rbtnWeixiu";
            this.rbtnWeixiu.Size = new System.Drawing.Size(74, 20);
            this.rbtnWeixiu.TabIndex = 0;
            this.rbtnWeixiu.TabStop = true;
            this.rbtnWeixiu.Text = "维修中";
            this.rbtnWeixiu.UseVisualStyleBackColor = true;
            // 
            // rbtnKeYong
            // 
            this.rbtnKeYong.AutoSize = true;
            this.rbtnKeYong.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnKeYong.Location = new System.Drawing.Point(17, 32);
            this.rbtnKeYong.Name = "rbtnKeYong";
            this.rbtnKeYong.Size = new System.Drawing.Size(58, 20);
            this.rbtnKeYong.TabIndex = 0;
            this.rbtnKeYong.TabStop = true;
            this.rbtnKeYong.Text = "可用";
            this.rbtnKeYong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbtnMZPWQ);
            this.groupBox2.Controls.Add(this.rbtnSPZQ);
            this.groupBox2.Controls.Add(this.rbtnQLBJ);
            this.groupBox2.Controls.Add(this.rbtnXYQ);
            this.groupBox2.Controls.Add(this.rbtnYXQ);
            this.groupBox2.Controls.Add(this.rbtnPTQ);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(85, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "电脑所在区域";
            // 
            // rbtnMZPWQ
            // 
            this.rbtnMZPWQ.AutoSize = true;
            this.rbtnMZPWQ.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnMZPWQ.Location = new System.Drawing.Point(262, 71);
            this.rbtnMZPWQ.Name = "rbtnMZPWQ";
            this.rbtnMZPWQ.Size = new System.Drawing.Size(122, 20);
            this.rbtnMZPWQ.TabIndex = 1;
            this.rbtnMZPWQ.Text = "妹纸陪玩专区";
            this.rbtnMZPWQ.UseVisualStyleBackColor = true;
            // 
            // rbtnSPZQ
            // 
            this.rbtnSPZQ.AutoSize = true;
            this.rbtnSPZQ.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnSPZQ.Location = new System.Drawing.Point(134, 71);
            this.rbtnSPZQ.Name = "rbtnSPZQ";
            this.rbtnSPZQ.Size = new System.Drawing.Size(90, 20);
            this.rbtnSPZQ.TabIndex = 2;
            this.rbtnSPZQ.Text = "视频专区";
            this.rbtnSPZQ.UseVisualStyleBackColor = true;
            // 
            // rbtnQLBJ
            // 
            this.rbtnQLBJ.AutoSize = true;
            this.rbtnQLBJ.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnQLBJ.Location = new System.Drawing.Point(15, 71);
            this.rbtnQLBJ.Name = "rbtnQLBJ";
            this.rbtnQLBJ.Size = new System.Drawing.Size(90, 20);
            this.rbtnQLBJ.TabIndex = 3;
            this.rbtnQLBJ.Text = "情侣包间";
            this.rbtnQLBJ.UseVisualStyleBackColor = true;
            // 
            // rbtnXYQ
            // 
            this.rbtnXYQ.AutoSize = true;
            this.rbtnXYQ.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnXYQ.Location = new System.Drawing.Point(262, 34);
            this.rbtnXYQ.Name = "rbtnXYQ";
            this.rbtnXYQ.Size = new System.Drawing.Size(74, 20);
            this.rbtnXYQ.TabIndex = 4;
            this.rbtnXYQ.Text = "吸烟区";
            this.rbtnXYQ.UseVisualStyleBackColor = true;
            // 
            // rbtnYXQ
            // 
            this.rbtnYXQ.AutoSize = true;
            this.rbtnYXQ.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnYXQ.Location = new System.Drawing.Point(134, 34);
            this.rbtnYXQ.Name = "rbtnYXQ";
            this.rbtnYXQ.Size = new System.Drawing.Size(90, 20);
            this.rbtnYXQ.TabIndex = 5;
            this.rbtnYXQ.Text = "游戏专区";
            this.rbtnYXQ.UseVisualStyleBackColor = true;
            // 
            // rbtnPTQ
            // 
            this.rbtnPTQ.AutoSize = true;
            this.rbtnPTQ.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnPTQ.Location = new System.Drawing.Point(15, 34);
            this.rbtnPTQ.Name = "rbtnPTQ";
            this.rbtnPTQ.Size = new System.Drawing.Size(74, 20);
            this.rbtnPTQ.TabIndex = 6;
            this.rbtnPTQ.Text = "普通区";
            this.rbtnPTQ.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(205, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "修改";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(317, 481);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave_1);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "电脑ID";
            // 
            // lblNO
            // 
            this.lblNO.AutoSize = true;
            this.lblNO.BackColor = System.Drawing.Color.Transparent;
            this.lblNO.Font = new System.Drawing.Font("宋体", 12F);
            this.lblNO.ForeColor = System.Drawing.Color.White;
            this.lblNO.Location = new System.Drawing.Point(172, 146);
            this.lblNO.Name = "lblNO";
            this.lblNO.Size = new System.Drawing.Size(0, 16);
            this.lblNO.TabIndex = 4;
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
            this.btnMin.Location = new System.Drawing.Point(500, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 23);
            this.btnMin.TabIndex = 30;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // btnClearByAdd
            // 
            this.btnClearByAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnClearByAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearByAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearByAdd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearByAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnClearByAdd.Location = new System.Drawing.Point(95, 481);
            this.btnClearByAdd.Name = "btnClearByAdd";
            this.btnClearByAdd.Size = new System.Drawing.Size(88, 33);
            this.btnClearByAdd.TabIndex = 31;
            this.btnClearByAdd.Text = "清空";
            this.btnClearByAdd.UseVisualStyleBackColor = false;
            this.btnClearByAdd.Click += new System.EventHandler(this.btnClearByAdd_Click);
            this.btnClearByAdd.MouseLeave += new System.EventHandler(this.btnClearByAdd_MouseLeave);
            this.btnClearByAdd.MouseHover += new System.EventHandler(this.btnClearByAdd_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.OldLace;
            this.label4.Location = new System.Drawing.Point(480, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "修改电脑";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(546, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // frmUpdateComputer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(586, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearByAdd);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.lblNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtComputerIP);
            this.Controls.Add(this.txtComputerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改电脑信息";
            this.Load += new System.EventHandler(this.frmUpdateComputer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUpdateComputer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUpdateComputer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmUpdateComputer_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComputerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComputerIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBaofei;
        private System.Windows.Forms.RadioButton rbtnWeixiu;
        private System.Windows.Forms.RadioButton rbtnKeYong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbtnMZPWQ;
        private System.Windows.Forms.RadioButton rbtnSPZQ;
        private System.Windows.Forms.RadioButton rbtnQLBJ;
        private System.Windows.Forms.RadioButton rbtnXYQ;
        private System.Windows.Forms.RadioButton rbtnYXQ;
        private System.Windows.Forms.RadioButton rbtnPTQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNO;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClearByAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}