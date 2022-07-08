using System;

namespace RandomNumbers
{
    internal class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Numbers");
            Random rng = new Random();
            int rn = rng.Next();
            Console.WriteLine(rn);
            rn = rng.Next(10);
            Console.WriteLine(rn);
            int min = 1, max = 6;
            Console.WriteLine("Die roll [1-6]");
            rn = min + rng.Next(max - min + 1);
            Console.WriteLine(rn);
            Console.WriteLine("Not a die roll [1-6)");
            rn = min + rng.Next(max - min);
            Console.WriteLine(rn);
            Console.WriteLine("Random [7-37)");
            min = 7;
            max = 37;
            rn = rng.Next(min, max);
            Console.WriteLine(rn);
            Console.WriteLine("Random [7-17]");
            min = 7;
            max = 17;
            rn = rng.Next(min, max + 1);
            Console.WriteLine(rn);
            Console.WriteLine("Random double [0.0, 1.0)");
            double rd = rng.NextDouble();
            Console.WriteLine(rd);
            Console.WriteLine("Random double [0.0, 6.8)");
            double dmax = 6.8;
            rd = rng.NextDouble() * dmax;
            Console.WriteLine(rd);
        }
    }
}
