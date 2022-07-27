using System;
using System.Text;  // for StringBuilder

namespace NotEatingNewlines
{
    internal class NotEatingNewlines
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not Eating Newlines");
            Console.WriteLine("Input a string (it can have tabs, " +
                "spaces, and newlines).  Press the ESCAPE key to end.");
            String test = "";
            //StringBuilder test = new StringBuilder();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
                if (key.Key != ConsoleKey.Escape)
                {
                    if(key.Key == ConsoleKey.Enter)
                    {
                        test += "\n";
                        //test.Append("\n");
                        Console.WriteLine();
                    }
                    else
                    {
                        test += Convert.ToChar(key.KeyChar);
                        //test.Append(Convert.ToChar(key.Key));
                    }
                }
                
            } while (key.Key != ConsoleKey.Escape);
            
            Console.WriteLine("n"); // this is because the ESC key is active
            Console.WriteLine("This is the output");
            Console.WriteLine(test);
            //String s = test.ToString();
            //Console.WriteLine(s);
        }
    }
}
