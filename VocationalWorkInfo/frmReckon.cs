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
    public partial class frmReckon : Form
    {
        public int ComputerID;
        public double Price;
        public frmReckon()
        {
            InitializeComponent();
        }


        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReckon_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DBHelper.GetNote(ComputerID);
            reader.Read();
            this.txtNo.Text = reader["UserNo"].ToString();
            this.txtBeginTime.Text = reader["BeginTime"].ToString();
            this.txtType.Text = reader["Name"].ToString();
            this.txtSubmitPrice.Text = reader["SubmitPrice"].ToString();
            reader.Close();
            this.txtComputerId.Text = DBHelper.SelById(ComputerID);
            SqlDataReader reader1 = DBHelper.SelectUserNote(ComputerID);
            reader1.Read();
            DateTime dt1 = Convert.ToDateTime(reader1["BeginTime"]);
            DateTime dt2 = DateTime.Now;
            TimeSpan ts = dt2 - dt1;
            int hours = Convert.ToInt32(ts.TotalHours);
            if (ts.TotalHours % 1 > 0)
            {
                hours++;
            }
            string no = reader1["UserNo"].ToString();
            double SubmitPrice = Convert.ToDouble(reader1["SubmitPrice"]);
            reader1.Close();
            double price = SubmitPrice - hours * DBHelper.GetSectionPrice(ComputerID) * DBHelper.GetDiscount(no);
            this.txtYSPrice.Text = (hours * DBHelper.GetSectionPrice(ComputerID) * DBHelper.GetDiscount(no)).ToString();
            this.txtSXPrice.Text = price.ToString();
            this.Price = price;
        }

        private void btnOK_Click(object sender, EventArgs e)
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
            DBHelper.AddEndDate(DateTime.Now, ComputerID);
            DBHelper.UpdateIsOk(0, DBHelper.GetCard(ComputerID));
            MessageBox.Show("找零" + Price + "元", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBHelper.ActualPrice(hours * DBHelper.GetSectionPrice(ComputerID) * DBHelper.GetDiscount(no), ComputerID);;
            DBHelper.UpdateUserPrice(hours * DBHelper.GetSectionPrice(ComputerID) * DBHelper.GetDiscount(no), no);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReckon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmReckon_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmReckon_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
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

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            this.btnOK.ForeColor = Color.OrangeRed;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            this.btnOK.ForeColor = Color.Transparent;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            this.btnCancel.ForeColor = Color.OrangeRed;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            this.btnCancel.ForeColor = Color.Transparent;
        }
    }
}
