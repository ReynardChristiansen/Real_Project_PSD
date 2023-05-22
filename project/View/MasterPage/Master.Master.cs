using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View.MasterPage
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel_Customer.Visible = false;
            Panel_Admin.Visible = false;

            var session = Session["role"];
            if(session == null)
            {
                Label1.Text = "Not Login yet";
            }
            else if (session.ToString().Equals("Cust"))
            {
                Panel_Customer.Visible = true;
                Panel_Admin.Visible = false;
                Panel_Quest.Visible = false;
            }
            else if (session.ToString().Equals("Adm"))
            {
                Panel_Customer.Visible = false;
                Panel_Admin.Visible = true;
                Panel_Quest.Visible = false;
            }
            
                
                        
        }

        protected void btn_Quest_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Quest/Login.aspx");
        }

        protected void btn_Quest_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Quest/Register.aspx");
        }

        protected void btn_Customer_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Cust/Cust_Home.aspx");
        }

        protected void btn_Customer_Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Cust/Cust_Cart.aspx");
        }

        protected void btn_Customer_Transaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Cust/Cust_Transaction.aspx");
        }

        protected void btn_Customer_UpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Cust/Cust_UpdateProfile.aspx");
        }

        protected void btn_Customer_Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Cust/Cust_Logout.aspx");
        }

        protected void btn_Admin_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/Admin_Home.aspx");
        }

        protected void btn_Admin_Transaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/Admin_Transaction.aspx");
        }

        protected void btn_Admin_UpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/Admin_UpdateProfile.aspx");
        }

        protected void btn_Admin_Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/Admin_Logout.aspx");
        }

        protected void btn_Quest_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Quest/Home.aspx");
        }
    }
}