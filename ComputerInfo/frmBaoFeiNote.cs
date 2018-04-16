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
    public partial class frmBaoFeiNote : Form
    {
        public frmBaoFeiNote()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void frmBaoFeiNote_Load(object sender, EventArgs e)
        {
            this.cboType.DisplayMember = "SectionName";
            this.cboType.ValueMember = "SectionId";
            this.cboType.DataSource = db.ShowUserType();
            SelectType();
        }
        public void SelectType()
        {
            if (this.cboType.SelectedIndex == 0)
            {
                string sql = string.Format("select ComputerId,ComputerNo,IP,SectionName from Computer as c inner join Section as s on c.SectionId = s.SectionId where c.TypeId = 4");
                this.dgvVip.DataSource = db.ChaXunBaoFeiNote(sql);
            }
            else
            {
                string sql = string.Format("select ComputerId,ComputerNo,IP,SectionName from Computer as c inner join Section as s on c.SectionId = s.SectionId where c.TypeId = 4 and c.SectionId = {0}",this.cboType.SelectedValue);
                this.dgvVip.DataSource = db.ChaXunBaoFeiNote(sql);
            }
            if (this.dgvVip.Rows.Count == 0)
            {
                this.labSums.Text = "报废数量: 0台";
                return;
            }
            this.labSums.Text = "报废数量：" + this.dgvVip.Rows.Count.ToString()+"台";
        }
        private void btnTongJI_Click(object sender, EventArgs e)
        {
            SelectType();
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

        private void btnTongJI_MouseHover(object sender, EventArgs e)
        {
            this.btnTongJI.ForeColor = Color.OrangeRed;
        }

        private void btnTongJI_MouseLeave(object sender, EventArgs e)
        {
            this.btnTongJI.ForeColor = Color.Transparent;
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectType();
        }
    }
}
