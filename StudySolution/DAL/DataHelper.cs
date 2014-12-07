﻿using System;   
using System.Collections;   
using System.Collections.Specialized;   
using System.Data;   
using System.Data.SqlClient;   
using System.Configuration; 

namespace DAL
{
    public class DataHelper
    {
        public static string connectionString = ConfigurationManager.AppSettings["connectionString"];   

        public DataHelper()   
        {   
        }  
 
        #region 公用方法   
        /// <summary>   
        /// 获取某个表的数量   
        /// </summary>   
        /// <param name="field">主键</param>   
        /// <param name="tableName">表名</param>   
        /// <param name="where">条件</param>   
        /// <returns></returns>   
        public static int GetDataRecordCount(string field, string tableName, string where)   
        {   
            string strsql = "select count(" + field + ") from " + tableName;   
            if (where != "")   
            {   
                strsql += " where " + where;   
            }   
            object obj = DataHelper.GetSingle(strsql);   
            if (obj == null)   
            {   
                return 1;   
            }   
            else  
            {   
                return int.Parse(obj.ToString());   
            }   
  
  
        }   
        public static int GetMaxID(string FieldName, string TableName)   
        {   
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;   
            object obj = DataHelper.GetSingle(strsql);   
            if (obj == null)   
            {   
                return 1;   
            }   
            else  
            {   
                return int.Parse(obj.ToString());   
            }   
        }   
        public static bool Exists(string strSql)   
        {   
            object obj = DataHelper.GetSingle(strSql);   
            int cmdresult;   
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))   
            {   
                cmdresult = 0;   
            }   
            else  
            {   
                cmdresult = int.Parse(obj.ToString());   
            }   
            if (cmdresult == 0)   
            {   
                return false;   
            }   
            else  
            {   
                return true;   
            }   
        }   
        public static bool Exists(string strSql, params SqlParameter[] cmdParms)   
        {   
            object obj = DataHelper.GetSingle(strSql, cmdParms);   
            int cmdresult;   
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))   
            {   
                cmdresult = 0;   
            }   
            else  
            {   
                cmdresult = int.Parse(obj.ToString());   
            }   
            if (cmdresult == 0)   
            {   
                return false;   
            }   
            else  
            {   
                return true;   
            }   
        }  
        #endregion  
 
        #region  执行简单SQL语句   
  
        /// <summary>   
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>   
        /// <param name="SQLString">SQL语句</param>   
        /// <returns>影响的记录数</returns>   
        public static int ExecuteSql(string SQLString)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))   
                {   
                    try  
                    {   
                        connection.Open();   
                        int rows = cmd.ExecuteNonQuery();   
                        return rows;   
                    }   
                    catch (System.Data.SqlClient.SqlException E)   
                    {   
                        connection.Close();   
                        throw new Exception(E.Message);   
                        //ITNB.Base.Error.showError(E.Message.ToString());   
                    }   
                }   
            }   
        }   
  
        /// <summary>   
        /// 执行SQL语句，设置命令的执行等待时间   
        /// </summary>   
        /// <param name="SQLString"></param>   
        /// <param name="Times"></param>   
        /// <returns></returns>   
        public static int ExecuteSqlByTime(string SQLString, int Times)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))   
                {   
                    try  
                    {   
                        connection.Open();   
                        cmd.CommandTimeout = Times;   
                        int rows = cmd.ExecuteNonQuery();   
                        return rows;   
                    }   
                    catch (System.Data.SqlClient.SqlException E)   
                    {   
                        connection.Close();   
                        throw new Exception(E.Message);   
                        // ITNB.Base.Error.showError(E.Message.ToString());   
                    }   
                }   
            }   
        }   
  
        /// <summary>   
        /// 执行多条SQL语句，实现数据库事务。   
        /// </summary>   
        /// <param name="SQLStringList">多条SQL语句</param>        
        public static void ExecuteSqlTran(ArrayList SQLStringList)   
        {   
            using (SqlConnection conn = new SqlConnection(connectionString))   
            {   
                conn.Open();   
                SqlCommand cmd = new SqlCommand();   
                cmd.Connection = conn;   
                SqlTransaction tx = conn.BeginTransaction();   
                cmd.Transaction = tx;   
                try  
                {   
                    for (int n = 0; n < SQLStringList.Count; n++)   
                    {   
                        string strsql = SQLStringList[n].ToString();   
                        if (strsql.Trim().Length > 1)   
                        {   
                            cmd.CommandText = strsql;   
                            cmd.ExecuteNonQuery();   
                        }   
                    }   
                    tx.Commit();   
                }   
                catch (System.Data.SqlClient.SqlException E)   
                {   
                    tx.Rollback();   
                    throw new Exception(E.Message);   
                    //    ITNB.Base.Error.showError(E.Message.ToString());   
                }   
            }   
        }   

        /// <summary>   
        /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)   
        /// </summary>   
        /// <param name="strSQL">SQL语句</param>   
        /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>   
        /// <returns>影响的记录数</returns>   
        public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                SqlCommand cmd = new SqlCommand(strSQL, connection);   
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@fs", SqlDbType.Image);   
                myParameter.Value = fs;   
                cmd.Parameters.Add(myParameter);   
                try  
                {   
                    connection.Open();   
                    int rows = cmd.ExecuteNonQuery();   
                    return rows;   
                }   
                catch (System.Data.SqlClient.SqlException E)   
                {   
                    throw new Exception(E.Message);   
                    //ITNB.Base.Error.showError(E.Message.ToString());   
                }   
                finally  
                {   
                    cmd.Dispose();   
                    connection.Close();   
                }   
            }   
        }   
  
        /// <summary>   
        /// 执行一条计算查询结果语句，返回查询结果（object）。   
        /// </summary>   
        /// <param name="SQLString">计算查询结果语句</param>   
        /// <returns>查询结果（object）</returns>   
        public static object GetSingle(string SQLString)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))   
                {   
                    try  
                    {   
                        connection.Open();   
                        object obj = cmd.ExecuteScalar();   
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))   
                        {   
                            return null;   
                        }   
                        else  
                        {   
                            return obj;   
                        }   
                    }   
                    catch (System.Data.SqlClient.SqlException e)   
                    {   
                        connection.Close();   
                        throw new Exception(e.Message);   
                        //  ITNB.Base.Error.showError(e.Message.ToString());   
                    }   
                }   
            }   
        }   
  
  
        /// <summary>   
        /// 执行查询语句，返回SqlDataReader(使用该方法切记要手工关闭SqlDataReader和连接)   
        /// </summary>   
        /// <param name="strSQL">查询语句</param>   
        /// <returns>SqlDataReader</returns>   
        public static SqlDataReader ExecuteReader(string strSQL)   
        {   
            SqlConnection connection = new SqlConnection(connectionString);   
            SqlCommand cmd = new SqlCommand(strSQL, connection);   
            try  
            {   
                connection.Open();   
                SqlDataReader myReader = cmd.ExecuteReader();   
                return myReader;   
            }   
            catch (System.Data.SqlClient.SqlException e)   
            {   
                throw new Exception(e.Message);   
                // ITNB.Base.Error.showError(e.Message.ToString());   
            }   
            //finally //不能在此关闭，否则，返回的对象将无法使用   
            //{   
            //  cmd.Dispose();   
            //  connection.Close();   
            //}    
  
  
        }   
        /// <summary>   
        /// 执行查询语句，返回DataSet   
        /// </summary>   
        /// <param name="SQLString">查询语句</param>   
        /// <returns>DataSet</returns>   
        public static DataSet Query(string SQLString)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                DataSet ds = new DataSet();   
                try  
                {   
                    connection.Open();   
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);   
                    command.Fill(ds, "ds");   
                }   
                catch (System.Data.SqlClient.SqlException E)   
                {   
                    throw new Exception(E.Message);   
                    //   ITNB.Base.Error.showError(E.Message.ToString());   
                }   
                return ds;   
            }   
        }   
        /// <summary>   
        /// 执行查询语句，返回DataSet,设置命令的执行等待时间   
        /// </summary>   
        /// <param name="SQLString"></param>   
        /// <param name="Times"></param>   
        /// <returns></returns>   
        public static DataSet Query(string SQLString, int Times)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                DataSet ds = new DataSet();   
                try  
                {   
                    connection.Open();   
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);   
                    command.SelectCommand.CommandTimeout = Times;   
                    command.Fill(ds, "ds");   
                }   
                catch (System.Data.SqlClient.SqlException E)   
                {   
                    throw new Exception(E.Message);   
                    //  ITNB.Base.Error.showError(ex.Message.ToString());   
                }   
                return ds;   
            }   
        }  
 
 
 
        #endregion  
 
        #region 执行带参数的SQL语句   
  
        /// <summary>   
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>   
        /// <param name="SQLString">SQL语句</param>   
        /// <returns>影响的记录数</returns>   
        public static int ExecuteSql(string SQLString, params SqlParameter[] cmdParms)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                using (SqlCommand cmd = new SqlCommand())   
                {   
                    try  
                    {   
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);   
                        int rows = cmd.ExecuteNonQuery();   
                        cmd.Parameters.Clear();   
                        return rows;   
                    }   
                    catch (System.Data.SqlClient.SqlException E)   
                    {   
                        throw new Exception(E.Message);   
                        //  ITNB.Base.Error.showError(E.Message.ToString());   
                    }   
                }   
            }   
        }

        /// <summary>   
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>   
        /// <param name="SQLString">SQL语句</param>   
        /// <returns>影响的记录数</returns>   
        public static object ExecuteScalar(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        return obj;
                    }
                    catch (System.Data.SqlClient.SqlException E)
                    {
                        throw new Exception(E.Message);
                        //  ITNB.Base.Error.showError(E.Message.ToString());   
                    }
                }
            }
        }   

        /// <summary>   
        /// 执行多条SQL语句，实现数据库事务。   
        /// </summary>   
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>   
        public static void ExecuteSqlTran(Hashtable SQLStringList)   
        {   
            using (SqlConnection conn = new SqlConnection(connectionString))   
            {   
                conn.Open();   
                using (SqlTransaction trans = conn.BeginTransaction())   
                {   
                    SqlCommand cmd = new SqlCommand();   
                    try  
                    {   
                        //循环   
                        foreach (DictionaryEntry myDE in SQLStringList)   
                        {   
                            string cmdText = myDE.Key.ToString();   
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;   
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);   
                            int val = cmd.ExecuteNonQuery();   
                            cmd.Parameters.Clear();   
  
                            trans.Commit();   
                        }   
                    }   
                    catch  
                    {   
                        trans.Rollback();   
                        throw;   
                    }   
                }   
            }   
        }   
  
  
        /// <summary>   
        /// 执行一条计算查询结果语句，返回查询结果（object）。   
        /// </summary>   
        /// <param name="SQLString">计算查询结果语句</param>   
        /// <returns>查询结果（object）</returns>   
        public static object GetSingle(string SQLString, params SqlParameter[] cmdParms)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                using (SqlCommand cmd = new SqlCommand())   
                {   
                    try  
                    {   
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);   
                        object obj = cmd.ExecuteScalar();   
                        cmd.Parameters.Clear();   
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))   
                        {   
                            return null;   
                        }   
                        else  
                        {   
                            return obj;   
                        }   
                    }   
                    catch (System.Data.SqlClient.SqlException e)   
                    {   
                        throw new Exception(e.Message);   
                        // ITNB.Base.Error.showError(e.Message.ToString());   
                    }   
                }   
            }   
        }   
  
        /// <summary>   
        /// 执行查询语句，返回SqlDataReader (使用该方法切记要手工关闭SqlDataReader和连接)   
        /// </summary>   
        /// <param name="strSQL">查询语句</param>   
        /// <returns>SqlDataReader</returns>   
        public static SqlDataReader ExecuteReader(string SQLString, params SqlParameter[] cmdParms)   
        {   
            SqlConnection connection = new SqlConnection(connectionString);   
            SqlCommand cmd = new SqlCommand();   
            try  
            {   
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);   
                SqlDataReader myReader = cmd.ExecuteReader();   
                cmd.Parameters.Clear();   
                return myReader;   
            }   
            catch (System.Data.SqlClient.SqlException e)   
            {   
                throw new Exception(e.Message);   
                // ITNB.Base.Error.showError(e.Message.ToString());   
            }   
            //finally //不能在此关闭，否则，返回的对象将无法使用   
            //{   
            //  cmd.Dispose();   
            //  connection.Close();   
            //}    
  
        }   
  
        /// <summary>   
        /// 执行查询语句，返回DataSet   
        /// </summary>   
        /// <param name="SQLString">查询语句</param>   
        /// <returns>DataSet</returns>   
        public static DataTable Query(string SQLString, params SqlParameter[] cmdParms)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                SqlCommand cmd = new SqlCommand();   
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);   
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))   
                {   
                    DataSet ds = new DataSet();   
                    try  
                    {   
                        da.Fill(ds, "ds");   
                        cmd.Parameters.Clear();   
                    }   
                    catch (System.Data.SqlClient.SqlException E)   
                    {   
                        throw new Exception(E.Message);   
                    }   
                    return ds.Tables.Count > 0 ? ds.Tables[0] : null;   
                }   
            }   
        }   
  
  
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)   
        {   
            if (conn.State != ConnectionState.Open)   
                conn.Open();   
            cmd.Connection = conn;   
            cmd.CommandText = cmdText;   
            if (trans != null)   
                cmd.Transaction = trans;   
            cmd.CommandType = CommandType.Text;//cmdType;   
            if (cmdParms != null)   
            {   
  
  
                foreach (SqlParameter parameter in cmdParms)   
                {   
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&   
                        (parameter.Value == null))   
                    {   
                        parameter.Value = DBNull.Value;   
                    }   
                    cmd.Parameters.Add(parameter);   
                }   
            }   
        }  
 
        #endregion  
 
        #region 存储过程操作   
  
        /// <summary>   
        /// 执行存储过程  (使用该方法切记要手工关闭SqlDataReader和连接)   
        /// </summary>   
        /// <param name="storedProcName">存储过程名</param>   
        /// <param name="parameters">存储过程参数</param>   
        /// <returns>SqlDataReader</returns>   
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)   
        {   
            SqlConnection connection = new SqlConnection(connectionString);   
            SqlDataReader returnReader;   
            connection.Open();   
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);   
            command.CommandType = CommandType.StoredProcedure;   
            returnReader = command.ExecuteReader();   
            //Connection.Close(); 不能在此关闭，否则，返回的对象将无法使用               
            return returnReader;   
  
        }   
  
  
        /// <summary>   
        /// 执行存储过程   
        /// </summary>   
        /// <param name="storedProcName">存储过程名</param>   
        /// <param name="parameters">存储过程参数</param>   
        /// <param name="tableName">DataSet结果中的表名</param>   
        /// <returns>DataSet</returns>   
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                DataSet dataSet = new DataSet();   
                connection.Open();   
                SqlDataAdapter sqlDA = new SqlDataAdapter();   
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);   
                sqlDA.Fill(dataSet, tableName);   
                connection.Close();   
                return dataSet;   
            }   
        }   
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName, int Times)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                DataSet dataSet = new DataSet();   
                connection.Open();   
                SqlDataAdapter sqlDA = new SqlDataAdapter();   
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);   
                sqlDA.SelectCommand.CommandTimeout = Times;   
                sqlDA.Fill(dataSet, tableName);   
                connection.Close();   
                return dataSet;   
            }   
        }   
        /// <summary>   
        /// 执行存储过程后返回执行结果（标识）   
        /// </summary>   
        /// <param name="storedProcName"></param>   
        /// <param name="parameters"></param>   
        /// <returns></returns>   
        public static string RunProcedureState(string storedProcName, IDataParameter[] parameters)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
  
                connection.Open();   
                SqlDataAdapter sqlDA = new SqlDataAdapter();   
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);   
                sqlDA.SelectCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null)); //增加存储过程的返回值参数   
                sqlDA.SelectCommand.ExecuteNonQuery();   
                connection.Close();   
                return sqlDA.SelectCommand.Parameters["ReturnValue"].Value.ToString();   
            }   
        }   
        /*  
@TableNames VARCHAR(200),    --表名，可以是多个表，但不能用别名  
@PrimaryKey VARCHAR(100),    --主键，可以为空，但@Order为空时该值不能为空  
@Fields    VARCHAR(200),        --要取出的字段，可以是多个表的字段，可以为空，为空表示select *  
@PageSize INT,            --每页记录数  
@CurrentPage INT,        --当前页，0表示第1页  
@Filter VARCHAR(200) = '',    --条件，可以为空，不用填 where  
@Group VARCHAR(200) = '',    --分组依据，可以为空，不用填 group by  
@Order VARCHAR(200) = ''    --排序，可以为空，为空默认按主键升序排列，不用填 order by  
 
         */  
        /// <summary>   
        /// 关键字，显示字段，表，条件，排序，每页显示数，当前页   
        /// </summary>   
        /// <param name="PrimaryKey">主键</param>   
        /// <param name="Fields">要取出的字段</param>   
        /// <param name="TableNames">表名</param>   
        /// <param name="Filter">条件</param>   
        /// <param name="Order">排序</param>   
        /// <param name="PageSize">每页记录数INT</param>   
        /// <param name="CurrentPage">当前页，INT</param>   
        /// <returns></returns>   
        public static DataSet GetPageDataList(string PrimaryKey, string Fields, string TableNames, string Filter, string Order, int PageSize, int CurrentPage)   
        {   
            string tableName = "viewPage";   
            string storedProcName = "P_viewPage";   
            IDataParameter[] p = new IDataParameter[8];   
            p[0] = new SqlParameter("TableNames", TableNames);   
            p[1] = new SqlParameter("PrimaryKey", PrimaryKey);   
            p[2] = new SqlParameter("Fields", Fields);   
            p[3] = new SqlParameter("PageSize", PageSize);   
            p[4] = new SqlParameter("CurrentPage", CurrentPage - 1);   
            p[5] = new SqlParameter("Filter", Filter);   
            p[6] = new SqlParameter("Group", "");   
            p[7] = new SqlParameter("Order", Order);   
  
            return RunProcedure(storedProcName, p, tableName);   
        }   
        public static DataSet GetPageDataList(string PrimaryKey, string Fields, string TableNames, string Filter, string Order, int PageSize, int CurrentPage, string Group)   
        {   
            string tableName = "viewPage";   
            string storedProcName = "P_viewPage";   
            IDataParameter[] p = new IDataParameter[8];   
            p[0] = new SqlParameter("TableNames", TableNames);   
            p[1] = new SqlParameter("PrimaryKey", PrimaryKey);   
            p[2] = new SqlParameter("Fields", Fields);   
            p[3] = new SqlParameter("PageSize", PageSize);   
            p[4] = new SqlParameter("CurrentPage", CurrentPage - 1);   
            p[5] = new SqlParameter("Filter", Filter);   
            p[6] = new SqlParameter("Group", Group);   
            p[7] = new SqlParameter("Order", Order);   
  
            return RunProcedure(storedProcName, p, tableName);   
        }   
        /*  
@TableName VARCHAR(200),     --表名  
@FieldList VARCHAR(2000),    --显示列名，如果是全部字段则为*  
@PrimaryKey VARCHAR(100),    --单一主键或唯一值键  
@Where VARCHAR(2000),        --查询条件 不含'where'字符，如id>10 and len(userid)>9  
@Order VARCHAR(1000),        --排序 不含'order by'字符，如id asc,userid desc，必须指定asc或desc  
--注意当@SortType=3时生效，记住一定要在最后加上主键，否则会让你比较郁闷  
@SortType INT,               --排序规则 1:正序asc 2:倒序desc 3:多列排序方法  
@RecorderCount INT,          --记录总数 0:会返回总记录  
@PageSize INT,               --每页输出的记录数  
@PageIndex INT,              --当前页数  
@TotalCount INT OUTPUT,      --记返回总记录  
@TotalPageCount INT OUTPUT   --返回总页数  
         */  
        public static DataSet GetPageDataList2(string PrimaryKey, string FieldList, string TableName, string Where, string Order, int PageSize, int PageIndex)   
        {   
            string tableName = "viewPage";   
            string storedProcName = "P_viewPage2";   
            IDataParameter[] p = new IDataParameter[11];   
            p[0] = new SqlParameter("TableName", TableName);   
            p[1] = new SqlParameter("FieldList", FieldList);   
            p[2] = new SqlParameter("PrimaryKey", PrimaryKey);   
            p[3] = new SqlParameter("Where", Where);   
            p[4] = new SqlParameter("Order", Order);   
            p[5] = new SqlParameter("SortType", 3);   
            p[6] = new SqlParameter("RecorderCount", 0);   
            p[7] = new SqlParameter("PageSize", PageSize);   
            p[8] = new SqlParameter("PageIndex", PageIndex);   
            p[9] = new SqlParameter("TotalCount", 0);   
            p[10] = new SqlParameter("TotalPageCount", 0);   
  
  
            return RunProcedure(storedProcName, p, tableName);   
        }   
  
        /// <summary>   
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)   
        /// </summary>   
        /// <param name="connection">数据库连接</param>   
        /// <param name="storedProcName">存储过程名</param>   
        /// <param name="parameters">存储过程参数</param>   
        /// <returns>SqlCommand</returns>   
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)   
        {   
            SqlCommand command = new SqlCommand(storedProcName, connection);   
            command.CommandType = CommandType.StoredProcedure;   
            foreach (SqlParameter parameter in parameters)   
            {   
                if (parameter != null)   
                {   
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.   
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&   
                        (parameter.Value == null))   
                    {   
                        parameter.Value = DBNull.Value;   
                    }   
                    command.Parameters.Add(parameter);   
                }   
            }   
  
            return command;   
        }   
  
        /// <summary>   
        /// 执行存储过程，返回影响的行数         
        /// </summary>   
        /// <param name="storedProcName">存储过程名</param>   
        /// <param name="parameters">存储过程参数</param>   
        /// <param name="rowsAffected">影响的行数</param>   
        /// <returns></returns>   
        public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)   
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))   
            {   
                int result;   
                connection.Open();   
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);   
                rowsAffected = command.ExecuteNonQuery();   
                result = (int)command.Parameters["ReturnValue"].Value;   
                //Connection.Close();   
                return result;   
            }   
        }   
  
        /// <summary>   
        /// 创建 SqlCommand 对象实例(用来返回一个整数值)      
        /// </summary>   
        /// <param name="storedProcName">存储过程名</param>   
        /// <param name="parameters">存储过程参数</param>   
        /// <returns>SqlCommand 对象实例</returns>   
        private static SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)   
        {   
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);   
            command.Parameters.Add(new SqlParameter("ReturnValue",   
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,   
                false, 0, 0, string.Empty, DataRowVersion.Default, null));   
            return command;   
        }  
        #endregion  
 
        #region SQL语句式分页   
        /// <summary>      
        /// 智能返回SQL语句      
        /// </summary>      
        /// <param name="primaryKey">主键（不能为空）</param>      
        /// <param name="queryFields">提取字段（不能为空）</param>      
        /// <param name="tableName">表（理论上允许多表）</param>      
        /// <param name="condition">条件（可以空）</param>      
        /// <param name="OrderBy">排序，格式：字段名+""+ASC（可以空）</param>      
        /// <param name="pageSize">分页数（不能为空）</param>      
        /// <param name="pageIndex">当前页，起始为：1（不能为空）</param>      
        /// <returns></returns>      
  
        public static DataSet GetPageDataListSQL(string primaryKey, string queryFields, string tableName, string condition, string orderBy, int pageSize, int pageIndex)   
        {   
            string strTmp = ""; //---strTmp用于返回的SQL语句      
            string SqlSelect = "", SqlPrimaryKeySelect = "", strOrderBy = "", strWhere = " where 1=1 ", strTop = "";   
            //0：分页数量      
            //1:提取字段      
            //2:表      
            //3:条件      
            //4:主键不存在的记录      
            //5:排序      
            SqlSelect = " select top {0} {1} from {2} {3} {4} {5}";   
            //0:主键      
            //1:TOP数量,为分页数*(排序号-1)      
            //2:表      
            //3:条件      
            //4:排序      
            SqlPrimaryKeySelect = " and {0} not in (select {1} {0} from {2} {3} {4}) ";   
  
            if (orderBy != "")   
                strOrderBy = " order by " + orderBy;   
            if (condition != "")   
                strWhere += " and " + condition;   
            int pageindexsize = (pageIndex - 1) * pageSize;   
            if (pageindexsize > 0)   
            {   
                strTop = " top " + pageindexsize.ToString();   
  
                SqlPrimaryKeySelect = String.Format(SqlPrimaryKeySelect, primaryKey, strTop, tableName, strWhere, strOrderBy);   
  
                strTmp = String.Format(SqlSelect, pageSize.ToString(), queryFields, tableName, strWhere, SqlPrimaryKeySelect, strOrderBy);   
  
            }   
            else  
            {   
                strTmp = String.Format(SqlSelect, pageSize.ToString(), queryFields, tableName, strWhere, "", strOrderBy);   
  
            }   
            return Query(strTmp);   
        }     
        #endregion  

        #region 获取安全的SQL字符串   
        /// <summary>   
        /// 获取安全的SQL字符串   
        /// </summary>   
        /// <param name="sql"></param>   
        /// <returns></returns>   
        public static string GetSafeSQLString(string sql)   
        {   
            sql = sql.Replace(",", "，");   
            sql = sql.Replace(".", "。");   
            sql = sql.Replace("(", "（");   
            sql = sql.Replace(")", "）");   
            sql = sql.Replace(">", "＞");   
            sql = sql.Replace("<", "＜");   
            sql = sql.Replace("-", "－");   
            sql = sql.Replace("+", "＋");   
            sql = sql.Replace("=", "＝");   
            sql = sql.Replace("?", "？");   
            sql = sql.Replace("*", "＊");   
            sql = sql.Replace("|", "｜");   
            sql = sql.Replace("&", "＆");   
            return sql;   
        }  
        #endregion   
    }
}
