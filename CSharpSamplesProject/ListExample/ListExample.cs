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

            Console.WriteLine("int List");
            List<int> intList = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                intList.Add(i + 1);
            }

            OutputList(intList);

            intList.Remove(10);     // removes the number 10
            intList.Remove(20);     // removes the number 20
            intList.RemoveAt(33);   // removes the number at location 33 (36)
            intList.RemoveAt(33);   // (37)
            intList.Insert(39, 101);
            intList[6] = 17;
            intList[9] = intList[9] * 10;

            Console.WriteLine("int List with removals and insertion and changes");
            OutputList(intList);
            Console.WriteLine();

            Console.WriteLine("double List");
            List<double> doubleList = new List<double>();
            for(int i = 0; i < intList.Count; i++)
            {
                doubleList.Add(intList[i] * 1.5);
            }

            OutputList(doubleList);
        }

        static void OutputList(List<int> list)
        {
            int counter = 0;
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write("{0,8}", list[i] + "\t");
                counter++;
                if (counter == 10)  // puts ten items on a line
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
        }
        static void OutputList(List<double> list)
        {
            int counter = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0,7:0.00}", list[i] + "\t");
                //Console.Write("{0,7:0.00}\t", list[i]);
                //Console.Write(String.Format("{0,10:0.000}", list[i]));
                counter++;
                if (counter == 10)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
        }
    }
}