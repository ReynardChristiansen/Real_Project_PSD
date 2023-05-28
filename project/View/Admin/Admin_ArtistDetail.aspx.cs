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
    public partial class Admin_ArtistDetail : System.Web.UI.Page
    {
        public List<Artist> Artists = new List<Artist>();
        public List<Album> Albums = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request["ID"]);
                Artists = ArtistRepository.GetArtistsDetail(id);

                Admin_GridView_ArtistDetail.DataSource = Artists;
                Admin_GridView_ArtistDetail.DataBind();

                Albums = AlbumRepository.GetAlbumArtist(id);
                Admin_GridView_Album.DataSource = Albums;
                Admin_GridView_Album.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["ID"]);
            Response.Redirect("Admin_InsertAlbum.aspx?ID=" + id);

        }
    }
}