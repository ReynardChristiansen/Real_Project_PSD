using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View.Admin
{
    public partial class Admin_Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void yes_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;

            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);

            }

            Session.Remove("userAuth");
            Session.Remove("role");
            Session.Remove("name");
            Response.Redirect("~/View/Quest/Home.aspx");
        }

        protected void no_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/Admin_Home.aspx");
        }
    }
}