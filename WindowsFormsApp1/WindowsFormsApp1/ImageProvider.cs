using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ImageProvider
    {
        private const string IMAGE_PATH = @"C:\Users\msima\Pictures";

        internal static Image GetImage()
        {
            return GetFirstImage();
        }

        private static Image GetFirstImage()
        {
            List<string> allImageFiles = getAllImageFiles();
            string imageFile = allImageFiles[0];
            Image ret = LoadImage(imageFile);
            return ret;
        }

        public static Image GetRandomImage()
        {
            List<string> allImageFiles = getAllImageFiles();
            Random rnd = new Random();
            int randomIndex = rnd.Next(allImageFiles.Count);
            string imageFile = allImageFiles[randomIndex];
            Image ret = LoadImage(imageFile);
            return ret;
        }

        private static List<string> getAllImageFiles()
        {
            string[] imageFiles = System.IO.Directory.GetFiles(IMAGE_PATH);
            List<string> ret = imageFiles
                .Where(q => q.EndsWith(".png") || q.EndsWith(".jpg"))
                .ToList();
            return ret;
        }

        private static Image LoadImage(string imageFile)
        {
            Image ret = Image.FromFile(imageFile);
            return ret;
        }
    }
}
