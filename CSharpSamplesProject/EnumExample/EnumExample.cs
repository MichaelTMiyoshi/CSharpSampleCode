using System;
namespace EnumExample
{
    internal class EnumExample
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        enum Months { January = 1, February, March, April, May, June, 
                      July, August, September, October, November, December }
        enum Mem { Bit = 1, Nibble = 4, Byte = 8 }
        enum Amounts { Each = 1, Dozen = 12, Gross = 144 }
        static void Main(string[] args)
        {
            Console.WriteLine("enum Example");
            Days day = Days.Sunday;
            Console.WriteLine(day + " = " + (int)day);
            Months month = Months.September;
            Console.WriteLine(month + " = " + (int)month);
            Mem memory = Mem.Nibble;
            Console.WriteLine(memory + " = " + (int)memory);
            Amounts amount = Amounts.Gross;
            Console.WriteLine(amount + " = " + (int)amount);
            Console.WriteLine();

            Fn(month, day); // Works as it should
            //Fn(day, month); // compiler error because of order of arguments
            Fn(Months.April, Days.Tuesday); // Works as it should
            //Fn(4, 2);       // compiler error because arguments are integers
            Fn((Months)5, (Days)6); // Works as it should - casting
        }
        static void Fn(Months m, Days d)
        {
            Console.WriteLine(m + " " + d);
        }
    }
}