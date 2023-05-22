using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Repositoy
{
    public class ArtistRepository
    {
        static Kpop db = Singleton.getConnection();

        public static List<Artist> GetArtists()
        {
            return (from x in db.Artists select x).ToList();
        }

    }
}