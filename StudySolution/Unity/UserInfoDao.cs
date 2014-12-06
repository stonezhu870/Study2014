using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATMSolution.Model;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; //专门用于操作Mssql的命令空间

namespace Unity
{
    public class UserInfoDao
    {
        private string ConnectionString
        {
            get
            {
                //引用System.Configuration类库，可以调用到Web.config的配置
                return ConfigurationManager.AppSettings["connectionString"];
            }
        }

        /// <summary>
        /// 利用SqlDataReader获取数据
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetList()
        {
            List<UserInfo> ret = new List<UserInfo>();

            //链接数据步骤
            //第一步，创建连接
            //创建执行命令
            //执行
            //关闭数据库连接
            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = conn; //告诉Sql命令类，数据库连接是什么
            command.CommandText = "select * from userInfo"; //sql语句是什么

            conn.Open();
            //执行非查询的命令
            //command.ExecuteNonQuery();

            SqlDataReader reader = null;

            try
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var userInfo = new UserInfo();
                    userInfo.Id = Convert.ToInt32(reader["Id"]);
                    userInfo.CustomerName = Convert.ToString(reader["CustomerName"]);
                    userInfo.Pid = Convert.ToString(reader["Pid"]);
                    userInfo.TelPhone = Convert.ToString(reader["TelePhone"]);
                    userInfo.CreateTime = Convert.ToDateTime(reader["CreateTime"]);
                    userInfo.Address = Convert.ToString(reader["Address"]);

                    ret.Add(userInfo);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                conn.Close();
            }

            return ret;
        }

        public DataTable GetTable()
        {
            //链接数据步骤
            //第一步，创建连接
            //创建执行命令
            //数据适配器进行装载数据
            //关闭数据库连接

            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlDataAdapter sda = new SqlDataAdapter("select * from userInfo", conn);

            DataSet ds = new DataSet();

            try
            {
                sda.Fill(ds);
            }
            finally
            {
                conn.Close();
            }

            var dataTable = ds.Tables[0];

            return dataTable;
        }

        public bool UpdateUserInfo(int id, string pid)
        {
            //链接数据步骤
            //第一步，创建连接
            //创建执行命令
            //执行
            //关闭数据库连接
            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = conn; //告诉Sql命令类，数据库连接是什么
            //command.CommandText = "update userInfo set pid= '"+ pid +"' where id= " + id; //sql语句是什么
            command.CommandText = "update userInfo set pid= @pid where id = @id"; //sql语句是什么
            command.Parameters.Add(new SqlParameter("pid", pid));
            command.Parameters.Add(new SqlParameter("id", id));

            try
            {
                conn.Open();
                
                var count = command.ExecuteNonQuery();
                
                return count > 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
