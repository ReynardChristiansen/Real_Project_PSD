using project.Controller;
using project.Model;
using project.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View.Admin
{
    public partial class Admin_UpdateAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_UpdateAlbum_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["ID"]);
            string name = txt_Name.Text;
            string desc = txt_Desc.Text;
            FileUpload image = ImageUpload;


            int price = Convert.ToInt32(txt_Price.Text);
            int stock = Convert.ToInt32(txt_Stock.Text);
            Album albums = AlbumRepository.FindAlbumbyID(id);

            string temp = AlbumController.validation(name, desc, price, stock, image);

            if (temp == "")
            {
                AlbumController.Update(albums , name, desc, price, stock, image, id);
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