namespace FunctionRootReducer
{
    internal class FunctionRootReducer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square Root Reducer");
            Console.Write("Input a number to find the reduced square root: √");
            int number = Convert.ToInt32(Console.ReadLine());
            (int outside, int inside) = RootReducer(number);
            Console.WriteLine("√" + number + " = " + outside + "√" + inside);
        }

        static (int, int) RootReducer(int n)
        {
            int outside = 1;
            int inside = 1;
            for(int i = 1; i <= n; i++)
            {
                if(n % (i * i) == 0)
                {
                    outside = i;
                    inside = n / (i * i);
                }
            }
            return (outside, inside);
        }
    }
}