using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetBar
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            //frmLogin frm = new frmLogin();
            //Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)frm);
            //skin.SkinFile = "NewFolder/MP10.ssk"; // xxx.ssk为指定皮肤文件路径
            //skin.TitleFont = new System.Drawing.Font("微软雅黑", 10F);// 指定标题栏的Font。
			Application.Run( new frmLogin());
		}
	}
}
