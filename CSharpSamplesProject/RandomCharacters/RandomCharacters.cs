using System;

namespace RandomCharacters
{
    internal class RandomCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for(int i = 0; i < 128; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
