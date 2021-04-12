using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Sqlite
{
    [Serializable]
    public class SQLiteHelper
    {
        #region 成员


        //连接对象
        public SQLiteConnection SLcon = null;
        //命令对象
        public SQLiteCommand SLcmd = null;
        //连接器
        private SQLiteDataAdapter SLadp = null;
        //命令字符串
        private SQLiteConnectionStringBuilder SLcsb = null;


        //事务对象
        public SQLiteTransaction SLTrans = null;
        //事务激活标识
        public bool _IsRunTrans = false;
        //事务自动提交标识
        public bool _AutoCommit = false;

        //数据库字段数据类型枚举
        public enum DatabaseType : ushort
        {
            //仅容纳整数。在括号内规定数字的最大位数
            Typeinteger,
            Typeint,
            Typesmallint,
            Typetinyint,
            //容纳固定长度的字符串（可容纳字母、数字以及特殊字符）。
            //在括号中规定字符串的长度
            Typechar,
            //容纳可变长度的字符串（可容纳字母、数字以及特殊字符）。
            //在括号中规定字符串的长度
            Typevarchar,
            //容纳日期
            Typedata,
            // 容纳带有小数的数字。
            //"size" 规定数字的最大位数。"d" 规定小数点右侧的最大位数
            Typedecimal,
            Typenumeric,
        }

        #endregion

        #region 属性

        /// <summary>
        /// 连接字符串,设置只需要写入文件路径,写入后连接处于断开状态
        /// </summary>
        public string SQLiteConnectingString
        {
            get { return SLcon.ConnectionString; }
            set { SLcon.Close(); SLcsb.DataSource = value; SLcon.ConnectionString = SLcsb.ConnectionString; }
        }

        #endregion

        #region 事件

        #endregion

        #region 方法

        /// <summary>
        /// 构造函数,默认密码为admin
        /// </summary>
        public SQLiteHelper(string dbpath,string password = "admin")
        {
            SLcsb = new SQLiteConnectionStringBuilder();
            //SLcsb.Password = password;
            SLcsb.DataSource = dbpath;
            SLcon = new SQLiteConnection(SLcsb.ToString());

            SLcmd = new SQLiteCommand(SLcon);
            SLadp = new SQLiteDataAdapter(SLcmd);

            SLcon.Open();
        }

        /// <summary>
        /// 创建数据库文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>正常返回"",异常返回异常原因字符串</returns>
        public static string CreatDBFile(string path)
        {
            try
            {
                //创建一个零字节文件，正确打开时变成数据库文件
                SQLiteConnection.CreateFile(path);
                return "";
            }
            catch (Exception ex)
            {
                return $"数据库文件创建失败，原因是:{ex.Message}";
            }
        }

        /// <summary>
        /// 创建数据库文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>正常返回"",异常返回异常原因字符串</returns>
        public static string CreatDBFile(string path, string invalidstring)
        {
            try
            {
                //创建后释放文件句柄
                File.Create(path).Close();
                return "";
            }
            catch (Exception ex)
            {
                return $"数据库文件创建失败，原因是:{ex.Message}";
            }
        }

        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="NewTableName">表名</param>
        /// <param name="ColumnName">第一列名</param>
        /// <param name="ColumnType">第一列数据类型</param>
        /// <returns>正常返回"",异常返回异常原因字符串</returns>
        public string CreatDBTable(string NewTableName, string ColumnName, DatabaseType ColumnType = DatabaseType.Typevarchar)
        {
            try
            {
                //判断当前是否已经存在表
                List<string> tableName = GetTableNames();
                foreach (string i in tableName)
                {
                    if (i == NewTableName)
                    {
                        return "当前已经存在同名表";
                    }
                }
                if (SLcon.State != ConnectionState.Open)
                {
                    SLcon.Open();
                }
                //建表语句:CREATE TABLE 表名称(列名称1 数据类型,列名称2 数据类型,...)
                SLcmd.CommandText = $"CREATE TABLE {NewTableName}" +
                    $" ({ ColumnName}" +
                    //获得枚举名字符串值并去除Type,位数默认
                    $" {Enum.GetName(typeof(DatabaseType), ColumnType).Substring(4)})";
                SLcmd.Connection = SLcon;
                SLcmd.ExecuteNonQuery();
                SLcon.Close();
                return "";
            }
            catch (Exception ex)
            {
                return $"创建表失败，具体原因是：{ex.Message}";
            }

        }


        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        public Boolean Open()
        {
            if (SLcon != null && SLcon.State != ConnectionState.Open)
            {
                SLcon.Open();
            }
            if (SLcon.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <returns></returns>
        public Boolean Close()
        {
            if (SLcon != null && SLcon.State != ConnectionState.Closed)
            {
                SLcon.Close();
            }
            if (SLcon.State == ConnectionState.Open)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 修改密码,新密码不能为空
        /// </summary>
        /// <param name="newPassword">新密码</param>
        /// <returns></returns>
        public Boolean ChangePassword(string newPassword)
        {
            SLcon.Open();
            if (newPassword.Length > 0)
            {
                SLcsb.Password = newPassword;
                SQLiteConnectingString = $"{SLcsb.DataSource}";
                SLcon.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更改连接数据源
        /// </summary>
        /// <param name="newDataSource">新数据源</param>
        /// <returns></returns>
        public bool ChangeDataSource(string newDataSource)
        {
            Close();
            if (!string.IsNullOrEmpty(newDataSource))
            {
                SQLiteConnectingString = newDataSource;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 执行SQL语句增删改数据库,支持增加字段，修改表名等操作
        /// </summary>
        /// <param name="CommandString">SQL语句</param>
        /// <returns></returns>
        public string CommandDatabase(string CommandString)
        {
            try
            {
                if (SLcon.State != ConnectionState.Open)
                {
                    SLcon.Open();
                }
                SLcmd.CommandText = CommandString;
                SLcmd.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return $"执行SQL语句失败，异常原因是：{ex.Message}";
            }

        }
        /// <summary>
        /// 执行SQL语句查询数据库
        /// </summary>
        /// <param name="cmdtxt"></param>
        /// <returns></returns>
        public string Query(string cmdtxt)
        {
            try
            {
                if (SLcon.State != ConnectionState.Open)
                {
                    SLcon.Open();
                }
                SLcmd.CommandText = cmdtxt;
                using (SQLiteDataReader SLdr = SLcmd.ExecuteReader())
                {
                    if (SLdr.HasRows)
                    {
                        return "";
                    }
                    else
                    {
                        return "无数据";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"执行SQL语句失败，异常原因是：{ex.Message}";
            }
        }

        /// <summary>
        /// 获取数据库的架构
        /// </summary>
        /// <returns>返回形式以DataTable呈现</returns>
        public DataTable GetSchema()
        {
            if (SLcon.State != ConnectionState.Open)
            {
                SLcon.Open();
            }
            return SLcon.GetSchema("TABLES");
        }

        /// <summary>
        /// 获取数据库的所有表名
        /// </summary>
        /// <returns>返回泛型字符串集合</returns>
        public List<string> GetTableNames()
        {
            List<string> tableNames = new List<string>();
            try
            {
                if (SLcon.State != ConnectionState.Open)
                {
                    SLcon.Open();
                }
                SLcmd.CommandText = @"select name from sqlite_master where type='table' order by name";
                using (SQLiteDataReader SLdr = SLcmd.ExecuteReader())
                {
                    while (SLdr.Read())
                    {
                        tableNames.Add(Convert.ToString(SLdr["Name"]));
                    }
                }
                SLcon.Close();
                return tableNames;
            }
            catch (Exception ex)
            {
                throw new Exception($"获取数据库所有表名失败，失败的原因是{ex.Message}");
            }
        }

        /// <summary>
        /// 获取数据库表的所有字段名
        /// </summary>
        /// <param name="TableName">要获取字段的表名</param>
        /// <returns>返回泛型字符串集合</returns>
        public List<string> GetTableColunmnNames(string cmdtxt)
        {
            List<string> tableColunmsNames = new List<string>();
            int i = 0;
            try
            {
                if (SLcon.State != ConnectionState.Open)
                {
                    SLcon.Open();
                }
                SLcmd.CommandText = cmdtxt;
                using (SQLiteDataReader SLdr = SLcmd.ExecuteReader())
                {
                    while (SLdr.Read())
                    {
                        tableColunmsNames.Add(SLdr[0].ToString());
                        i += 1;
                    }
                }
                SLcon.Close();
                return tableColunmsNames;
            }
            catch (Exception ex)
            {
                throw new Exception($"获取数据库表字段名失败，失败的原因是{ex.Message}");
            }
        }

        /// <summary>
        /// 获取数据库表的所有数据
        /// </summary>
        /// <param name="TableName">要获取字段的表名</param>
        /// <returns>返回DataTable集合</returns>
        public DataTable GetDataTable(string TableName)
        {
            using (DataTable dt = new DataTable())
            {
                try
                {
                    if (SLcon.State != ConnectionState.Open)
                    {
                        SLcon.Open();
                    }
                    SLcmd.CommandText = $"select * from {TableName}";
                    SLadp.Fill(dt);
                    SLcon.Close();
                    return dt;
                }
                catch 
                {
                    return dt ;
                }
            }
        }

        /// <summary>
        /// 判断是否存在满足条件的记录
        /// </summary>
        /// <param name="Condition">条件选择</param>
        /// <returns></returns>
        public bool IsExitData(string TableName, string Condition)
        {
            try
            {
                if (SLcon.State != ConnectionState.Open)
                {
                    SLcon.Open();
                }
                bool r = false;
                SLcmd.CommandText = $"select isnull((select top(1) 1 from {TableName} where {Condition}), 0)";
                using (SQLiteDataReader SLdr = SLcmd.ExecuteReader())
                {
                    r = SLdr.Read();
                }
                SLcon.Close();
                return r;
            }
            catch 
            {
                return false ;
            }
        }



        /// <summary>
        /// 开始新事务
        /// </summary>
        public void BeginTransaction()
        {           
            SLTrans = SLcon.BeginTransaction();
            SLcmd.Transaction = SLTrans;
            _IsRunTrans = true;
        }

        /// <summary>
        /// 开始新事务
        /// </summary>
        /// <param name="isoLevel">事务锁级别</param>
        public void BeginTransaction(IsolationLevel isoLevel = IsolationLevel.Serializable)
        {
            SLTrans = SLcon.BeginTransaction(isoLevel);
            SLcmd.Transaction = SLTrans;
            _IsRunTrans = true;
        }

        /// <summary>
        /// 提交当前挂起的事务
        /// </summary>
        public void Commit()
        {
            if (_IsRunTrans)
            {
                SLTrans.Commit();
                _IsRunTrans = false;
            }
        }
        #endregion
    }
}
