using System;
using System.Collections.Generic;
using ShapeTester;
namespace ListExample
{
    internal class ListExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Example");
            String fortune = "What is the any key?";
            List<int> scores = new List<int>();
            scores.Add(1);
            scores.Add(2);
            for(int i = 3; i <= 10; i++)
            {
                scores.Add(i);
            }

            Console.WriteLine(fortune);
            Console.WriteLine(scores);
            List<double> doubles = new List<double>();
            List<bool> TFAnswers = new List<bool>();
            List<Circle> circles = new List<Circle>();

            List<int> nums = new List<int> {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            foreach (int i in nums)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            List<double> health = new List<double> { 10.5, 9.6, 8.7, 7.6, 6.5 };
            Console.WriteLine(health[3]);
            health[3] = 16.5;
            Console.WriteLine(health[3]);
        }
    }
}