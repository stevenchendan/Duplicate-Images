using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DuplicateImages.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuplicateImages.Test.Helper.Test
{
    [TestClass]
    public class ImageHelperTest
    {

        [TestInitialize]
        public void InitializeManageCarServiceTest()
        {

        }

        [TestMethod]
        public void Shoud_Return_Not_Null_After_Provide_Valid_FileName_To_ConvertToBitmap()
        {
            var bitmap = ImageHelper.ConvertToBitmap(@"../../../Testimages\\mew.jpg");

            Assert.IsNotNull(bitmap);
        }


        [TestMethod]
        public void Shoud_Return_String_After_Provide_Bitmap_To_GetImageBase64()
        {
            Bitmap testBitmap = new Bitmap(200, 100);
            var base64 = ImageHelper.GetImageBase64(testBitmap);

            Assert.IsNotNull(base64);
        }

        [TestCleanup]
        public void Cleanup()
        {
            //rollback transaction
        }

    }
}
