using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOrganizer
{
    public partial class Form1 : Form
    {

        string rootpath, currentpath;
        FileInfo[] files;
        int imageindex = 0;
        bool keyControlEnabled = false;
        ImageOrganizer imageOrganizer;

        public Form1()
        {
            InitializeComponent();

          
        }

  

        

        /*Function used to receive keyboard events*/
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            parseKeyInput(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /*Parse pressed key and invoke action*/
        private void parseKeyInput(Keys keyData)
        {
            const Keys Right = Keys.Right;
            const Keys Left = Keys.Left;
            const Keys ctrl_Right = (Keys.Control | Keys.Right);
            const Keys ctrl_Left = (Keys.Control | Keys.Left);
            const Keys returnenter = (Keys.Return | Keys.Enter);
            const Keys shft_one = (Keys.Shift | Keys.D1);
            const Keys shft_two = (Keys.Shift | Keys.D2);
            const Keys ctrl_shft_a = (Keys.Shift | Keys.A | Keys.Control);

            DirectoryInfo di;
           
            switch (keyData)
            {
                case Right:
                    if (keyControlEnabled == true)
                    {
                        setImageBox("right");
                    }
                    break;
                case Left:
                    if (keyControlEnabled == true)
                    {
                        setImageBox("left");
                    }
                    break;
                case returnenter:
                    if (keyControlEnabled == true)
                    {
                        setImageBox();
                    }

                    break;
                case shft_one:
                    if (keyControlEnabled == true)
                    {
                        imageOrganizer.setLabel(imageindex,"Label1");
                    }

                    break;
                case shft_two:
                    if (keyControlEnabled == true)
                    {
                        imageOrganizer.setLabel(imageindex, "Label2");
                    }
                    break;
                case ctrl_shft_a:
                    if (keyControlEnabled == true)
                    {
                        imageOrganizer.ApplyChanges();
                    }
                    break;


            }

        }

        /*Sets the imagebox to an image from filelist depending on input action*/
        public void setImageBox(string dir = "")
        {
            Bitmap bmp;
            DirectoryInfo di = new DirectoryInfo(currentpath);
            files = di.GetFiles();

            if ((imageindex < files.Length) && (dir == "right"))
            {

                imageindex++;
            }
            else
            if ((imageindex > 0) && (dir == "left"))
            {
                imageindex--;
            }
            else
            if (dir == "")
            {
                imageindex = 0;
            }

            bmp = createBitmap(files[imageindex]);
            picBox_Imageview.Image = bmp;
            bmp = null;
        }


        /*Creates a bitmap from a file and uses dcraw conversion if needed*/
        private Bitmap createBitmap(FileInfo file)
        {
            /*Convert input if neccesary*/
            Bitmap bmp=null;
            if (".cr2" == FileHandler.checkExtensionForImage(file))
            {
                RawConverter rawconverter = new RawConverter();
                try
                {
                    bmp = (Bitmap)Image.FromStream(rawconverter.GetImageFromRaw(file.FullName));
                }
                catch { }
            }
            else
            {
                /*Workaround to release file lock imideately*/
                Image img;
                using (var bmpTemp = new Bitmap(file.FullName))
                {
                    img = new Bitmap(bmpTemp);
                }

                bmp = (Bitmap)img;

            }
            return bmp;
        }



        private void picBox_Imageview_Click(object sender, EventArgs e)
        {

        }

        private void ApplyLabelsButton_Click(object sender, EventArgs e)
        {

        }


        /*Opens a folder dialog and loads a first image after a folder was chosen*/
        private void SelectFolderButtonClick(object sender, EventArgs e)
        {
            
            string path = FileHandler.OpenFolder();
            if (path != "")
            { 
                currentpath = path;
                DirectoryInfo di = new DirectoryInfo(path);
                files = di.GetFiles();
                keyControlEnabled = true;
                setImageBox();
                imageOrganizer = new ImageOrganizer(path);
            }



        }

    }
}
