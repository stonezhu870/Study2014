using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace ChengLi
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Init();
            }
        }

        private void Init()
        {
            var bll = new ProductTypeBll();

            //产品中心
            var list = bll.GetList(SmallType.Products);
            repProductList.DataSource = list;
            repProductList.DataBind();

            //产品中心
            var newsList = bll.GetList(SmallType.News);
            repNewList.DataSource = newsList;
            repNewList.DataBind();
        }
    }
}