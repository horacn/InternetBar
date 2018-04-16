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
	public partial class frmAddComputer : Form
	{
		public frmAddComputer()
		{
			InitializeComponent();
		}
        //DataView dv;
        DBHelper db = new DBHelper();
		private void btnAdd_Click(object sender, EventArgs e)
		{
            if (this.txtComputerId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写完整信息！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            if (this.txtComputerId.Text.Trim().Length <= 2)
            {
                MessageBox.Show("电脑名称格式不正确 （XX号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                return;
            }
            if (this.txtComputerId.Text.Substring(this.txtComputerId.Text.Trim().Length - 2, 2) != "号机")
            {
                MessageBox.Show("电脑名称格式不正确 （XX号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                return;
            }
            string ComputerByNoSubstring = this.txtComputerId.Text.Substring(0, this.txtComputerId.Text.Trim().Length - 2);
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(ComputerByNoSubstring);
            }
            catch (Exception)
            {
                MessageBox.Show("机子号码必须为数字类型！例如（1号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                this.txtComputerId.Focus();
                return;
            }
            if (DBHelper.GetComputerNo(this.txtComputerId.Text.Trim()))
            {
                MessageBox.Show("您的输入有误，该电脑名称已存在！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                return;
            }
			string name = this.txtComputerId.Text.Trim();
			string ip = this.txtComputerIP.Text.Trim();
            int typeid = 2;
            int  sectionid;
            if (this.rbtnPTQ.Checked)
            {
                sectionid = 1;
            }
            else if (this.rbtnYXQ.Checked)
            {
                sectionid = 2;
            }
            else if (this.rbtnSPZQ.Checked)
            {
                sectionid = 3;
            }
            else if (this.rbtnQLBJ.Checked)
            {
                sectionid = 4;
            }
            else if (this.rbtnXYQ.Checked)
            {
                sectionid = 5;
            }
            else
            {
                sectionid = 6;
            }
            if (DBHelper.ADDComputer(name, typeid, sectionid, ip))
            {
                MessageBox.Show("新增电脑成功", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                this.txtComputerIP.Clear();
                this.rbtnPTQ.Checked = true;
            }
            else
                MessageBox.Show("新增电脑失败", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            
              
			
		}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtComputerId.Clear();
            this.txtComputerIP.Clear();
            this.rbtnPTQ.Checked = true;
        }

        private void txtComputerId_Leave(object sender, EventArgs e)
        {
            if (this.txtComputerId.Text.Trim().Length <= 2)
            {
                MessageBox.Show("电脑名称格式不正确 （XX号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                return;
            }
            if (this.txtComputerId.Text.Substring(this.txtComputerId.Text.Trim().Length - 2, 2) != "号机")
            {
                MessageBox.Show("电脑名称格式不正确 （XX号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                return;
            }
            string ComputerByNoSubstring = this.txtComputerId.Text.Substring(0, this.txtComputerId.Text.Trim().Length - 2);
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(ComputerByNoSubstring);
            }
            catch (Exception)
            {
                MessageBox.Show("机子号码必须为数字类型！例如（1号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                this.txtComputerId.Focus();
                return;
            }
            if (DBHelper.GetComputerNo(this.txtComputerId.Text.Trim()))
            {
                MessageBox.Show("您的输入有误，该电脑名称已存在！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerId.Clear();
                return;
            }
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void frmAddComputer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmAddComputer_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmAddComputer_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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


        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            this.btnClear.ForeColor = Color.OrangeRed;
        }

        private void btnClose_MouseHover_1(object sender, EventArgs e)
        {
            this.btnClose.ForeColor = Color.OrangeRed;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            this.btnAdd.ForeColor = Color.OrangeRed;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            this.btnAdd.ForeColor = Color.Transparent;
        }

        private void btnClose_MouseLeave_1(object sender, EventArgs e)
        {
            this.btnClose.ForeColor = Color.Transparent;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            this.btnClear.ForeColor = Color.Transparent;
        }
	}
}
