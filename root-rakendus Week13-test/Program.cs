using System;
using System.IO;
namespace CreateTITpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples";

            Console.WriteLine("Enter directory  name:");
            string userFolder = Console.ReadLine();

            string newDirectoryFullPath = $@"{rootDirectory}\{userFolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userFolder} already exists in samples  .");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userFolder} has been created.");
            }

            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}