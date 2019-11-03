using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DuplicateImages
{
    class Program
    {
        static void Main(string[] args)
        {


            //Read configuration Information
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();
            string feedDataLocation = root["imageFolder"];
            Console.WriteLine("Hello World!");
        }
    }
}
