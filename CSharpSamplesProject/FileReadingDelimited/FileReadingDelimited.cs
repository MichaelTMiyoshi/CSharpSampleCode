using System;
using System.IO;

namespace FileReadingDelimited
{
    internal class FileReadingDelimited
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delimited files");
            String folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            try
            {
                StreamReader reader = new StreamReader($"{folder}" +
                    $"{Path.DirectorySeparatorChar}" +
                    $"Documents{Path.DirectorySeparatorChar}CommaDelimited.txt");

                // the file is located in the directory:
                // Documents/Documents  (on a Windows machine)
                // Documents            (on a Mac)

                StreamWriter writer = new StreamWriter($"{folder}" +
                    $"{Path.DirectorySeparatorChar}" +
                    $"Documents{Path.DirectorySeparatorChar}TabDelimited.txt");

                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    Console.WriteLine(line);
                    String[] data = line.Split(',');
                    String name = data[0];
                    char ch = Convert.ToChar(data[1]);
                    int i = Convert.ToInt32(data[2]);
                    writer.WriteLine(name + "\t" + ch + "\t" + i);
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