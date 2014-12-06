using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManager.Ajax
{
    public partial class CommonAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Requst["name"] //能取POST给我的数据和GET给我的数据
            //Request.QueryString["name"] //服务器只能取到Get给我的参数

            Response.Write("{\"status\":true}");
        }
    }
}