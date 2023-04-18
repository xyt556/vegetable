using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Mahoroshi.Database
{
    /// <summary>
    /// OLE DB数据库适配器
    /// </summary>
    public class MiaoOleDbAdapter
    {
        /// <summary>
        /// 数据库路径
        /// </summary>
        private string _dbPath;
        /// <summary>
        /// OLE DB数据库连接
        /// </summary>
        private OleDbConnection _dbCon = new OleDbConnection();

        /// <summary>
        /// 数据库文件名+绝对路径
        /// </summary>
        public string DbPath
        {
            get { return _dbPath; }
            set 
            { 
                _dbPath = value;
                _dbCon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                    "Data Source=" +_dbPath;
            }
        }

        /// <summary>
        /// 新建 数据库访问连接（默认数据库文件）
        /// </summary>
        public MiaoOleDbAdapter()
        {
            _dbPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName)
            + "\\植物信息系统.mdb";
            _dbCon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 
                _dbPath;
        }
        /// <summary>
        /// 新建 数据库访问连接
        /// </summary>
        /// <param name="dbFile">数据库绝对路径+文件名</param>
        public MiaoOleDbAdapter(string dbFile)
            : base()
        {
            _dbPath = dbFile;
            _dbCon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _dbPath;
        }
        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <returns></returns>
        public bool Test()
        {
            try
            {
                _dbCon.Open();
                _dbCon.Close();
                return true;
            }
            catch(Exception ex)
            {
                _dbCon.Close();
                throw ex;
            }
        }
        /// <summary>
        /// 以指定SQL命令查询数据库
        /// </summary>
        /// <param name="cmdStr">SQL命令语句</param>
        /// <returns>查询结果表</returns>
        public DataTable GetDataTable(string cmdStr)
        {
            try
            {
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(cmdStr, _dbCon);    // 创建 SQL命令执行器
                _dbCon.Open();                                          // 打开 数据库
                OleDbDataReader rd = cmd.ExecuteReader();               // 创建 数据阅读器 并执行命令
                dt.Load(rd);                                            // 填充 数据表
                _dbCon.Close();                                         // 关闭 数据库

                return dt;
            }
            catch (Exception ex)                                        // 捕捉到异常？
            {
                _dbCon.Close();                                         // 关闭 数据库[防出错处理]
                throw ex;                                               // 抛出异常 等待上级程序处理
            }
        }
        /// <summary>
        /// 以指定SQL命令向数据库中添加或修改数据
        /// </summary>
        /// <param name="cmdStr">SQL命令语句</param>
        /// <returns>受影响的行数</returns>
        public int SetDataLines(string cmdStr)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(cmdStr, _dbCon);    // 创建 SQL命令执行器
                _dbCon.Open();                                          // 打开 数据库
                int l = cmd.ExecuteNonQuery();                          // 执行 SQL命令
                _dbCon.Close();                                         // 关闭 数据库

                return l;                                               // 返回 数据库执行结果
            }
            catch (Exception ex)                                        // 捕捉到异常？
            {
                _dbCon.Close();                                         // 关闭数据库[防出错处理]
                throw ex;                                               // 抛出异常 等待上级程序处理
            }
        }
        /// <summary>
        /// 以指定SQL命令向数据库中更新OLE对象
        /// </summary>
        /// <param name="cmdStr">含有存储参数的SQL更新命令</param>
        /// <param name="olePara">OLE对象存储参数名</param>
        /// <param name="oleBuffer">OLE对象数据</param>
        /// <returns>受影响的行数</returns>
        public int SetOleObject(string cmdStr, string olePara, byte[] oleBuffer)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(cmdStr, _dbCon);    // 创建 SQL命令执行器
                cmd.Parameters.AddWithValue(olePara, oleBuffer);
                _dbCon.Open();                                          // 打开 数据库
                int l = cmd.ExecuteNonQuery();                          // 执行 SQL命令
                _dbCon.Close();                                         // 关闭 数据库

                return l;                                               // 返回 数据库执行结果
            }
            catch (Exception ex)                                        // 捕捉到异常？
            {
                _dbCon.Close();                                         // 关闭数据库[防出错处理]
                throw ex;                                               // 抛出异常 等待上级程序处理
            }
        }
    }
}
