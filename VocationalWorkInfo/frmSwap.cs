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
    public partial class frmSwap : Form
    {
        public int ComputerID;
        public frmSwap()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmSwap_Load(object sender, EventArgs e)
        {
            //给下拉框绑定显示值和隐藏值
            this.cboComputer.DisplayMember = "ComputerNo";
            this.cboComputer.ValueMember = "ComputerId";
            this.cboComputer.DataSource = DBHelper.SelctComputer();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = DBHelper.SelectUserNote(ComputerID);
            reader.Read();
            DateTime dt1 = Convert.ToDateTime(reader["BeginTime"]);
            DateTime dt2 = DateTime.Now;
            TimeSpan ts = dt2 - dt1;
            int hours = Convert.ToInt32(ts.TotalHours);
            if (ts.TotalHours % 1 > 0)
            {
                hours++;
            }
            string no = reader["UserNo"].ToString();
            double SubmitPrice = Convert.ToDouble(reader["SubmitPrice"]);
            reader.Close();
            DBHelper.ActualPrice(hours * DBHelper.GetSectionPrice(ComputerID) * DBHelper.GetDiscount(no), ComputerID);
            double price = SubmitPrice - hours * DBHelper.GetSectionPrice(ComputerID) * DBHelper.GetDiscount(no);
            if (price <= 0)
            {
                MessageBox.Show("您的余额不足，不能换机","系统提醒 ");
                return;
            }
            DBHelper.AddEndDate(DateTime.Now, ComputerID);
            DBHelper.UpdateType(2, ComputerID);
            DBHelper.UpdateType(1, Convert.ToInt32(this.cboComputer.SelectedValue));
            DBHelper.UpdateUserPrice(hours * DBHelper.GetSectionPrice(ComputerID) * DBHelper.GetDiscount(no), no);
            DBHelper.AddUserNote(no, Convert.ToInt32(this.cboComputer.SelectedValue), DateTime.Now, price);
            this.Close();
            
        }

        private void cboComputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader = DBHelper.SelSectionById(Convert.ToInt32(this.cboComputer.SelectedValue));
            reader.Read();
            this.lbPrice.Text = reader["SectionPrice"].ToString() + "元";
            this.lbSection.Text = reader["SectionName"].ToString();
            reader.Close();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void frmSwap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmSwap_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmSwap_MouseUp(object sender, MouseEventArgs e)
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

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.OrangeRed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.Transparent;
        }

        private void btnOk_MouseHover(object sender, EventArgs e)
        {
            this.btnOk.ForeColor = Color.OrangeRed;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            this.btnOk.ForeColor = Color.Transparent;
        }
    }
}
