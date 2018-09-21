using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageOrganizer
{
    class ImageOrganizer
    {
        /*Variable definitions*/
        ImageOrganizerFileInfo iOFileInfo = new ImageOrganizerFileInfo();
        string path;
        

        /*Constructor*/
        public ImageOrganizer(string _path)
        {
            path = _path;
            DirectoryInfo di = new DirectoryInfo(path);
            iOFileInfo.fileInfos = di.GetFiles();
            iOFileInfo.labels = new string[iOFileInfo.fileInfos.Length];
            iOFileInfo.rotation = new int[iOFileInfo.fileInfos.Length];

            /*Initialize Labels*/
            for (int i = 0; i < iOFileInfo.labels.Count(); i++)
            {
                iOFileInfo.labels[i] = "";
            }

            /*Add standart labels*/
            addLabel("_loeschen");
            addLabel("_bearbeiten");
            addLabel("_weiterSortieren");

        }

        public void setRotation(int rot,int Index)
        {
            iOFileInfo.rotation[Index] = rot;
        }

        public int getRotation( int Index)
        {
            return iOFileInfo.rotation[Index];
        }


        public void addLabel(string newlabel)
        {
            iOFileInfo.labeltypes.Add(newlabel);
        }

        /*Set Label for certain image*/
        public void setLabel(int Index, string label)
        {
            iOFileInfo.labels[Index] = label;
        }

        public string getLabel(int Index)
        {
            return iOFileInfo.labels[Index];
        }

        public void ApplyChanges()
        {
            FileInfo[] fi = iOFileInfo.fileInfos;
            string[] labels = iOFileInfo.labels;


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


    }

    class ImageOrganizerFileInfo
    {
        public FileInfo[] fileInfos;
        public int ImageIndex;
        public string[] labels;
        public List<string> labeltypes = new List<string>();
        public int[] rotation; 

        public ImageOrganizerFileInfo() { }


    }
}
