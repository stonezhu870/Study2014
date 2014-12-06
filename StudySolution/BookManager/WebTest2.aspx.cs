using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManager
{
    public partial class WebTest2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取母板页
            //this.Page.Master

            //执行顺序
            //先是自己的Page_load
            //然后再是母板页的Page_load
            
            //Url中传递参数，多个参数用&符号分隔，参数和网页地址之间用？号分隔
            //webtest2.aspx?id=1

            //通过Request[""]可以取到Url中提交过来的内容，取不到会范围null
            var str = Request["id"];

            //是否是一个回传的请求
            var tmp = this.IsPostBack;
            if (this.IsPostBack == false)
            {
                Init();
                //session夸页面保存数据，可以记录当前的会话内容
                //ViewState也可以记录会话信息，但是仅对于当前页面，不能夸页面
                var username = Session["name"];
            }
        }

        private string GlobalsVerb
        {
            get
            {
                if (ViewState["GlobalsVerb"] == null)
                    return "";
                else
                    return ViewState["GlobalsVerb"].ToString();
            }
            set { ViewState["GlobalsVerb"] = value; }
        }

        private void Init()
        {
            GlobalsVerb = "1";
        }

        private void Init2()
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //如果有按钮的回传事件，那么也是先走Page_load，然后走按钮事件
            string a = "1";

            string b = GlobalsVerb;
        }
    }
}