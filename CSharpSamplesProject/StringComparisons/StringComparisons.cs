using System;

namespace StringComparisons
{
    internal class StringComparisons
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string Comparisons");

            String s1 = "Alpha";
            String s2 = "alpha";
            String s3 = "omega";

            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);
            Console.WriteLine("s3: " + s3);
            
            int answer = String.Compare(s1, s2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(answer);

            if (s1.Equals(s2))
            {
                Console.WriteLine("The strings s1 and s2 are equal.");
            }
            else if(s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The strings " + s1 + " and " + s2 + " are equal, ignoring the case of letters.");
            }
            else
            {
                Console.WriteLine("The strings " + s1 + " and " + s2 + " are not equal.");
            }

            answer = String.Compare(s1, s3, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(answer);
            
            if(0 < String.Compare(s1, s3, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(s3 + " goes before " + s1 + " alphabetically.");
            }
            else if(String.Compare(s1, s3, StringComparison.OrdinalIgnoreCase) < 0)
            {
                Console.WriteLine(s1 + " goes before " + s3 + " alphabetically.");
            }
            else
            {
                Console.WriteLine("The strings " + s1 + " and " + s3 + " are equal.");
            }
        }
    }
}
