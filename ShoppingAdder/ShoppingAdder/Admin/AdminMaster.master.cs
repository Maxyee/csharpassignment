using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingAdder.Admin
{
    public partial class AdminMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ShoppingAddedAdmin"] == null)
            {
                Response.Redirect("~/Admin/Login.aspx");
            }
        }
    }
}