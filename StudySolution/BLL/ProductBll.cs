using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class ProductBll
    {
        ProductDao dal = new ProductDao();

        public bool Save(Product product)
        {
            return dal.Save(product);
        }


        public List<Product> GetList(string smallType, int typeid)
        {
            return dal.GetList(smallType, typeid);
        }

        public Product GetProduct(int id)
        {
            return dal.GetProduct(id);
        }

        public void UpdateClick(int id)
        {
            dal.UpdateClick(id);
        }
    }
}
