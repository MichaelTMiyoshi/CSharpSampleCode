using System;
using System.IO;

namespace FileReadingDelimited
{
    internal class FileReadingDelimited
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delimited files");
            try
            {
                StreamReader reader = new StreamReader("../../../CommaDelimited.txt");

                // the files are located in the same directory
                // as the .cs file (on both Windows machines and Macs)

                StreamWriter writer = new StreamWriter("../../../TabDelimited.txt");

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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}