using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace InternetBar
{
    class DBHelper
    {
        private static string connString = "DATA SOURCE =.; INITIAL CATALOG = Internet Bar; USER ID = sa; Pwd = ok";
        private static SqlConnection conn = new SqlConnection(connString);


        //孙永杰

        //获取特定区域的电脑信息		id	37	int

        public static SqlDataReader SelBySection(int id)
        {
            string sql = string.Format("SELECT * FROM Computer AS C INNER JOIN Type AS T ON C.TypeId = T.TypeId  WHERE C.SectionId = {0}  and c.typeid != 4", id);  //如果报废就不显示
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        //获取电脑名称的方法
        public static string SelById(int id)
        {
            string sql = string.Format("SELECT ComputerNo FROM Computer WHERE ComputerId = {0}", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取电脑数量
        public static int SelCount(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return (int)comm.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //修改电脑状态
        public static int UpdateType(int no, int id)
        {
            string sql = string.Format("UPDATE Computer SET TypeId = {0} WHERE ComputerId='{1}'", no, id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return (int)comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //通过电脑编号获取电脑所在区域和区域价格
        public static SqlDataReader SelSectionById(int id)
        {
            string sql = string.Format("SELECT * FROM Computer AS C INNER JOIN Section AS S ON C.SectionId = S.SectionId  WHERE ComputerId = {0}", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        //获取电脑当前的状态
        public static string SeleteType(int id)
        {
            string sql = string.Format("SELECT TypeName FROM Computer AS C INNER JOIN Type AS T ON C.TypeId = T.TypeId WHERE ComputerId = {0}", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

        }
        //通过区域ID获取电脑ID和电脑名称
        public static DataTable SelctComputer()
        {
            string sql = string.Format("SELECT ComputerId,ComputerNo FROM Computer WHERE TypeId = 2 ");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "Computer");
                return ds.Tables["Computer"];
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取每个区域的价格
        public static double SelectPrice(int SectionId)
        {
            string sql = string.Format("SELECT SectionPrice FROM Section WHERE SectionId = {0}", SectionId);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return Convert.ToDouble(comm.ExecuteScalar());
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //通过身份证获取用户状态,姓名,余额
        public static SqlDataReader SelectUserByCid(string Cid)
        {
            string sql = string.Format("SELECT * FROM Users AS U INNER JOIN UserType AS T ON U.DID = T.ID WHERE IdCard = '{0}'", Cid);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        //通过身份证查询用户表里有没有该用户的信息
        public static int SelectCard(string Card)
        {
            string sql = string.Format("SELECT COUNT(*) FROM Users WHERE IdCard = '{0}'", Card);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return (int)comm.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //向用户表添加信息
        public static int AddUsers(string no, string name, string card, DateTime date, int did)
        {
            string sql = string.Format("INSERT Users VALUES('{0}','{1}','{2}',null,'{3}',null,{4},null,'false')", no, name, card, date, did);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //向消费记录表中添加信息
        public static void AddUserNote(string no, int id, DateTime begindate, double price)
        {
            string sql = string.Format("insert UserNote values('{0}',{1},'{2}',null,null,{3},null,null)", no, id, begindate, price);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取当前选中电脑的预交押金
        public static string SelectSubmitPrice(int id)
        {
            string sql = string.Format("SELECT TOP 1 SubmitPrice FROM UserNote WHERE ComputerID = {0} ORDER BY BeginTime DESC", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //如果是会员，给会员用户续费
        public static void UserAddPrice(double price, string no)
        {
            string sql = string.Format("UPDATE Users SET Balance +={0}  WHERE Did = 2 AND UserNo = {1}", price, no);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        //续费
        public static void AddPrice(double price, int id)
        {
            string sql = string.Format("UPDATE UserNote SET AddPrice += {0},SubmitPrice += {1} WHERE ComputerID = {2} AND BeginTime = (SELECT TOP 1 BeginTime FROM UserNote WHERE ComputerID = {3} ORDER BY BeginTime DESC)", price, price, id, id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        //根据身份证获取用户编号
        public static string SelectUserIdByCard(string Card)
        {
            string sql = string.Format("SELECT UserNo FROM Users WHERE IdCard = '{0}'", Card);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conn.Close();
            }
            
        }
        //获取该用户的消费记录
        public static SqlDataReader SelectUserNote(int id)
        {
            string sql = string.Format("SELECT TOP 1 * FROM UserNote WHERE ComputerID = {0} ORDER BY BeginTime DESC", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        //修改该用户上级记录的下机时间
        public static void AddEndDate(DateTime enddate, int id)
        {
            string sql = string.Format("UPDATE UserNote SET EndTime = '{0}' WHERE ComputerID = {1} AND BEGINTIME = (SELECT TOP 1 BeginTime FROM UserNote WHERE ComputerID = {2} ORDER BY BeginTime DESC)", enddate, id,id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        //修改消费记录表的实交金额
        public static void ActualPrice(double price, int id)
        {
            string sql = string.Format("UPDATE UserNote SET ActualPrice = {0} WHERE ComputerID = {1} AND BeginTime = (SELECT TOP 1 BeginTime FROM UserNote WHERE ComputerID = {2} ORDER BY BeginTime DESC)", price, id,id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        //修改会员用户表中会员用户的余额
        public static void UpdateUserPrice(double price, string no)
        {
            string sql = string.Format("UPDATE Users SET Balance -= {0} WHERE UserNo = '{1}' AND Did = 2", price, no);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取电脑所在区域的价格
        public static double GetSectionPrice(int id)
        {
            string sql = string.Format("SELECT SectionPrice FROM Computer AS C INNER JOIN Section AS S ON C.SectionId = S.SectionId  WHERE ComputerId = {0}", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return Convert.ToDouble(comm.ExecuteScalar());
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取该用户的折扣费率
        public static double GetDiscount(string no)
        {
            string sql = string.Format("SELECT Discount FROM Users AS U INNER JOIN UserType AS UT ON U.Did = UT.ID WHERE UserNo = '{0}'", no);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return Convert.ToDouble(comm.ExecuteScalar());
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取用户的类型，预交押金，卡号
        public static SqlDataReader GetNote(int ComputerID)
        {
            string sql = string.Format("SELECT TOP 1 * FROM UserNote AS UN INNER JOIN Users AS U ON UN.UserNo = U.UserNo INNER JOIN UserType AS UT ON U.Did = UT.ID WHERE UN.ComputerID = {0} ORDER BY BeginTime DESC", ComputerID);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        //判断该用户是否正在上机
        public static int IsOkComputer(string Card)
        {
            string sql = string.Format("SELECT IsOk FROM Users WHERE IdCard = '{0}'", Card);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }

        }
        //修改改用户为上机中
        public static void UpdateIsOk(int isok, string Card)
        {
            string sql = string.Format("Update Users set IsOk = {0} where IdCard =  '{1}'", isok, Card);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        //根据卡号查询出正在上机用户的身份证
        public static string GetCard(int id)
        {
            string sql = string.Format("SELECT TOP 1 IdCard FROM UserNote AS UN INNER JOIN Users AS U ON UN.UserNo = U.UserNo WHERE ComputerID = {0} ORDER BY BeginTime DESC ", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 返回一个Int类型的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int SelectCount(int id)
        {
            string sql = string.Format("SELECT COUNT(*) FROM Computer WHERE SectionId = {0}", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return (int)comm.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;

            }
            finally
            {
                conn.Close();
            }
        }

        //李浩
        //查询通用
        public static DataTable Search(string sql, string State)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                da.Fill(ds, State);
                return ds.Tables[State];
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //查询所有会员信息
        public static DataTable SearchVip()
        {
            string sql = "SELECT UserNo,UserName,IdCard,Balance,FoundTime,Remark FROM Users AS U  INNER JOIN UserType AS T ON U.Did = T.ID WHERE T.ID = 2";
            return Search(sql, "Vip");
        }

        //根据选中的会员编号查询
        public static SqlDataReader GetVipByID(string id)
        {
            string sql = string.Format("SELECT UserNo,UserName,IdCard,Balance,FoundTime,Remark FROM Users AS U  INNER JOIN UserType AS T ON U.Did = T.ID WHERE T.ID = 2 And UserNo ={0}", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                return null;

            }

        }

        //根据输入的身份证号进行查询
        public static SqlDataReader GetVipInfoByID(string IdCard)
        {
            string sql = string.Format("SELECT UserNo,UserName,IdCard,Balance,FoundTime,Remark FROM Users AS U  INNER JOIN UserType AS T ON U.Did = T.ID WHERE T.ID = 2 And IdCard ='{0}'", IdCard);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                return null;

            }

        }

        //查询是否为会员
        public static bool CheckIdCard2(string IdCard)
        {
            string sql = string.Format("select did from users where idcard = '{0}' ", IdCard);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader1 = comm.ExecuteReader(CommandBehavior.CloseConnection);
                reader1.Read();
                string idcord = string.Empty;
                idcord = reader1["did"].ToString();
                if (idcord == "2")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        //查询身份证是否存在的方法
        public static bool CheckIdCard(string IdCard)
        {
            string sql = string.Format("select Idcard from users where idcard = '{0}'", IdCard);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //增改 通用
        public static bool Exe(string sql, ref string msg)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int num = comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //根据会员编号 改
        public static bool UpdateUser(string userName, double balance, string remark, string id, ref string msg)
        {
            string sql = string.Format("UPDATE Users SET UserName = '{0}',Balance = {1},REMARK = '{2}' WHERE UserNo= '{3}'", userName, balance, remark, id);
            return Exe(sql, ref msg);
        }

        //增加会员信息
        public static bool AddUser(string userno, string cardpwd, string name, string idcard, double balance, DateTime found, string remark, int ID, ref string msg)
        {
            string sql = string.Format("Insert Into Users Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'False')", userno, name, idcard, balance, found, remark, ID, cardpwd);
            return Exe(sql, ref msg);
        }

        //根据身份证号修改余额
        public static bool UpdateBalance(string IdCard, double sum, ref string msg)
        {
            string sql = string.Format("Update Users Set Balance = {0} where Idcard = '{1}'", sum, IdCard);
            return Exe(sql, ref msg);
        }

        //查询所有的管理员信息

        public static DataTable SearchAdmin()
        {
            string sql = "Select * From Admin";
            return Search(sql, "Admin");
        }

        //根据姓名查询管理员信息
        public static DataTable AdminByName(string name)
        {
            string sql = string.Format("Select * From Admin where AdminName like '%{0}%'", name);
            return Search(sql, "AdminName");
        }

        public static bool AddAdmin(string name, string pwd, string phone, ref string msg)
        {
            string sql = string.Format("Insert into Admin Values('{0}','{1}','{2}')", name, pwd, phone);
            return Exe(sql, ref msg);
        }


        //何钊


        //消费记录查询窗体代码
        //消费记录统计绑定区域类型
        public DataTable ShowUserType()
        {
            string sql = "select * from  Section ";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "UserType");
                DataRow dr = ds.Tables["UserType"].NewRow();
                dr[0] = 0;
                dr[1] = "请选择";
                ds.Tables["UserType"].Rows.InsertAt(dr, 0);
                return ds.Tables["UserType"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 显示消费记录统计DATAGrawView中全部的数据
        public DataTable ShowAllDgv()
        {
            string sql = "select  u.UserNo,u.UserName,c.ComputerNo,un.BeginTime,un.EndTime ,ut.Discount ,un.Remark,DATEDIFF(MI,un.BeginTime,un.EndTime)/60 as LongTime,DATEDIFF(MI,un.BeginTime,un.EndTime)%60 as SmallTime,CONVERT(decimal(12,1),DATEDIFF(MI,un.BeginTime,un.EndTime)*(s.SectionPrice/60)*ut.Discount) as HowMoney,s.SectionName from UserNote as un inner join Computer as c on un.ComputerID = c.ComputerId inner join Section as s on c.SectionId = s.SectionId inner join Users as u on un.UserNo = u.UserNo inner join UserType as ut on ut.ID = u.Did ";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "AllDgv");
                return ds.Tables["AllDgv"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 根据区域与会员账号条件查询消费记录统计DATAGrawView中的数据
        public DataTable ShowAllDgvByQuYuHuiYuan(string UserName, int SectionId)
        {
            string sql = string.Format("select  u.UserNo,u.UserName,c.ComputerNo,un.BeginTime,un.EndTime ,ut.Discount ,un.Remark,DATEDIFF(MI,un.BeginTime,un.EndTime)/60 as LongTime,DATEDIFF(MI,un.BeginTime,un.EndTime)%60 as SmallTime,CONVERT(decimal(12,1),DATEDIFF(MI,un.BeginTime,un.EndTime)*(s.SectionPrice/60)*ut.Discount) as HowMoney,s.SectionName from UserNote as un inner join Computer as c on un.ComputerID = c.ComputerId inner join Section as s on c.SectionId = s.SectionId inner join Users as u on un.UserNo = u.UserNo inner join UserType as ut on ut.ID = u.Did where u.UserNo like '%{0}%' and s.SectionId = {1}", UserName, SectionId);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "AllDgvByQuYuHuiYuan");
                return ds.Tables["AllDgvByQuYuHuiYuan"];


            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 根据区域查询消费记录统计DATAGrawView中的数据
        public DataTable ShowAllDgvByQuYu(int SectionId)
        {
            string sql = string.Format("select  u.UserNo,u.UserName,c.ComputerNo,un.BeginTime,un.EndTime ,ut.Discount ,un.Remark,DATEDIFF(MI,un.BeginTime,un.EndTime)/60 as LongTime,DATEDIFF(MI,un.BeginTime,un.EndTime)%60 as SmallTime,CONVERT(decimal(12,1),DATEDIFF(MI,un.BeginTime,un.EndTime)*(s.SectionPrice/60)*ut.Discount) as HowMoney,s.SectionName from UserNote as un inner join Computer as c on un.ComputerID = c.ComputerId inner join Section as s on c.SectionId = s.SectionId inner join Users as u on un.UserNo = u.UserNo inner join UserType as ut on ut.ID = u.Did where  s.SectionId = {0}", SectionId);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "AllDgvByQuYu");
                return ds.Tables["AllDgvByQuYu"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 根据会员账号模糊查询消费记录统计DATAGrawView中的数据
        public DataTable ShowAllDgvByHY(string UserName)
        {
            string sql = string.Format("select  u.UserNo,u.UserName,c.ComputerNo,un.BeginTime,un.EndTime ,ut.Discount ,un.Remark,DATEDIFF(MI,un.BeginTime,un.EndTime)/60 as LongTime,DATEDIFF(MI,un.BeginTime,un.EndTime)%60 as SmallTime,CONVERT(decimal(12,1),DATEDIFF(MI,un.BeginTime,un.EndTime)*(s.SectionPrice/60)*ut.Discount) as HowMoney,s.SectionName from UserNote as un inner join Computer as c on un.ComputerID = c.ComputerId inner join Section as s on c.SectionId = s.SectionId inner join Users as u on un.UserNo = u.UserNo inner join UserType as ut on ut.ID = u.Did where u.UserNo LIKE '%{0}%'", UserName);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "AllDgvByHYName");
                return ds.Tables["AllDgvByHYName"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 根据时间与区域查询消费记录统计DATAGrawView中的数据
        public DataTable ShowAllDgvByTimeQuYu(DateTime StartTime, DateTime EndTime, int QuYu)
        {
            string sql = string.Format("select  u.UserNo,u.UserName,c.ComputerNo,un.BeginTime,un.EndTime ,ut.Discount ,un.Remark,DATEDIFF(MI,un.BeginTime,un.EndTime)/60 as LongTime,DATEDIFF(MI,un.BeginTime,un.EndTime)%60 as SmallTime,CONVERT(decimal(12,1),DATEDIFF(MI,un.BeginTime,un.EndTime)*(s.SectionPrice/60)*ut.Discount) as HowMoney,s.SectionName from UserNote as un inner join Computer as c on un.ComputerID = c.ComputerId inner join Section as s on c.SectionId = s.SectionId inner join Users as u on un.UserNo = u.UserNo inner join UserType as ut on ut.ID = u.Did where BeginTime between '{0}' and '{1}' and s.SectionId = {2}", StartTime, EndTime, QuYu);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "AllDgvByTimeQuYu");
                return ds.Tables["AllDgvByTimeQuYu"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 根据时间与会员账号查询消费记录统计DATAGrawView中的数据
        public DataTable ShowAllDgvByTimeHuiYuan(DateTime StartTime, DateTime EndTime, string HuiYuan)
        {
            string sql = string.Format("select  u.UserNo,u.UserName,c.ComputerNo,un.BeginTime,un.EndTime ,ut.Discount ,un.Remark,DATEDIFF(MI,un.BeginTime,un.EndTime)/60 as LongTime,DATEDIFF(MI,un.BeginTime,un.EndTime)%60 as SmallTime,CONVERT(decimal(12,1),DATEDIFF(MI,un.BeginTime,un.EndTime)*(s.SectionPrice/60)*ut.Discount) as HowMoney,s.SectionName from UserNote as un inner join Computer as c on un.ComputerID = c.ComputerId inner join Section as s on c.SectionId = s.SectionId inner join Users as u on un.UserNo = u.UserNo inner join UserType as ut on ut.ID = u.Did where BeginTime between '{0}' and '{1}' and u.UserNo LIKE '%{2}%'", StartTime, EndTime, HuiYuan);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "AllDgvByTimeHuiYuan");
                return ds.Tables["AllDgvByTimeHuiYuan"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 根据时间与区域与会员账号查询消费记录统计DATAGrawView中的数据
        public DataTable ShowAllDgvByTimeQuYuHuiYuan(DateTime StartTime, DateTime EndTime, int QuYu, string HuiYuan)
        {
            string sql = string.Format("select  u.UserNo,u.UserName,c.ComputerNo,un.BeginTime,un.EndTime ,ut.Discount ,un.Remark,DATEDIFF(MI,un.BeginTime,un.EndTime)/60 as LongTime,DATEDIFF(MI,un.BeginTime,un.EndTime)%60 as SmallTime,CONVERT(decimal(12,1),DATEDIFF(MI,un.BeginTime,un.EndTime)*(s.SectionPrice/60)*ut.Discount) as HowMoney,s.SectionName from UserNote as un inner join Computer as c on un.ComputerID = c.ComputerId inner join Section as s on c.SectionId = s.SectionId inner join Users as u on un.UserNo = u.UserNo inner join UserType as ut on ut.ID = u.Did where BeginTime between '{0}' and '{1}' and s.SectionId = {2} and u.UserNo LIKE '%{3}%'", StartTime, EndTime, QuYu, HuiYuan);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "AllDgvByTimeQuYuHuiYuan");
                return ds.Tables["AllDgvByTimeQuYuHuiYuan"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 根据时间查询消费记录统计DATAGrawView中的数据
        public DataTable ShowAllDgvByTime(DateTime StartTime, DateTime EndTime)
        {
            string sql = string.Format("select  u.UserNo,u.UserName,c.ComputerNo,un.BeginTime,un.EndTime ,ut.Discount ,un.Remark,DATEDIFF(MI,un.BeginTime,un.EndTime)/60 as LongTime,DATEDIFF(MI,un.BeginTime,un.EndTime)%60 as SmallTime,CONVERT(decimal(12,1),DATEDIFF(MI,un.BeginTime,un.EndTime)*(s.SectionPrice/60)*ut.Discount) as HowMoney,s.SectionName from UserNote as un inner join Computer as c on un.ComputerID = c.ComputerId inner join Section as s on c.SectionId = s.SectionId inner join Users as u on un.UserNo = u.UserNo inner join UserType as ut on ut.ID = u.Did where BeginTime between '{0}' and '{1}' ", StartTime, EndTime);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "AllDgvByTime");
                return ds.Tables["AllDgvByTime"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //删除用户记录表
        public bool SelectStipNoteById(string UserNo)
        {
            string sql = string.Format("select * from StipNote where userNo = '{0}'", UserNo);
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
        }


        // 查询用户管理
        public DataTable SeachUserInfo(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "SeachUserInfo");
                return ds.Tables["SeachUserInfo"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // 修改用户管理
        public int UpdateUserInfo(string UserNo, string UserName, double Balance, DateTime FoundTime, string Remark, int Did)
        {
            string sql = string.Format("update Users set UserName = '{0}',Balance = {1},FoundTime = '{2}',Remark = '{3}',Did = {4} where UserNo = '{5}'", UserName, Balance, FoundTime, Remark, Did, UserNo);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() == 1)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //查询身份证是否存在的方法
        public bool CheckIdCardForUserInfo(string IdCard)
        {
            string sql = string.Format("select Idcard from users where idcard = '{0}'", IdCard);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //查询账号是否存在的方法
        public bool CheckNoForUserInfo(string No)
        {
            string sql = string.Format("select userNo from users where userno = '{0}'", No);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        // 新增用户管理
        public int AddUserInfo(string UserNo, string UserName, string IdCard, double Balance, DateTime FoundTime, string Remark, int Did)
        {
            string sql = string.Format("insert  Users(UserName,IdCard,Balance,FoundTime,Remark,Did,UserNo,CardPwd,IsOk) values('{0}','{1}', {2},'{3}','{4}',{5} ,'{6}','123','False')", UserName, IdCard, Balance, FoundTime, Remark, Did, UserNo);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        // 删除用户管理第一步
        public int DeleteUserInfo(string UserNo)
        {
            string sql = string.Format("delete Users where UserNo = '{0}'", UserNo);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //删除用户时先查询在用户记录表是否存在
        public bool SelectUserNoteById(string UserNo)
        {
            string sql = string.Format("select userNo from usernote where userNo = '{0}'", UserNo);
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
        }

        // 删除用户管理第二步
        public int DeleteUserInfoTwo(string UserNo)
        {
            string sql = string.Format("delete usernote where userNo =  '{0}'", UserNo);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //查询区间价格
        public DataTable ChaXunJiaGe()
        {
            string sql = string.Format("select * from Section");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "Price");
                return ds.Tables["Price"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }

        // 修改价格
        public int UpdateJiaGe(double price, int id)
        {
            string sql = string.Format("update section set SectionPrice = {0} where Sectionid = {1}", price, id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() == 1)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //修改管理员by’登录‘
        public int UpdateAdminByName(string name, string pwd, string phone, string OldPwd, ref int msg)
        {
            string sql = string.Format("update admin set adminName = '{0}',adminPwd = '{1}',Phone = '{2}' where adminName = '{3}' and adminPwd = '{4}'", name, pwd, phone, name, OldPwd);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() >0)
                {
                    return 1;
                }
                else
                {
                    msg = -2;
                    return msg;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //修改管理员by’管理员设置‘
        public int UpdateAdminById(int id, string name, string pwd, string phone,string OldPwd,ref int msg)
        {
            string sql = string.Format("update admin set adminName = '{0}',adminPwd = '{1}',Phone = '{2}' where adminid = {3} and adminPwd = '{4}'", name, pwd, phone, id, OldPwd);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() == 1)
                {
                    return 1;
                }
                else
                {
                    msg = -2;
                    return msg;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //删除管理员
        public static int DeleteAdminById(int adminId)
        {
            string sql = string.Format("delete admin where adminid =  {0}", adminId);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //查询报废记录
        public DataTable ChaXunBaoFeiNote(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(ds, "BaoFeiNote");
                return ds.Tables["BaoFeiNote"];
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }


        //李瑞

        //添加电脑方法
        public static bool ADDComputer(string name, int typeid, int sectionid, string ip)
        {
            string sql = string.Format("INSERT INTO Computer VALUES ('{0}','{1}','{2}','{3}')", name, 2, sectionid, ip);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        //查询电脑编号（新增）
        public static bool GetComputerNo(string ComputerNo)
        {
            string sql = string.Format("SELECT COUNT(*) FROM Computer WHERE ComputerNo = '{0}' and typeId != 4", ComputerNo);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int no = Convert.ToInt32(comm.ExecuteScalar());
                if (no == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //查询电脑编号（修改）
        public static bool GetComputerNoByUpdate(string ComputerNo, int ComputerId)
        {
            string sql = string.Format("SELECT COUNT(*) FROM Computer WHERE ComputerNo = '{0}' and ComputerId != {1} and typeId != 4", ComputerNo, ComputerId);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int no = Convert.ToInt32(comm.ExecuteScalar());
                if (no == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }



        //查询电脑信息方法
        public static DataTable ShowComputer()
        {
            string sql = "select c.ComputerId,c.ComputerNo,t.TypeName,s.SectionName,s.SectionPrice,c.IP from Computer  AS C inner join Section AS S ON C.SectionId = s.SectionId inner join Type AS t ON t.TypeId = c.TypeId where C.typeId!=4";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "Computer");
                return ds.Tables["Computer"];
            }
            catch (Exception)
            {

                return null;

            }
            finally
            {

                conn.Close();

            }
        }
        //ShowUserNote()
        public static DataTable ShowUserNote()
        {
            string sql = "select * from UserNote";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "UserNote");
                return ds.Tables["UserNote"];
            }
            catch (Exception)
            {

                return null;

            }
            finally
            {

                conn.Close();

            }
        }

        ////删除电脑方法
        //public static bool DELComputer(int ComputerId)
        //{
        //    string sql = string.Format("DELETE Computer WHERE ComputerId = {0}", ComputerId);
        //    SqlCommand comm = new SqlCommand(sql, conn);
        //    try
        //    {
        //        conn.Open();
        //        comm.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //报废电脑方法
        public  bool UpdateComputerType(int ComputerId, ref string msg)
        {
            string sql = string.Format("update Computer set TypeId = 4 where ComputerId = {0}", ComputerId);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    msg = "失败";
                    return true;
                }
            }
            catch (Exception)
            {
                msg = string.Empty;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //查询电脑信息By cumputerID
        public static SqlDataReader GetcumputerByID(int ComputerId)
        {
            string sql = string.Format("SELECT * FROM Computer WHERE ComputerId = {0}", ComputerId);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                return null;

            }
        }

        //查询电脑信息
        public static DataTable GetComputerById(int ComputerId)
        {
            string sql = string.Format("SELECT *  FROM Computer WHERE ComputerId = {0}", ComputerId);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "Computer");
                return ds.Tables["Computer"];
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // UpdateComputer
        public static bool UpdateComputer(string name, int typeid, int sectionid, string ip, int id)
        {
            string sql = string.Format("UPDATE Computer SET ComputerNo='{0}',TypeId={1},SectionId={2},IP='{3}' WHERE ComputerId={4}", name, typeid, sectionid, ip, id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() == 1)
                    return true;//修改成功
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        // 登录验证
        public static bool CheckLogin(string name, string pwd, ref string msg)
        {
            string sql = string.Format("SELECT * FROM Admin WHERE AdminName = '{0}' AND AdminPwd = '{1}'", name, pwd);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                    return true;
                else
                    return false;

            }
            catch (Exception e)
            {
                msg = e.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取特定区域的电脑信息
        public static SqlDataReader SelBySectio(int id)
        {
            string sql = string.Format("SELECT * FROM Computer AS C INNER JOIN Type AS T ON C.TypeId = T.TypeId  WHERE C.SectionId = {0} AND C.TypeId <> 4 ", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        //获取电脑名称的方法
        public static string SelBy(int id)
        {
            string sql = string.Format("SELECT ComputerNo FROM Computer WHERE ComputerId = {0}", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取电脑数量
        public static int Selcount(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return (int)comm.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //修改电脑状态
        public static int UpdateTYPE(int no, int id)
        {
            string sql = string.Format("UPDATE Computer SET TypeId = {0} WHERE ComputerId='{1}'", no, id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return (int)comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //获取电脑当前的状态
        public static string SeleType(int id)
        {
            string sql = string.Format("SELECT TypeName FROM Computer AS C INNER JOIN Type AS T ON C.TypeId = T.TypeId WHERE ComputerId = {0}", id);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

        }


    }
}
