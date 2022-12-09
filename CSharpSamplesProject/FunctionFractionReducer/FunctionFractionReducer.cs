namespace FunctionFractionReducer
{
    internal class FunctionFractionReducer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fraction Reducer");
            Console.Write("Input numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int factor = GCF(numerator, denominator);   // function call
            Console.WriteLine("the Greatest Common Factor is: " + factor);
        }

        static int GCF(int num1, int num2)  // function signature
        {
            // below is the function definition
            int gcf = 1;
            for(int i = 2; i <= num1; i++)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    gcf = i;
                }
            }
            return gcf; // must match the return type
        }
    }
}