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
    public partial class FrmAddAdmin : Form
    {
        public FrmAddAdmin()
        {
            InitializeComponent();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text.Trim().Length == 0)
            {
                 MessageBox.Show("管理员账号不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.txtName.Focus();
                 return;
            }
            if (this.txtpwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("管理员密码不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpwd.Focus();
                return;
            }
            if (this.txtName.Text.Trim() == "jbit")
            {
                MessageBox.Show("管理员账号不能与超级管理员同名！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return;
            }
            string name = this.txtName.Text.Trim();
            string pwd = this.txtpwd.Text.Trim();
            string phone = this.txtPhone.Text.Trim();
            string msg = string.Empty;
            if (DBHelper.AddAdmin(name,pwd,phone,ref msg))
            {
                MessageBox.Show("添加管理员成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Clear();
                this.txtPhone.Clear();
                this.txtpwd.Clear();
            }
            else
            {
                MessageBox.Show("添加管理员失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
            this.txtpwd.Clear();
            this.txtPhone.Clear();
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {

        }

        private void FrmAddAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void FrmAddAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void FrmAddAdmin_MouseUp(object sender, MouseEventArgs e)
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
            this.Close();
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
        //当鼠标停留时恢复颜色
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            this.btnMin.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            this.btnClear.ForeColor = Color.OrangeRed;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.OrangeRed;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.OrangeRed;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            this.btnClear.ForeColor = Color.Transparent;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.Transparent;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.Transparent;
        }
       
    }
}
