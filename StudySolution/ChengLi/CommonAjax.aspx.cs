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
    public partial class CommonAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var fun = Request["fun"];

            if (fun == "addType")
            {
                AddType();
            }
        }

        private void AddType()
        {
            var type = new ProductType();
            type.TypeName = Request["TypeName"];
            type.SmallType = Request["SmallType"];

            var bll = new ProductTypeBll();
            var id = bll.Save(type);

            Response.Write(id);
        }
    }
}