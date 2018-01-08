using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PDD
{
    public class ImageWorker
    {
        public Bitmap GetImageByRelativePath(string relativePath)
        {
            string imagePath = Path.Combine(Application.StartupPath, @"img\" + relativePath);

            if (File.Exists(imagePath))
            {
                return (Bitmap)Image.FromFile(imagePath);
            }

            return null;
        }
        public Bitmap GetImageByAbsolutePath(string absolutePath)
        {
            if (File.Exists(absolutePath))
            {
                return (Bitmap)Image.FromFile(absolutePath);
            }

            return null;
        }

        public void SaveInProgramFolder(string name)
        {
            


        }

        public bool CopyImageByName(string absolutePath, string name)
        {
            if (File.Exists(absolutePath))
            {
                Bitmap newImage = GetImageByAbsolutePath(absolutePath);
                string imagePath = Path.Combine(Application.StartupPath, @"img\" + name + ".png");

                newImage.Save(imagePath);

                return true;
            }

            return false;
        }
    }
}
