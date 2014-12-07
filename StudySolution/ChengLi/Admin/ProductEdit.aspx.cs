using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace ChengLi.Admin
{
    public partial class ProductEdit : System.Web.UI.Page
    {
        private ProductTypeBll bll = new ProductTypeBll();
        private ProductBll productBll = new ProductBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Init();
            }
        }

        private void Init()
        {
            var sb = new StringBuilder();

            //加载默认新闻的类别
            var table = bll.GetTable(SmallType.News);

            sb.AppendFormat("newsType={0};", table == null || table.Rows.Count == 0 ? "[]" : Json.ToString(table));

            sb.AppendLine();

            //商品类别
            var pTable = bll.GetTable(SmallType.Products);

            sb.AppendFormat("productType={0};", pTable == null || pTable.Rows.Count == 0 ? "[]" : Json.ToString(pTable));

            CreateTime.Text = DateTime.Now.ToString("yyyy-MM-dd");

            litJs.Text = string.Format("<script>{0}</script>", sb.ToString());
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product();

            product.Title = txtTitle.Text;
            product.TypeId = Common.SafeInt(TypeIdVal.Value);
            product.ClickCount = Common.SafeInt(ClickCount.Text);
            product.MConent =  hidMConent.Value;
            product.CreateTime = Convert.ToDateTime(CreateTime.Text);

            product.SmallType = GetSmallType();

            var result = productBll.Save(product);

            litJs.Text = string.Format("<script>afterSave({0});</script>", result.ToString().ToLower());
        }

        private string GetSmallType()
        {
            var productType = "";
            if (SmallType1.Checked == true)
                productType = SmallType.News;
            else if (SmallType2.Checked == true)
                productType = SmallType.Products;

            return productType;
        }
    }
}