using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ImageGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string m_RootImageDirectory;
        string m_RootIconDirectory;
        string m_RootSingleDirectory;

        string m_IconName;

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            txtDirectory.Text = "";
            btnGenerateImages.Enabled = false;
            FolderBrowserDialog dirDialog = new FolderBrowserDialog();
            dirDialog.SelectedPath = Directory.GetCurrentDirectory();
            if (dirDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtDirectory.Text = dirDialog.SelectedPath;
                m_RootImageDirectory = txtDirectory.Text + "\\";
                btnGenerateImages.Enabled = true;
                Debug.WriteLine(m_RootImageDirectory);
            }
        }

        private void btnGenerateImages_Click(object sender, EventArgs e)
        {
            try
            {
                int width = Convert.ToInt32(txtWidth.Text);
                int height = Convert.ToInt32(txtHeight.Text);
                if (cbxCustom.Checked)
                    CBGenerator.GenerateImages(m_RootImageDirectory, width, height);
                else
                    CBGenerator.GenerateImages(m_RootImageDirectory);
                Process.Start(m_RootImageDirectory);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectIcon_Click(object sender, EventArgs e)
        {
            btnGenerateIcon.Enabled = false;
            txtIcon.Text = "";
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select a Icon File";
            openDialog.Filter = "Image Files (*.png, *.bmp, *.jpg)|*.png; *.bmp;*.jpg";
            openDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if(openDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtIcon.Text = openDialog.FileName;
                FileInfo file = new FileInfo(openDialog.FileName);
                m_IconName = file.Name;
                m_RootIconDirectory = file.DirectoryName + "\\";
                btnGenerateIcon.Enabled = true;
                Debug.WriteLine(m_RootIconDirectory);
                Debug.WriteLine(m_IconName);
            }
        }

        private void btnGenerateIcon_Click(object sender, EventArgs e)
        {
            try
            {
                CBGenerator.GenerateIcons(m_RootIconDirectory, m_IconName);
                Process.Start(m_RootIconDirectory);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxCustom.Checked)
            {
                txtWidth.Enabled = true;
                txtHeight.Enabled = true;
            }
            else
            {
                txtWidth.Enabled = false;
                txtHeight.Enabled = false;
            }
        }

        private void btnSingleSelect_Click(object sender, EventArgs e)
        {
            btnSingleGenerate.Enabled = false;
            txtIcon.Text = "";
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select a Icon File";
            openDialog.Filter = "Image Files (*.png, *.bmp, *.jpg)|*.png; *.bmp;*.jpg";
            openDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (openDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtSingleImage.Text = openDialog.FileName;
                FileInfo file = new FileInfo(openDialog.FileName);
                m_RootSingleDirectory = file.DirectoryName + "\\";
                btnSingleGenerate.Enabled = true;
                Debug.WriteLine(m_RootIconDirectory);
                Debug.WriteLine(m_IconName);
            }
        }

        private void btnSingleGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int width = Convert.ToInt32(txtSingleWidth.Text);
                int height = Convert.ToInt32(txtSingleHeight.Text);
                CBGenerator.GenerateImage(txtSingleImage.Text, width, height);
                Process.Start(m_RootSingleDirectory);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
