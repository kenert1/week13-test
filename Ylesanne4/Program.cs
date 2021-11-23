using System;
using System.IO;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = $@"C:\Users\opilane\samples\test";
            Console.WriteLine("What file would you like displayed?");
            string userFile = Console.ReadLine();
            string fileDirect = $@"{rootdirect}\{userFile}.txt";
            bool excists = File.Exists(fileDirect);
            if (excists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirect);
                if (userFile == "Toyota" || userFile == "BMW" || userFile == "Tesla")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt file does not exist.");
                }
            }
            else
            {
                Console.WriteLine($"{userFile}.txt file does not exist.");
            }
        }
    }
}
