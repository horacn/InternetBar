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
    public partial class FrmChongZhi : Form
    {
        public FrmChongZhi()
        {
            InitializeComponent();
        }
        double sum = 0;

        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        //根据身份证号来提取其他的信息 
        private void txtIdCard_Leave(object sender, EventArgs e)
        {
            if (this.txtIdCard.Text.Trim().Length == 0)
            {
                return;
            }
            else if (this.txtIdCard.Text.Trim().Length != 18)
            {

                MessageBox.Show("身份证号必须为十八位！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtIdCard.Clear();
                this.txtIdCard.Clear();
                this.txtIdCard.Focus();
                return;
            }
            Int64 isIdcordForInt = 0;
            string x = "X";
            try
            {
                isIdcordForInt = Convert.ToInt64(this.txtIdCard.Text.Trim());
                isIdcordForInt = Convert.ToInt64(this.txtIdCard.Text.Trim().Substring(0, 17));
            }
            catch (Exception)
            {
                if (!x.Equals(this.txtIdCard.Text.Trim().Substring(17, 1).ToUpper()))
                {
                    MessageBox.Show("请输入合法的身份证号！必须是数字类型或者“X”结尾", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtIdCard.Clear();
                    this.txtNo.Clear();
                    this.txtIdCard.Focus();
                    return;
                }
            }
            if (DBHelper.CheckIdCard(this.txtIdCard.Text.Trim()) == false)
            {
                MessageBox.Show("身份证号不存在！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdCard.Clear();
                this.txtIdCard.Focus();
                this.txtNo.Clear();
                this.txtBalance.Clear();
                this.txtName.Clear();
                return;
            }
            if (DBHelper.CheckIdCard2(this.txtIdCard.Text.Trim()) == false)
            {
                MessageBox.Show("你不是会员！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdCard.Clear();
                this.txtIdCard.Focus();
                this.txtNo.Clear();
                this.txtBalance.Clear();
                this.txtName.Clear();
                return;
            }
            string IdCard = this.txtIdCard.Text.Trim();
            SqlDataReader reader = DBHelper.GetVipInfoByID(IdCard);
            if (reader.Read())
            {
                this.txtNo.Text = reader["UserNo"].ToString();
                this.txtName.Text = reader["UserName"].ToString();
                this.txtBalance.Text = reader["Balance"].ToString();

                reader.Close();
            }
            else
            {
                reader.Close();
                return;
            }
           
        }

        private void FrmChongZhi_Load(object sender, EventArgs e)
        {
            this.cboMoney.SelectedIndex = 0;
        }

        //根据
        private void cboMoney_TextChanged(object sender, EventArgs e)
        {

            Money();
        }

        private void btnChongZhi_Click(object sender, EventArgs e)
        {
            if (this.txtIdCard.Text.Trim() != string.Empty)
            {
                if (this.txtSum.Text.Trim() == string.Empty || Convert.ToDouble(this.txtBalance.Text.Trim()) >= Convert.ToDouble(this.txtSum.Text.Trim()))
                {
                    MessageBox.Show("充值金额必须大于0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (this.txtIdCard.Text.Trim() == string.Empty)
            {
                MessageBox.Show("信息填写不完整！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string msg = string.Empty;
            string IdCard = this.txtIdCard.Text.Trim();
            double sum = Convert.ToDouble(this.txtSum.Text);
            if (DBHelper.UpdateBalance(IdCard, sum, ref msg))
            {
                MessageBox.Show("充值成功！余额为" + sum + "元", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Clear();
                this.txtNo.Clear();
                this.txtBalance.Clear();
                this.txtSum.Clear();
                this.txtIdCard.Clear();
                this.cboMoney.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("充值失败！" + msg, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void Money()
        {
            if (this.cboMoney.SelectedIndex > 0 && this.txtIdCard.Text.Length != 0)
            {
                double y = Convert.ToDouble(this.txtBalance.Text);
                double x = Convert.ToDouble(this.cboMoney.Text);
                // MessageBox.Show(x+"\t"+y);
                sum = y + x;
                this.txtSum.Text = Convert.ToString(sum);
            }
            else if (this.txtIdCard.Text.Length != 0)
            {
                this.txtSum.Text = this.txtBalance.Text;
            }
        }

        private void btnQingKong_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
            this.txtNo.Clear();
            this.txtBalance.Clear();
            this.txtSum.Clear();
            this.txtIdCard.Clear();
            this.cboMoney.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.OrangeRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.Transparent;
        }

        private void btnChongZhi_MouseHover(object sender, EventArgs e)
        {
            this.btnChongZhi.ForeColor = Color.OrangeRed;
        }

        private void btnChongZhi_MouseLeave(object sender, EventArgs e)
        {
            this.btnChongZhi.ForeColor = Color.Transparent;
        }

        private void btnQingKong_MouseHover(object sender, EventArgs e)
        {
            this.btnQingKong.ForeColor = Color.OrangeRed;
        }

        private void btnQingKong_MouseLeave(object sender, EventArgs e)
        {
            this.btnQingKong.ForeColor = Color.Transparent;
        }
    
    }
}
