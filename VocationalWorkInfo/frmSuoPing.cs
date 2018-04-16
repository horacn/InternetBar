using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InternetBar;

namespace InternetBar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Info q = new Info();
        //public frmMain fm = new frmMain ();
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "" || textBox1.Text.Trim() == null || textBox1.Text.Trim() == String.Empty)
            {
                Info.Name = "暂离中，勿动";

                if (textBox2.Text.Length < 4)
                {
                    MessageBox.Show("密码至少要四位数以上");
                }
                else
                {
                    if (textBox2.Text != textBox3.Text)
                    {
                        MessageBox.Show("两次输入密码不一致");
                    }
                    else
                    {

                        //fm.isClose = true;
                        Info.Pass = textBox2.Text;
                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                        return;
                    }
                }

            }
            else
            {
                //5|1|a|s|p|x
                if (textBox2.Text.Length < 4)
                {
                    MessageBox.Show("密码至少要四位数以上");
                }
                else
                {
                    if (textBox2.Text != textBox3.Text)
                    {
                        MessageBox.Show("两次输入密码不一致");
                    }
                    else
                    {
                        //fm.isClose = true;
                        Info.Name = textBox1.Text;
                        Info.Pass = textBox2.Text;

                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                        return;
                    }
                }
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnClearByAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void FrmAddAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void FrmAddAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void FrmAddAdmin_MouseUp(object sender, MouseEventArgs e)
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