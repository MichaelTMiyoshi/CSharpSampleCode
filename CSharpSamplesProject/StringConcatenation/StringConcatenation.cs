using System;

namespace StringConcatenation
{
    internal class StringConcatenation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s;
            s = "";
            Console.WriteLine(s);
            s = "Something";
            Console.WriteLine(s);
            s = s + " else";
            Console.WriteLine(s);
            s += " goes here";
            Console.WriteLine(s);

            string t, u;
            s = "Something";
            t = "else";
            u = "where";
            s = s + " " + t;
            Console.WriteLine(s);
            s += " goes here";
            Console.WriteLine(s);
            s = "";
            s = u + " " + t;
            Console.WriteLine(s);   // what is the output?
            s = "???" + s;
            Console.WriteLine(s);   // what is the output?
        }
    }
}
