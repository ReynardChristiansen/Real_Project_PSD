using project.Factory;
using project.Model;
using project.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Handler
{
    public class Handler_Public
    {
    
        public static void delete_Artist_Album(int id)
        {
            Artist x = ArtistRepository.FindID(id);

            if(x == null)
            {
                return;
            }
            else
            {
                if (x.Albums.Count > 0)
                {
                    AlbumRepository.DeleteAlbums(x.Albums.ToList());
                }
                    ArtistRepository.DeleteArtist(id);
            }
        }


    }
}