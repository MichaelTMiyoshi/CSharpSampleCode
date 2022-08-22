namespace FunctionArgumentsExample
{
    internal class FunctionArgumentsExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function Arguments");
            double val = 123.4567;
            int dec = 0;
            double answer = Math.Round(val, dec, MidpointRounding.AwayFromZero);
            Console.WriteLine("Round to nearest int:   " + answer);
            val = 123.45;
            dec = 1;
            answer = Math.Round(val, dec, MidpointRounding.AwayFromZero);
            Console.WriteLine("Round midpoint up:      " + answer);
            val = 123.45;
            answer = Math.Round(val, dec, MidpointRounding.ToEven);
            Console.WriteLine("Round midpoint to even: " + answer);
        }
    }
}