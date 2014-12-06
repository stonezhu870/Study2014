using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using BookManager;

namespace BookManager
{
    public class Global : HttpApplication
    {
        /// <summary>
        /// 网站最开始启动时走的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Start(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 网站停止时走的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Application_End(object sender, EventArgs e)
        {
            //  在应用程序关闭时运行的代码

        }

        void Application_Error(object sender, EventArgs e)
        {
            // 在出现未处理的错误时运行的代码
        }

        /// <summary>
        /// 会话开始时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Session_Start(Object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 会话结束时(超时和注销)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Session_End(Object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 每一次访问触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            //Request : 请求
            //Response ： 响应
        }

        /// <summary>
        /// 每一次访问完之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_EndRequest(Object sender, EventArgs e)
        {

        }  
    }
}
