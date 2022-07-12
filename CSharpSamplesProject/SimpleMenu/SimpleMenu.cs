using System;
using System.Threading;

namespace SimpleMenu
{
    internal class SimpleMenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Menu");
            Console.WriteLine("How may we serve you?");
            Console.WriteLine("\t1) choice 1");
            Console.WriteLine("\t2) choice 2"); 
            Console.WriteLine("\t3) choice 3");
            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Menu item 1");
                // do other stuff here
            }
            else if (choice == 2)
            {
                Console.WriteLine("Menu item 2");
                // do other stuff here
            }
            else if (choice == 3)
            {
                Console.WriteLine("Menu item 3");
                // do other stuff here
            }
            else
            {
                Console.WriteLine("That is not a choice on the menu");
                // do other stuff here
            }

            // actually should be separate programs.  One with if, one with switch.
            Console.Clear();
            Console.WriteLine("How may we serve you?");
            Console.WriteLine("\t1) choice 1");
            Console.WriteLine("\t2) choice 2");
            Console.WriteLine("\t3) choice 3");
            Console.WriteLine("\t11) Exit");
            Console.Write("Your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

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
                    break;
                default:
                Console.WriteLine("That is not a choice on the menu");
                    // do other stuff here
                    break;
            }

            Console.WriteLine("Lots of other stuff needs to happen here...");

            // actually should be separate programs.  One with if, one with switch.
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("How may we serve you?");
            Console.WriteLine("\t1) choice 1");
            Console.WriteLine("\t2) choice 2");
            Console.WriteLine("\t3) choice 3");
            Console.Write("Your choice: ");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    Console.WriteLine("Menu item 1");
                    // do other stuff here
                    break;

                case '2':
                    Console.WriteLine("Menu item 2");
                    // do other stuff here
                    break;

                case '3':
                    Console.WriteLine("Menu item 3");
                    // do other stuff here
                    break;
                default:
                    Console.WriteLine("That is not a choice on the menu");
                    // do other stuff here
                    break;
            }

            Console.WriteLine("Lots of other stuff needs to happen here...");

        }
    }
}
