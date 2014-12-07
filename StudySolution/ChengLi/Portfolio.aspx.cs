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
    public partial class Portfolio : System.Web.UI.Page
    {
        private int TypeId = -1;
        protected string SmallTypeVal;

        protected void Page_Load(object sender, EventArgs e)
        {
            //取出Get参数中的Type，标记用户到底选的是哪一个分类
            var type = Request["type"];
            if (!string.IsNullOrWhiteSpace(type))
            {
                TypeId = Common.SafeInt(type, -1);
            }

            var smallType = Request["st"];
            if (!string.IsNullOrWhiteSpace(smallType))
            {
                if (smallType == SmallType.News || smallType == SmallType.Products)
                    SmallTypeVal = smallType;
            }

            if (!IsPostBack)
            {
                Init();
            }
        }

        private void Init()
        {
            if (SmallTypeVal == SmallType.News)
                lbTitle.Text = "新闻中心";
            else if (SmallTypeVal == SmallType.Products)
                lbTitle.Text = "产品中心";
            else
                throw new Exception("未知的类型");

            var bll = new ProductTypeBll();

            var newsList = bll.GetList(SmallTypeVal);
            repList.DataSource = newsList;
            repList.DataBind();

            var productBll = new ProductBll();
            var productList = productBll.GetList(SmallTypeVal, TypeId);
            repList2.DataSource = productList;
            repList2.DataBind();
        }

        protected string GetSelectedClass(object inputType)
        {
            int val = Common.SafeInt(inputType, -1);

            if (val == TypeId)
                return "selected-1";

            return "";
        }
    }
}