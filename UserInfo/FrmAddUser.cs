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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtcard.Text.Trim().Length != 18)
            {
                MessageBox.Show("身份证号必须为18位！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtname.Text.Trim().Length ==0 )
            {
                MessageBox.Show("会员姓名不允许为空哦！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtpwd.Text.Trim().Length <3)
            {
                MessageBox.Show("会员密码必须三位以上哦！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            if (this.txtMoney.Text.Trim().Length != 0)
            {
                if (Convert.ToInt32(this.txtMoney.Text.Trim()) < 20)
                {
                    MessageBox.Show("预交费不能少于20哦！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Focus();
                    return;
                }
               
            }
            else
            {
                MessageBox.Show("金额不能为空哦！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string userno = this.txtcard.Text.Trim().Substring(12, 6) + DateTime.Now.ToString("HHmmss");
            string name = this.txtname.Text.Trim();
            string cardpwd = this.txtpwd.Text.Trim();
            string idcard = this.txtcard.Text.Trim();
            DateTime found = dateTimePicker1.Value;
            double balance= Convert.ToDouble(this.txtMoney.Text.Trim());
            int Id = 2;
            string remark = this.txtRemark.Text.Trim();
            string msg = string.Empty;
            if (DBHelper.AddUser(userno, cardpwd, name, idcard, balance, found, remark, Id, ref msg))
            {
                MessageBox.Show("添加会员成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtname.Clear();
                this.txtcard.Clear();
                this.txtpwd.Clear();
                this.txtMoney.Clear();
                this.txtRemark.Clear();
                this.dateTimePicker1.Value = DateTime.Now;
                this.txtId.Clear();
            }
            else
            {
                MessageBox.Show("添加会员失败！" + msg, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtname.Clear();
            this.txtcard.Clear();
            this.txtpwd.Clear();
            this.txtMoney.Clear();
            this.txtRemark.Clear();
            this.dateTimePicker1.Value = DateTime.Now;
            this.txtId.Clear();
 
        }


        private void txtcard_Leave(object sender, EventArgs e)
        {
            if (this.txtcard.Text.Trim().Length == 0)
            {
                return;
            }
            else if (this.txtcard.Text.Trim().Length != 18)
            {
                MessageBox.Show("身份证号必须为18位！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtcard.Clear();
                this.txtId.Clear();
                this.txtcard.Focus();
                return;
            }
            Int64 isIdcordForInt = 0;
            string x = "X";
            try
            {
                isIdcordForInt = Convert.ToInt64(this.txtcard.Text.Trim());
                isIdcordForInt = Convert.ToInt64(this.txtcard.Text.Trim().Substring(0, 17));
            }
            catch (Exception)
            {
                if (!x.Equals(this.txtcard.Text.Trim().Substring(17, 1).ToUpper()))
                {
                    MessageBox.Show("请输入合法的身份证号！必须是数字类型或者“X”结尾", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtcard.Clear();
                    this.txtId.Clear();
                    this.txtcard.Focus();
                    return;
                }
            }
            if (DBHelper.CheckIdCard(this.txtcard.Text.Trim()))
            {
                MessageBox.Show("身份证号已经存在！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtcard.Clear();
                this.txtId.Clear();
                return;
            }

            this.txtId.Text = this.txtcard.Text.Trim().Substring(12, 6) + DateTime.Now.ToString("HHmmss");
        }

        private void FrmAddUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }   
        }

        private void FrmAddUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void FrmAddUser_MouseUp(object sender, MouseEventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now < this.dateTimePicker1.Value)
            {
                MessageBox.Show("注册时间不能大于系统当前时间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dateTimePicker1.Value = DateTime.Now;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.OrangeRed;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.OrangeRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.Transparent;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            this.btnClear.ForeColor = Color.OrangeRed;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            this.btnClear.ForeColor = Color.Transparent;
        }
    }
}
