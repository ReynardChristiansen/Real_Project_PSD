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
    public class AlbumController
    {
        public static string validation(string name, string desc,int price, int stock,  FileUpload image)
        {

            int MAX_FILE_SIZE = 2 * 1024 * 1024;
            string fileExtension = Path.GetExtension(image.PostedFile.FileName).ToLower();

            if (name.Equals(""))
            {
                return "Album Name cannot be empty";
            }
            else if(name.Length > 50)
            {
                return "Album Name length must be less than 50";
            }
            else if (desc.Equals(""))
            {
                return "Album Description cannot be empty";
            }
            else if(desc.Length > 255)
            {
                return "Album Description length must be less than 255";
            }
            else if (price.ToString().Equals(""))
            {
                return "Album Price cannot be empty";
            }
            else if (price < 100000 || price > 1000000)
            {
                return "Album Price must between 100000 and 1000000";
            }
            else if (stock.ToString().Equals(""))
            {
                return "Album Stock cannot be empty";
            }
            else if (stock < 0)
            {
                return "Album stock must more than 0";
            }
            else if (!image.HasFile)
            {
                return "Album image cannot be empty";
            }
            else if(image.PostedFile.ContentLength > MAX_FILE_SIZE)
            {
                return "Album image size must be lower than 2MB";
            }
            else if(fileExtension != ".png" && fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".jfif")
            {
                return "file extension must be .png, .jpg, .jpeg, or .jfif";
            }
            
            return "";
        }

        public static void registration(int id_Artist, string name, string desc, int price, int stock, string image)
        {
            int id = AlbumRepository.NextID();
            Album newAlbum = AlbumFactory.create(id, id_Artist, name, image, price, stock, desc);
            AlbumRepository.add(newAlbum);
        }

    }
}