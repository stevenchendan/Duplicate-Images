using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DuplicateImages.Services
{
    public interface IImageProcessingServices
    {
        bool ShowDuplicateImages(string[] files);
    }
}
