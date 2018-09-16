using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageOrganizer
{
    class RawConverter
    {
        Bitmap _sourceImage;
        //static string PathToDcRawExecutable = @"C:\Users\kerst\Desktop\spl-1.2.1\ImageOrganizer\ImageOrganizer\dcraw-9.27-ms-64-bit.exe";
        static string PathToDcRawExecutable;

        public RawConverter()
        {
            var dir = Directory.GetCurrentDirectory();
            var filenameofexe = @"\dcraw-9.27-ms-64-bit.exe";
            PathToDcRawExecutable = dir + filenameofexe;
        }

      


        public Stream GetImageFromRaw(string inputFile)
        {
            var memoryStream = new MemoryStream();
            if (File.Exists(PathToDcRawExecutable))
            {
                var startInfo = new ProcessStartInfo(PathToDcRawExecutable)
                {
                    Arguments = "-c -e \"" + inputFile + "\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                var process = Process.Start(startInfo);

                var image = Image.FromStream(process.StandardOutput.BaseStream);


                image.Save(memoryStream, ImageFormat.Png);


            }
            else
            {
                MessageBox.Show("DcRaw Executable not found.\n Expecting: " + PathToDcRawExecutable);
            }
            return memoryStream;
        }

    }
}
