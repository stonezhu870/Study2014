using ATMSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManager
{
    public partial class WebTest3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Init2();
            Label1.Text = DateTime.Now.ToString();
            
        }
        private void Init2()
        {
            var userInfoList = FileHelper.GetUserInfos();
            Repeater1.DataSource = userInfoList;
            Repeater1.DataBind();


        }
    }
}