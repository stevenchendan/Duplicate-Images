using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DuplicateImages.Helper;

namespace DuplicateImages.Services
{
    public class ImageProcessingServices : IImageProcessingServices
    {
        public bool ShowDuplicateImages(string[] files)
        {
            var hashToNameMap = new Dictionary<string, string>();
            if (files.Length == 0)
            {
                Console.WriteLine("Cannot find find any image");
                return false;
            }
            for (int i = 0; i < files.Length; i++)
            {
                Bitmap bitmap = ImageHelper.ConvertToBitmap(files[i]);
                var imageBitmap = ImageHelper.GetImageBase64(bitmap);

                if (hashToNameMap.ContainsKey(imageBitmap))
                {
                    Console.WriteLine("{0} is a duplicate of {1}", files[i], hashToNameMap[imageBitmap]);
                }
                else
                {
                    hashToNameMap[imageBitmap] = files[i];
                }
            }

            return true;
        }
    }
}
