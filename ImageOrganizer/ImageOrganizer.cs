using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WorkingTimeTracker;

using System.Xml.Serialization;


namespace ImageOrganizer
{
    public class ImageOrganizer
    {
        /*Variable definitions*/
        public string path;
        public int imageindex = 0;
        public int[] rotation = new int[10000];
        public string[] labels = new string[10000];

        [XmlIgnore]
        ImageOrganizerFileInfo iOFileInfo = new ImageOrganizerFileInfo();
        
        

        /*Updates all relevant data according to path*/
        public void updateData()
        {
            
            DirectoryInfo di = new DirectoryInfo(path);
            iOFileInfo.fileInfos = di.GetFiles();
            

            /*Add standart labels*/
            addLabel("_loeschen");
            addLabel("_bearbeiten");
            addLabel("_weiterSortieren");

        }

        public FileInfo[] getFileInfos()
        {
            return iOFileInfo.fileInfos;
        }

        public void setRotation(int rot,int Index)
        {
            rotation[Index] = rot;
        }

        public int getRotation( int Index)
        {
            return rotation[Index];
        }


        public void addLabel(string newlabel)
        {
            iOFileInfo.labeltypes.Add(newlabel);
        }

        /*Set Label for certain image*/
        public void setLabel(string label)
        {
            labels[imageindex] = label;
        }

        public string getLabel()
        {
            return labels[imageindex];
        }

        public void ApplyChanges()
        {
            FileInfo[] fi = iOFileInfo.fileInfos;
            


            foreach (string label in iOFileInfo.labeltypes)
            {
                string dirlabel = path + @"\" + label;
                Directory.CreateDirectory(dirlabel);
            }
            

            for (int i = 0; i < fi.Length; i++)
            {
                if (labels[i] != "")
                {
                    string src = fi[i].FullName;
                    string dest = path + @"\" + labels[i] + @"\" + Path.GetFileName(src);
                    File.Move(src,dest);

                }
            }
        }

        internal void setPath(string Path)
        {
            path = Path;
            updateData();
        }
    }

    class ImageOrganizerFileInfo
    {
        public FileInfo[] fileInfos;
        public int ImageIndex;
        
        public List<string> labeltypes = new List<string>();
         

        public ImageOrganizerFileInfo() { }


    }
}
