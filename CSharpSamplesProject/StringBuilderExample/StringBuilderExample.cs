using System;
using System.Text;

namespace StringBuilderExample
{
    internal class StringBuilderExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder Example");
            StringBuilder sb = new StringBuilder();
            sb.Append("ABC");
            Console.WriteLine(sb);
            for(int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
            sb[2] = 'c';
            Console.WriteLine(sb);

            String test = "Something here.";
            for(int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i]);
            }
            Console.WriteLine();

            StringBuilder name = new StringBuilder("michael");
            Console.WriteLine(name);
            name[0] = 'M';
            Console.WriteLine(name);
            name.Append(" Miyoshi");
            Console.WriteLine(name + "\n\n");
            name.AppendLine();
            name.AppendLine("greets you with C# StringBuilder");
            Console.WriteLine(name);
        }
    }
}
