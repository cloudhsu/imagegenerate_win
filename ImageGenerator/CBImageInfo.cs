using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGenerator
{
    public enum DeviceType
    {
        iOS,
        Android,
        WP7
    }

    public class CBImageInfo
    {
        DeviceType m_DeviceType;
        int m_Width;
        int m_Height;
        string m_FileName;

        public DeviceType DeviceType
        {
            get { return m_DeviceType; }
            set { m_DeviceType = value; }
        }
        public int Width
        {
            get { return m_Width; }
            set { m_Width = value; }
        }
        public int Height
        {
            get { return m_Height; }
            set { m_Height = value; }
        }
        public string FileName
        {
            get { return m_FileName; }
            set { m_FileName = value; }
        }

    }
}
