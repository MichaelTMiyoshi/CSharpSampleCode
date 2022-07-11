using System;

namespace UserInput
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting User Input");
            Console.Write("Input an integer: ");
            int min;
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input an integer: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("min: " + min + "\nmax: " + max);
            Console.Write("Input a double: ");
            double minD = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input a char: ");
            char minC = Convert.ToChar(Console.ReadLine());
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("double: " + minD + "\nchar: " + minC + "\nstring: " + input);
        }
    }
}
