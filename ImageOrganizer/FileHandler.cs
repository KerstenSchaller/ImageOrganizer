﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOrganizer
{
    class FileHandler
    {
        public static bool checkExtensionForImage(FileInfo[] fis)
        {
            bool retval = false;

            foreach (FileInfo fi in fis)
            {

            
                string ext = fi.Extension;
                ext = ext.ToLower();
                if ((ext == ".jpg") || (ext == ".bmp") || (ext == ".jpeg") || (ext == ".jpg") || (ext == ".cr2"))
                {
                    retval = true;
                }
            }
            return retval;
        }

        public static string checkExtensionForImage(FileInfo fi)
        {
            string retval = "";



            string ext = fi.Extension;
            ext = ext.ToLower();
            if ((ext == ".jpg") || (ext == ".bmp") || (ext == ".jpeg") || (ext == ".jpg") || (ext == ".cr2"))
            {
                retval = ext;
            }
            

            return retval;
        }

        public static string OpenFolder()
        {
            string[] paths = { ""};
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
           
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
           
            }
            return "";
            }
    }
}
