namespace FunctionsOverloading
{
    internal class FunctionsOverloading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overloading functions");
            String example = "Hello";
            Console.WriteLine(Function(example));
            Console.WriteLine(Function(example, 0));
            Console.WriteLine(Function(example, 7));
        }
        static String Function(String someString)
        {
            return someString + " world.";
        }
        static String Function(String someString, int num)
        {
            if(num == 0)
            {
                return someString + " universe.";
            }
            else
            {
                return someString + " there.";
            }
        }
    }
}