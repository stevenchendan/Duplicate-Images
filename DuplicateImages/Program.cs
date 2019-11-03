using System;
using System.IO;
using DuplicateImages.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DuplicateImages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Log service
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IImageProcessingServices, ImageProcessingServices>()
                .AddLogging(cfg => cfg.AddConsole())
                .Configure<LoggerFilterOptions>(cfg => cfg.MinLevel = LogLevel.Debug).BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger<Program>>();
            var imageService = serviceProvider.GetRequiredService<IImageProcessingServices>();


            //Read configuration Information
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();
            string feedDataLocation = root["imageFolder"];


            //Print Images 
            var files = Directory.GetFiles(feedDataLocation, "*.*", SearchOption.AllDirectories);
            if (files == null || files.Length == 0)
            {
                logger.LogDebug("Cannot Read Images from {0}", feedDataLocation);
            }
            else
            {
                Console.WriteLine("loading please wait");
                imageService.ShowDuplicateImages(files);
            }
            Console.ReadLine();
        }
    }
}
