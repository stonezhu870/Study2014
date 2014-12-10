using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public class ProductDao
    {
        public bool Save(Product product)
        {
            var sql = @"INSERT INTO Product 
           (Title
           ,CreateTime
           ,TypeId
           ,ClickCount
           ,MConent
           ,SmallType)
     VALUES
           (@Title,
            @CreateTime,
            @TypeId,
            @ClickCount,
            @MConent,
            @SmallType)";

            var ps = new List<SqlParameter>();
            ps.Add(new SqlParameter("Title", product.Title));
            ps.Add(new SqlParameter("CreateTime", product.CreateTime));
            ps.Add(new SqlParameter("TypeId", product.TypeId));
            ps.Add(new SqlParameter("ClickCount", product.ClickCount));
            ps.Add(new SqlParameter("MConent", product.MConent));
            ps.Add(new SqlParameter("SmallType", product.SmallType));

            var count = DataHelper.ExecuteSql(sql, ps.ToArray());

            return count > 0;
        }

        public List<Product> GetList(string smallType, int typeid)
        {
            var sql = "SELECT Id ,Title  ,CreateTime  ,TypeId  ,ClickCount  ,MConent  ,SmallType from Product WHERE SmallType = @smallType ";

            var ps = new List<SqlParameter>();

            ps.Add(new SqlParameter("smallType", smallType));

            if (typeid != -1)
            {
                sql = sql + " and TypeId = @typeid";

                ps.Add(new SqlParameter("typeid", typeid));
            }

            var reader = DataHelper.ExecuteReader(sql, ps.ToArray());

            var ret = new List<Product>();

            while (reader.Read())
            {
                var model = new Product();
                model.Id = Convert.ToInt32(reader["Id"]);
                model.Title = Convert.ToString(reader["Title"]);
                model.MConent = Convert.ToString(reader["MConent"]);
                model.ClickCount = Convert.ToInt32(reader["ClickCount"]);
                model.SmallType = Convert.ToString(reader["SmallType"]);
                model.TypeId = Convert.ToInt32(reader["TypeId"]);
                model.CreateTime = Convert.ToDateTime(reader["CreateTime"]);

                ret.Add(model);
            }

            reader.Close();

            return ret;
        }

        public Product GetProduct(int id)
        {
            var sql = "SELECT Id ,Title  ,CreateTime  ,TypeId  ,ClickCount  ,MConent  ,SmallType from Product WHERE Id = @id ";

            var ps = new List<SqlParameter>();

            ps.Add(new SqlParameter("id", id));

            var reader = DataHelper.ExecuteReader(sql, ps.ToArray());

            Product model = null;

            while (reader.Read())
            {
                model = new Product();

                model.Id = Convert.ToInt32(reader["Id"]);
                model.Title = Convert.ToString(reader["Title"]);
                model.MConent = Convert.ToString(reader["MConent"]);
                model.ClickCount = Convert.ToInt32(reader["ClickCount"]);
                model.SmallType = Convert.ToString(reader["SmallType"]);
                model.TypeId = Convert.ToInt32(reader["TypeId"]);
                model.CreateTime = Convert.ToDateTime(reader["CreateTime"]);
            }

            reader.Close();

            return model;
        }

        public void UpdateClick(int id)
        {
            var sql = "update Product set ClickCount = ClickCount + 1  WHERE Id = @id ";

            var ps = new List<SqlParameter>();

            ps.Add(new SqlParameter("id", id));

            DataHelper.ExecuteSql(sql, ps.ToArray());
        }
    }
}
