using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WorkingTimeTracker;

namespace ImageOrganizer
{
    class FileHandler
    {

        /*Checks if file extension has image type*/
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

        /*Checks if file extension has image type*/
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

        /*Opens a file dialog and returns chosen path*/
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

        public static bool saveImageOrganizerToXML(ImageOrganizer io)
        {
            var dir = Directory.GetCurrentDirectory();
            string path = Path.Combine(dir,"FileInfoFromLastUse.xml");
            try
            {
                Serialization.WriteToXmlFile<ImageOrganizer>(path, io);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            
        }

        public static ImageOrganizer loadImageOrganizerFromXML()
        {
            var dir = Directory.GetCurrentDirectory();
            string path = Path.Combine(dir, "FileInfoFromLastUse.xml");
            try
            {
                return  Serialization.ReadFromXmlFile<ImageOrganizer>(path);
                
            }
            catch (Exception e)
            {
                return null;
            }

        }

    }
}
