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
        }
        static int SomeFunction(int a, ref int b)
        {
            b = b * b;
            a += b;
            return a / b;
        }
    }
}