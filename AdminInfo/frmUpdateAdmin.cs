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
    public partial class frmUpdateAdmin : Form
    {
        public frmUpdateAdmin()
        {
            InitializeComponent();
        }

        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        public int id = 0;
        public string name = string.Empty;
        public string pwd = string.Empty;
        public string phone = string.Empty;
        public bool isLogin = true;
        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    this.txtName.Clear();
        //    this.txtpwd.Clear();
        //    this.txtPhone.Clear();
        //}
        DBHelper db = new DBHelper();
       
        private void frmUpdateAdmin_Load(object sender, EventArgs e)
        {
            if (isLogin == false)
            {
                this.txtName.Text = name;
                //this.txtpwd.Text = pwd;
                this.txtPhone.Text = phone;
               // this.txtId.Visible = false;
                //this.label5.Visible = false;
                //this.txtpwd.ReadOnly = true;
            }
        }

        private void frmUpdateAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmUpdateAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmUpdateAdmin_MouseUp(object sender, MouseEventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入管理员账号！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return;
            }
            if (this.txtpwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入原密码！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpwd.Focus();
                return;
            }
            if (this.txtNewpwd.Text.Trim().Length == 0 )
            {
                MessageBox.Show("请输入新密码！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNewpwd.Focus();
                return;
            }
            if (isLogin == false)
            {
                if (this.txtName.Text.Trim() == "jbit")
                {
                    MessageBox.Show("管理员账号不能与超级管理员同名！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtName.Focus();
                    return;
                }
            }
            else
            {
                if (this.txtName.Text.Trim() == "jbit")
                {
                    MessageBox.Show("jbit为系统超级管理员！不允许更改", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtName.Focus();
                    return;
                }
                
            }
            string name = this.txtName.Text.Trim();
            string pwd = this.txtpwd.Text.Trim();
            string phone = this.txtPhone.Text.Trim();
            int msg = 0;
            if (isLogin == false)
            {
                if (db.UpdateAdminById(id, name, this.txtNewpwd.Text.Trim(), phone,pwd,ref msg) == 1)
                {
                    MessageBox.Show("管理员信息修改成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtName.Clear();
                    this.txtPhone.Clear();
                    this.txtNewpwd.Clear();
                    this.Close();
                }
                else
                {
                    if (msg == -2)
                    {
                        MessageBox.Show("账号或密码输入错误！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("系统出现异常，无法修改管理员信息！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (db.UpdateAdminByName(name, this.txtNewpwd.Text.Trim(), phone, pwd,ref msg) == 1)
                {
                    MessageBox.Show("管理员信息修改成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtName.Clear();
                    this.txtPhone.Clear();
                    this.txtNewpwd.Clear();
                    this.Close();
                }
                else
                {
                    if (msg == -2)
                    {
                        MessageBox.Show("账号或密码输入错误！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("系统出现异常，无法修改管理员信息！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
            this.txtPhone.Clear();
            this.txtNewpwd.Clear();
        }
        //当鼠标停留时改变颜色及显示文字
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(button3, "关闭");
            this.button3.BackColor = Color.Red;
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(btnMin, "最小化");
            this.btnMin.BackColor = Color.White;
        }
        //当鼠标停留时恢复颜色及显示文字
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Transparent;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            this.btnMin.BackColor = Color.Transparent;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.OrangeRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.Transparent;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.ForeColor = Color.OrangeRed;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.ForeColor = Color.Transparent;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.OrangeRed;
        }
    }
}
