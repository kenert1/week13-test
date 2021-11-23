using System;
using System.IO;


namespace rakendus_ylesanne2

{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\test";
            string userFile = "Toyota";
            string userFile2 = "Bmw";
            string userFile3 = "Tesla";
            string userFilePath = $@"{rootDirectory}\{userFile}.txt";
            string userFile2Path = $@"{rootDirectory}\{userFile2}.txt";
            string userFile3Path = $@"{rootDirectory}\{userFile3}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool userFileExists = File.Exists(userFilePath);
            bool userFile2Exists = File.Exists(userFile2Path);
            bool userFile3Exists = File.Exists(userFile3Path);
            if (directoryExists && userFileExists && userFile2Exists && userFile3Exists)
            {
                Console.WriteLine($"{userFile} and {userFile2} and {userFile3} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(userFilePath);
                File.Create(userFile2Path);
                File.Create(userFile3Path);
                Console.WriteLine($"{userFile}.txt and {userFile2}.txt and {userFile3}.txt have been created in {rootDirectory}.");

            }
            else
            {
                File.Create(userFilePath);
                File.Create(userFile2Path);
                File.Create(userFile3Path);
                Console.WriteLine($"{userFile}.txt and {userFile2} and {userFile3}.txt has been created in {rootDirectory}.");
            }
        }
    }
}

