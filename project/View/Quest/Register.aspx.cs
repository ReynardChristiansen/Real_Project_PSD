using project.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View.Quest
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Register_Click(object sender, EventArgs e)
        {
            string temp = RegisterController.validation(txt_Name.Text, txt_Email.Text, txt_Password.Text, txt_Address.Text, rb_Gender.SelectedValue);
            if (temp == "")
            {
                label_Error.Visible = false;
                RegisterController.registration(txt_Name.Text, txt_Email.Text, txt_Password.Text, txt_Address.Text, rb_Gender.SelectedValue, "Cust");
            }
            else
            {
                label_Error.Text = temp;
                label_Error.Visible = true;
            }
        }
    }
}