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
    public partial class frmUpdateComputer : Form
    {
        public frmUpdateComputer()
        {
            InitializeComponent();
        }
        public int computerid;
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtComputerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写完整信息！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtComputerID.Text.Trim().Length <= 2)
            {
                MessageBox.Show("电脑名称格式不正确 （XX号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtComputerID.Text.Substring(this.txtComputerID.Text.Trim().Length - 2, 2) != "号机")
            {
                MessageBox.Show("电脑名称格式不正确 （XX号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ComputerByNoSubstring = this.txtComputerID.Text.Substring(0, this.txtComputerID.Text.Trim().Length - 2);
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(ComputerByNoSubstring);
            }
            catch (Exception)
            {
                MessageBox.Show("机子号码必须为数字类型！例如（1号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerID.Clear();
                this.txtComputerID.Focus();
                return;
            }
            if (DBHelper.GetComputerNoByUpdate(this.txtComputerID.Text.Trim(), Convert.ToInt32(this.lblNO.Text.Trim())))
            {
                MessageBox.Show("您的输入有误，该电脑名称已存在！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id =int.Parse(this.lblNO.Text);
            string name = this.txtComputerID.Text.Trim();
            string ip = this.txtComputerIP.Text.Trim();
            int typeid;
            if (this.rbtnKeYong.Checked)
            {
                typeid = 2;
            }
            else if (this.rbtnWeixiu.Checked)
            {
                typeid = 3;
            }
            else
                typeid = 4;

            int sectionid;
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
            if (!DBHelper.UpdateComputer(name, typeid, sectionid, ip, id))
            {
                MessageBox.Show("修改电脑信息失败", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("修改电脑信息成功", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
          
              
        }

        private void frmUpdateComputer_Load(object sender, EventArgs e)
        {
            
            DataTable dt = DBHelper.GetComputerById(this.computerid);
            this.lblNO.Text = dt.Rows[0]["ComputerId"].ToString();
            this.txtComputerID.Text = dt.Rows[0]["ComputerNo"].ToString();
            this.txtComputerIP.Text = dt.Rows[0]["IP"].ToString();
            int typeid =Convert.ToInt32( dt.Rows[0]["TypeId"]);
            if (typeid == 3)
            {
                this.rbtnWeixiu.Checked = true;
            }
            else if (typeid == 4)
            {
                this.rbtnBaofei.Checked = true;
            }
            else
                this.rbtnKeYong.Checked = true;
            int SectionId = Convert.ToInt32(dt.Rows[0]["SectionId"]);
            if (SectionId == 1)
            {
                this.rbtnPTQ.Checked = true;
            }
            else if (SectionId == 2)
            {
                this.rbtnYXQ.Checked = true;
            }
            else if (SectionId == 3)
            {
                this.rbtnSPZQ.Checked = true;
            }
            else if (SectionId == 4)
            {
                this.rbtnQLBJ.Checked = true;
            }
            else if (SectionId == 5)
            {
                this.rbtnXYQ.Checked = true;
            }
            else
                this.rbtnMZPWQ.Checked = true;
            this.rbtnBaofei.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtComputerID_Leave(object sender, EventArgs e)
        {
            if (this.txtComputerID.Text.Trim().Length <= 2)
            {
                MessageBox.Show("电脑名称格式不正确 （XX号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtComputerID.Text.Substring(this.txtComputerID.Text.Trim().Length - 2, 2) != "号机")
            {
                MessageBox.Show("电脑名称格式不正确 （XX号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ComputerByNoSubstring = this.txtComputerID.Text.Substring(0, this.txtComputerID.Text.Trim().Length - 2);
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(ComputerByNoSubstring);
            }
            catch (Exception)
            {
                MessageBox.Show("机子号码必须为数字类型！例如（1号机）", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtComputerID.Clear();
                this.txtComputerID.Focus();
                return;
            }
            if (DBHelper.GetComputerNoByUpdate(this.txtComputerID.Text.Trim(), Convert.ToInt32(this.lblNO.Text.Trim())))
            {
                MessageBox.Show("您的输入有误，该电脑名称已存在！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void frmUpdateComputer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmUpdateComputer_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmUpdateComputer_MouseUp(object sender, MouseEventArgs e)
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

        private void btnClearByAdd_Click(object sender, EventArgs e)
        {
            this.txtComputerID.Clear();
            this.txtComputerIP.Clear();
            this.rbtnPTQ.Checked = true;
            this.rbtnKeYong.Checked = true;
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

        private void btnClose_MouseHover_1(object sender, EventArgs e)
        {
            this.btnClose.ForeColor = Color.OrangeRed;
        }

        private void btnClose_MouseLeave_1(object sender, EventArgs e)
        {
            this.btnClose.ForeColor = Color.Transparent;
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
