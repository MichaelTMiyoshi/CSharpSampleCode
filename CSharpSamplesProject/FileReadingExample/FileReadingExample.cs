﻿using System;
using System.IO;

namespace FileReadingExample
{
    internal class FileReadingExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Files");
            String folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            try
            {
                StreamReader reader = new StreamReader($"{folder}" +
                    $"{Path.DirectorySeparatorChar}" +
                    $"Documents{Path.DirectorySeparatorChar}InputTextFile.txt");

                // the file is located in the directory:
                // Documents/Documents  (on a Windows machine)
                // Documents            (on a Mac)

                StreamWriter writer = new StreamWriter($"{folder}" +
                    $"{Path.DirectorySeparatorChar}" +
                    $"Documents{Path.DirectorySeparatorChar}OutputTextFile.txt");

                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    Console.WriteLine(line);
                    writer.WriteLine(line);
                }
                writer.Close();
                reader.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException");
            }
            catch 
            {
                Console.WriteLine("Exception");
            }
        }
    }
}