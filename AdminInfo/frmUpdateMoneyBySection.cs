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
    public partial class frmUpdateMoneyBySection : Form
    {
        public frmUpdateMoneyBySection()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void frmUpdateMoneyBySection_Load(object sender, EventArgs e)
        {
            if (db.ChaXunJiaGe() == null)
            {
                MessageBox.Show("系统出现异常，无法显示数据！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
            this.dgvXGPrice.DataSource = db.ChaXunJiaGe();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtQuYu.Text.Trim().Length == 0)
            {
                MessageBox.Show("价格不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.txtQuYu.Focus();
                return;

            }
            double isMoney = 0;
            try
            {
                isMoney = Convert.ToDouble(this.txtQuYu.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("价格必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtQuYu.Clear();
                this.txtQuYu.Focus();
                return;
            }
            if (Convert.ToDouble(this.txtQuYu.Text.Trim()) <= 0)
            {
                MessageBox.Show("价格必须大于0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.txtQuYu.Focus();
                return;

            }
            int UpdateIndex = this.dgvXGPrice.CurrentRow.Index;
            if (db.UpdateJiaGe(Convert.ToDouble(this.txtQuYu.Text.Trim()), Convert.ToInt32(this.dgvXGPrice.CurrentRow.Cells["ClmId"].Value)) == -1)
            {
                MessageBox.Show("系统出现异常，修改失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string XinXi = "修改成功！ " + this.dgvXGPrice.CurrentRow.Cells["ColName"].Value.ToString() + "的价格为：" + this.txtQuYu.Text.Trim() + "元";
            MessageBox.Show(XinXi, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtQuYu.Clear();
            if (db.ChaXunJiaGe() == null)
            {
                MessageBox.Show("系统出现异常，无法显示数据！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.dgvXGPrice.DataSource = db.ChaXunJiaGe();
            this.dgvXGPrice.FirstDisplayedScrollingRowIndex = UpdateIndex;    //修改的行成为第一行
            this.dgvXGPrice.Rows[UpdateIndex].Selected = true;  //使当前行选中
            //this.dgvXGPrice.CurrentCell = this.dgvXGPrice.Rows[UpdateIndex].Cells[0];  //使当前行处于唯一活跃状态
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

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.ForeColor = Color.OrangeRed;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.ForeColor = Color.Transparent;
        }
    }
}
