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
	public partial class frmUserInfo : Form
	{
		public frmUserInfo()
		{
			InitializeComponent();
        }
        DBHelper db = new DBHelper();
        int UpdateIndex = 0;   //当前选中的dgv的Index
        bool SelectedDgvByAdd = false;
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            this.cboTypeBySeach.SelectedIndex = 0;
            SeachBySql();
        }

        private void btnScach_Click(object sender, EventArgs e)
        {
            SeachBySql();
        }
        /// <summary>
        /// 按条件查询用户信息
        /// </summary>
        public void SeachBySql()
        {
            string sql = null;
            if (this.txtNameBySeach.Text.Trim().Length == 0 && this.cboTypeBySeach.SelectedIndex == 0)
            {
                sql = "select UserNo,UserName,IdCard,Balance,FoundTime,Remark,Name from Users as u inner join UserType as ut on u.Did = ut.ID";
                this.dgvUserInfo.DataSource = db.SeachUserInfo(sql);
            }
            else if (this.txtNameBySeach.Text.Trim().Length == 0 && this.cboTypeBySeach.SelectedIndex != 0)
            {
                sql = string.Format("select UserNo,UserName,IdCard,Balance,FoundTime,Remark,Name from Users as u inner join UserType as ut on u.Did = ut.ID where Did = {0}",this.cboTypeBySeach.SelectedIndex);
                this.dgvUserInfo.DataSource = db.SeachUserInfo(sql);
            }
            else if (this.txtNameBySeach.Text.Trim().Length != 0 && this.cboTypeBySeach.SelectedIndex == 0)
            {
                sql = string.Format("select UserNo,UserName,IdCard,Balance,FoundTime,Remark,Name from Users as u inner join UserType as ut on u.Did = ut.ID where UserNo like '%{0}%'", this.txtNameBySeach.Text.Trim());
                this.dgvUserInfo.DataSource = db.SeachUserInfo(sql);
            }
            else
            {
                sql = string.Format("select UserNo,UserName,IdCard,Balance,FoundTime,Remark,Name from Users as u inner join UserType as ut on u.Did = ut.ID where Did = {0} and UserNo like '%{1}%'", this.cboTypeBySeach.SelectedIndex, this.txtNameBySeach.Text.Trim());
                this.dgvUserInfo.DataSource = db.SeachUserInfo(sql);
            }
            
        }

        private void btnUpdateBySeach_Click(object sender, EventArgs e)
        {
            this.tpUserInfo.SelectedIndex = 1;
        }
        /// <summary>
        /// 修改时将信息显示到修改窗体之上
        /// </summary>
        public void ShowUserInfoByUpdate()
        {
            if (this.dgvUserInfo.RowCount == 0)
            {
                 //MessageBox.Show("没有选中任何用户进行修改！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 ClearUpdate();
                 this.txtUserNoByUpdate.Clear();
                 this.txtUserNoByUpdate.Focus();
                 UpdateIndex = -1;
                 this.txtNameBySeach.Clear();
                 SeachBySql();
                 this.label15.Visible = false;
                 this.txtUserNoByUpdate.ReadOnly = false;
                 this.txtIdCardByUpdate.Text = "身份证号不能修改";
                 return;
            }
            
            this.txtNameByUpdate.Text = this.dgvUserInfo.CurrentRow.Cells["clName"].Value.ToString();
            this.txtUserNoByUpdate.Text = this.dgvUserInfo.CurrentRow.Cells["clNo"].Value.ToString();
            this.txtIdCardByUpdate.Text = this.dgvUserInfo.CurrentRow.Cells["clIdCard"].Value.ToString();
            this.dtFindTimeByUpdate.Value = Convert.ToDateTime(this.dgvUserInfo.CurrentRow.Cells["clTime"].Value.ToString());
            this.txtRemarkByUpdate.Text = this.dgvUserInfo.CurrentRow.Cells["clRemark"].Value.ToString();
            this.txtMoneyByUpdate.Text = this.dgvUserInfo.CurrentRow.Cells["clMoney"].Value.ToString();
            this.cboTypeByUpdate.SelectedIndex = this.dgvUserInfo.CurrentRow.Cells["clType"].Value.ToString() == "普通用户" ? 0 : 1;
        }
        private void btnDeleteBySeach_Click(object sender, EventArgs e)
        {
            if (this.dgvUserInfo.RowCount == 0)
            {
                MessageBox.Show("当前表中没有任何数据，不能进行删除操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string isDelete = "您确认要删除账号为： " + this.dgvUserInfo.CurrentRow.Cells["clNo"].Value.ToString() + "的用户吗？";
            if (MessageBox.Show(isDelete, "系统提示 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (db.SelectUserNoteById(this.dgvUserInfo.CurrentRow.Cells["clNo"].Value.ToString()))
            {
                if (db.DeleteUserInfoTwo(this.dgvUserInfo.CurrentRow.Cells["clNo"].Value.ToString()) == -1 && db.DeleteUserInfo(this.dgvUserInfo.CurrentRow.Cells["clNo"].Value.ToString()) == -1)
                {
                    MessageBox.Show("该用户已充值，不能删除！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (db.DeleteUserInfo(this.dgvUserInfo.CurrentRow.Cells["clNo"].Value.ToString()) == -1)
                {
                    MessageBox.Show("该用户已充值，不能删除！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("删除成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SeachBySql();
            }
            else
            {
                if (db.DeleteUserInfo(this.dgvUserInfo.CurrentRow.Cells["clNo"].Value.ToString()) == -1)
                {
                    MessageBox.Show("该用户已充值，不能删除！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("删除成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SeachBySql();
            }
                
        }

        private void tpUpdate_Enter(object sender, EventArgs e)
        {
            if (this.cboTypeByUpdate.SelectedIndex == 0)
            {
                this.txtMoneyByUpdate.Text = "0";
            }
            else
            {
                this.txtMoneyByUpdate.ReadOnly = false;
            }
            if (this.dgvUserInfo.RowCount !=0)
            {
                this.label15.Visible = true;
                this.txtUserNoByUpdate.ReadOnly = true;
            }
            this.txtNameByUpdate.Focus();
            ShowUserInfoByUpdate();
            if (UpdateIndex==-1)
            {
                this.txtUserNoByUpdate.Focus();
                return;
            }
            UpdateIndex = this.dgvUserInfo.CurrentRow.Index;   //把index赋给UpdateIndex
        }

        private void btnCancelByUpdate_Click(object sender, EventArgs e)
        {
            this.tpUserInfo.SelectedIndex = 0;
        }

        /// <summary>
        /// 清空修改窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearByUpdate_Click(object sender, EventArgs e)
        {
            ClearUpdate();
        }
        public void ClearUpdate()
        {
            this.txtNameByUpdate.Clear();
            this.txtMoneyByUpdate.Clear();
            this.dtFindTimeByUpdate.Value = DateTime.Now;
            this.txtRemarkByUpdate.Clear();
            this.cboTypeByUpdate.SelectedIndex = 0;
            this.txtNameByUpdate.Focus();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateByUpdate_Click(object sender, EventArgs e)
        {
            //if (this.txtMoneyByUpdate.Text.Trim().Length == 0)
            //{
            //    if (this.cboTypeByUpdate.SelectedIndex == 0)
            //    {
            //        this.txtMoneyByUpdate.Text = "0";
            //    }
            //    else if (this.cboTypeByUpdate.SelectedIndex == 1 && Convert.ToDouble(this.txtMoneyByUpdate.Text.Trim()) < 0)
            //    {
            //        MessageBox.Show("会员金额不能小于0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //}
            if (this.txtNameByUpdate.Text.Trim().Length == 0 || this.txtUserNoByUpdate.Text.Trim().Length == 0 || this.txtMoneyByUpdate.Text.Trim().Length == 0)
            {
                MessageBox.Show("信息填写不完整！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.dtFindTimeByUpdate.Value > DateTime.Now)
            {
                MessageBox.Show("时间不能大于当前时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.cboTypeByUpdate.SelectedIndex == 1 && Convert.ToDouble(this.txtMoneyByUpdate.Text.Trim()) < 0)
            {
                MessageBox.Show("会员金额不能小于0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.cboTypeByUpdate.SelectedIndex == 0 && Convert.ToDouble(this.txtMoneyByUpdate.Text.Trim()) != 0)
            {
                MessageBox.Show("普通用户金额必须为0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMoneyByUpdate.Text = "0";
                return;
            }
            if (db.UpdateUserInfo(
                this.txtUserNoByUpdate.Text.Trim(),
                this.txtNameByUpdate.Text.Trim(),
                Convert.ToDouble(this.txtMoneyByUpdate.Text.Trim()),
                this.dtFindTimeByUpdate.Value,
                this.txtRemarkByUpdate.Text.Trim(),
                this.cboTypeByUpdate.SelectedIndex + 1
                ) == -1)
            {
                MessageBox.Show("修改失败！请检查用户名是否正确", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("修改操作成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tpUserInfo.SelectedIndex = 0;
            SeachBySql();
            if (UpdateIndex == -1)
            {
                this.txtNameBySeach.Clear();
                SeachBySql();
                return;
            }
            this.dgvUserInfo.FirstDisplayedScrollingRowIndex = UpdateIndex;   //修改的行成为第一行
            this.dgvUserInfo.Rows[UpdateIndex].Selected = true;  //使当前行选中
            this.dgvUserInfo.CurrentCell = this.dgvUserInfo.Rows[UpdateIndex].Cells[0];  //使当前行处于唯一活跃状态
           
        }
        /// <summary>
        /// 清空新增窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearByAdd_Click(object sender, EventArgs e)
        {
            ClearAdd();
        }
        public void ClearAdd()
        {
            this.txtNameByAdd.Clear();
            this.txtIdCardBuAdd.Clear();
            this.txtMoneyByAdd.Clear();
            this.dtFindTimeByAdd.Value = DateTime.Now;
            this.txtRemarkByAdd.Clear();
            this.txtUserNoByAdd.Clear();
            this.cboTypeByAdd.SelectedIndex = 0;
            this.txtNameByAdd.Focus();
        }
        private void btnCancelByAdd_Click(object sender, EventArgs e)
        {
            this.tpUserInfo.SelectedIndex = 0;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveByAdd_Click(object sender, EventArgs e)
        {
            if (this.txtNameByAdd.Text.Trim().Length == 0 || this.txtIdCardBuAdd.Text.Trim().Length == 0 || this.txtUserNoByAdd.Text.Trim().Length == 0 || this.txtMoneyByAdd.Text.Trim().Length == 0)
            {
                MessageBox.Show("信息填写不完整！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.txtIdCardBuAdd.Text.Trim().Length != 18)
            {
                MessageBox.Show("身份证号必须为18位！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.cboTypeByAdd.SelectedIndex == 1 && Convert.ToDouble(this.txtMoneyByAdd.Text.Trim()) <= 0)
            {
                MessageBox.Show("会员注册金额必须大于0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.dtFindTimeByAdd.Value > DateTime.Now)
            {
                MessageBox.Show("时间不能大于当前时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.cboTypeByAdd.SelectedIndex == 0 && Convert.ToDouble(this.txtMoneyByAdd.Text.Trim()) != 0)
            {
                MessageBox.Show("普通用户注册金额必须等于0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMoneyByAdd.Text = "0";
                return;
            }
            else if (db.CheckNoForUserInfo(this.txtUserNoByAdd.Text.Trim()))
            {
                MessageBox.Show("已有此账号，请检查身份证号是否正确", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdCardBuAdd.Clear();
                this.txtUserNoByAdd.Clear();
                return;
            }

            if (db.AddUserInfo(
                this.txtUserNoByAdd.Text.Trim(),
                this.txtNameByAdd.Text.Trim(),
                this.txtIdCardBuAdd.Text.Trim(),
                Convert.ToDouble(this.txtMoneyByAdd.Text.Trim()),
                this.dtFindTimeByAdd.Value,
                this.txtRemarkByAdd.Text.Trim(),
                this.cboTypeByAdd.SelectedIndex + 1
                ) == -1)
            {
                MessageBox.Show("新增失败！可能是系统出现异常或操作有误", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string AddNo = "新增操作成功！您的账号是：" + this.txtUserNoByAdd.Text.Trim() + "  请记好您的账号！";
            MessageBox.Show(AddNo, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SeachBySql();
            ClearAdd();
            this.txtMoneyByAdd.Text = "0";
            SelectedDgvByAdd = true;
        }

        private void tpAdd_Enter(object sender, EventArgs e)
        {
            this.cboTypeByAdd.SelectedIndex = 0;
            this.txtNameByAdd.Focus();
        }
        /// <summary>
        /// 验证金额是否为数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMoneyByUpdate_Leave(object sender, EventArgs e)
        {
            if (this.txtMoneyByUpdate.Text.Trim().Length == 0)
            {
                return;
            }
            double  isMoney = 0;
            try 
	        {	        
		    isMoney = Convert.ToDouble(this.txtMoneyByUpdate.Text.Trim());
	        }
	        catch (Exception)
	        {
		        MessageBox.Show("金额必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMoneyByUpdate.Clear();
                this.txtMoneyByUpdate.Focus();
                return;
	        }
        }
        /// <summary>
        /// 验证金额是否为数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMoneyByAdd_Leave_1(object sender, EventArgs e)
        {
            if (this.txtMoneyByAdd.Text.Trim().Length == 0)
            {
                return;
            }
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(this.txtMoneyByAdd.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("金额必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMoneyByAdd.Clear();
                this.txtMoneyByAdd.Focus();
                return;
            }
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            this.tpUserInfo.SelectedIndex = 2;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (this.dgvUserInfo.SelectedRows.Count == 0)
            {
               this.tsmiUpdate.Enabled = false;
               this.tsmiDelete.Enabled = false;
            }
           else
           {
               this.tsmiUpdate.Enabled = true;
               this.tsmiDelete.Enabled = true;
           }
            
        }

        private void tpSeach_Enter(object sender, EventArgs e)
        {
            this.txtNameBySeach.Focus();
            if (SelectedDgvByAdd == false)
            {
                return;
            }
            UpdateIndex = dgvUserInfo.Rows.Count-1; //把index赋给UpdateIndex
            this.dgvUserInfo.FirstDisplayedScrollingRowIndex = UpdateIndex;   //修改的行成为第一行
            this.dgvUserInfo.Rows[UpdateIndex].Selected = true;  //使当前行选中
            this.dgvUserInfo.CurrentCell = this.dgvUserInfo.Rows[UpdateIndex].Cells[0];  //使当前行处于唯一活跃状态
        }

        private void txtIdCardBuAdd_Leave(object sender, EventArgs e)
        {
            if (this.txtIdCardBuAdd.Text.Trim().Length == 0)
            {
                return;
            }
            else if (this.txtIdCardBuAdd.Text.Trim().Length != 18)
            {

                MessageBox.Show("身份证号必须为十八位！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdCardBuAdd.Clear();
                this.txtUserNoByAdd.Clear();
                this.txtIdCardBuAdd.Focus();
                return;
            }

            Int64 isIdCordForInt = 0;
            string x = "X";
            try
            {
                isIdCordForInt = Convert.ToInt64(this.txtIdCardBuAdd.Text.Trim());
                isIdCordForInt = Convert.ToInt64(this.txtIdCardBuAdd.Text.Trim().Substring(0, 17));
            }
            catch (Exception)
            {
                if (!x.Equals(this.txtIdCardBuAdd.Text.Trim().Substring(17, 1).ToUpper()))
                {
                    MessageBox.Show("请输入合法的身份证号！必须是数字类型或者“X”结尾", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtIdCardBuAdd.Clear();
                    this.txtUserNoByAdd.Clear();
                    this.txtIdCardBuAdd.Focus();
                    return;
                }
            }

            if (db.CheckIdCardForUserInfo(this.txtIdCardBuAdd.Text.Trim()))
            {
                MessageBox.Show("已有此身份证号用户，请检查输入是否正确", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdCardBuAdd.Clear();
                this.txtUserNoByAdd.Clear();
                return;
            }
            else if (db.CheckNoForUserInfo(this.txtUserNoByAdd.Text.Trim()))
            {
                MessageBox.Show("已有此账号，请检查身份证号是否正确", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdCardBuAdd.Clear();
                this.txtUserNoByAdd.Clear();
                return;
            }

            this.txtUserNoByAdd.Text = this.txtIdCardBuAdd.Text.Trim().Substring(12,6) + DateTime.Now.ToString("HHmmss");
        }

        public bool HowShowFrmUserInfo = false;
        private void tsmiShopSum_Click(object sender, EventArgs e)
        {
            frmShopSum fs = new frmShopSum(); ;
            if (HowShowFrmUserInfo)
            {
                fs.Activate();
            }
            else
            {
                fs.Show();
                fs.Activate();
            }
        }

        private void dtFindTimeByAdd_Leave(object sender, EventArgs e)
        {
            if (db.CheckNoForUserInfo(this.txtUserNoByAdd.Text.Trim()))
            {
                MessageBox.Show("已有此账号，请检查身份证号后6位是否正确", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdCardBuAdd.Clear();
                this.txtUserNoByAdd.Clear();
                return;
            }
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void frmUserInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmUserInfo_MouseMove(object sender, MouseEventArgs e)
        {
             if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmUserInfo_MouseUp(object sender, MouseEventArgs e)
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

        private void dtFindTimeByUpdate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now < this.dtFindTimeByUpdate.Value)
            {
                MessageBox.Show("注册时间不能大于系统当前时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtFindTimeByUpdate.Value = DateTime.Now;
                return;
            }
        }

        private void dtFindTimeByAdd_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now < this.dtFindTimeByAdd.Value)
            {
                MessageBox.Show("注册时间不能大于系统当前时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtFindTimeByAdd.Value = DateTime.Now;
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

        private void btnClearByUpdate_MouseHover(object sender, EventArgs e)
        {
            this.btnClearByUpdate.ForeColor = Color.OrangeRed;
        }

        private void btnClearByUpdate_MouseLeave(object sender, EventArgs e)
        {
            this.btnClearByUpdate.ForeColor = Color.Transparent;
        }

        private void btnUpdateByUpdate_MouseHover(object sender, EventArgs e)
        {
            this.btnUpdateByUpdate.ForeColor = Color.OrangeRed;
        }

        private void btnUpdateByUpdate_MouseLeave(object sender, EventArgs e)
        {
            this.btnUpdateByUpdate.ForeColor = Color.Transparent;
        }

        private void btnCancelByUpdate_MouseHover(object sender, EventArgs e)
        {
            this.btnCancelByUpdate.ForeColor = Color.OrangeRed;
        }

        private void btnCancelByUpdate_MouseLeave(object sender, EventArgs e)
        {
            this.btnCancelByUpdate.ForeColor = Color.Transparent;
        }

        private void btnClearByAdd_MouseHover(object sender, EventArgs e)
        {
            this.btnClearByAdd.ForeColor = Color.OrangeRed;
        }

        private void btnClearByAdd_MouseLeave(object sender, EventArgs e)
        {
            this.btnClearByAdd.ForeColor = Color.Transparent;
        }

        private void btnSaveByAdd_MouseHover(object sender, EventArgs e)
        {
            this.btnSaveByAdd.ForeColor = Color.OrangeRed;
        }

        private void btnSaveByAdd_MouseLeave(object sender, EventArgs e)
        {
            this.btnSaveByAdd.ForeColor = Color.Transparent;
        }

        private void btnCancelByAdd_MouseHover(object sender, EventArgs e)
        {
            this.btnCancelByAdd.ForeColor = Color.OrangeRed;
        }

        private void btnCancelByAdd_MouseLeave(object sender, EventArgs e)
        {
            this.btnCancelByAdd.ForeColor = Color.Transparent;
        }

        private void btnDeleteBySeach_MouseHover(object sender, EventArgs e)
        {
            this.btnDeleteBySeach.ForeColor = Color.OrangeRed;
        }

        private void btnDeleteBySeach_MouseLeave(object sender, EventArgs e)
        {
            this.btnDeleteBySeach.ForeColor = Color.Transparent;
        }

        private void btnUpdateBySeach_MouseHover(object sender, EventArgs e)
        {
            this.btnUpdateBySeach.ForeColor = Color.OrangeRed;
        }

        private void btnUpdateBySeach_MouseLeave(object sender, EventArgs e)
        {
            this.btnUpdateBySeach.ForeColor = Color.Transparent;
        }

        private void btnScachBySeach_MouseHover(object sender, EventArgs e)
        {
            this.btnScachBySeach.ForeColor = Color.OrangeRed;
        }

        private void btnScachBySeach_MouseLeave(object sender, EventArgs e)
        {
            this.btnScachBySeach.ForeColor = Color.Transparent;
        }

        private void cboTypeByUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTypeByUpdate.SelectedIndex == 1)
            {
                this.txtMoneyByUpdate.ReadOnly = false;
                this.txtMoneyByUpdate.Clear();
                this.txtMoneyByUpdate.ForeColor = Color.Black;
            }
            else
            {
                this.txtMoneyByUpdate.ReadOnly = true;
                this.txtMoneyByUpdate.ForeColor = Color.Red;
                this.txtMoneyByUpdate.Text = "0";
            }
        }

        private void cboTypeByAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTypeByAdd.SelectedIndex == 1)
            {
                this.txtMoneyByAdd.ReadOnly = false;
                this.txtMoneyByAdd.Clear();
                this.txtMoneyByAdd.ForeColor = Color.Black;
            }
            else
            {
                this.txtMoneyByAdd.ReadOnly = true;
                this.txtMoneyByAdd.ForeColor = Color.Red;
                this.txtMoneyByAdd.Text = "0";
            }
        }

        private void cboTypeBySeach_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeachBySql();
        }

        private void txtNameBySeach_TextChanged(object sender, EventArgs e)
        {
            SeachBySql();
        }

	}
}
