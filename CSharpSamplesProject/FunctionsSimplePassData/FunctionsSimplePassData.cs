namespace FunctionsSimplePassData
{
    internal class FunctionsSimplePassData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passing data to functions");
            int a = 4, b = 5;
            int ans = SomeFunction(a, ref b);   // 1
            Console.WriteLine("The answer of SomeFunction(" + a + "," + b + ") is: " + ans);
            String s = "Hello ";
            String t = "World ";
            String u = SomeFunction(s, ref t);
            Console.WriteLine("The answer of SomeFunction(" + s + "," + t + ") is: " + u);

            t = "World";
            (String greeting, int value) = Greetings(t, 5);
            Console.WriteLine(greeting + " " + Convert.ToString(value));
        }
        static int SomeFunction(int a, ref int b)
        {
            b = b * b;  // 25
            a += b;     // 29
            return a / b;   // 1
        }
        static String SomeFunction(String a, ref String b)
        {
            a += b;
            b = a + b;
            return a;
        }
        static (String, int) Greetings(String s, int v)
        {
            String result = "Hello " + s;
            int value = v * v;
            return (result, value);
        }
    }
}