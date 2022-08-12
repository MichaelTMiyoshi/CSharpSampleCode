using System;
namespace SimpleSineCosine
{
    internal class SimpleSineCosine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Sine and Cosine");
            while (true)
            {
                Console.Write("Input an angle in degrees (<= -1000 to quit): ");
                double angle = Convert.ToDouble(Console.ReadLine());
                if(angle <= -1000)
                {
                    break;
                }
                double radians = Math.PI * angle / 180.0;
                double result = Math.Cos(radians);
                Console.WriteLine("Cosine of " + angle + " = " + result);
            }
        }
    }
}