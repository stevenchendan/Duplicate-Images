using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DuplicateImages.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuplicateImages.Test.Services.Test
{
    [TestClass]
    public class ImageProcessServervicesTest
    {
        protected IImageProcessingServices ImageProcessServices;

        [TestInitialize]
        public void InitializeManageCarServiceTest()
        {
            ImageProcessServices = new ImageProcessingServices();
        }

        [TestMethod]
        public void Shoud_Return_True_After_Provide_List_Of_Images_To_ShowDuplicateImages()
        {
            var imageLocation = "../../../Testimages";
            var files = Directory.GetFiles(imageLocation, "*.*", SearchOption.AllDirectories);
            var result = ImageProcessServices.ShowDuplicateImages(files);

            Assert.IsTrue(result);
        }


        [TestCleanup]
        public void Cleanup()
        {
            //rollback transaction
        }

    }
}
