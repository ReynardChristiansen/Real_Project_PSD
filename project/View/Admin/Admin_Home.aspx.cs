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
    public partial class Admin_Home : System.Web.UI.Page
    {
        public List<Artist> Artists = new List<Artist>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Artists = ArtistRepository.GetArtists();
            Admin_GridView.DataSource = Artists;
            Admin_GridView.DataBind();
        }

        protected void insrt_artist_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/Admin_InsertArtist.aspx");
        }
    }
}