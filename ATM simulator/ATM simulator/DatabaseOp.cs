using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;

namespace ATM_simulator
{
    /// <summary>
    ///主要包括sqlHelp数据库访问助手类 和常用的一些函数定义
    ///</summary>
    ///SqlHelp数据库访问助手
    ///1.public static void OpenConn()                                  //打开数据库连接
    ///2.public static void CloseConn()                                 //关闭数据库连接
    ///3.public static SqlDataReader getDataReaderValue(string sql)     //读取数据
    ///4.public DataSet GetDataSetValue(string sql, string tableName)   //返回DataSet
    ///5.public DataView GetDataViewValue(string sql)                   //返回DataView
    ///6.public DataTable GetDataTableValue(string sql)                 //返回DataTable
    ///7.public void ExecuteNonQuery(string sql)                        //执行一个SQL操作:添加、删除、更新操作
    ///8.public int ExecuteNonQueryCount(string sql)                    //执行一个SQL操作:添加、删除、更新操作，返回受影响的行
    ///9.public static object ExecuteScalar(string sql)                 //执行一条返回第一条记录第一列的SqlCommand命令
    ///10.public int SqlServerRecordCount(string sql)                   //返回记录数


    ///常用函数
    ///1.public static bool IsNumber(string a)                          //判断是否为数字
    ///2.public static string GetSafeValue(string value)                //过滤非法字符
    public class DatabaseOp
    {
        ///私有属性:数据库连接字符串
        ///Data Source=(Local)          服务器地址
        ///Initial Catalog=SimpleMESDB  数据库名称
        ///User ID=sa                   数据库用户名
        ///Password=admin123456         数据库密码
        private const string connectionString = "server=SQLEXPRESS;database=BankAccount;user=sa;pwd=123456";



        /// <summary>
        /// sqlHelp 的摘要说明:数据库访问助手类
        /// sqlHelper是从DAAB中提出的一个类，在这里进行了简化，DAAB是微软Enterprise Library的一部分，该库包含了大量大型应用程序
        /// 开发需要使用的库类。
        /// </summary>

        public DatabaseOp()
        {
            //无参构造函数
        }

        public static SqlConnection conn;

        //打开数据库连接
        public static void OpenConn()
        {
            string SqlCon = connectionString;//数据库连接字符串
            conn = new SqlConnection(SqlCon);
            if (conn.State.ToString().ToLower() == "open")
            {

            }
            else
            {
                conn.Open();
            }
        }

        //关闭数据库连接
        public static void CloseConn()
        {
            if (conn.State.ToString().ToLower() == "open")
            {
                //连接打开时
                conn.Close();
                conn.Dispose();
            }
        }


        // 读取数据
        public static SqlDataReader GetDataReaderValue(string sql)
        {
            OpenConn();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            CloseConn();
            return dr;
        }


        // 返回DataSet
        public DataSet GetDataSetValue(string sql, string tableName)
        {
            OpenConn();
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, tableName);
            CloseConn();
            return ds;
        }

        //  返回DataView
        public DataView GetDataViewValue(string sql)
        {
            OpenConn();
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "temp");
            CloseConn();
            return ds.Tables[0].DefaultView;
        }

        // 返回DataTable
        public DataTable GetDataTableValue(string sql)
        {
            OpenConn();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            CloseConn();
            return dt;
        }

        // 执行一个SQL操作:添加、删除、更新操作
        public void ExecuteNonQuery(string sql)
        {
            OpenConn();
            SqlCommand cmd;
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            CloseConn();
        }

        // 执行一个SQL操作:添加、删除、更新操作，返回受影响的行
        public int ExecuteNonQueryCount(string sql)
        {
            OpenConn();
            SqlCommand cmd;
            cmd = new SqlCommand(sql, conn);
            int value = cmd.ExecuteNonQuery();
            return value;
        }

        //执行一条返回第一条记录第一列的SqlCommand命令
        public object ExecuteScalar(string sql)
        {
            OpenConn();
            SqlCommand cmd;
            cmd = new SqlCommand(sql, conn);
            object value = cmd.ExecuteScalar();
            return value;
        }

        // 返回记录数
        public int SqlServerRecordCount(string sql)
        {
            OpenConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int RecordCount = 0;
            while (dr.Read())
            {
                RecordCount = RecordCount + 1;
            }
            CloseConn();
            return RecordCount;
        }


        ///<summary>
        ///一些常用的函数
        ///</summary>

        //判断是否为数字
        public static bool IsNumber(string a)
        {
            if (string.IsNullOrEmpty(a))
                return false;
            foreach (char c in a)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        // 过滤非法字符
        public static string GetSafeValue(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;
            value = Regex.Replace(value, @";", string.Empty);
            value = Regex.Replace(value, @"'", string.Empty);
            value = Regex.Replace(value, @"&", string.Empty);
            value = Regex.Replace(value, @"%20", string.Empty);
            value = Regex.Replace(value, @"--", string.Empty);
            value = Regex.Replace(value, @"==", string.Empty);
            value = Regex.Replace(value, @"<", string.Empty);
            value = Regex.Replace(value, @">", string.Empty);
            value = Regex.Replace(value, @"%", string.Empty);
            return value;
        }
    }
}
