using System;

namespace RandomCharacters
{
    internal class RandomCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Characters");
            Random rng = new Random();
            int min = 32;
            int max = 127;
            int rn = rng.Next(min, max);
            Console.WriteLine((char)rn);
            char cmin = ' ';
            char cmax = '~';
            char rc = (char)rng.Next(cmin, cmax + 1); ;
            Console.WriteLine(rc);
        }
    }
}
