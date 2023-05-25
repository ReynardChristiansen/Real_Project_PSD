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
    public partial class Admin_UpdateArtist : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request["ID"]);
                Artist updateArtist = ArtistRepository.findID(id);

                txt_ArtistName.Text = updateArtist.ArtistName;
                ImageTobeUpdated.ImageUrl = updateArtist.ArtistImage;
            }
            


        }

        protected void submit_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["ID"]);
            string ArtistName = txt_ArtistName.Text;
            FileUpload image = ImageUpload;
            string temp = ArtistController.isUnique(ArtistName);
            string temp2 = ArtistController.IsFileValid(ImageUpload);
            Artist artists = ArtistRepository.findID(id);

            if (temp == "")
            {
                if (temp2 == "")
                {
                    ArtistRepository.Update(artists, ArtistName, "~/Assets/Image_Artist/" + image.FileName);
                    ImageUpload.SaveAs(Server.MapPath("~/Assets/Image_Artist/" + ImageUpload.FileName));
                    Response.Redirect("~/View/Admin/Admin_Home.aspx");
                }
                else
                {
                    lbl_Error.Text = "File must be filled, File extension must be correct and less than 2mb";
                    lbl_Error.Visible = true;
                }


            }
            else
            {
                lbl_Error.Text = temp;
                lbl_Error.Visible = true;
            }
        }
    }
}