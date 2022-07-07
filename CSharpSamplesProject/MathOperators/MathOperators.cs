/*	Name:  (Put your name here)
	Problem:  (Put the whole problem statement here, or use your own words.)
        Declare, initialize, output string variables.
	Pseudocode:  (State your algorithm in English here.)
        Declare and initialize and output string variable
	Notes:  (Put any notes about your thoughts here.)
        Copy Git commit message to maintenance log.
	Maintenance log:    (You can copy your detailed Git commit messages.)
        Date:		Done:
        (Date here) (What you did here)
        07/07/2022	Sample code created (math operations)
*/using System;

namespace MathOperators
{
    internal class MathOperators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(2 + 3);
            int result = 2 + 3;
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Different ways to add one or subtract one.");
            int i = 0;

            i++;        // adds 1 to i (1)
            Console.WriteLine(i);
            i = i + 1;  // adds 1 to i (2)
            Console.WriteLine(i);
            i += 1;     // adds 1 to i (3)
            Console.WriteLine(i);

            i--;        // subtracts 1 from i (2)
            Console.WriteLine(i);
            i = i - 1;  // subtracts 1 to i (1)
            Console.WriteLine(i);
            i -= 1;     // subtracts 1 to i (0)
            Console.WriteLine(i);

            Console.WriteLine("\nTypes of division.");

            int a = 3;
            int b = 4;
            int c = 7;
            double x = 3.0, y = 4.0, z = 7.0;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine("\tint division");
            c = a / b;
            Console.WriteLine("\ta / b = " + c);
            Console.WriteLine("\tint modulus");
            int d = a % b;
            Console.WriteLine("\ta % b = " + d);
            Console.WriteLine("\tfloat division");
            z = x / y;
            Console.WriteLine("\tx / y = " + z);
            Console.WriteLine("\tfloat division into an int");
            c = (int) (x / y);
            Console.WriteLine("\tx / y = " + c);
            Console.WriteLine("\tint division into a float");
            z = a / b;
            Console.WriteLine("\ta / b = " + z);
            Console.WriteLine("\tmixed division into an int");
            c = a / (int) y;
            Console.WriteLine("\ta / y = " + c);
            Console.WriteLine("\tmixed division into a float");
            z = x / b;
            Console.WriteLine("\tx / b = " + z);
            Console.WriteLine("\tmixed division into an int");
            c = (int) x / b;
            Console.WriteLine("\tx / b = " + c);
            Console.WriteLine("\tmixed division into a float");
            z = a / y;
            Console.WriteLine("\ta / y = " + z);
        }
    }
}
