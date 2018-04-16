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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您确定要取消登录吗？", "系统提示 ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Close();
			}
		}
		/// <summary>
		/// 登陆验证
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnLogin_Click(object sender, EventArgs e)
		{
            if (this.txtLoginName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入管理员账号", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtLoginName.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入管理员密码", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtLoginPwd.Focus();
                return;
            }
            string msg = string.Empty;
            if (DBHelper.CheckLogin(this.txtLoginName.Text.Trim(), this.txtLoginPwd.Text.Trim(), ref msg))
            {
                frmMain fm = new frmMain();
                fm.frmLogin = this;
                fm.Show();
                this.Hide();
            }
            else
            {
                if (msg == string.Empty)
                {
                    MessageBox.Show("账号或密码输入错误！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("系统出现异常", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
		}

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要取消登录吗？", "系统提示 ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmAddAdmin fd = new FrmAddAdmin();
            fd.ShowDialog();
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            frmUpdateAdmin fu = new frmUpdateAdmin();
            fu.ShowDialog();
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

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.ForeColor = Color.OrangeRed;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.ForeColor = Color.Transparent;
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            this.btnRegister.ForeColor = Color.OrangeRed;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            this.btnRegister.ForeColor = Color.Transparent;
        }

        private void btnUpdatePwd_MouseHover(object sender, EventArgs e)
        {
            this.btnUpdatePwd.ForeColor = Color.OrangeRed;
        }

        private void btnUpdatePwd_MouseLeave(object sender, EventArgs e)
        {
            this.btnUpdatePwd.ForeColor = Color.Transparent;
        }
	}
}
