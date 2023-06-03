using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace project.Repositoy
{
    public class AlbumRepository
    {
        static Kpop db = Singleton.GetConnection();

        public static void Save()
        {
            db.SaveChanges();
        }

        public static void Add(Album x)
        {
            db.Albums.Add(x);
            db.SaveChanges();
        }

        public static void Remove(Album x)
        {
            db.Albums.Remove(x);
            db.SaveChanges();
        }

        public static List<Album> GetAlbum()
        {
            return (from x in db.Albums select x).ToList();
        }

        public static List<Album> GetAlbumArtist(int id)
        {
            return (from x in db.Albums where x.ArtistID == id select x).ToList();
        }

        public static int NextID()
        {
            if (db.Albums.Count() == 0)
                return 0;
            return db.Albums.Max(x => x.AlbumID) + 1;
        }

        public static List<Album> GetAlbums(int id)
        {
            return (from x in db.Albums where x.AlbumID == id select x).ToList();
        }

        public static Album FindAlbumbyID(int id)
        {
            return (from x in db.Albums where x.AlbumID == id select x).FirstOrDefault();
        }

        public static List<Album> ByArtist(List<Album> y)
        {
            return (from x in db.Albums select x).ToList();
        }
        public static void DeleteAlbums(List<Album> x)
        {
            db.Albums.RemoveRange(x);
            db.SaveChanges();
        }

        public static void AddAlbums(List<Album> x)
        {
            db.Albums.AddRange(x);
            db.SaveChanges();
        }

        public static void Update(Album updatedAlbum, string name,FileUpload image,int price,int stock,string description, int id)
        {
            int ArtistID = Convert.ToInt32(updatedAlbum.ArtistID);

            updatedAlbum.AlbumID = id;
            updatedAlbum.ArtistID = ArtistID;
            updatedAlbum.AlbumName = name;
            updatedAlbum.AlbumPrice = price;
            updatedAlbum.AlbumStock = stock;
            updatedAlbum.AlbumDescription = description;
            updatedAlbum.AlbumImage = "~/Assets/Image_Artist/" + image.FileName;
            Save();
        }

    }
}