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
    public partial class frmAddPrice : Form
    {
        public string no;
        public int ComputerID;
        public frmAddPrice()
        {
            InitializeComponent();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtAddPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("充值金额不能为空", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtAddPrice.Focus();
                return;
            }
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(this.txtAddPrice.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("金额必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtAddPrice.Clear();
                this.txtAddPrice.Focus();
                return;
            }
            DBHelper.AddPrice(Convert.ToDouble(this.txtAddPrice.Text.Trim()), ComputerID);
            DBHelper.UserAddPrice(Convert.ToDouble(this.txtAddPrice.Text), no);
            MessageBox.Show("续费成功~","系统提示");
            this.Close();

        }

        private void frmAddPrice_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void frmAddPrice_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmAddPrice_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
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

        private void btnOk_MouseHover(object sender, EventArgs e)
        {
            this.btnOk.ForeColor = Color.OrangeRed;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            this.btnOk.ForeColor = Color.Transparent;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.OrangeRed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.Transparent;
        }
    }
}
