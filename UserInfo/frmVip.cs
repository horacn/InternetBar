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
    public partial class FrmVipNote : Form
    {
        public FrmVipNote()
        {
            InitializeComponent();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        DataView dv;
        string rowFilter = string.Empty;
        private void FrmVip_Load(object sender, EventArgs e)
        {
            dv = new DataView();
           dv.Table= DBHelper.SearchVip();
           ShowExamInfo();
        }

        private void ShowExamInfo()
        {
            string id = this.txtVip.Text;
            string name = this.txtName.Text;
            if (id.Trim().Length == 0 && name.Trim().Length == 0)//两个都为空的情况
            {
                //两个都为空意味着筛选条件即为空
                rowFilter = string.Empty;
            }
            else if (id.Trim().Length != 0 && name.Trim().Length != 0)//两个都不为空的情况
            {
                //意味着需要两个筛选条件
                rowFilter = string.Format("UserNo LIKE '%{0}%' AND UserName LIKE '%{1}%'",id.Trim(), name.Trim());
            }
            else if (name.Trim().Length == 0 && id.Trim().Length != 0)
            {
                rowFilter = string.Format("UserNo LIKE '%{0}%'", id.Trim());
            }
            else//根据姓名筛选
            {
                rowFilter = string.Format("UserName LIKE '%{0}%'", name.Trim());
            }
            //将获取到的条件赋值给DV的RowFilter属性
            dv.RowFilter = rowFilter;
            //将DV绑定到datagridview中
            this.dgvVip.DataSource = dv;
        }
  
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            ShowExamInfo();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvVip.RowCount == 0)
            {
                MessageBox.Show("当前表中没有任何数据，不能进行修改操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string id =Convert.ToString (this.dgvVip.CurrentRow.Cells["colUserNo"].Value);
            int UpdateIndex = this.dgvVip.CurrentRow.Index;
            frmUpdateVip fv = new frmUpdateVip();
            fv.id = id;
            fv.ShowDialog();

            dv.Table = DBHelper.SearchVip();
            ShowExamInfo();
            this.dgvVip.FirstDisplayedScrollingRowIndex = UpdateIndex;    //修改的行成为第一行
            this.dgvVip.Rows[UpdateIndex].Selected = true;  //使当前行选中
           // this.dgvVip.CurrentCell = this.dgvVip.Rows[UpdateIndex].Cells[0];  //使当前行处于唯一活跃状态
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddUser fa = new FrmAddUser();
            fa.ShowDialog();
            dv.Table = DBHelper.SearchVip();
            ShowExamInfo();
        }

        private void FrmVipNote_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void FrmVipNote_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void FrmVipNote_MouseDown(object sender, MouseEventArgs e)
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

        private void 充值记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserNote fn = new frmUserNote();
            fn.ShowDialog();
        }


        //当鼠标停留时改变颜色及显示文字
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(button2, "关闭");
            this.button2.BackColor = Color.Red;
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(btnMin, "最小化");
            this.btnMin.BackColor = Color.White;
        }
        //当鼠标停留时恢复颜色及显示文字
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Transparent;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            this.btnMin.BackColor = Color.Transparent;
        }

        private void cmtUpdate_Opening(object sender, CancelEventArgs e)
        {
            if (this.dgvVip.RowCount == 0)
            {
                this.修改ToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.修改ToolStripMenuItem.Enabled = true;
            }
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            this.btnSearch.ForeColor = Color.OrangeRed;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            this.btnSearch.ForeColor = Color.Transparent;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.OrangeRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.Transparent;
        }

        private void txtVip_TextChanged(object sender, EventArgs e)
        {
            ShowExamInfo();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ShowExamInfo();
        }
       
    }
}
