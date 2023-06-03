using project.Model;
using project.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View.Quest
{
    public partial class Quest_ArtistDetail : System.Web.UI.Page
    {
        public List<Artist> Artists = new List<Artist>();
        public List<Album> Albums = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (IsPostBack == false)
                {
                    int id = Convert.ToInt32(Request["ID"]);
                    Artists = ArtistRepository.GetArtistsDetail(id);

                    Quest_GridView_ArtistDetail.DataSource = Artists;
                    Quest_GridView_ArtistDetail.DataBind();

                    Albums = AlbumRepository.GetAlbumArtist(id);
                    Quest_GridView_Album.DataSource = Albums;
                    Quest_GridView_Album.DataBind();
                }
            }
        }
    }
}