using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetBar
{
    public partial class frmShopSum : Form
    {
        public frmShopSum()
        {
            InitializeComponent();
        }

        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        DBHelper db = new DBHelper();
        private void frmShopSum_Load(object sender, EventArgs e)
        {
            //绑定Cbo区域
            this.cboUserType.DisplayMember = "SectionName";
            this.cboUserType.ValueMember = "SectionId";
            this.cboUserType.DataSource = db.ShowUserType();
			//this.dgvMoney.DataSource = db.ShowAllDgv();
            this.dtimeStart.Value = DateTime.Now.AddMonths(-1);
            ChaXun();
        }

        // 查询
        public void ChaXun()
        {
            DateTime StartTime = DateTime.Now;
            DateTime EndTime = DateTime.Now;
            //两种情况，获取开始时间与结束时间
            if (this.cboxTime.Checked)
            {
                StartTime = this.dtimeStart.Value;
                EndTime = this.dtimeEnd.Value;
            }
            if (this.cboxMonth.Checked)
            {
                EndTime = DateTime.Now;
                //将开始时间变为一月前
                StartTime = EndTime.AddMonths(-1);
            }
            //如果时间按钮选中
            if (this.cboxTime.Checked || this.cboxMonth.Checked)
            {
                //根据会员与时间查询
                if (this.cboUserType.SelectedIndex == 0 && this.txtName.Text.Trim().Length != 0)
                {
                    if (db.ShowAllDgvByTimeHuiYuan(StartTime, EndTime, this.txtName.Text.Trim()) == null)
                    {
                        MessageBox.Show("系统出现异常！！！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.dgvMoney.DataSource = db.ShowAllDgvByTimeHuiYuan(StartTime, EndTime, this.txtName.Text.Trim());
                }
                //根据时间与区域查询
                else if (this.txtName.Text.Trim().Length == 0 && this.cboUserType.SelectedIndex != 0)
                {
                    if (db.ShowAllDgvByTimeQuYu(StartTime, EndTime, Convert.ToInt32(this.cboUserType.SelectedValue)) == null)
                    {
                        MessageBox.Show("系统出现异常！！！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.dgvMoney.DataSource = db.ShowAllDgvByTimeQuYu(StartTime, EndTime, Convert.ToInt32(this.cboUserType.SelectedValue));
                }
                //根据时间与区域和会员查询
                else if (this.txtName.Text.Trim().Length != 0 && this.cboUserType.SelectedIndex != 0)
                {
                    if (db.ShowAllDgvByTimeQuYuHuiYuan(StartTime, EndTime, Convert.ToInt32(this.cboUserType.SelectedValue), this.txtName.Text.Trim()) == null)
                    {
                        MessageBox.Show("系统出现异常！！！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.dgvMoney.DataSource = db.ShowAllDgvByTimeQuYuHuiYuan(StartTime, EndTime, Convert.ToInt32(this.cboUserType.SelectedValue), this.txtName.Text.Trim());
                }
                //根据时间查询
                else if (this.txtName.Text.Trim().Length == 0 && this.cboUserType.SelectedIndex == 0)
                {
                    if (db.ShowAllDgvByTime(StartTime, EndTime) == null)
                    {
                        MessageBox.Show("系统出现异常！！！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.dgvMoney.DataSource = db.ShowAllDgvByTime(StartTime, EndTime);
                }
            }
            //如果时间不选
            else
            {
                //查全部
                if (this.txtName.Text.Trim().Length == 0 && this.cboUserType.SelectedIndex == 0)
                {
                    if (db.ShowAllDgv() == null)
                    {
                        MessageBox.Show("系统出现异常！！！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.dgvMoney.DataSource = db.ShowAllDgv();
                }
                //根据会员查询
                else if (this.txtName.Text.Trim().Length != 0 && this.cboUserType.SelectedIndex == 0)
                {
                    if (db.ShowAllDgvByHY(this.txtName.Text.Trim()) == null)
                    {
                        MessageBox.Show("系统出现异常！！！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.dgvMoney.DataSource = db.ShowAllDgvByHY(this.txtName.Text.Trim());
                }
                //根据区域查询
                else if (this.txtName.Text.Trim().Length == 0 && this.cboUserType.SelectedIndex != 0)
                {
                    if (db.ShowAllDgvByQuYu(Convert.ToInt32(this.cboUserType.SelectedValue)) == null)
                    {
                        MessageBox.Show("系统出现异常！！！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.dgvMoney.DataSource = db.ShowAllDgvByQuYu(Convert.ToInt32(this.cboUserType.SelectedValue));
                }
                //根据区域会员查询
                else
                {
                    if (db.ShowAllDgvByQuYuHuiYuan(this.txtName.Text.Trim(), Convert.ToInt32(this.cboUserType.SelectedValue)) == null)
                    {
                        MessageBox.Show("系统出现异常！！！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.dgvMoney.DataSource = db.ShowAllDgvByQuYuHuiYuan(this.txtName.Text.Trim(), Convert.ToInt32(this.cboUserType.SelectedValue));
                }
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btnSave_Click(object sender, EventArgs e)
		{
            ChaXun();
        }
        /// <summary>
        /// 当选中时间选项时将最近一月选项勾掉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxTime.Checked)
            {
                this.cboxMonth.Checked = false;
                this.cboxTime.ForeColor = Color.OrangeRed;
                this.cboxMonth.ForeColor = Color.Transparent;
            }
            ChaXun();
        }
        /// <summary>
        /// 当选中最近一月选项时将时间选项勾掉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxMonth.Checked)
            {
                this.cboxTime.Checked = false;
                this.cboxMonth.ForeColor = Color.OrangeRed;
                this.cboxTime.ForeColor = Color.Transparent;
            }
            ChaXun();
        }
        /// <summary>
        /// 当选中日期控件时将时间选项按钮选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtimeStart_ValueChanged(object sender, EventArgs e)
        {
            this.cboxTime.Checked = true;
            if (this.dtimeEnd.Value < this.dtimeStart.Value && this.dtimeStart.Value <= DateTime.Now)
            {
                MessageBox.Show("开始时间不能大于结束时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtimeStart.Value = this.dtimeEnd.Value.AddDays(-1);
                return;
            }
            else if (this.dtimeStart.Value > DateTime.Now)
            {
                MessageBox.Show("开始时间不能大于系统当前时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtimeStart.Value = DateTime.Now.AddDays(-1);
                return;
            }
            ChaXun();
            this.cboxTime.ForeColor = Color.OrangeRed;
            this.cboxMonth.ForeColor = Color.Transparent;
        }

        private void dtimeEnd_ValueChanged(object sender, EventArgs e)
        {
            this.cboxTime.Checked = true;
            //开始时间不能大于结束时间
            if (this.dtimeEnd.Value < this.dtimeStart.Value && this.dtimeEnd.Value <= DateTime.Now)
            {
                MessageBox.Show("结束时间不能小于开始时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtimeStart.Value = this.dtimeEnd.Value.AddDays(-1);
                return;
            }
            else if (this.dtimeEnd.Value > DateTime.Now)
            {
                MessageBox.Show("结束时间不能大于系统当前时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtimeEnd.Value = DateTime.Now;
                return;
            }
            ChaXun();
            this.cboxTime.ForeColor = Color.OrangeRed;
            this.cboxMonth.ForeColor = Color.Transparent;
        }
        public frmUserInfo fu = new frmUserInfo ();
        private void frmShopSum_Enter(object sender, EventArgs e)
        {
            fu.HowShowFrmUserInfo = true;
        }

        private void frmShopSum_Leave(object sender, EventArgs e)
        {
            fu.HowShowFrmUserInfo = false;
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (db.SelectStipNoteById(this.dgvMoney.CurrentRow.Cells["Column4"].Value.ToString()) == true)
            {
                MessageBox.Show("该用户已充值，不能删除消费记录！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string isDelete = "是否删除账号为： " + this.dgvMoney.CurrentRow.Cells["Column4"].Value.ToString() + " 的消费记录？";
            if (MessageBox.Show(isDelete, "系统提示 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (db.DeleteUserInfoTwo(this.dgvMoney.CurrentRow.Cells["Column4"].Value.ToString()) == -1)
            {
                MessageBox.Show("删除消费记录失败，可能是系统出现异常！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("删除消费记录成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChaXun();
        }

        private void frmShopSum_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmShopSum_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmShopSum_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (this.dgvMoney.RowCount == 0)
            {
                e.Cancel = true;
                return;
            }
        }
        //当鼠标停留时改变颜色及显示文字
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(button1, "关闭");
            this.button1.BackColor = Color.Red;
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(btnMin, "最小化");
            this.btnMin.BackColor = Color.White;
        }
        //当鼠标停留时恢复颜色及显示文字
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            this.btnMin.BackColor = Color.Transparent;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.OrangeRed;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.Transparent;
        }

        private void cboxMonth_MouseHover(object sender, EventArgs e)
        {
            this.cboxMonth.ForeColor = Color.OrangeRed;
        }

        private void cboxMonth_MouseLeave(object sender, EventArgs e)
        {
            this.cboxMonth.ForeColor = Color.Transparent;
        }

        private void cboxTime_MouseHover(object sender, EventArgs e)
        {
            this.cboxTime.ForeColor = Color.OrangeRed;
        }

        private void cboxTime_MouseLeave(object sender, EventArgs e)
        {
            this.cboxTime.ForeColor = Color.Transparent;
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ChaXun();
        }
    }
}
