using project.Factory;
using project.Model;
using project.Repositoy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace project.Controller
{
    public class ArtistController
    {
        public static void registration(string ArtistName, string ArtistImage)
        {
            int id = ArtistRepository.NextID();
            Artist newArtist = ArtistFactory.create(id, ArtistName, ArtistImage);
            ArtistRepository.add(newArtist);
        }

        public static string isUnique(string ArtistName)
        {
            Artist x = ArtistRepository.findName(ArtistName);
            if (x != null)
            {
                return "Artist Name must unique";
            }
            if (ArtistName.Equals(""))
            {
                return "Artist Name cannot be empty";
            }
            else
            {
                return "";
            }

        }

        public static string IsFileValid(FileUpload file)
        {
            int MAX_FILE_SIZE = 2 * 1024 * 1024;
            string fileExtension = Path.GetExtension(file.PostedFile.FileName).ToLower();
            if (file == null || file.PostedFile == null)
            {
                return "xxxxx";
            }


            if (fileExtension != ".png" && fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".jfif")
            {
                return "xxxxx";
            }
                
            if(file.PostedFile.ContentLength > MAX_FILE_SIZE)
            {
                return "xxxxx";
            }

            return "";
        }
        

 

    }
}