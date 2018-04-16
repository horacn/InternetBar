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
    public partial class frmSelectComputer : Form
    {
        DataView dv;
        public frmSelectComputer()
        {
            InitializeComponent();
        }

        private void frmSelectComputer_Load(object sender, EventArgs e)
        {
            this.dgv.DataSource = DBHelper.ShowComputer();
        }

        private void tsbtnInster_Click(object sender, EventArgs e)
        {
            frmAddComputer fac = new frmAddComputer();
            fac.ShowDialog();
            dv = new DataView(DBHelper.ShowComputer());
            this.dgv.DataSource = dv;
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgv.RowCount == 0)
            {
                MessageBox.Show("当前列表没有数据，不能报废电脑！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //报废电脑方法
            DialogResult dr = MessageBox.Show("您确定要将" + this.dgv.CurrentRow.Cells["ColComputerNo"].Value.ToString() + "报废吗？", "系统提示 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No)
                return;
            int ComputerId = Convert.ToInt32(this.dgv.CurrentRow.Cells["ColComputerID"].Value);
            string msg = string.Empty;
            DBHelper db = new DBHelper();
            if (db.UpdateComputerType(ComputerId, ref msg) == true)
            {
                MessageBox.Show("报废电脑成功!", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (msg == "失败")
                {
                    MessageBox.Show("可能是您的操作有误，报废电脑失败!", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("系统出现异常，报废电脑失败!", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.dgv.DataSource = DBHelper.ShowComputer();
         
        }


        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        private void tsbtnSelUserNote_Click(object sender, EventArgs e)
        {
            frmUserNote fun = new frmUserNote();
            fun.Show();
        }

        private void tsbtnUpdata_Click(object sender, EventArgs e)
        {
            if (this.dgv.RowCount == 0)
            {
                MessageBox.Show("当前列表没有数据，不能修改！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int UpdateIndex = this.dgv.CurrentRow.Index;
            int id = Convert.ToInt32(this.dgv.CurrentRow.Cells["ColComputerID"].Value);
            frmUpdateComputer fuc = new frmUpdateComputer();
            fuc.computerid = id;
            fuc.ShowDialog();
            this.dgv.DataSource = DBHelper.ShowComputer();
            this.dgv.FirstDisplayedScrollingRowIndex = UpdateIndex;    //修改的行成为第一行
            this.dgv.Rows[UpdateIndex].Selected = true;  //使当前行选中
            //this.dgv.CurrentCell = this.dgv.Rows[UpdateIndex].Cells[0];  //使当前行处于唯一活跃状态
        }

        private void frmSelectComputer_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void frmSelectComputer_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmSelectComputer_MouseDown(object sender, MouseEventArgs e)
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (this.dgv.Rows.Count == 0)
            {
                this.tsbtnUpdata.Enabled = false;
                this.删除ToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.tsbtnUpdata.Enabled = true;
                this.删除ToolStripMenuItem.Enabled = true;
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

        private void 报废记录统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoFeiNote fb = new frmBaoFeiNote();
            fb.ShowDialog();
        }
    }
}
