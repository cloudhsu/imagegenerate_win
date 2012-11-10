using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace ImageGenerator
{
    public class CBImageFile
    {
        string m_DirectoryName;
        string m_FileName;
        string m_FullName;

        Bitmap m_SourceImage;

        public Bitmap SourceImage
        {
            get { return m_SourceImage; }
            set { m_SourceImage = value; }
        }

        public string DirectoryName
        {
            get { return m_DirectoryName; }
            set { m_DirectoryName = value; }
        }

        public string FileName
        {
            get { return m_FileName; }
            set { m_FileName = value; }
        }

        private CBImageFile()
        {
        }

        public CBImageFile(string fullName)
        {
            FileInfo file = new FileInfo(fullName);
            m_FileName = file.Name;
            m_DirectoryName = file.DirectoryName + "\\";
            m_FullName = fullName;
            m_SourceImage = CBImageManager.LoadImage(m_FullName);
        }

        public CBImageFile(string directory,string fileName)
        {
            m_DirectoryName = directory;
            m_FileName = fileName;
            m_FullName = directory + fileName;
            m_SourceImage = CBImageManager.LoadImage(m_FullName);
        }
    }
}
