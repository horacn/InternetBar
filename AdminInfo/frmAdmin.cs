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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.dgvAdmin.DataSource = DBHelper.SearchAdmin();
        }

        public void SeachAdmin()
        {
            if (this.txtName.Text.Trim().Length == 0)
            {
                this.dgvAdmin.DataSource = DBHelper.SearchAdmin();
            }
            else
            {
                string name = this.txtName.Text;
                dgvAdmin.DataSource = DBHelper.AdminByName(name);
            }
        }
        private void btnSeaech_Click(object sender, EventArgs e)
        {
            SeachAdmin();
        }

        private void msiAddAdmin_Click(object sender, EventArgs e)
        {
            FrmAddAdmin fa = new FrmAddAdmin();
            fa.ShowDialog();
            this.dgvAdmin.DataSource = DBHelper.SearchAdmin();
        }

        private void frmAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void frmAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvAdmin.CurrentRow.Cells["clmName"].Value.ToString().Equals("jbit"))
            {
                MessageBox.Show("超级管理员不能删除！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string isDelete = "您确认要删除账号为 " + this.dgvAdmin.CurrentRow.Cells["clmName"].Value.ToString() + "的管理员吗？";
            if (MessageBox.Show(isDelete, "系统提示 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            if (DBHelper.DeleteAdminById(Convert.ToInt32(this.dgvAdmin.CurrentRow.Cells["clmId"].Value)) == -1)
            {
                MessageBox.Show("系统出现异常，删除失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("删除管理员成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dgvAdmin.DataSource = DBHelper.SearchAdmin();
        }

        private void smiUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (this.dgvAdmin.CurrentRow.Cells["clmName"].Value.ToString().Equals("jbit"))
            {
                MessageBox.Show("超级管理员不能修改！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmUpdateAdmin fu = new frmUpdateAdmin();
           // int UpdateIndex = this.dgvAdmin.CurrentRow.Index;
            fu.isLogin = false;
            fu.id = Convert.ToInt32(this.dgvAdmin.CurrentRow.Cells["clmId"].Value);
            fu.name = this.dgvAdmin.CurrentRow.Cells["clmName"].Value.ToString();
            fu.pwd = this.dgvAdmin.CurrentRow.Cells["clmPwd"].Value.ToString();
            fu.phone = this.dgvAdmin.CurrentRow.Cells["clmPhone"].Value.ToString();
            fu.ShowDialog();
            this.dgvAdmin.DataSource = DBHelper.SearchAdmin();
            //this.dgvAdmin.FirstDisplayedScrollingRowIndex = UpdateIndex;    //修改的行成为第一行
           // this.dgvAdmin.Rows[UpdateIndex].Selected = true;  //使当前行选中
            //this.dgvAdmin.CurrentCell = this.dgvAdmin.Rows[UpdateIndex].Cells[0];  //使当前行处于唯一活跃状态
        }

        private void cmtAdmin_Opening(object sender, CancelEventArgs e)
        {
            if (this.dgvAdmin.RowCount == 0)
            {
                //this.删除ToolStripMenuItem.Enabled = false;
                this.smiUpdateAdmin.Enabled = false;
            }
            else
            {
               // this.删除ToolStripMenuItem.Enabled = true;
                this.smiUpdateAdmin.Enabled = true;
            }
        }

        private void 修改上机价格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateMoneyBySection fm = new frmUpdateMoneyBySection();
            fm.ShowDialog();
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

        private void btnSeaech_MouseHover(object sender, EventArgs e)
        {
            this.btnSeaech.ForeColor = Color.OrangeRed;
        }

        private void btnSeaech_MouseLeave(object sender, EventArgs e)
        {
            this.btnSeaech.ForeColor = Color.Transparent;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SeachAdmin();
        }
    }
}
