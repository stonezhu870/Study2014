using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ChengLi
{
    public partial class Single : System.Web.UI.Page
    {
        private int ProductId = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request["id"];

            if (!string.IsNullOrWhiteSpace(id))
            {
                ProductId = Model.Common.SafeInt(id);
            }

            if (!IsPostBack)
            {
                Init();
            }
        }

        private void Init()
        {
            var bll = new ProductBll();

            var product = bll.GetProduct(ProductId);

            if (product == null)
                throw new Exception("未能找到合适的商品");

            lbClickCount.Text = product.ClickCount.ToString();
            lbTitle.Text = product.Title;
            this.Title = "详情-" + lbTitle.Text;
            this.litHtml.Text = product.MConent;
            this.lbCreateTime.Text = product.CreateTime.ToString("yyyy-MM-dd");

            //更新点击数
            bll.UpdateClick(ProductId);
        }
    }
}