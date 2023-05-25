using project.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View.Admin
{
    public partial class Admin_InsertArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ArtistName = txt_ArtistName.Text;
            FileUpload image = ImageUpload;
            string temp = ArtistController.isUnique(ArtistName);
            string temp2 = ArtistController.IsFileValid(ImageUpload);

            if (temp == "")
            {
                if(temp2 == "")
                {
                    ArtistController.registration(ArtistName, "~/Assets/Image_Artist/" + image.FileName);
                    ImageUpload.SaveAs(Server.MapPath("~/Assets/Image_Artist/" + ImageUpload.FileName));
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