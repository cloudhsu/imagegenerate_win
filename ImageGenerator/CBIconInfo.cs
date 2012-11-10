using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGenerator
{
    public class CBIconInfo
    {
        List<CBImageInfo> m_IconDefine = new List<CBImageInfo>();

        public List<CBImageInfo> IconDefines
        {
            get { return m_IconDefine; }
            set { m_IconDefine = value; }
        }
        
        public CBIconInfo()
        {
        }


        public static CBIconInfo GenerateDefault()
        {
            CBIconInfo icons = new CBIconInfo();
            GenerateiOSDefault(icons);
            GenerateAndroidDefault(icons);
            GenerateWP7Default(icons);

            return icons;
        }

        private static void GenerateAndroidDefault(CBIconInfo icons)
        {
            CBImageInfo info = new CBImageInfo();
            info.DeviceType = DeviceType.Android;
            info.Width = 36;
            info.Height = 36;
            info.FileName = "drawable-ldpi\\icon.png";
            icons.IconDefines.Add(info);

            info = new CBImageInfo();
            info.DeviceType = DeviceType.Android;
            info.Width = 48;
            info.Height = 48;
            info.FileName = "drawable-mdpi\\icon.png";
            icons.IconDefines.Add(info);

            info = new CBImageInfo();
            info.DeviceType = DeviceType.Android;
            info.Width = 72;
            info.Height = 72;
            info.FileName = "drawable-hdpi\\icon.png";
            icons.IconDefines.Add(info);

            info = new CBImageInfo();
            info.DeviceType = DeviceType.Android;
            info.Width = 135;
            info.Height = 135;
            info.FileName = "SamsungMarket.png";
            icons.IconDefines.Add(info);
        }

        private static void GenerateWP7Default(CBIconInfo icons)
        {
            CBImageInfo info = new CBImageInfo();
            info.DeviceType = DeviceType.WP7;
            info.Width = 62;
            info.Height = 62;
            info.FileName = "ApplicationIcon.png";
            icons.IconDefines.Add(info);

            info = new CBImageInfo();
            info.DeviceType = DeviceType.WP7;
            info.Width = 173;
            info.Height = 173;
            info.FileName = "ApplicationTile.png";
            icons.IconDefines.Add(info);

            info = new CBImageInfo();
            info.DeviceType = DeviceType.WP7;
            info.Width = 99;
            info.Height = 99;
            info.FileName = "Market99.png";
            icons.IconDefines.Add(info);

            info = new CBImageInfo();
            info.DeviceType = DeviceType.WP7;
            info.Width = 200;
            info.Height = 200;
            info.FileName = "Market200.png";
            icons.IconDefines.Add(info);
        }
        static void GenerateiOSDefault(CBIconInfo icons)
        {
            // for iOS
            CBImageInfo info = new CBImageInfo();
            info.DeviceType = DeviceType.iOS;
            info.Width = 57;
            info.Height = 57;
            info.FileName = "icon.png";
            icons.IconDefines.Add(info);
            // for iPhone Retina
            info = new CBImageInfo();
            info.DeviceType = DeviceType.iOS;
            info.Width = 114;
            info.Height = 114;
            info.FileName = "icon@2x.png";
            icons.IconDefines.Add(info);
            // for iPad
            info = new CBImageInfo();
            info.DeviceType = DeviceType.iOS;
            info.Width = 72;
            info.Height = 72;
            info.FileName = "icon-72.png";
            icons.IconDefines.Add(info);
            // for new iPad
            info = new CBImageInfo();
            info.DeviceType = DeviceType.iOS;
            info.Width = 144;
            info.Height = 144;
            info.FileName = "icon-72@2x.png";
            icons.IconDefines.Add(info);
        }
    }
}
