using project.Controller;
using project.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View.Admin
{
    public partial class Admin_InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["ID"]);
            string name = txt_Name.Text;
            string desc = txt_Desc.Text;
            FileUpload image = ImageUpload;


            int price = Convert.ToInt32(txt_Price.Text);
            int stock = Convert.ToInt32(txt_Stock.Text);

            string temp = AlbumController.validation(name, desc, price, stock, image);

            if (temp == "")
            {
                AlbumController.registration(id, name, desc, price, stock, "~/Assets/Album_Artist/" + image.FileName);
                ImageUpload.SaveAs(Server.MapPath("~/Assets/Album_Artist/" + ImageUpload.FileName));
                Response.Redirect("~/View/Admin/Admin_ArtistDetail.aspx");
            }
            else
            {
                   lbl_Error.Text = temp;
                   lbl_Error.Visible = true;
            }
        }
    }
}