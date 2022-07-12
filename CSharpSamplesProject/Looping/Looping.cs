using System;

namespace Looping
{
    internal class Looping
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping");
            Console.WriteLine("for Loop");
            int number;
            for(number = 1; number <= 10; number++)
            {
                Console.WriteLine(String.Format("{0,2}", number));
            }
            Console.WriteLine("while Loop");
            number = 1;
            while(number <= 10)
            {
                Console.WriteLine(String.Format("{0,2}", number));
                number++;
            }
            Console.WriteLine("do-while Loop");
            number = 1;
            do
            {
                Console.WriteLine(String.Format("{0,2}", number));
                number++;
            }while (number <= 10) ;

            Console.WriteLine("menu\n");
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("How may we serve you?");
                Console.WriteLine("\t1) choice 1");
                Console.WriteLine("\t2) choice 2");
                Console.WriteLine("\t3) choice 3");
                Console.WriteLine("\t11) Exit");
                Console.Write("Your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Menu item 1");
                        // do other stuff here
                        break;

                    case 2:
                        Console.WriteLine("Menu item 2");
                        // do other stuff here
                        break;

                    case 3:
                        Console.WriteLine("Menu item 3");
                        // do other stuff here
                        break;
                    case 11:
                        Console.WriteLine("Thank you.  Come again.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("That is not a choice on the menu");
                        // do other stuff here
                        break;
                }
                while(true)
                {
                    Console.Write("Would you like to exit? ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if(Char.ToUpper(ch) == 'Y')
                    {
                        break;
                    }
                }

                number = 2147483640;
                while (true) 
                {
                    Console.Write(number++ + "\t");
                    Console.ReadKey();  // try commenting this out and lowering the starting value of number
                }
            }
        }
    }
}
