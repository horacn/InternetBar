using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetBar
{
    public partial class frmStartComputer : Form
    {
        
        public frmStartComputer()
        {
            InitializeComponent();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        public int ComputerId;
        private void frmStartComputer_Load(object sender, EventArgs e)
        {
        }
      
   
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //清空开卡的信息
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtCard.Clear();
            this.txtName.Clear();
            this.txtPrice.Clear();
            this.lbName.Text = "普通用户";
        }
        //上机验证
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtCard.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入身份证号码！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtCard.Text.Trim().Length != 18)
            {

                MessageBox.Show("身份证号必须为十八位！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCard.Clear();
                this.txtCard.Clear();
                this.txtCard.Focus();
                return;
            }
            Int64 isIdCordForInt = 0;
            string x = "X";
            try
            {
                isIdCordForInt = Convert.ToInt64(this.txtCard.Text.Trim());
                isIdCordForInt = Convert.ToInt64(this.txtCard.Text.Trim().Substring(0, 17));
            }
            catch (Exception)
            {
                if (!x.Equals(this.txtCard.Text.Trim().Substring(17, 1).ToUpper()))
                {
                    MessageBox.Show("身份证号必须为数字类型,或以“X”结尾", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCard.Clear();
                    this.txtCard.Clear();
                    this.txtCard.Focus();
                    return;
                }
            }
            if (this.txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入姓名", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return;
            }
            if (this.txtName.Text.Trim().Length > 4)
            {
                MessageBox.Show("请输入正确的姓名", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return;
            }
            if (this.txtPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入预交金额", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPrice.Focus();
                return;
            }
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(this.txtPrice.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("金额必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPrice.Clear();
                this.txtPrice.Focus();
                return;
            }
            if (Convert.ToDouble(this.txtPrice.Text) < 1)
            {
                MessageBox.Show("预交金额不能小于1元", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPrice.Focus();
                return;
            }
            if (DBHelper.IsOkComputer(this.txtCard.Text.Trim().ToString()) == 1)
            {
                MessageBox.Show("该用户正已经开机,不能重复开机", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SelectCard(this.txtCard.Text.Trim().ToString()) == 1)
            {
            }
            else
            {
                if (DBHelper.AddUsers(this.txtCard.Text.Trim().Substring(12, 6)+ DateTime.Now.ToString("HHmmss"), this.txtName.Text.ToString(), this.txtCard.Text.ToString(), DateTime.Now, this.lbName.Text == "普通用户" ? 1 : 2) == 1)
                {
                }
                else
                {
                    MessageBox.Show("添加用户失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DBHelper.AddUserNote(DBHelper.SelectUserIdByCard(this.txtCard.Text.ToString()), ComputerId, DateTime.Now, Convert.ToDouble(this.txtPrice.Text.Trim()));
            DBHelper.UpdateIsOk(1,this.txtCard.Text.Trim().ToString());
            this.DialogResult = DialogResult.OK;

        }

        private void txtCard_Leave(object sender, EventArgs e)
        {
            if (this.txtCard.Text.Trim().Length == 0)
            {
                return;
            }
            else if (this.txtCard.Text.Trim().Length != 18)
            {

                MessageBox.Show("身份证号必须为十八位！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCard.Clear();
                this.txtCard.Clear();
                this.txtCard.Focus();
                return;
            }
            Int64 isIdCordForInt = 0;
            string x = "X";
            try
            {
                isIdCordForInt = Convert.ToInt64(this.txtCard.Text.Trim());
                isIdCordForInt = Convert.ToInt64(this.txtCard.Text.Trim().Substring(0, 17));
            }
            catch (Exception)
            {
                if (!x.Equals(this.txtCard.Text.Trim().Substring(17, 1).ToUpper()))
                {
                    MessageBox.Show("身份证号必须为数字类型,或以“X”结尾", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCard.Clear();
                    this.txtCard.Clear();
                    this.txtCard.Focus();
                    return;
                }
            }
            SqlDataReader reader = DBHelper.SelectUserByCid(this.txtCard.Text.Trim());
            if (reader.Read())
            {
                this.txtName.Text = reader["UserName"].ToString();
                this.txtPrice.Text = reader["Balance"].ToString();
                this.lbName.Text = reader["Name"].ToString();
                reader.Close();
            }
            else
            {
                this.lbName.Text = "普通用户";
                this.txtPrice.Text = "";
                this.txtName.Text = "";
                reader.Close();
                return;
            }

        }

        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmStartComputer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmStartComputer_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmStartComputer_MouseUp(object sender, MouseEventArgs e)
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

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (this.txtPrice.Text.Trim().Length == 0)
            {
                return;
            }
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(this.txtPrice.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("金额必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPrice.Clear();
                this.txtPrice.Focus();
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
