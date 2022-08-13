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
        }
    }
}