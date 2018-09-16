﻿using System;
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
            clearLabelDisplay();

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

            DirectoryInfo di;
           
            switch (keyData)
            {
                case Right:
                    if (keyControlEnabled == true)
                    {
                        setImageBox("right");
                        setLabelDisplay();
                    }
                    break;
                case Left:
                    if (keyControlEnabled == true)
                    {
                        setImageBox("left");
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
                case ctrl_one:
                    if (keyControlEnabled == true)
                    {
                        imageOrganizer.setLabel(imageindex,"_loeschen");
                        setLoeschenLabelDisplay();
                    }

                    break;
                case ctrl_two:
                    if (keyControlEnabled == true)
                    {
                        imageOrganizer.setLabel(imageindex, "_bearbeiten");
                        setbearbeitenLabelDisplay();
                    }
                    break;
                case ctrl_three:
                    if (keyControlEnabled == true)
                    {
                        
                        imageOrganizer.setLabel(imageindex, "_weiterSortieren");
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


        private void setLabelDisplay()
        {
            string label = imageOrganizer.getLabel(imageindex);
            if (label == "_loeschen") setLoeschenLabelDisplay();
            if (label == "_weiterSortieren") setSortierenLabelDisplay();
            if (label == "_bearbeiten") setbearbeitenLabelDisplay();
            if (label == "") clearLabelDisplay();


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
