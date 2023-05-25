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

        public static void save()
        {
            db.SaveChanges();
        }

        public static void add(Artist x)
        {
            db.Artists.Add(x); 
            db.SaveChanges();
        }

        public static void remove(Artist x)
        {
            db.Artists.Remove(x);
            db.SaveChanges();
        }

        public static List<Artist> GetArtists()
        {
            return (from x in db.Artists select x).ToList();
        }

    }
}