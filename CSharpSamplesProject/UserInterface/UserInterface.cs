using System;

namespace UserInterface
{
    internal class UserInterface
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");

            /*
             * Note:
             * the rows are really y
             * the colums are really x
             * as can be seen when positioning the cursor.
             * 
             * That is why col goes first in the arguments.
             */
            int row = 10, col = 15;
            Console.SetCursorPosition(col, row);
            Console.WriteLine("[" + row + ", " + col + "]");

            Random rng = new Random();

            for(int i = 0; i < 10; i++)
            {
                row = rng.Next(Console.WindowHeight);
                col = rng.Next(Console.WindowWidth - 10);
                Console.SetCursorPosition(col, row);
                Console.WriteLine("[" + row + ", " + col + "]");
            }

            Console.WriteLine((char)191 + "" + (char)177);
            Console.SetCursorPosition(Console.WindowLeft, Console.WindowTop + Console.WindowHeight - 6);
        }
    }
}
