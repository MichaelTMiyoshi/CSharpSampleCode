using System;
using System.IO;

namespace FileReadingExample
{
    internal class FileReadingExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Files");
            try
            {
                StreamReader reader = new StreamReader("../../../InputTextFile.txt");

                // the files are located in the same directory
                // as the .cs file (on both Windows machines and Macs)

                StreamWriter writer = new StreamWriter("../../../OutputTextFile.txt");

                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    Console.WriteLine(line);
                    writer.WriteLine(line);
                }
                writer.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}