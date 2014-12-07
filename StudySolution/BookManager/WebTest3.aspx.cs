using ATMSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity;

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
            var dao = new UserInfoDao();

            var userInfoList = FileHelper.GetUserInfos();
            Repeater1.DataSource = userInfoList;
            Repeater1.DataBind();

            Repeater2.DataSource = dao.GetTable();
            Repeater2.DataBind();
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var pid = TextBox1.Text;

            var dao = new UserInfoDao();

            using (var tran = new TransactionScope())
            {
                var result = dao.UpdateUserInfo(1, pid);

                Label2.Text = result ? "成功" : "失败";
            }
        }

     
    }
}