using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace ImageGenerator
{
    public static class CBGenerator
    {
        public static void GenerateIcons(string directory, string fileName)
        {
            CBDeviceManager deviceManager = new CBDeviceManager();
            deviceManager.CreateAllDeviceDirectory(directory);
            CBImageFile image = new CBImageFile(directory, fileName);
            CBIconInfo icons = CBIconInfo.GenerateDefault();
            foreach (CBImageInfo info in icons.IconDefines)
            {
                CBImageManager.SaveIcon(image, info);
            }
        }

        public static void GenerateImage(string fileName, int width, int height)
        {
            CBImageFile image = new CBImageFile(fileName);
            CBDeviceManager deviceManager = new CBDeviceManager();
            deviceManager.CreateAllDeviceDirectory(image.DirectoryName);

            CBImageManager.SaveiOSImage(image, width, height);
            CBImageManager.SaveAndroidImage(image, width, height);
            CBImageManager.SaveWP7Image(image, width, height);
        }

        public static void GenerateImages(string rootImageDirectory, int width, int height)
        {
            CBDeviceManager deviceManager = new CBDeviceManager();
            deviceManager.CreateAllDeviceDirectory(rootImageDirectory);

            string[] files = Directory.GetFiles(rootImageDirectory, "*.png");

            foreach (string fullName in files)
            {
                Debug.WriteLine(fullName);
                CBImageFile image = new CBImageFile(fullName);
                CBImageManager.SaveiOSImage(image, width, height);
                CBImageManager.SaveAndroidImage(image, width, height);
                CBImageManager.SaveWP7Image(image, width, height);
            }
        }

        public static void GenerateImages(string rootImageDirectory)
        {
            CBDeviceManager deviceManager = new CBDeviceManager();
            deviceManager.CreateAllDeviceDirectory(rootImageDirectory);

            string[] files = Directory.GetFiles(rootImageDirectory, "*.png");

            foreach (string fullName in files)
            {
                CBImageFile image = new CBImageFile(fullName);
                // v1.2 fix width and height to even
                int width = image.SourceImage.Width - (image.SourceImage.Width % 2);
                int height = image.SourceImage.Height - (image.SourceImage.Height % 2);
                CBImageManager.SaveiOSImage(image, width, height);
                CBImageManager.SaveAndroidImage(image, width, height);
                CBImageManager.SaveWP7Image(image, width, height);
            }
        }
    }
}
