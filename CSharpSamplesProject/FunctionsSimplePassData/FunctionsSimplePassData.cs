namespace FunctionsSimplePassData
{
    internal class FunctionsSimplePassData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passing data to functions");
            int a = 4, b = 5;
            int ans = SomeFunction(a, ref b);
            Console.WriteLine("The answer of SomeFunction(" + a + "," + b + ") is: " + ans);
            String s = "Hello ";
            String t = "World ";
            String u = SomeFunction(s, ref t);
            Console.WriteLine("The answer of SomeFunction(" + s + "," + t + ") is: " + u);
        }
        static int SomeFunction(int a, ref int b)
        {
            b = b * b;
            a += b;
            return a / b;
        }
        static String SomeFunction(String a, ref String b)
        {
            a += b;
            b = a + b;
            return a;
        }
    }
}