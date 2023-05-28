using project.Factory;
using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

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

        public static List<Artist> GetArtistsDetail(int id)
        {
            return (from x in db.Artists where x.ArtistID == id select x).ToList();
        }

        public static int NextID()
        {
            if (db.Artists.Count() == 0)
                return 0;
            return db.Artists.Max(x => x.ArtistID) + 1;
        }

        public static Artist findName(string ArtistName)
        {
            return (from user in db.Artists where user.ArtistName == ArtistName select user).FirstOrDefault();
        }

        public static Artist findID(int ArtistIDS)
        {
            return (from user in db.Artists where user.ArtistID == ArtistIDS select user).FirstOrDefault();
        }

        public static void Update(Artist updatedArtist, string name, FileUpload imagePath)
        {
            int id = updatedArtist.ArtistID;

            updatedArtist.ArtistID = id;
            updatedArtist.ArtistName = name;
            updatedArtist.ArtistImage = "~/Assets/Image_Artist/" + imagePath.FileName;
            save();
        }

    }
}