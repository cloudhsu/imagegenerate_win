using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageGenerator
{
    public class CBDeviceManager
    {
        public const string DEVICE_IOS = "\\iOS";
        public const string DEVICE_Android = "\\Android";
        public const string DEVICE_WP7 = "\\WP7";
        
        string m_RootDirectory;

        static CBDeviceManager()
        {
        }

        public void CreateAllDeviceDirectory(string rootDirectory)
        {
            m_RootDirectory = rootDirectory;
            CreateDir(rootDirectory);
            CreateiOSDir();
            CreateAndroidDir();
            CreateWP7Dir();
        }

        private void CreateWP7Dir()
        {
            CreateDir(m_RootDirectory + DEVICE_WP7);
        }

        private void CreateAndroidDir()
        {
            CreateDir(m_RootDirectory + DEVICE_Android);
            CreateDir(m_RootDirectory + DEVICE_Android + "\\drawable-ldpi");
            CreateDir(m_RootDirectory + DEVICE_Android + "\\drawable-mdpi");
            CreateDir(m_RootDirectory + DEVICE_Android + "\\drawable-hdpi");
        }

        private void CreateiOSDir()
        {
            CreateDir(m_RootDirectory + DEVICE_IOS);
        }

        public static void CreateDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public void SaveIcons(CBImageFile image, CBImageInfo info)
        {
            Bitmap newImage = CBImageManager.ResizeImage(image.SourceImage, info.Width, info.Height);
            string fileName = GetIconName(info);
            newImage.Save(fileName, ImageFormat.Png);
        }

        private string GetIconName(CBImageInfo info)
        {
            string fullName = m_RootDirectory + "\\" +
                info.DeviceType.ToString() + "\\" + info.FileName;
            return fullName;
        }
    }
}
