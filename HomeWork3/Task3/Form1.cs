using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string searchedFile;
        

        private bool SearchFile (string fileName)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                if (drive.Name.Equals(@"C:\"))
                {
                    continue;
                }               
                string path = drive.RootDirectory.FullName;
                var directoryes = new DirectoryInfo(path).GetDirectories();
                
                foreach (var directory in directoryes)
                {
                    if (directory.Attributes.Equals(FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory))
                    {
                        continue;
                    }
                    FileInfo[] files = directory.GetFiles("*.*");

                    foreach (var file in files)
                    {
                        
                        if (file.Name == fileName)
                        {
                            searchedFile = file.FullName;
                            return true;
                        }
                    }

                }              

            }
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (SearchFile(textBox1.Text))
            {
                richTextBox1.Text = searchedFile;
            } else
            {
                searchedFile = null;
                richTextBox1.Text = "No such file";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchedFile != null)
            {
                richTextBox1.Text = File.ReadAllText(searchedFile);
            } else
            {
                richTextBox1.Text = "No file searched";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream source = File.OpenRead(searchedFile);
            string fileName = Path.GetFileNameWithoutExtension(searchedFile);
            string directory = Path.GetDirectoryName(searchedFile);
            string newArchive = directory + @"\" + fileName + ".zip";

            FileStream destination = File.Create(newArchive);
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);
            int theByte = source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }
            compressor.Close();
            MessageBox.Show("Archive created");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
