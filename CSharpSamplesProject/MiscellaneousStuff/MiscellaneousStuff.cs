using System;

namespace MiscellaneousStuff
{
    internal class MiscellaneousStuff
    {
        static bool DEBUG = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Miscellaneous");
            double q = 17.1;
            int a = 7;
            if(DEBUG) { Console.WriteLine("q = " + q); }
            if(!DEBUG) { Thread.Sleep(1000); }
            Console.WriteLine((char) a);    // beep (or a Windows chime)
        }
    }
}