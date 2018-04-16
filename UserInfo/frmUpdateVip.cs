using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InternetBar
{
    public partial class frmUpdateVip : Form
    {
        public frmUpdateVip()
        {
            InitializeComponent();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        public string id;
        private void frmUpdateVip_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DBHelper.GetVipByID(this.id);
            if (reader == null)
            {
                MessageBox.Show("系统出现异常！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (reader.Read())
            {
                //将读取到的信息显示到窗体之上
                this.labId.Text = reader["UserNo"].ToString();
                this.txtName.Text = reader["UserName"].ToString();
                this.txtMoney.Text = reader["Balance"].ToString();
                this.labFound.Text = reader["Foundtime"].ToString();
                this.labIdCard.Text = reader["IdCard"].ToString();
                this.txtRemark.Text = reader["Remark"].ToString();
            }
            reader.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtMoney.Text.Trim().Length == 0 || this.txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("信息填写不完整！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string userName = this.txtName.Text.Trim();
            double balance =Convert.ToDouble(this.txtMoney.Text.Trim());
            string remark = this.txtRemark.Text.Trim();
            string msg = string.Empty;
            if (DBHelper.UpdateUser(userName,balance,remark,id,ref msg))
            {
                MessageBox.Show("修改成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("修改失败" + msg, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateVip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmUpdateVip_MouseMove(object sender, MouseEventArgs e)
        {

            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmUpdateVip_MouseUp(object sender, MouseEventArgs e)
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

        private void txtMoney_Leave(object sender, EventArgs e)
        {

            if (this.txtMoney.Text.Trim().Length == 0)
            {
                return;
            }
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(this.txtMoney.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("金额必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMoney.Clear();
                this.txtMoney.Focus();
                return;
            }
        }

        private void btnClearByAdd_Click(object sender, EventArgs e)
        {
            this.txtMoney.Clear();
            this.txtName.Clear();
            this.txtRemark.Clear();
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

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.OrangeRed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.Transparent;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.OrangeRed;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.Transparent;
        }

        private void btnClearByAdd_MouseHover(object sender, EventArgs e)
        {
            this.btnClearByAdd.ForeColor = Color.OrangeRed;
        }

        private void btnClearByAdd_MouseLeave(object sender, EventArgs e)
        {
            this.btnClearByAdd.ForeColor = Color.Transparent;
        }
    }
}
