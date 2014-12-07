using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class ProductTypeBll
    {
        public int Save(ProductType type)
        {
            var sql = "INSERT INTO ProductType(TypeName, SmallType )VALUES  (@TypeName, @SmallType); select @@identity;";

            var ps = new List<SqlParameter>();

            ps.Add(new SqlParameter("TypeName", type.TypeName));
            ps.Add(new SqlParameter("SmallType", type.SmallType));

            var result = DataHelper.ExecuteScalar(sql, ps.ToArray());

            return Common.SafeInt(result, -1);
        }

        public DataTable GetTable(string type)
        {
            //写一个sql语句取对应分类的列表
            var sql = "SELECT Id, TypeName FROM ProductType WHERE SmallType = @type";
            var p = new SqlParameter("type", type);

            return DataHelper.Query(sql, p);
        }

        public List<ProductType> GetList(string type)
        {
            var sql = "SELECT Id, TypeName, SmallType FROM ProductType WHERE SmallType = @type";
            var p = new SqlParameter("type", type);

            var reader = DataHelper.ExecuteReader(sql, p);

            var ret = new List<ProductType>();

            while (reader.Read())
            {
                var model = new ProductType();
                model.Id = Convert.ToInt32(reader["Id"]);
                model.TypeName = Convert.ToString(reader["TypeName"]);
                model.SmallType = Convert.ToString(reader["SmallType"]);

                ret.Add(model);
            }

            reader.Close();

            return ret;
        }
    }
}
