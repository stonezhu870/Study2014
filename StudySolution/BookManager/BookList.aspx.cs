using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ATMSolution.Model;
using Unity;


namespace BookManager
{
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "http://www.sohu.com";

            linkb.HRef = "http://www.sohu.com";

            Label1.Text = DateTime.Now.ToString();

            //服务器控件的Visible属性，如果visible为false, asp.net是不会将此控件的html代码生成到客户端的
            //visiable 和display:none的选用
            PlaceHolder1.Visible = false;

            Init();
        }

        private void Init()
        {
            var dao = new UserInfoDao();

            //获取用户信息对象作为数据源绑定到Reperter
            var userInfoList = dao.GetList(); //FileHelper.GetUserInfos();
            Repeater1.DataSource = userInfoList;
            Repeater1.DataBind(); //调用了DataBind方法才会真正绑定到控件上

            DropDownList1.DataSource = userInfoList;
            DropDownList1.DataTextField = "CustomerName";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();

            //Session["name"] = "aaa";
            Repeater2.DataSource =  dao.GetTable();
            Repeater2.DataBind(); //调用了DataBind方法才会真正绑定到控件上

            Repeater3.DataSource = DataHelper.Query("SELECT * FROM cardInfo");
            Repeater3.DataBind();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            using (var tran = new TransactionScope())
            {
                //去新增交易记录表

                //去更新余额

                tran.Complete();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var pid = TextBox2.Text;

            var dao = new UserInfoDao();
            
            using (var tran = new TransactionScope())
            {
                var result = dao.UpdateUserInfo(1, pid);

                Label4.Text = result ? "成功" : "失败";
            }
        }
    }
}