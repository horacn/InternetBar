using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetBar;

namespace InternetBar
{
    public partial class frmMain : Form
    {
        private string SectionName;
        public string sql;
        public frmLogin frmLogin;
        private bool isExit = true;//默认退出
        public frmMain()
        {
            InitializeComponent();
        }
       
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        public void Clear()
        {
            this.lbName.Text = string.Empty;
            this.lbType.Text = string.Empty;
            this.lbTooTime.Text = string.Empty;
            this.lbSPrice.Text = string.Empty;
            this.lbSYPrice.Text = string.Empty;
            this.lbSYTime.Text = string.Empty;
            this.lbUser.Text = string.Empty;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SectionName = "妹子陪玩区";
            this.txtType.Text = SectionName;
            Clear();
            ShowComputerIcon(Convert.ToInt32(this.btnHide.Tag));
            ShowComputer();
            this.btnHide.ForeColor = Color.OrangeRed;
            this.btnPu.ForeColor = Color.Transparent;
            this.btnSmoke.ForeColor = Color.Transparent;
            this.btnMV.ForeColor = Color.Transparent;
            this.btnGame.ForeColor = Color.Transparent;
            this.btnLove.ForeColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SectionName = "吸烟区";
            this.txtType.Text = SectionName;
            Clear();
            ShowComputerIcon(Convert.ToInt32(this.btnSmoke.Tag));
            ShowComputer();
            this.btnSmoke.ForeColor = Color.OrangeRed;
            this.btnPu.ForeColor = Color.Transparent;
            this.btnHide.ForeColor = Color.Transparent;
            this.btnMV.ForeColor = Color.Transparent;
            this.btnGame.ForeColor = Color.Transparent;
            this.btnLove.ForeColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SectionName = "情侣包间";
            this.txtType.Text = SectionName;
            Clear();
            ShowComputerIcon(Convert.ToInt32(this.btnLove.Tag));
            ShowComputer();
            this.btnLove.ForeColor = Color.OrangeRed;
            this.btnPu.ForeColor = Color.Transparent;
            this.btnHide.ForeColor = Color.Transparent;
            this.btnMV.ForeColor = Color.Transparent;
            this.btnGame.ForeColor = Color.Transparent;
            this.btnSmoke.ForeColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SectionName = "视频专区";
            this.txtType.Text = SectionName;
            Clear();
            ShowComputerIcon(Convert.ToInt32(this.btnMV.Tag));
            ShowComputer();
            this.btnMV.ForeColor = Color.OrangeRed;
            this.btnPu.ForeColor = Color.Transparent;
            this.btnHide.ForeColor = Color.Transparent;
            this.btnLove.ForeColor = Color.Transparent;
            this.btnGame.ForeColor = Color.Transparent;
            this.btnSmoke.ForeColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SectionName = "游戏专区";
            this.txtType.Text = SectionName;
            Clear();
            ShowComputerIcon(Convert.ToInt32(this.btnGame.Tag));
            ShowComputer();
            this.btnGame.ForeColor = Color.OrangeRed;
            this.btnPu.ForeColor = Color.Transparent;
            this.btnHide.ForeColor = Color.Transparent;
            this.btnLove.ForeColor = Color.Transparent;
            this.btnMV.ForeColor = Color.Transparent;
            this.btnSmoke.ForeColor = Color.Transparent;
        }
        //显示电脑信息的方法
        private void ShowComputerIcon(int id)
        {
            SqlDataReader reader = DBHelper.SelBySection(id);
            this.lvComputer.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader["ComputerNo"].ToString(), 0);
                lvi.Tag = reader["ComputerId"];
                this.lvComputer.Items.Add(lvi);
            }
            reader.Close();
            ShowComputer();
        }
        public void ShowComputer()
        {
            foreach (ListViewItem l in lvComputer.Items)
            {
                if (DBHelper.SeleteType(Convert.ToInt32(l.Tag)) == "已用")
                {
                    l.ImageIndex = 1;
                }
                if (DBHelper.SeleteType(Convert.ToInt32(l.Tag)) == "可用")
                {
                    l.ImageIndex = 0;
                }
                if (DBHelper.SeleteType(Convert.ToInt32(l.Tag)) == "维修中")
                {
                    l.ImageIndex = 2;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SectionName = "普通区";
            this.txtType.Text = SectionName;
            Clear();
            ShowComputerIcon(Convert.ToInt32(this.btnPu.Tag));
            this.btnPu.ForeColor = Color.OrangeRed;
            this.btnGame.ForeColor = Color.Transparent;
            this.btnHide.ForeColor = Color.Transparent;
            this.btnLove.ForeColor = Color.Transparent;
            this.btnMV.ForeColor = Color.Transparent;
            this.btnSmoke.ForeColor = Color.Transparent;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lvComputer.View = View.LargeIcon;
            this.lvComputer.SmallImageList = this.ilComputer;
            this.lvComputer.Clear();
            SectionName = "普通区";
            this.txtType.Text = SectionName;
            ShowComputerIcon(Convert.ToInt32(this.btnPu.Tag));
            Display();
            ShowComputer();
            this.btnPu.Text += "\n"+DBHelper.SelectPrice(Convert.ToInt32(this.btnPu.Tag))+"元/小时";
            this.btnGame.Text += "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnGame.Tag)) + "元/小时";
            this.btnMV.Text += "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnMV.Tag)) + "元/小时";
            this.btnLove.Text += "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnLove.Tag)) + "元/小时";
            this.btnHide.Text += "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnHide.Tag)) + "元/小时";
            this.btnSmoke.Text += "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnSmoke.Tag)) + "元/小时";
            //显示气泡提示工具
            this.nfiico.ShowBalloonTip(1000, "正在运行 ", "欢迎登录鼎盛网吧管理系统", ToolTipIcon.Info);
            this.btnPu.ForeColor = Color.OrangeRed;
        }
        //显示总电脑状态的方法
        public void Display()
        {
            sql = "SELECT COUNT(*) FROM Computer WHERE TypeId!=4";
            this.lbCount.Text = DBHelper.SelCount(sql).ToString();
            sql = "SELECT COUNT(*) FROM Computer WHERE TypeId = 2 and TypeId!=4";
            this.lbDo.Text = DBHelper.SelCount(sql).ToString();
            sql = "SELECT COUNT(*) FROM Computer WHERE TypeId = 1 and TypeId!=4";
            this.lbEnd.Text = DBHelper.SelCount(sql).ToString();
            sql = "SELECT COUNT(*) FROM Computer WHERE TypeId = 3 and TypeId!=4";
            this.lbWH.Text = DBHelper.SelCount(sql).ToString();
        }
        private void time_Tick(object sender, EventArgs e)
        {
            this.lbTime.Text = DateTime.Now.ToString();
            if (this.lvComputer.SelectedItems.Count == 0)
            {
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "已用")
            {
                SqlDataReader reader = DBHelper.SelectUserNote(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
                reader.Read();
                DateTime dt1 = Convert.ToDateTime(reader["BeginTime"]);
                DateTime dt2 = DateTime.Now;
                TimeSpan ts = dt2 - dt1;
                int mm = Convert.ToInt32(ts.TotalMinutes);
                if (ts.TotalMinutes % 1 > 0)
                {
                    mm++;
                }
                string no = reader["UserNo"].ToString();
                double SubmitPrice = Convert.ToDouble(reader["SubmitPrice"]);
                reader.Close();
                double YXTime = SubmitPrice / Convert.ToDouble((DBHelper.GetSectionPrice(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) * DBHelper.GetDiscount(no)) / 60);
                this.lbSYTime.Text = Convert.ToInt32(YXTime - mm).ToString() + "分钟";
                this.lbSYPrice.Text = Convert.ToSingle(SubmitPrice - Convert.ToDouble((DBHelper.GetSectionPrice(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) * DBHelper.GetDiscount(no)) / 60) * mm).ToString("F2") + "元";
            }
        }

        private void ctmsMenu_Opening(object sender, CancelEventArgs e)
        {
            if (this.lvComputer.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "可用")
            {
                this.tsmiGo.Enabled = true;
                this.tsmiVindicate.Enabled = true;
                this.tsmiQYWH.Enabled = false;
                this.tsmiExit.Enabled = false;
                this.tsmiAdd.Enabled = false;
                this.tsmiSwap.Enabled = false;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "已用")
            {
                this.tsmiGo.Enabled = false;
                this.tsmiVindicate.Enabled = false;
                this.tsmiQYWH.Enabled = false;
                this.tsmiExit.Enabled = true;
                this.tsmiAdd.Enabled = true;
                this.tsmiSwap.Enabled = true;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "维修中")
            {
                this.tsmiGo.Enabled = false;
                this.tsmiVindicate.Enabled = false;
                this.tsmiQYWH.Enabled = true;
                this.tsmiExit.Enabled = false;
                this.tsmiAdd.Enabled = false;
                this.tsmiSwap.Enabled = false;
            }

        }

        private void tsmiGo_Click(object sender, EventArgs e)
        {
            if (this.lvComputer.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择电脑", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //创建上机窗体的对象并打开窗体
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "已用")
            {
                MessageBox.Show("本机子已用", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "维修中")
            {
                MessageBox.Show("本电脑处于维护中，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmStartComputer fsc = new frmStartComputer();
            fsc.ComputerId = Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag);
            DialogResult dr = fsc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DBHelper.UpdateType(1, Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
                this.lvComputer.SelectedItems[0].ImageIndex = 1;
                //从数据库查询出当前选中电脑的状态
                this.lbType.Text = DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
                Display();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "可用")
            {
                MessageBox.Show("您没有上机,不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "维修中")
            {
                MessageBox.Show("本电脑处于维护中，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmReckon fr = new frmReckon();
            fr.ComputerID = Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag);
            DialogResult dr = fr.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DBHelper.UpdateType(2, Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
                this.lvComputer.SelectedItems[0].ImageIndex = 0;
                ShowComputer();
            }
        }
        private void lvSmall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvComputer.SelectedItems.Count == 0)
                return;
            this.txtType.Text = SectionName + this.lvComputer.SelectedItems[0].Text;
            this.lbName.Text = this.lvComputer.SelectedItems[0].Text;
            //从数据库查询出当前选中电脑的状态
            this.lbType.Text = DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "已用")
            {
                this.lbSPrice.Text = DBHelper.SelectSubmitPrice(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
                SqlDataReader reader = DBHelper.SelectUserNote(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
                reader.Read();
                this.lbTooTime.Text = Convert.ToDateTime(reader["BeginTime"]).ToString("HH:mm:ss");
                this.lbUser.Text = reader["UserNo"].ToString();
                reader.Close();
            }
            else
            {
                this.lbSYPrice.Text = "";
                this.lbSYTime.Text = "";
                this.lbSPrice.Text = "";
                this.lbTooTime.Text = "";
                this.lbUser.Text = "";
            }

            //this.lbTooTime.Text = DBHelper
            Display();
        }

        private void tsmiVindicate_Click(object sender, EventArgs e)
        {
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "已用")
            {
                MessageBox.Show("本电脑正在使用，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBHelper.UpdateType(3, Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
            this.lvComputer.SelectedItems[0].ImageIndex = 2;
        }

        private void tsmiScrap_Click(object sender, EventArgs e)
        {
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "已用")
            {
                MessageBox.Show("本电脑正在使用，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBHelper.UpdateType(4, Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
            this.lvComputer.SelectedItems[0].ImageIndex = 3;
        }

        private void tsmi_Click(object sender, EventArgs e)
        {
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "可用")
            {
                MessageBox.Show("您没有上机,不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "维修中")
            {
                MessageBox.Show("本电脑处于维护中，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmSwap fs = new frmSwap();
            fs.ComputerID = Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag);
            fs.ShowDialog();
            ShowComputer();

        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            if (this.lvComputer.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择电脑", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "可用")
            {
                MessageBox.Show("您没有上机,不能续费", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "维修中")
            {
                MessageBox.Show("本电脑处于维护中，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmAddPrice fap = new frmAddPrice();
            fap.ComputerID = Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag);
            fap.no = this.lbUser.Text;
            fap.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.lvComputer.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择电脑", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "可用")
            {
                MessageBox.Show("您没有上机,不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "维修中")
            {
                MessageBox.Show("本电脑处于维护中，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmReckon fr = new frmReckon();
            fr.ComputerID = Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag);
            DialogResult dr = fr.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DBHelper.UpdateType(2, Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
                this.lvComputer.SelectedItems[0].ImageIndex = 0;
                ShowComputer();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.lvComputer.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择电脑", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "可用")
            {
                MessageBox.Show("您没有上机,不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "维修中")
            {
                MessageBox.Show("本电脑处于维护中，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmSwap fs = new frmSwap();
            fs.ComputerID = Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag);
            fs.ShowDialog();
            ShowComputer();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmChongZhi fc = new FrmChongZhi();
            fc.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvComputer.Items)
            {
                if (DBHelper.SeleteType(Convert.ToInt32(i.Tag)) == "已用")
                {
                    SqlDataReader reader = DBHelper.SelectUserNote(Convert.ToInt32(i.Tag));
                    reader.Read();
                    DateTime dt1 = Convert.ToDateTime(reader["BeginTime"]);
                    DateTime dt2 = DateTime.Now;
                    TimeSpan ts = dt2 - dt1;
                    int mm = Convert.ToInt32(ts.TotalMinutes);
                    if (ts.TotalMinutes % 1 > 0)
                    {
                        mm++;
                    }
                    string no = reader["UserNo"].ToString();
                    double SubmitPrice = Convert.ToDouble(reader["SubmitPrice"]);
                    reader.Close();
                    double YXTime = SubmitPrice / Convert.ToDouble((DBHelper.GetSectionPrice(Convert.ToInt32(i.Tag)) * DBHelper.GetDiscount(no)) / 60);
                    this.lbSYTime.Text = Convert.ToInt32(YXTime - mm).ToString() + "分钟";
                    this.lbSYPrice.Text = Convert.ToSingle(SubmitPrice - Convert.ToDouble((DBHelper.GetSectionPrice(Convert.ToInt32(i.Tag)) * DBHelper.GetDiscount(no)) / 60) * mm).ToString("F2")+"元";
                    if (mm >= YXTime - 3)
                    {
                        MessageBox.Show(DBHelper.SelById(Convert.ToInt32(i.Tag)) + "时间不足，请续费", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mm >= YXTime)
                    {
                        DBHelper.AddEndDate(DateTime.Now, Convert.ToInt32(i.Tag));
                        DBHelper.ActualPrice(SubmitPrice, Convert.ToInt32(i.Tag));
                        DBHelper.UpdateType(2, Convert.ToInt32(i.Tag));
                        DBHelper.UpdateUserPrice(SubmitPrice, no);
                        i.ImageIndex = 0;
                        MessageBox.Show(DBHelper.SelById(Convert.ToInt32(i.Tag)) + "余额不足，已强制下机", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowComputer();
                        return;
                    }

                }

            }
        }
        private void tsmiQYWH_Click(object sender, EventArgs e)
        {
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "可用")
            {
                MessageBox.Show("本电脑可用，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBHelper.SeleteType(Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag)) == "已用")
            {
                MessageBox.Show("本电脑正在使用中，不能执行此操作", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBHelper.UpdateType(2, Convert.ToInt32(this.lvComputer.SelectedItems[0].Tag));
            this.lvComputer.SelectedItems[0].ImageIndex = 0;
        }

        private void tsmiQYBF_Click(object sender, EventArgs e)
        {
        }

        private void smiUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo fu = new frmUserInfo();
            fu.ShowDialog();
        }

        private void smiComputer_Click(object sender, EventArgs e)
        {
            int ShowComputerByUpdateComputer = 0;
            if (this.txtType.Text == string.Empty)
            {
                SectionName = "普通区";
                ShowComputerByUpdateComputer = Convert.ToInt32(this.btnPu.Tag);
            }
            else if (this.txtType.Text.Contains("普通"))
            {
                SectionName = "普通区";
                ShowComputerByUpdateComputer = Convert.ToInt32(this.btnPu.Tag);
            }
            else if (this.txtType.Text.Contains("游戏"))
            {
                SectionName = "游戏专区";
                ShowComputerByUpdateComputer = Convert.ToInt32(this.btnGame.Tag);
            }
            else if (this.txtType.Text.Contains("视频"))
            {
                SectionName = "视频专区";
                ShowComputerByUpdateComputer = Convert.ToInt32(this.btnMV.Tag);
            }
            else if (this.txtType.Text.Contains("情侣"))
            {
                SectionName = "情侣包间";
                ShowComputerByUpdateComputer = Convert.ToInt32(this.btnLove.Tag);
            }
            else if (this.txtType.Text.Contains("吸烟"))
            {
                SectionName = "吸烟区";
                ShowComputerByUpdateComputer = Convert.ToInt32(this.btnSmoke.Tag);
            }
            else if (this.txtType.Text.Contains("妹子"))
            {
                SectionName = "妹子陪玩区";
                ShowComputerByUpdateComputer = Convert.ToInt32(this.btnHide.Tag);
            }
            frmSelectComputer fs = new frmSelectComputer();
            fs.ShowDialog();
            this.lvComputer.View = View.LargeIcon;
            this.lvComputer.SmallImageList = this.ilComputer;
            this.lvComputer.Clear();
            // SectionName = "普通区";
            this.txtType.Text = SectionName;
            ShowComputerIcon(ShowComputerByUpdateComputer);
            Display();
            ShowComputer();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FrmAddUser fa = new FrmAddUser();
            fa.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FrmVipNote fv = new FrmVipNote();
            fv.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmShopSum fs = new frmShopSum();
            fs.ShowDialog();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.ShowDialog();
        }

        private void nfiico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;

                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Maximized;
                this.Activate();
            }
        }

        private void tsmiShowMainByico_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            this.Activate();
        }

        private void tamiMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tsmiHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tsmiExitByico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                DialogResult dr = MessageBox.Show("您确定要退出鼎盛网吧管理系统吗？", "系统提示 ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void 注销ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAdmin fd = new frmAdmin();
            fd.ShowDialog();

            this.btnPu.Text = "普通区" + "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnPu.Tag)) + "元/小时";
            this.btnGame.Text = "游戏专区" + "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnGame.Tag)) + "元/小时";
            this.btnMV.Text = "视频专区" + "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnMV.Tag)) + "元/小时";
            this.btnLove.Text = "情侣包厢" + "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnLove.Tag)) + "元/小时";
            this.btnHide.Text = "妹子陪玩区" + "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnHide.Tag)) + "元/小时";
            this.btnSmoke.Text = "吸烟区" + "\n" + DBHelper.SelectPrice(Convert.ToInt32(this.btnSmoke.Tag)) + "元/小时";
        }

        private void 添加管理员AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddAdmin fd = new FrmAddAdmin();
            fd.ShowDialog();
        }

        private void 充值记录查询SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserNote fu = new frmUserNote();
            fu.ShowDialog();
        }

        private void 管理员查询SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin fd = new frmAdmin();
            fd.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }

        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
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
        Process pcalc = null;
        ProcessStartInfo Info = new ProcessStartInfo();
        private void bubbleButton3_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmMC fmc = new frmMC();
            fmc.Show();
        }
        private void bubbleButton4_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            pcalc = Process.Start("calc.exe");
        }
        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Info.FileName = "notepad.exe ";//"calc.exe"为计算器，"notepad.exe"为记事本
            Process Proc = Process.Start(Info);
        }
        //public bool isSuoPing = false;
        //public bool isClose = false;
        private void bubbleButton5_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Form2 fr = new Form2();
            //isSuoPing = true;
            fr.Show();
            //this.WindowState = FormWindowState.Minimized;
            //this.Close();
            
            //Form3 f3 = new Form3();
            //f3.fm = this;
        }

        //当鼠标停留时改变颜色及显示文字
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(btnClose, "关闭");
            this.btnClose.BackColor = Color.Red;
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(btnMin, "最小化");
            this.btnMin.BackColor = Color.White;
        }
        //当鼠标停留时恢复颜色及显示文字
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.BackColor = Color.Transparent;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            this.btnMin.BackColor = Color.Transparent;
        }

        private void btnGame_MouseHover(object sender, EventArgs e)
        {
            this.btnGame.ForeColor = Color.OrangeRed;
        }

        private void btnGame_MouseLeave(object sender, EventArgs e)
        {
            this.btnGame.ForeColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult reault = MessageBox.Show("您确定要注销账号吗？", "注销账号 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reault == DialogResult.Yes)
            {
                this.isExit = false;//注销操作
                frmLogin.Show();
                this.Close();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(button2, "注销");
            this.button2.BackColor = Color.DarkMagenta;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Transparent;
        }
    }
}
