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
        static Kpop db = Singleton.GetConnection();

        public static void Save()
        {
            db.SaveChanges();
        }

        public static void Add(Artist x)
        {
            db.Artists.Add(x); 
            db.SaveChanges();
        }

        public static void Remove(Artist x)
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

        public static Artist FindName(string ArtistName)
        {
            return (from user in db.Artists where user.ArtistName == ArtistName select user).FirstOrDefault();
        }

        public static Artist FindID(int ArtistIDS)
        {
            return (from user in db.Artists where user.ArtistID == ArtistIDS select user).FirstOrDefault();
        }

        public static void Update(Artist updatedArtist, string name, FileUpload imagePath)
        {
            int id = updatedArtist.ArtistID;

            updatedArtist.ArtistID = id;
            updatedArtist.ArtistName = name;
            updatedArtist.ArtistImage = "~/Assets/Image_Artist/" + imagePath.FileName;
            Save();
        }
        public static int DeleteArtist(int id)
        {
            Artist ct = FindID(id);
            db.Artists.Remove(ct);
            return db.SaveChanges();
        }

    }
}