using System;

namespace FloatingPointEquality
{
    internal class FloatingPointEquality
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do NOT check floating point equality!");
            
            double avogadro = 6.0221408e23 * 10.0 / 10.0;
            //avogadro = avogadro * 10.0 / 10.0;
            if (avogadro == 6.0221408e23)
            {
                Console.WriteLine("You have a mole.");
            }
            if (avogadro != 6.0221408e23)
            {
                Console.WriteLine("You do not have a mole.");
            }

            // instead, check a range
            if (6.019e23 <= avogadro && avogadro <= 6.023e23)
            {
                Console.WriteLine("You have a mole.");
            }
            else
            {
                Console.WriteLine("You do not have a mole.");
            }

            double g = 9.8 * 1000.0 / 1000.0;
            // do not use equality with floating point data
            if (g == 9.8)
            {
                Console.WriteLine("You are on earth.");
            }
            if(g != 9.8)
            {
                Console.WriteLine("You are not on earth.");
            }

            // instead, check a range
            if(9.799 <= g && g <= 9.811)
            {
                Console.WriteLine("You are on earth.");
            }
            else
            {
                Console.WriteLine("You are not on earth.");
            }
        }
    }
}
