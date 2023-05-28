using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Repositoy
{
    public class AlbumRepository
    {
        static Kpop db = Singleton.getConnection();

        public static void save()
        {
            db.SaveChanges();
        }

        public static void add(Album x)
        {
            db.Albums.Add(x);
            db.SaveChanges();
        }

        public static void remove(Album x)
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

        public static List<Album> byArtist(List<Album> x)
        {
            return (from x in db.Albums select x).ToList();
        }
        public static void deleteAlbums(List<Album> x)
        {
            db.Albums.RemoveRange(x);
            db.SaveChanges();
        }

        public static void addAlbums(List<Album> x)
        {
            db.Albums.AddRange(x);
            db.SaveChanges();
        }

    }
}