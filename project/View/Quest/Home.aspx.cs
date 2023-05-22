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
    public partial class Home : System.Web.UI.Page
    {
        public List<Artist> Artists = new List<Artist>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Artists = ArtistRepository.GetArtists();
        }
    }
}