using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageGenerator
{
    public static class CBImageManager
    {
        public static Bitmap ResizeImage(Bitmap srcImage, int newWidth, int newHeight)
        {
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            newImage.SetResolution(72, 72);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
            }
            return newImage;

        }

        public static void SaveIcon(CBImageFile image, CBImageInfo info)
        {
            Bitmap newImage = CBImageManager.ResizeImage(image.SourceImage, info.Width, info.Height);
            string fileName = GetIconName(image, info);
            newImage.Save(fileName, ImageFormat.Png);
        }

        private static string GetIconName(CBImageFile image, CBImageInfo info)
        {
            string fullName = image.DirectoryName + "\\" +
                info.DeviceType.ToString() + "\\" + info.FileName;
            return fullName;
        }

        public static Bitmap LoadIcon(string fileName)
        {
            Bitmap icon = LoadImage(fileName);
            if(icon.Width != 512 && icon.Height != 512)
            {
                throw new Exception("Icon must be 512*512 pixel.");
            }
            return icon;
        }

        public static Bitmap LoadImage(string fileName)
        {
            Bitmap image = new Bitmap(fileName);
            return image;
        }

        internal static void SaveiOSImage(CBImageFile image, int width, int height)
        {
            // normal image
            Bitmap newImage = CBImageManager.ResizeImage(image.SourceImage, width / 2, height / 2);
            string fileName = string.Format("{0}\\iOS\\{1}", image.DirectoryName,image.FileName);
            newImage.Save(fileName, ImageFormat.Png);
            // retina image
            newImage = CBImageManager.ResizeImage(image.SourceImage, width, height);
            fileName = string.Format("{0}\\iOS\\{1}", image.DirectoryName, image.FileName.Replace(".png","@2x.png"));
            newImage.Save(fileName, ImageFormat.Png);
        }

        internal static void SaveAndroidImage(CBImageFile image, int width, int height)
        {
            Bitmap newImage = CBImageManager.ResizeImage(image.SourceImage, width, height);
            string fileName = string.Format("{0}\\Android\\{1}", image.DirectoryName, image.FileName);
            newImage.Save(fileName, ImageFormat.Png);
        }

        internal static void SaveWP7Image(CBImageFile image, int width, int height)
        {
            Bitmap newImage = CBImageManager.ResizeImage(image.SourceImage, width, height);
            string fileName = string.Format("{0}\\WP7\\{1}", image.DirectoryName, image.FileName);
            newImage.Save(fileName, ImageFormat.Png);
        }
    }
}
