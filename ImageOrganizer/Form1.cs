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


        FileInfo[] files;
        
        bool keyControlEnabled = false;
        ImageOrganizer imageOrganizer;
        

        public Form1()
        {
            InitializeComponent();
            clearLabelDisplay();
            LoadImageOrganizer();

        }

        

        public void SaveImageOrganizer()
        {
            FileHandler.saveImageOrganizerToXML(imageOrganizer);
        }

        public void LoadImageOrganizer()
        {
            imageOrganizer = FileHandler.loadImageOrganizerFromXML();
            if (imageOrganizer != null)
            {
                imageOrganizer.updateData();
                if (imageOrganizer.getFileInfos().Length > 0)
                { 
                    setLabelDisplay();
                    setImageBoxStatic();
                    keyControlEnabled = true;
                }
            }
        }

        private void setImageBoxStatic()
        {
            int index = imageOrganizer.imageindex;
            int rot = imageOrganizer.getRotation(index);

            setImageBox("static", rot);
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
            const Keys ctrl_one = (Keys.Control | Keys.D1);
            const Keys ctrl_two = (Keys.Control | Keys.D2);
            const Keys ctrl_three = (Keys.Control | Keys.D3);
            const Keys ctrl_four = (Keys.Control | Keys.D4);
            const Keys ctrl_shft_a = (Keys.Shift | Keys.A | Keys.Control);
            const Keys ctrl_r = (Keys.Control | Keys.R );
            const Keys k1 = Keys.D1;
            const Keys k2 = Keys.D2;
            const Keys k3 = Keys.D3;
            const Keys k4 = Keys.D4;
            const Keys k5 = Keys.D5;
            const Keys k6 = Keys.D6;
            const Keys k7 = Keys.D7;
            const Keys k8 = Keys.D8;
            const Keys k9 = Keys.D9;

            DirectoryInfo di;
           
            switch (keyData)
            {
                case Right:
                    if (keyControlEnabled == true)
                    {
                        int rot = imageOrganizer.getRotation(imageOrganizer.imageindex +1);
                        setImageToTheRight(rot);
                        setLabelDisplay();
                        
                    }
                    break;
                case Left:
                    if (keyControlEnabled == true)
                    {
                        int tempindex = imageOrganizer.imageindex - 1;
                        tempindex = (tempindex >= 0) ? tempindex : 0; 
                        int rot = imageOrganizer.getRotation(tempindex);
                        setImageToTheLeft(rot);
                        setLabelDisplay();
                    }
                    break;
                case returnenter:
                    if (keyControlEnabled == true)
                    {
                        setImageBox();
                        setLabelDisplay();
                    }

                    break;
                case k1:
                    if (keyControlEnabled == true)
                    {
                        imageOrganizer.setLabel("_loeschen");
                        setLoeschenLabelDisplay();
                    }

                    break;
                case k2:
                    if (keyControlEnabled == true)
                    {
                        imageOrganizer.setLabel("_bearbeiten");
                        setbearbeitenLabelDisplay();
                    }
                    break;
                case k3:
                    if (keyControlEnabled == true)
                    {
                        
                        imageOrganizer.setLabel( "_weiterSortieren");
                        setSortierenLabelDisplay();
                    }
                    break;
                case ctrl_four:
                    if (keyControlEnabled == true)
                    {
                        
                    }
                    break;
                case ctrl_shft_a:
                    if (keyControlEnabled == true)
                    {
                        imageOrganizer.ApplyChanges();
                    }
                    break;
                case ctrl_r:
                    if (keyControlEnabled == true)
                    {
                        int rot = imageOrganizer.getRotation(imageOrganizer.imageindex);
                        rot += 90;
                        imageOrganizer.setRotation(rot, imageOrganizer.imageindex);
                        setImageBox("static",rot);
                        
                    }
                    break;

            }

            SaveImageOrganizer();

        }

        public void setImageToTheLeft(int rot)
        {
            setImageBox("left",rot);
        }

        public void setImageToTheRight(int rot)
        {
            setImageBox("right", rot);
        }

        /*Sets the imagebox to an image from filelist depending on input action*/
        public void setImageBox(string dir = "0", int rot = 0)
        {
            Bitmap bmp;
            
            files = imageOrganizer.getFileInfos();
            if (files.Length < imageOrganizer.imageindex)
            {
                imageOrganizer.imageindex = 0;
            }
            

            if ((imageOrganizer.imageindex < files.Length) && (dir == "right"))
            {
                if ((imageOrganizer.imageindex + 1) < files.Length)
                {
                    imageOrganizer.imageindex++;
                }
                
            }
            else
            if ((imageOrganizer.imageindex > 0) && (dir == "left"))
            {
                imageOrganizer.imageindex--;
            }
            else
            if (dir == "0")
            {
                imageOrganizer.imageindex = 0;
            }
            if (rot != 0)
            {
                bmp = createBitmap(files[imageOrganizer.imageindex],90);
            }
            else
            {
                bmp = createBitmap(files[imageOrganizer.imageindex]);
            }
            
            picBox_Imageview.Image = bmp;
            bmp = null;
        }


        private void setLabelDisplay()
        {
            string label = imageOrganizer.getLabel();
            if (label == "_loeschen") setLoeschenLabelDisplay();
            if (label == "_weiterSortieren") setSortierenLabelDisplay();
            if (label == "_bearbeiten") setbearbeitenLabelDisplay();
            if ((label == "") || (label == null)) clearLabelDisplay();


        }

        private void setLoeschenLabelDisplay()
        {
            DeleteLabelTextbox.BackColor = Color.Green;
            WeiterbearbeitenTextBox.BackColor = Color.Red;
            SortierenTextBox.BackColor = Color.Red;
        }

        private void setbearbeitenLabelDisplay()
        {
            DeleteLabelTextbox.BackColor = Color.Red;
            WeiterbearbeitenTextBox.BackColor = Color.Green;
            SortierenTextBox.BackColor = Color.Red;
        }

        private void setSortierenLabelDisplay()
        {
            DeleteLabelTextbox.BackColor = Color.Red;
            WeiterbearbeitenTextBox.BackColor = Color.Red;
            SortierenTextBox.BackColor = Color.Green;
        }

        private void clearLabelDisplay()
        {
            DeleteLabelTextbox.BackColor = Color.Red;
            WeiterbearbeitenTextBox.BackColor = Color.Red;
            SortierenTextBox.BackColor = Color.Red;
        }

        /*Creates a bitmap from a file and uses dcraw conversion if needed*/
        private Bitmap createBitmap(FileInfo file, int rot = 0)
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
                if ("" != FileHandler.checkExtensionForImage(file))
                {
                    /*Workaround to release file lock imideately*/
                    Image img;
                    using (var bmpTemp = new Bitmap(file.FullName))
                    {
                        img = new Bitmap(bmpTemp);

                        bmp = (Bitmap)img;

                    }

                }

            }

            if (rot != 0)
            {
                if (rot == 90)
                {
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
            }
            return bmp;
        }



        private void picBox_Imageview_Click(object sender, EventArgs e)
        {

        }

        private void ApplyLabelsButton_Click(object sender, EventArgs e)
        {
            imageOrganizer.ApplyChanges();
            imageOrganizer.imageindex = 0;
            reset();
        }




        /*Opens a folder dialog and loads a first image after a folder was chosen*/
        private void SelectFolderButtonClick(object sender, EventArgs e)
        {
            
            string path = FileHandler.OpenFolder();
            if (path != "")
            {


                

                imageOrganizer = new ImageOrganizer();
                imageOrganizer.setPath(path);
                files = imageOrganizer.getFileInfos();
                setImageBox();

                keyControlEnabled = true;


            }



        }

        private void DeleteLabelTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            reset();
        }

        private void reset()
        {
            imageOrganizer.resetChanges();
            setImageBoxStatic();
            setLabelDisplay();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            picBox_Imageview.Width = this.Width - 233;
            picBox_Imageview.Height = this.Height - 16;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            picBox_Imageview.Width = this.Width - 233;
            picBox_Imageview.Height = this.Height - 16;
        }
    }
}
