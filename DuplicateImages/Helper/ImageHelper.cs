using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace DuplicateImages.Helper
{
    public class ImageHelper
    {
        public static string GetImageBase64(Bitmap image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            String firstBitmap = Convert.ToBase64String(ms.ToArray());
            return firstBitmap;
        }

        public static Bitmap ConvertToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = System.IO.File.Open(fileName, System.IO.FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);

                bitmap = new Bitmap(image);

            }
            return bitmap;
        }
    }
}
