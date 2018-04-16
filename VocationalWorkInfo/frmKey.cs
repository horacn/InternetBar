using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InternetBar;
using System.Threading;

namespace InternetBar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public  frmMain fm = new frmMain ();
        public Form1 f1 = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            string dd = Info.Pass;
            
            if (textBox1.Text == dd)
            {
                //fm.WindowState = FormWindowState.Maximized;
                this.f1.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误，请检查后输入...");
                this.textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        private void frmAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmAbout_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void frmAbout_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
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
        //当鼠标停留时恢复颜色
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            this.btnMin.BackColor = Color.Transparent;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.OrangeRed;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.Transparent;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.ForeColor = Color.OrangeRed;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.ForeColor = Color.Transparent;
        }
    }
}